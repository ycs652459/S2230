using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSpy
{
   public class SavingInfo
    {
       public SavingInfo()
        {
            this.myFavor = new List<ChannelBase>();
        }
        #region 属性
        /// <summary>
        /// 我的收藏
        /// </summary>
        private List<ChannelBase> myFavor;

        
        public List<ChannelBase> MyFavor
        {
            get
            {
                if (myFavor == null)
                {
                    return new List<ChannelBase>();
                }
                else
                {
                    return myFavor;
                }
            }
            set { myFavor = value; }
        }
        #endregion

       ////持久化信息类
       //public SavingInfo()
       //{
       //    this.mycollect = new List<ChannelBase>();
       //}
       ////我的保存
       // private List<ChannelBase> mycollect;   

       // public List<ChannelBase> Mycollect
       // {

       //     get
       //     {
       //         if (mycollect == null)
       //         {
       //          return new List<ChannelBase>();
       //         }
       //         else
       //         {
       //             return mycollect;
       //         }
       //     }
       //     set { mycollect = value; }
       // }
    }
}
