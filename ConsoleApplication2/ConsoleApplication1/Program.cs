using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("new.xml");
            XmlNodeList list = doc.SelectNodes("/note/heading");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].InnerText);
            }
            list = doc.SelectNodes("/note/body[@test]");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].InnerText);
            }
        }
    }

}