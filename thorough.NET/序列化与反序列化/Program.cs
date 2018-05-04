using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //List<Person> list = new List<Person>();
            //Person p1 = new Person();
            //p1.Name = "邓超";
            //p1.Age = 12;

            //Person p2 = new Person();
            //p2.Name = "Baby";
            //p2.Age = 22;

            //Person p3 = new Person();
            //p3.Name = "范冰冰";
            //p3.Age = 32;

            //list.Add(p1);
            //list.Add(p2);
            //list.Add(p3);
            ////3通过二进制序列化器工具
            //BinaryFormatter bf = new BinaryFormatter();
            //FileStream fs = new FileStream("save.txt",FileMode.Create);
            //bf.Serialize(fs,list);
            //fs.Close();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("save.txt", FileMode.Open);
            List<Person> LIST = (List<Person>)bf.Deserialize(fs);
            foreach (Person item in LIST)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("序列化成功");
            Console.ReadKey();
        }
    }
}
