// Author: Ritika Pareek

namespace RayCare.Model
{
    /// <summary>
    /// This class defines the model of calendar.
    /// </summary>
    public class Calendar
    {
        public const int NUM_DAYS = 180;
        
        private int[] days;
        
        public Calendar()
        {
            days = new int[NUM_DAYS];
        }

        /// <summary>
        /// Check if the calendar date is available.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool IsAvailable(int i)
        {
            return days[i] == 0;
        }

        /// <summary>
        /// Books the calendar date.
        /// </summary>
        /// <param name="i"></param>
        public void Book(int i)
        {
            days[i] = 1;
        }

    }
}
