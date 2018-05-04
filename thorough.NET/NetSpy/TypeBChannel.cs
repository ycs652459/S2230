using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NetSpy
{
    //屏道B类
   public class TypeBChannel:ChannelBase
    {
       public override void Fetch()
       {
           XmlDocument xmlDoc = new XmlDocument();
           try
           {
               xmlDoc.Load(Path);
           }
           catch (Exception ex)
           {
               MessageBox.Show("文件加载失败！" + ex.Message);
               return;
           }
           //选择父类节点
           XmlElement elem = xmlDoc.DocumentElement;
           if (ProgramList == null)
           {
               ProgramList = new List<TVProgram>();

           }
           foreach (XmlNode item in elem.ChildNodes)
           {
               //判断拿到的xml文件标签
               if (item.Name == "ProgramList")
               {
                   foreach (XmlNode item1 in item.ChildNodes)
                   {
                       TVProgram program = new TVProgram();
                       program.Playtime = DateTime.Parse(item1["playTime"].InnerText);
                       //program.ShiDuan = item1["meridien"].InnerText;
                       program.Name = item1["name"].InnerText;
                       program.Path = item1["path"].InnerText;
                       this.ProgramList.Add(program);
                   }
               }
           }
       }
    }
}
