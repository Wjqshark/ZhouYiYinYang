using LibTraditional;
using LibTraditional.Models.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDate();
            PrintWuxing();
            PrintBaGua();
            Console.ReadLine();
        }


        #region testMethod

        /// <summary>
        /// 打印时间
        /// </summary>
        static void PrintDate()
        {
            DateTime dt = DateTime.Now;
            ChineseCalendar cc = new ChineseCalendar(dt);
            Console.WriteLine("阳历：" + cc.DateString);
            Console.WriteLine("属相：" + cc.AnimalString);
            Console.WriteLine("农历：" + cc.ChineseDateString);
            Console.WriteLine("时辰：" + cc.ChineseHour);
            Console.WriteLine("节气：" + cc.ChineseTwentyFourDay);
            Console.WriteLine("节日：" + cc.DateHoliday);
            Console.WriteLine("前一个节气：" + cc.ChineseTwentyFourPrevDay);
            Console.WriteLine("后一个节气：" + cc.ChineseTwentyFourNextDay);
            Console.WriteLine("干支：" + cc.GanZhiDateString);
            Console.WriteLine("星期：" + cc.WeekDayStr);
            Console.WriteLine("星宿：" + cc.ChineseConstellation);
            Console.WriteLine("星座：" + cc.Constellation);
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// 打印五行
        /// </summary>
        static void PrintWuxing()
        {
            List<string> WuxingList = new List<string> { "金", "木", "水", "火", "土" };
            foreach(var item in WuxingList)
            {
                WuXing wuX = new WuXing(item);
                Console.WriteLine(string.Format("{0}  ：{0}生{1}，{0}克{2}，由{3}生，被{4}克。", wuX.Name,wuX.Generate,wuX.Inhibite,wuX.GenerateFrom,wuX.InhibiteBy));
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        static void PrintBaGua()
        {
            List<int> BaGua = new List<int> { 0,1,2,3,4,5,6,7};
            foreach (var item in BaGua)
            {
                Gua8 gua = new Gua8(item);
                Console.WriteLine(string.Format("{0}  :{1}", gua.Name, gua.YaoStr));
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion




    }
}
