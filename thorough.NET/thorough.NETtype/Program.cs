using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thorough.NETtype
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 第二章课后5题
            //int[] oudScoue = new int[3];
            //int[] newScoue = new int[3];
            //for (int i = 0; i < oudScoue.Length; i++)
            //{
            //    Console.Write("请" + (i + 1) + "位同学的分数：");
            //    oudScoue[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("提分后：");
            ////数组赋值
            //for (int j = 0; j < oudScoue.Length; j++)
            //{
            //    newScoue[j] = oudScoue[j];
            //    newScoue[j] += 5;
            //    Console.Write("\n" + newScoue[j]);
            //}
            //Console.ReadLine();
            #endregion


            #region 第二章课后4题
            

            #endregion
       
          
            #region 
            //    //定义两个数组
            //    int[] integral = new int[5];
            //    int[] newintegral = new int[5];
            //    Console.WriteLine("请输入5位会员的积分：");
            //    //循环打印
            //    for (int i = 0; i < integral.Length; i++)
            //    {
            //        Console.WriteLine("请"+(i+1)+"位会员积分：");
            //        integral[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    //数组的复制
            //    for (int j = 0; j < integral.Length; j++)
            //    {
            //        newintegral[j] = integral[j];
            //        //新年的积分
            //        newintegral[j]+= 500;

            //    }
            //    Console.WriteLine("\n序号");


            ////值类型
            //int heightzhang = 170;
            //int heightli = heightzhang;
            //Console.WriteLine("郑浩"+heightzhang+"李明"+heightli);
            //heightli = 180;
            //Console.WriteLine("李浩" + heightzhang + "李明" + heightli);
            //Console.ReadLine();

            //int[] zhang = new int[] {170,60 };
            //int[] li = zhang;
            //Console.WriteLine("张"+zhang[0]+"重"+zhang[1]+"李"+li[0]+"重"+li[1]);
            //li[0] = 180;
            //li[1] = 60;
            //Console.WriteLine("张" + zhang[0] + "重" + zhang[1] + "李" + li[0] + "重" + li[1]);
            //Console.ReadLine();
            //Student ss;
            //ss.Age = 12;
            //ss.Name = "夏明";


            //int num1 = 5;
            //int num2 = 10;
            //ChangeNum(num1, num2);
            //Console.WriteLine("{0}\t{1}", num1, num2);
            //Console.ReadLine();    



            ////值传递的引用传递
            //Student stu = new Student();
            //stu.Age = 18;
            ////用一个方法更改学生年龄
            //changStudentAge(stu);
            //Console.WriteLine(stu.Age);

            //ArrayList list = new ArrayList();
            //list.Add("狗子");
            //list.Add("狍子");
            //list.Add("戏子");

            ////遍历
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            ////移除
            //list.Remove("戏子");
            ////移除ArraylIST的指定索引除的下标
            //list.RemoveAt(1);
            ////修改
            //list[0] = "瘸子";
            //Console.WriteLine("list.Remove==========");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list1 = new ArrayList()
            //{
            //    new SE(){Name = "你好"},
            //    new SE(){Name = "BYANG"},
            //};
            //foreach (SE item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Hashtable table = new Hashtable();
            //table.Add("CBC", "中国建设银行");
            //table.Add("IBC", "中国农业银行");
            //table.Add("ICBC", "中国工商银行");
            //foreach (string Key in table.Keys)
            //{
            //    //获取值
            //    Console.WriteLine(Key);
            //    //双列表如何
            //    Console.WriteLine(table[Key]);
            //}

            //Console.WriteLine("第二种遍历");
            //foreach (看，m item in table.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine(item.Key+"\t"+item.Value);
            //}




    //        Dictionary<string, SE> dic = new Dictionary<string, SE>();
    //        SE jack = new SE();
    //        jack.Name = "王小二";
    //        jack.Price = 20;
    //        dic.Add(jack.Name,jack);
    //        //通过Key遍历Value
    //        foreach (string Key in dic.Keys)
    //{
    //     Console.WriteLine(Key+"\t"+dic[Key]);
    //}
    //        Console.WriteLine("分割后==================");
    //        //直接遍历Value
    //        foreach (SE value in dic.Values)
    //{
    //     Console.WriteLine(value);
    //}

            //Mygeneric<int> list = new Mygeneric<int>();
            //list.r = 12;
            //Mygeneric<string> list1 = new Mygeneric<string>();
            //list1.r = "3";
            //Mygeneric<int[]> list2 = new Mygeneric<int[]>();
            //list2.r = new int[3];
            //Mygeneric<Dog> list3 = new Mygeneric<Dog>();
            //list3.r = Dog;
            //Mygeneric<Dictionary<string,Dog>>

            Console.ReadLine();
            //Console.WriteLine("删除之后=================");
            ////删除
            //table.Remove("CBC");
            //foreach (string Key in table.Keys)
            //{
            //      //获取值
            //    Console.WriteLine(Key);
            //    //双列表如何
            //    Console.WriteLine(table[Key]);
            //}

            #endregion
      
            
        }
        //static void changStudentAge(Student stu)
        //{
        //    stu.Age = 20;   
        //}
       

 
        //#region MyRegion
        //static void ChangeNum(int num1, int num2)
        //{


        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine("交换方法内部{0}\t{1}", num1, num2);



        //}
        //#endregion
    }
}
