using System.Reflection.Metadata;

namespace Greeter
{
    public class GreetingMaker
    {
        public GreetingMaker()
        {
        }

        bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }

        public void ListOfBadNames() // need to figure out what exactly are the bad names (who decides what is bad and what isn't)
        {

        }

        public string NotificationOfTroll(string[] invalidNames)
        {
            DateTime currentTime = DateTime.UtcNow;
            string timeStamp = (((DateTimeOffset)currentTime).ToUnixTimeSeconds()).ToString();
            string convertedNames = "";
            foreach(string name in invalidNames)
            {
                convertedNames += name;
            }
            return "NotifyOfPossibleTroll([" + timeStamp + "] User Used All Invalid Names: (" + convertedNames + ")";
        }

        public string Greet(params string[] Params) // requirement 5 - arbritrary list of names
        {
            string builder = "";
            for (int i = 0; i < Params.Length - 1; i++)
            {
                builder += Params[i] + ", ";
            }

            bool checkExit = true;
            string[] reorder = new string[Params.Length];
            foreach (string param in Params)
            {
                if(IsAllUpper(param) == true)
                {

                }
            }

            // for requirement 6 part 1
            bool checker = true;
            foreach (string param in Params)
            {
                if(IsAllUpper(param) == true)
                {
                    checker = true;
                }
            }
            
            

            if (checker == true) // requirement 6 - if all names are uppercase then shout the whole thing
            {
                return "HELLOm " + builder.ToUpper() + "!";
            }

            return "Hello, " + builder + "!";
        }

        public string Greet(string name1, string name2) // requirement 4 - two names
        {
            return "Hello, " + name1 + " and " + name2 + "!";
        }

        public string Greet(string name) 
        {
            if (IsAllUpper(name) == true) // requirement 3 - handle shouting
            {
                return "HELLO, " + name + "!";
            }
            if (name == null)
            {       
                return "Hello, chief!"; // requirement 2 - dealing with nulls
            }
            return "Hello, " + name + "."; // requirement 1 - saying hello
        }
    }
}