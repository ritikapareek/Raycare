using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCare.Model
{
    public class Calendar
    {
        public const int NUM_DAYS = 180;
        
        private int[] days;
        
        public Calendar()
        {
            this.days = new int[NUM_DAYS];
        }

        public bool isAvailable(int i)
        {
            return days[i] == 0;
        }

        public void book(int i)
        {
            days[i] = 1;
        }

    }
}
