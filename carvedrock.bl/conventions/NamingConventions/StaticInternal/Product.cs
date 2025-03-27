
namespace carvedrock.bl.Conventions.NamingConventions.StaticInternal
{
    public class Product
    {
        private static int s_reviewsQueue;

        [ThreadStatic]
        private static TimeSpan t_TimeSpan;

        public Product()
        {
            s_reviewsQueue = 0;
            t_TimeSpan = TimeSpan.Zero;
        }

        public static void Update()
        {
            s_reviewsQueue--;
            t_TimeSpan = new TimeSpan(1, 2, 3);
        }

        public static void Log()
        {
            var reviews = s_reviewsQueue;
            var timespan = t_TimeSpan.ToString();
            Console.WriteLine($"{reviews}, {timespan}");
        }
    }   
}
