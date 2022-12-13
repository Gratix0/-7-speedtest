using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePech
{
    internal class TimeR
    {
        private static int j;
        private static Timer timer;
        static void Ti(string[] args)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            j = 1000;
            // создаем таймер
            timer = new Timer(tm, num, 0, j);

            Console.ReadLine();
        }
        public static void Count(Object num)
        {
            int x = (int)num;
            Console.WriteLine(j += 1000);
            timer.Change(j, 0);
        }
    }
}
