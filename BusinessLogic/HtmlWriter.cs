using BusinessLogic.Interfaces;
using SkypeMainDB;
using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class HtmlWriter
    {
        HtmlTextWriter writer;
        StringWriter text;

        public HtmlWriter()
        {
            text = new StringWriter();
            writer = new HtmlTextWriter(text);
        }
        public void WriteHtml(List<Messages> messagelist, string filepath)
        {
            DateTime tempdate = DateTime.Now;

            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            foreach (Messages m in messagelist)
            {
                bool left = m.author == m.dialog_partner || m.dialog_partner == null ? true : false;
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                if (left)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "date");
                    writer.RenderBeginTag(HtmlTextWriterTag.P);
                    writer.WriteEncodedText(Utils.TimestampToDateTime(m.timestamp.Value).ToString("dd.MM.yyyy"));
                    writer.WriteBreak();
                    writer.WriteEncodedText(Utils.TimestampToDateTime(m.timestamp.Value).ToLocalTime().ToString("HH:mm"));
                    writer.RenderEndTag();
                }
                writer.RenderEndTag();
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "msg");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.AddAttribute(HtmlTextWriterAttribute.Class, left ? "message left" : "message right");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                writer.RenderBeginTag(HtmlTextWriterTag.P);

                string text = "";
                if (m.body_xml != null) text = m.body_xml;
                string[] split = Regex.Split(text, "</ss>");

                text = "";

                foreach (string s in split)
                {
                    Regex regex = new Regex(@"(?<=\btype="")[^""]*");
                    string smily = regex.Match(s).Value;

                    string result = Regex.Replace(s, @"(<ss.*?>.*$|<e_m.*?>)", string.Empty);
                    writer.WriteEncodedText(System.Web.HttpUtility.HtmlDecode(result));

                    if (smily != string.Empty)
                    {
                        string smilyUrl = EmoticonMap.GetEmoticonFilename(smily);
                        writer.AddAttribute(HtmlTextWriterAttribute.Src, "./Emoticons/" + smilyUrl + ".png");
                        writer.RenderBeginTag(HtmlTextWriterTag.Img);
                    }
                }

                writer.RenderEndTag();
                writer.RenderEndTag();
                writer.RenderEndTag();
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                if (!left)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "date");
                    writer.RenderBeginTag(HtmlTextWriterTag.P);
                    writer.WriteEncodedText(Utils.TimestampToDateTime(m.timestamp.Value).ToString("dd.MM.yyyy"));
                    writer.WriteBreak();
                    writer.WriteEncodedText(Utils.TimestampToDateTime(m.timestamp.Value).ToLocalTime().ToString("HH:mm"));
                    writer.RenderEndTag();
                }

                writer.RenderEndTag();
            }
            string stream = File.ReadAllText("./HTML/Template.html");
            stream = stream.Replace("{content}", text.ToString());

            File.WriteAllText(filepath, stream);
        }
    }
}
