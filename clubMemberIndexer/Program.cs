using System;

namespace Indexer_example1
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor

            //indexer get and set methods
        
        public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

           public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }

            } 
        }
        static void Main(string[] args)
        {
            ClubMembers Club = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club do you want to see information about (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club");
                Club[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue to the next club, q to move on");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }
            Console.WriteLine("What type of club is it?");
            Club.ClubType = Console.ReadLine();
            Console.WriteLine("When do they meet next?");
            Club.MeetingDate = Console.ReadLine();
            Console.WriteLine("Where is it located?");
            Club.ClubLocation = Console.ReadLine();

            Console.WriteLine($"Here is information on the club");
            for (int i = 0; i < Size; i++)
            {
                if (Club[i] != string.Empty)
                    Console.WriteLine(Club[i]);
            }
            Console.WriteLine($"Address: {Club.ClubType}");
            Console.WriteLine($"City: {Club.MeetingDate}");
            Console.WriteLine($"State: {Club.ClubLocation}");
        }
    }
}