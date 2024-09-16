using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork
{
    class Student
    {
        delegate void AlarmZvoni(ClockAlarm clockAlarm);

        public void zvoni(ClockAlarm clockAlarm)
        {
            Console.WriteLine("Alarm zvoni!\n");


            Console.WriteLine("Da li zelite da odlozite alarm?");
            String s = Console.ReadLine();

            if (s == "da")
                clockAlarm.Snooze();
            else
                clockAlarm.Dissmis();
        }
    }
}
