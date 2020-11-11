using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealTimeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();

            teamLeader.SetNextSupervison(projectLeader);
            projectLeader.SetNextSupervison(hr);

            teamLeader.ApplyLeave("Anurag", 9);
            Console.WriteLine();

            teamLeader.ApplyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.ApplyLeave("Priyanka", 30);
            Console.WriteLine();

            teamLeader.ApplyLeave("Ramesh", 50);
            Console.Read();
        }
    }
}
