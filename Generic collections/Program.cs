using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//THIS WAS/IS HARD!!

namespace GenericCollections
{
    public class Games : IEquatable<Games>
    {
        public string GameName { get; set; }

        public int GameId { get; set; }

        public override string ToString()
        {
            return "ID: " + GameId + "   Name: " + GameName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Games objAsPart = obj as Games;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return GameId;
        }
        public bool Equals(Games other)
        {
            if (other == null) return false;
            return (this.GameId.Equals(other.GameId));
        }

        public class Example
        {
            public static void Main()
            {
                // Creating a list of games
                List<Games> games = new List<Games>();

                // Add games to the list.
                games.Add(new Games() { GameName = "Apex Legends", GameId = 1234 });
                games.Add(new Games() { GameName = "Call of Duty 4", GameId = 1334 });
                games.Add(new Games() { GameName = "Rainbow Six Siege", GameId = 1434 });
                games.Add(new Games() { GameName = "Halo Reach", GameId = 1444 });
                games.Add(new Games() { GameName = "Modern Warfare 2", GameId = 1534 });
                games.Add(new Games() { GameName = "Black Ops 4", GameId = 1634 });

                // Write out the games in the list.
               
                Console.WriteLine();
                foreach (Games GameName in games)
                {
                    Console.WriteLine(GameName);
                }

                //LinkedList<T>
                string[] words =
            { "Apex", "Legends", "is", "the", "best", "game" };

                LinkedList<string> sentence = new LinkedList<string>(words);
                Display(sentence, "The linked list values:");

                Console.WriteLine("sentence.Contains(\"game\") = {0}",
                    sentence.Contains("game"));

                sentence.AddFirst("Today");
                Display(sentence, "Test 1: Add 'Today' to beginning of the list:");

            }

            private static void Display(LinkedList<string> sentence, string v)
            {
                throw new NotImplementedException();
            }
        }
    }
}

// I ATTEMPTED THIS AND GOT THE LIST BUT IM NOT UNDERSTANDING WHAT IM DOING ON THE OTHER 
// COLLECTION ASPECTS

 // I ATTEMPTED THE REST OF THE ASIGNMENT BUT I COULDN'T GET ANYTHING ELSE TO RUN

    //THIS WAS HARD