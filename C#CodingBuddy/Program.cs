using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace IT391U3A
{
    class U3PartA
    {
        static void Main(string[] args)
        {
            //Sorting NFL Positions
            Console.WriteLine("Sorting NFL Positions");
            Console.WriteLine();

            String[] professions = new string[] { "Quarterback", "Offesnive Linemen", "Running Back", "Fullback", "Tight End", "Wide Receiver" };
            String[] defenseP = new string[] { "Defense Linemen", "Linebacker", "Cornerback", "Safety"};
            String[] specialP = new string[] { "Kicker", "Punter", "Kick Returner", "Punt Returner", "Long Snapper"};

            HashSet<String> setprofessions = new HashSet<String>();
            HashSet<String> PositionD = new HashSet<String>();
            HashSet<String> PositionS = new HashSet<String>();


            try
            {
                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    setprofessions.Add(professions[i]);
                    PositionD.Add(defenseP[i]);
                    PositionS.Add(specialP[i]);
                }
                Console.WriteLine("Original List: ");
                Console.Write("[");

                for (int i = 0; i <= professions.GetUpperBound(0); i++)
                {
                    Console.Write(professions[i]);
                    if (i == professions.GetUpperBound(0))
                    {
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sorted List: ");
                SortedSet<String> sortedProfessions = new SortedSet<string>(setprofessions);
                SortedSet<String> SortedD = new SortedSet<string>(setprofessions);
                SortedSet<String> SortedS = new SortedSet<string>(setprofessions);

                Console.Write("[");
                int j = 0;
                foreach (string job in sortedProfessions)
                {
                    Console.Write(job);
                    if (j != sortedProfessions.Count() - 1)
                        Console.Write(", ");
                    j++;
                }
                Console.Write("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }


            //Sorting NFL Teams
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorting NFL Teams");
            Console.WriteLine();

            List<String> lstbooks = new List<String>();
            lstbooks.Add("To Kill a Mockingbird");
            lstbooks.Add("Huckleberry Finn");
            lstbooks.Add("Pride and Prejudice");
            lstbooks.Add("Brave New World");
            lstbooks.Add("Lord of the Flies");
            lstbooks.Add("Alice in Wonderland");
            lstbooks.Add("The Old Man and the Sea");
            lstbooks.Add("Atlas Shrugged");

            Console.WriteLine("Original Book List: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            lstbooks.Sort(); //sort the list

            Console.WriteLine("Sorted Book List: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            lstbooks.RemoveAt(1);//remove second item from list
            lstbooks.RemoveAt(0); //remove first item from list
            lstbooks.RemoveAt(lstbooks.Count() - 1);//remove last item from list

            Console.WriteLine("Book List After Deletions: ");
            DisplayList(lstbooks);
            Console.WriteLine();

            Console.Write("The number of items in my book list is: " + lstbooks.Count + "\n");
            Console.WriteLine();

            int index = lstbooks.IndexOf("Brave New World"); //look for this title
            if (index != -1)
            {
                Console.WriteLine("Brave New World is in the list.");
            }
            else
            {
                Console.WriteLine("Brave New World is not in the list.");
            }

            static void DisplayList(List<String> lst)
            {
                Console.Write("[");
                for (int i = 0; i < lst.Count(); i++)
                {
                    Console.Write(lst[i]);
                    if (i != lst.Count() - 1)
                        Console.Write(", ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}