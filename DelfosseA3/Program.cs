namespace DelfosseA3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Display the following using string interpolation:

            //From today’s date
            //1.January 22, 2019 (right aligned in a 40 character field)

            var now = DateTime.Now;

            Console.WriteLine($"{now.ToString("MMMM dd, yyyy"),40}"); 

            //2.2019.01.22
            Console.WriteLine($"{now:yyyy.MM.dd}");

            //3.Day 22 of January, 2019
            Console.WriteLine($"Day {now:dd} of {now:MMMM}, {now:yyyy}");


            //4.Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {now:yyyy}, Month: {now:MM}, Day: {now:dd}");


            //5.            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{now,10:dddd}");

            //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{now,10:hh:mmtt}{now,10:dddd}");

            //7.h:11, m:01, s:27
            Console.WriteLine($"h:{now:hh}, m:{now:mm}, s:{now:ss}");

            //8.2019.01.22.11.01.27
            Console.WriteLine($"{now:yyyy}.{now:MM}.{now:dd}.{now:hh}.{now:mm}.{now:ss}");


            //If you have PI (3.1415) - use var pi = Math.PI;
            //1. Output as currency
            var pi = Math.PI;
            Console.WriteLine($"{pi:C2}");

            //2. Output as right-aligned (10 spaces), number with 3 decimal places

            Console.WriteLine($"{pi,10:N3}");





        }
    }
}

