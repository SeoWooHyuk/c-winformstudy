﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 도리도리강좌.ucPannel.classsusc7
{
    internal class XmlControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";


        //xml읽어오는 함수 메서드
        public Dictionary<string, string> fxml_read(string strxmlpath)
        {
            CRijndeal cRijndeal = new CRijndeal();
            string strRijndealtext = File.ReadAllText(strxmlpath);
            string roundtrip = cRijndeal.roundtrip(strRijndealtext); //복호화 처리

            Dictionary<string,string> dxmlconfig = new Dictionary<string,string>();

            using (XmlReader rd = XmlReader.Create(new StringReader(roundtrip)))  //StringReader 로 xml파일을 바로 읽어온다.
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strId = rd["ID"];
                            rd.Read();

                            string strTICK = rd.ReadElementContentAsString(_TICK, "");
                            dxmlconfig.Add(_TICK, strTICK);

                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            dxmlconfig.Add(_TOTAL, strTOTAL);

                            string strLEVEL1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            dxmlconfig.Add(_LEVEL_1, strLEVEL1);

                            string strLEVEL3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            dxmlconfig.Add(_LEVEL_3, strLEVEL3);

                            string strLEVEL50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            dxmlconfig.Add(_LEVEL_50, strLEVEL50);
                        }
                    }
                }

            }
                return dxmlconfig;
        }


        public void fxml_write(string strxmlpath, Dictionary<string, string> dxmlconfig)
        {

            StringBuilder builder = new StringBuilder();

            //using (XmlWriter wr = XmlWriter.Create(strxmlpath))
            using (XmlWriter wr = XmlWriter.Create(builder))
            {
                wr.WriteStartDocument();

                //SETTING

                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");
                wr.WriteElementString(_TICK, dxmlconfig[_TICK]);
                wr.WriteElementString(_TOTAL, dxmlconfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, dxmlconfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, dxmlconfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, dxmlconfig[_LEVEL_50]);

                wr .WriteEndElement();
                wr.WriteEndDocument();

            }

            CRijndeal cRijndeal = new CRijndeal();
            string strencrypted = cRijndeal.encrypted(builder.ToString());
            Console.WriteLine(strencrypted + "암호화");

            File.WriteAllText(strxmlpath, strencrypted); //텍스트 파일을 지정한이름으로 생성해라



        }

    }
}
