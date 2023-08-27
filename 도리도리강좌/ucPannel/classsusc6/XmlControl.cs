using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 도리도리강좌.ucPannel.classsusc6
{
    internal class XmlControl
    {
        public static string _TEXT_DATA = "TEXT_DATA";
        public static string _CBOX_DATA = "CBOX_DATA";
        public static string _NUMBER_DATA = "NUMBER_DATA";

        //xml읽어오는 함수 메서드
        public Dictionary<string, string> fxml_read(string strxmlpath)
        {
            Dictionary<string,string> dxmlconfig = new Dictionary<string,string>();

            using (XmlReader rd = XmlReader.Create(strxmlpath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strId = rd["ID"];
                            rd.Read();

                            string strTEXT = rd.ReadElementContentAsString(_TEXT_DATA,"");
                            dxmlconfig.Add(_TEXT_DATA, strTEXT);

                            string strcbox = rd.ReadElementContentAsString(_CBOX_DATA, "");
                            dxmlconfig.Add(_CBOX_DATA, strcbox);

                            string strnumber = rd.ReadElementContentAsString(_NUMBER_DATA, "");
                            dxmlconfig.Add(_NUMBER_DATA, strnumber);
                        }
                    }
                }

            }
                return dxmlconfig;
        }


        public void fxml_write(string strxmlpath, Dictionary<string, string> dxmlconfig)
        {

            using (XmlWriter wr = XmlWriter.Create(strxmlpath))
            {
                wr.WriteStartDocument();

                //SETTING

                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");
                wr.WriteElementString(_TEXT_DATA, dxmlconfig[_TEXT_DATA]);
                wr.WriteElementString(_CBOX_DATA, dxmlconfig[_CBOX_DATA]);
                wr.WriteElementString(_NUMBER_DATA, dxmlconfig[_NUMBER_DATA]);

                wr .WriteEndElement();
                wr.WriteEndDocument();

            }
        }

    }
}
