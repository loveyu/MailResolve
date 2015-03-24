using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MailResolve
{
	public partial class FormSesolve : Form
	{
		StreamReader sr;
		string MailFlag;
		public FormSesolve()
		{
			InitializeComponent();
		}

		private void buttonResolve_Click(object sender, EventArgs e)
		{
			textBoxSubject.Text = "";
			textBoxTo.Text = "";
			textBoxFrom.Text = "";
			textBoxCc.Text = "";
			richTextBoxContent.Text = "";
			richTextBoxAtt.Text = "";

			//创建字符串输入流
			sr = new StreamReader(GenerateStreamFromString(richTextBoxMail.Text));

			string str;
			int i;
			while (sr.EndOfStream == false)
			{
				str = sr.ReadLine();
				if ((i = str.IndexOf("Subject:")) == 0)
				{
					//修改标题
					textBoxSubject.Text = Conv(str.Substring(8));
					continue;
				}
				if ((i = str.IndexOf("From:")) == 0)
				{
					//修改发件人，存在一个如果发件人为多行会导致显示不全，没有进行相应的处理
					textBoxFrom.Text = Conv(str.Substring(5));
					continue;
				}
				if ((i = str.IndexOf("To:")) == 0)
				{
					//此处收件人地址和发件人存在相同问题
					textBoxTo.Text = Conv(str.Substring(3));
					continue;
				}
				if ((i = str.IndexOf("Cc:")) == 0)
				{
					//提取抄送地址，问题一样
					textBoxCc.Text = Conv(str.Substring(3));
					continue;
				}
				if ((i = str.IndexOf("Bcc:")) == 0)
				{
					//密抄地址，问题一样
					textBoxBcc.Text = Conv(str.Substring(4));
					continue;
				}
				if ((i = str.IndexOf("Content-Type:")) == 0)
				{
					//如果存在类型标示

					string[] type = GetContentType(str);
					//获取类型标示，type[0]标示类型如text、application、multipart
					//type[1]	仅对text有效、标示具体类型
					//type[2]	相应的编码（utf-8等）或者附件名称(有name、filename两种写法导致type[1]不准确)

					//Console.WriteLine(type[0]+"  "+type[1]+"  "+type[2]);
					if (type[0] == "text")
					{
						string s = "";
						switch (GetEncoding())
						{
							//获取对应的文本处理方式 返回小写字符

							case "base64":
								s = Encoding.GetEncoding(type[2].ToUpper()).GetString(Convert.FromBase64String(GetContent()));
								break;
							case "quoted-printable":
								s = QPUnEncryCode(GetContent(), type[2]);
								break;
							default:
								s = GetContent().Trim();//啥都没有直接删除前后的空白
								break;
						}
						if (type[1] == "html")
						{
							//类型为html输出到浏览器控件
							webBrowser.DocumentText = s;
						}
						else
						{
							//纯文本输出到存文本控件
							richTextBoxContent.Text = s;
						}
					}
					else if (type[0] == "multipart")
					{
						//邮件唯一标示符
						//删除 ‘-’在于部分邮件 '-'前后数量不一致，简单删除了全部 
						MailFlag = type[2].Replace("-", "");
					}
					else if (type[0] == "application")
					{
						//附件的处理
						//此处仅仅对名字进行添加
						richTextBoxAtt.Text += Conv(type[2]) + "\t";
						SaveFile(Conv(type[2]), GetContent());
					}
					continue;
				}
			}
		}
		private string GetContent()
		{
			//获取Conten-Type:获取之后的相应内容
			string str;
			string rt = "";
			while ((str = sr.ReadLine()) != "") ;	//内容会从空行之后开始，读取到空行内容
			while (true)
			{							//开始循环读取内容
				str = sr.ReadLine();
				if (str == null)		//读取为空
					break;
				if (MailFlag != null)
				{	//存在邮件标示的情况，如果不存在会一直读取到邮件结束，PHPMailer就有这样一个问题

					if (str.Replace("-", "").IndexOf(MailFlag) >= 0)	//读取到邮件标示符结束
					{
						break;
					}
				}
				rt += str + "\n";
			}
			return rt;
		}
		private string GetEncoding()
		{
			//获取下一行的邮件内容编码，如果不在下一行忽略
			string s = sr.ReadLine();
			if (s.ToLower().IndexOf("content-transfer-encoding:") != 0)
			{
				return "";
			}
			return s.Split(' ')[1].ToLower().Trim();
		}
		private string[] GetContentType(string str)
		{
			//获取Content-Type属性
			//Content-Type: text/plain; charset="gb2312"
			//该类型将会返回string[] = {"text","plain","gb2312"}
			string[] s, rt, s3;
			rt = new string[3];
			if (str.ToLower().IndexOf("charset") < 1 &&
				str.ToLower().IndexOf("name") < 1 &&
				str.ToLower().IndexOf("boundary") < 1)
			{
				//这里只对这三种情况惊喜下一行考虑，其他情况忽略
				str += sr.ReadLine();
			}
			str = str.Replace("\"", "");
			s = str.Split(';');
			s[0] = s[0].Trim();
			s[1] = s[1].Trim();
			s3 = s[0].Substring(s[0].IndexOf(" ") + 1).Trim().Split('/');
			rt[0] = s3[0];
			rt[1] = s3[1];
			rt[2] = s[1].Substring(s[1].IndexOf("=") + 1).Trim();
			return rt;
		}
		private Stream GenerateStreamFromString(string s)
		{
			//根据字符串创建一个文件流
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);
			writer.Write(s);
			writer.Flush();
			stream.Position = 0;
			return stream;
		}
		private string Conv(string s)
		{
			//转换 标题中的 字符
			//=?gb2312?B?u9i4tDogu9i4tKO6udjT2tT2vNNXb3JkcHJlc3Ox7cfpvLDQ3rjExL/CvA==?=

			s = s.Trim();
			Regex reg = new Regex(@"=\?(?<content>[\s\S]+)\?=");
			MatchCollection matches;
			matches = reg.Matches(s);
			for (int i = 0; i < matches.Count; i++)
			{
				s = s.Replace(matches[i].Value, GetConvString(matches[i].Value));
			}
			return s;
		}
		private string GetConvString(string s)
		{
			//转换相应的编码内容
			string[] s2 = s.Split('?');
			if (s2[2].ToLower() == "b")
			{
				//Base64转换
				s = Encoding.GetEncoding(s2[1].ToUpper()).GetString(Convert.FromBase64String(s2[3]));
			}
			else
			{
				//quoted-printable 编码转换
				s = QPUnEncryCode(s2[3], s2[1]);
			}
			return s;
		}
		private string QPUnEncryCode(string source, string coding)
		{
			//quoted-printable 转换为相应的字符串
			//此处为网上的代码，有点小问题，未做深入探索
			source = source.Replace("=\r\n", "");
			source = source.Replace("=\n", "");
			int len = source.Length;
			string dest = string.Empty;
			int i = 0;
			while (i < len)
			{
				string temp = source.Substring(i, 1);
				if (temp == "=")
				{
					try		//代码会出去解析异常，对这样问题进行屏蔽，但会导致乱码
					{
						int code = Convert.ToInt32(source.Substring(i + 1, 2), 16);
						if (Convert.ToInt32(code.ToString(), 10) < 127)
						{
							dest += ((char)code).ToString();
							i = i + 3;
						}
						else
						{
							try //这是另一处转换异常
							{
								dest += Encoding.GetEncoding(coding.ToUpper()).GetString(new byte[] { 
									Convert.ToByte(source.Substring(i + 1, 2), 16),
									Convert.ToByte(source.Substring(i + 4, 2), 16) 
								});
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
							}
							i = i + 6;
						}
					}
					catch
					{
						i++;
						continue;
					}
				}
				else
				{
					dest += temp;
					i++;
				}
			}
			return dest;
		}
		private void SaveFile(string file, string content)
		{
			//将附件写入到文件
			FileStream fs = new FileStream(file, FileMode.Create);
			byte[] bs = Convert.FromBase64String(content);
			fs.Write(bs, 0, bs.Length);
			fs.Close();
		}

		private void FormSesolve_Resize(object sender, EventArgs e)
		{
			//窗口调整
		}
	}
}
