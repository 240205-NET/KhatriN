namespace GuessingGame
{
    // See https://aka.ms/new-console-template for more information
    public class GG{
        public static void Main(string[] args){
            
         Game();
    }

    public static void Game(){
           //Greet the  player
            Console.WriteLine("Welcome to the Guessing Game");
            int target = CreateRandomNumber(21);
            Console.WriteLine(target);
            bool win = false;
            // i to check the number of attempts the user has made to correct guess
            int i = 0;
            while(!win){
               win = GameLoop(target);
            }
            Console.WriteLine("Congratulations, you've won! It took you " + i + " attempts");
        }

        public static bool GameLoop(int target){
             bool win = false;
             Console.WriteLine("please guess a number between 0 and 20");
                    //accept user input as a string, convert it, and store it in a numerical variable
                // int guess = -1;
                try {
                    int guess = Int32.Parse(Console.ReadLine());
                     if(guess >= 0 && guess <= 20){
                        if (guess == target){
                        Console.WriteLine("Yay! Congratulations, you got it right");
                        win = true;
                        }
                        else if(guess > target){
                            Console.WriteLine("Whoops, too high");
                        }
                        else if(guess < target){
                            Console.WriteLine("Nope, too low!");
                        }
                        else{
                            Console.WriteLine("No! You're bad");
                        }
                        i++;
                        Console.WriteLine("Attempt #: " + i);
                    }else {
                        Console.WriteLine("Your range was out of range, Please try again");
                    }

                }catch(Exception e){
                    Console.WriteLine(e.Message);
                    Console.WriteLine("The value you entered was not valid, please try again");
                }
                return win;
        }

        public static int CreateRandomNumber(int limit){
            Random rand = new Random();


            return rand.Next(rand);
        }
    }
}