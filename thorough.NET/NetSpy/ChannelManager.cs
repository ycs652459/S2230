using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NetSpy
{
    //解析频道xml，转换成泛型集合。
   public class ChannelManager
    {
       public Dictionary<string, ChannelBase> dic = new Dictionary<string, ChannelBase>();
  
       public ChannelBase Channelbase(string type)
       {
           ChannelBase Base = null;
           switch (type)
           {
               case "TypeA":
                   Base = new TypeAChannel();
                   break;
               case "TypeB":
                   Base = new TypeBChannel();
                   break;
               default:
                   break;
           }
           return Base;
       }
       public void LoadChannel()
       {       
           XmlDocument xml = new XmlDocument();
           xml.Load("FullChannels.xml");
           XmlElement xmle = xml.DocumentElement;
           foreach (XmlNode item in xmle.ChildNodes)
           {
               ChannelBase cb = Channelbase(item["channelType"].InnerText);
               //根据创建不同子类的对象将不同频道名称赋值给属性
               cb.ChanName = item["tvChannel"].InnerText;
               cb.Path =item["path"].InnerText;
                //根据不同子类对象执行重写方法 给 节目列表赋值
               cb.Fetch();
                //将不同频道 赋值给所有频道泛型集合
               dic.Add(cb.ChanName,cb);
           }
       }
       //持久化信息
       private SavingInfo seria = new SavingInfo();
       public SavingInfo Seria
       {
           get { return seria; }

       }
       //private SavingInfo save = new SavingInfo();


       //保存定制频道信息的文本文件名称
       private string saveFileName = @"save";
       /// <summary>
       /// 将我的电台信息存储到文本文件之中
       /// 要解决中文乱码问题
       /// </summary>
       public void SaveAsTxt()
       {
           try
           {
               FileStream fs = new FileStream(saveFileName + ".txt", FileMode.Create);
               StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding("GB2312"));
               string type = "";
               for (int index = 0; index < this.seria.MyFavor.Count; index++)
               {
                   ChannelBase channel = this.seria.MyFavor[index];
                   if (channel is TypeBChannel)
                   {
                       type = "TypeB";
                   }
                   else
                   {
                       type = "TypeA";
                   }
                   writer.WriteLine(type
                       + "|" + channel.ChanName
                       + "|" + channel.Path);
               }

               writer.WriteLine("End of my Favor");
               writer.Close();
               fs.Close();

           }
           catch (Exception ex)
           {
               MessageBox.Show("写入文件失败:" + ex.ToString());
           }
       }
    }
}
