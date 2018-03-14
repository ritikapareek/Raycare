using RayCare.Model;

namespace RayCare.Services
{
    public class SchedulingService
    {
        private static SchedulingService instance;

        private SchedulingService()
        { }

        public static SchedulingService GetInstance()
        {
            if (instance == null)
                instance = new SchedulingService();
            return instance;
        }

        public Consultation Schedule(Patient patient)
        {
            return new Consultation();       
        }


    }
}
