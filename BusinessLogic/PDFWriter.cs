using SkypeMainDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;

namespace BusinessLogic
{
    public class PDFMessageWriter
    {
        private PdfWriter writer;



        public void WritePDF(List<Messages> messagelist, string filepath)
        {
            ContactProcessor contactProcessor = new ContactProcessor();
            List<Contacts> contactList = contactProcessor.getAllContacts().OrderBy(t => t.displayname).ToList();


            float margin = Utilities.MillimetersToPoints(Convert.ToSingle(20));
            float margintop = Utilities.MillimetersToPoints(Convert.ToSingle(15));
            Document doc = new Document(iTextSharp.text.PageSize.A4, margin, margintop, margintop, margintop);

            writer = PdfWriter.GetInstance(doc, new FileStream(filepath, FileMode.Create));
            writer.SetFullCompression();
            writer.CloseStream = true;

            doc.Open();
            doc.NewPage();

            foreach(Messages m in messagelist)
            {
                string author = contactList.Where(c => c.skypename == m.author).Select(c => c.displayname).FirstOrDefault();
                if(string.IsNullOrEmpty(author))
                {
                    author = m.author;
                }

                string date = Utils.TimestampToDateTime(m.timestamp.Value).ToString("dd.MM.yyyy");
                string time = Utils.TimestampToDateTime(m.timestamp.Value).ToLocalTime().ToString("HH:mm");

                string text = "";
                if (m.body_xml != null) text = m.body_xml;
                string[] split = Regex.Split(text, "</ss>");

                text = "";

                Paragraph p = new Paragraph(date + ", " + time + " - " + author + ": ");

                foreach (string s in split)
                {
                    Regex regex = new Regex(@"(?<=\btype="")[^""]*");
                    string smily = regex.Match(s).Value;

                    string result = Regex.Replace(s, @"(<ss.*?>.*$|<e_m.*?>)", string.Empty);
                    p.Add(new Chunk(System.Web.HttpUtility.HtmlDecode(result)));

                    if (smily != string.Empty)
                    {
                        string smilyUrl = EmoticonMap.GetEmoticonFilename(smily);
                        try
                        {
                            var image = Image.GetInstance("./HTML/Resources/images/" + smilyUrl + ".png");
                            image.ScaleAbsolute(10f, 10f);
                            p.Add(new Chunk(image, 0, 0, true));
                        }
                        catch(WebException) { }
                    }
                }
                
                doc.Add(p);
            }

            if (doc != null)
                doc.Close();

            doc = null;
            Process.Start(filepath);
        }
    }
}
