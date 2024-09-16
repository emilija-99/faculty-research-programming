using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockAlarm clockAlarm = new ClockAlarm();

            Student s = new Student();

            clockAlarm.vremeJeZaBudjenje += s.zvoni;

            clockAlarm.startAlarm();

        }
    }
}
