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