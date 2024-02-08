using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString=""; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            //
            //
            //implement the required code here and within the methods below.
            Console.WriteLine("Please enter your message and press enter");
            userInputString = Console.ReadLine();

            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum = Int32.Parse(Console.ReadLine());
            StringToUpper(userInputString);
            Console.WriteLine(StringToUpper(userInputString));
            StringToLower(userInputString);
            Console.WriteLine(StringToLower(userInputString));
            StringTrim(userInputString);
             Console.WriteLine(StringTrim(userInputString));
             StringSubstring( userInputString,  elementNum);
             Console.WriteLine(StringSubstring( userInputString,  elementNum));
             Console.WriteLine(SearchChar( userInputString, 'n'));
             Console.WriteLine("Please Enter User Your First Name: ");
              fName = Console.ReadLine();

             Console.WriteLine("Please Enter User Your Last Name: ");
              lName = Console.ReadLine();
             
             Console.WriteLine(ConcatNames(fName, lName));



            //
            //


        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            return x.ToUpper();
            //throw new NotImplementedException("StringToUpper method not implemented.");
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            return x.ToLower();
            //throw new NotImplementedException("StringToUpper method not implemented.");

        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            return x.Trim();
           // throw new NotImplementedException("StringTrim method not implemented.");

        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            string newSub = x.Substring(elementNum);
            return newSub;
           // throw new NotImplementedException("StringSubstring method not implemented.");

        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            return userInputString.IndexOf(x);
            //throw new NotImplementedException("SearchChar method not implemented.");
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            
            return fName + " " + lName;
           // throw new NotImplementedException("ConcatNames method not implemented.");
        }



    }//end of program
}
