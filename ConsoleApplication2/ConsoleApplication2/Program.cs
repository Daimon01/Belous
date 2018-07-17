using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader sr = new StreamReader("new.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("new.xml");
            for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++)
            {
                XmlNode root = doc.DocumentElement.ChildNodes[i];
                if (root.Attributes.Count != 0)
                {
                    for (int k = 0; k < root.Attributes.Count; k++)
                    {
                        String to = root.Attributes.Item(k).Value;
                        Console.WriteLine(to);
                    }
                    
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
           

            //String to = ;
        }
    }
}