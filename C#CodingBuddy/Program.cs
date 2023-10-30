using System;

namespace CodingBuddyAssignment
{
    class CodingAssignment
    {
        static void Main(string[] args)
        {
            //Sorting NFL Positions
            Console.WriteLine("Sorting NFL Positions");

            //Player position offensive, defensive, special
            String[] professions = new string[] { "Quarterback", "Offensive Linemen", "Running Back", "Fullback", "Tight End", "Wide Receiver" };
            String[] defenseP = new string[] { "Defense Linemen", "Linebacker", "Cornerback", "Safety"};
            String[] specialP = new string[] { "Kicker", "Punter", "Kick Returner", "Punt Returner", "Long Snapper"};
            
            //Calling the sorting method for positions
            SortingMethod("Offensive Positions: ", professions);
            SortingMethod("Defense Positions: ", defenseP);
            SortingMethod("Special Positions: ", specialP);

            Console.WriteLine();
            Console.WriteLine("Randomly Selected Positions To Bet On");
            //Calling the random select method to select a random position.
            rString("Random Offensive Position: ",professions);
            rString("Random Defensive Position: ", defenseP);
            rString("Random Special Position: ", specialP);

            //Random method
            static void rString(string pname, string[] random)
            {
                //Creating random
                Random rnd = new Random();
                //Selecting word from string
                int wSelect = rnd.Next(random.Length);
                //Printing out string
                Console.WriteLine($"{pname}{random[wSelect]}");
            }

            static void SortingMethod(string pname, string[] pPostitions)
            {
                //Hashset to set positions
                HashSet<String> setPositions = new HashSet<String>();

                //For loop for positions to print
                for (int i = 0; i <= pPostitions.GetUpperBound(0); i++)
                {
                    setPositions.Add(pPostitions[i]);
                }

                Console.WriteLine();
                Console.WriteLine(pname + "Original List: ");
                Console.Write("[");

                //For loop to print original list
                for (int i = 0; i <= pPostitions.GetUpperBound(0); i++)
                {
                    Console.Write(pPostitions[i]);
                    if (i == pPostitions.GetUpperBound(0))
                    {
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();

                //Printing Sorted List
                Console.WriteLine(pname + "Sorted List: ");

                //New string set for sorted positions.
                SortedSet<String> sortedPositions = new SortedSet<string>(setPositions);
                Console.Write("[");
                int j = 0;

                //foreach method to print professions in order.
                foreach (string job in sortedPositions)
                {
                    Console.Write(job);
                    if (j != sortedPositions.Count() - 1)
                        Console.Write(", ");
                    j++;
                }
                Console.Write("]");
                Console.WriteLine();
            }


            //Sorting NFL Teams
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorting NFL Teams");
            Console.WriteLine();

            List<String> lstteams = new List<String>();
            lstteams.Add("Jets");
            lstteams.Add("Steelers");
            lstteams.Add("Ravens");
            lstteams.Add("Broncos");
            lstteams.Add("Rams");
            lstteams.Add("Jaguars");
            lstteams.Add("Giants");
            lstteams.Add("Bills");

            Console.WriteLine("Original Team List: ");
            DisplayList(lstteams);
            Console.WriteLine();

            lstteams.Sort(); //sort the list

            Console.WriteLine("Sorted Team List: ");
            DisplayList(lstteams);
            Console.WriteLine();

            lstteams.RemoveAt(1);//remove second item from list
            lstteams.RemoveAt(0); //remove first item from list
            lstteams.RemoveAt(lstteams.Count() - 1);//remove last item from list

            Console.WriteLine("Team List After Deletions: ");
            DisplayList(lstteams);
            Console.WriteLine();

            Console.Write("The number of items in my team list is: " + lstteams.Count + "\n");
            Console.WriteLine();

            int index = lstteams.IndexOf("Jets"); //look for this title
            if (index != -1)
            {
                Console.WriteLine("Jets are in the list.");
            }
            else
            {
                Console.WriteLine("Jets are not in the list.");
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
