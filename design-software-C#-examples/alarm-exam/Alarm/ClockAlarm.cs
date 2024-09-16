using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockWork
{
    class ClockAlarm
    {
        bool ukljucen = true;
        int brojSekundiDoZvona = 3;

        public event AlarmZvoni vremeJeZaBudjenje;

        public void Dissmis() {
            ukljucen = false;
        }

        public void Snooze() {
            brojSekundiDoZvona = 3;
            startAlarm();
        }

        internal void startAlarm()
        {
            Thread.Sleep(brojSekundiDoZvona * 1000);

            brojSekundiDoZvona = 0;

            if (vremeJeZaBudjenje != null)
                vremeJeZaBudjenje(this);
        }
    }
}
