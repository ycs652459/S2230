using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {


            //XmlDocument xml = new XmlDocument();
            //xml.Load("XMLFile1.xml");
            //XmlElement xmlRoot = xml.DocumentElement;
            ////遍历
            //foreach (XmlNode item in xmlRoot.ChildNodes)
            //{
            //    Console.WriteLine(item["book1"].InnerText);
            //    Console.WriteLine(item["book2"].InnerText);
            //}

            //XmlDataDocument xml1 = new XmlDataDocument();
            //xml1.Load("XMLFile1.xml");
            //XmlElement xmlroot = xml1.DocumentElement;
            //foreach (XmlNode item in xmlroot.ChildNodes)
            //{
            //    if (item.Name == "book1")
            //    {
            //        Console.WriteLine("图书名称："+item.InnerText);
            //    }
            //}


            Console.Write("输入想求的斐波那契数列项数：");
            int n = Convert.ToInt32(Console.ReadLine());
            //递归实现

            Console.WriteLine("斐波那契数列数列递归算出的第{0}项为:{1}", n, Calculate(n));
        }
        static int Calculate(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Calculate(n - 1) + Calculate(n - 2);
            }
            Console.ReadLine();
        }
           

    }
}
