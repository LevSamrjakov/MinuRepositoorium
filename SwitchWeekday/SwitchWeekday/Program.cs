namespace SwitchWeekday
{
    internal class Program
    {
        static void Main(string[] args)
        {

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday. Monday is a work day.");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday. Tuesday is a work day.");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is Wednesday. Wednesday is a work day.");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Today is Thursday. Thursday is a work day.");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Today is Friday. Friday is a work day.");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is Saturday. Saturday is a weekend.");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Today is Sunday. Sunday is a weekend.");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
