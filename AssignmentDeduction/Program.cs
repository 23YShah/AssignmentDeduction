using System.Threading.Channels;

namespace AssignmentDeduction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MARK INPUTTING
            int e1 = 4;
            int e2 = 2;
            int e3 = 1;

            double totalmark = (e1 + e2 + e3);
            Console.WriteLine("e1 mark: " + e1);
            Console.WriteLine("e2 mark: " + e2);
            Console.WriteLine("e3 mark: " + e3);

            Console.WriteLine();
            Console.WriteLine();

            //GETTING NO. OF LATES

            Console.WriteLine("How many of your asssignments were handed in late?");
            int lateassignments = Convert.ToInt32(Console.ReadLine());

            if (lateassignments == 1)
            {
                totalmark = totalmark -= 10;
            }
            else if (lateassignments >= 2)
            {
                totalmark = totalmark / 2;
            }

            if (totalmark < 0)
            {
                totalmark = 0;
            }

            Console.WriteLine("Your total mark overall is " + totalmark + " for your 3 assignments, since the amount you handed in late was " + lateassignments + ".");
        }
    }
}
