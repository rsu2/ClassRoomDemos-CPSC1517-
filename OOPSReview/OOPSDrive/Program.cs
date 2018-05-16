using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the instances of our objects to be used
            //in this program

            //you can check for additional namespaces
            //that may be needed to use your objects.

            //we need to have a structure that will allow
            //one to hold an unknown number of instances
            //of a variable
            //List<T> is an object that holds x number of datatype instances
            //The nuw List<T> phyiscal creates the instance of List<T>
            //      in memory. The constructor of List<T> is called
            List<Turn> gameTurns = new List<Turn>();

            //Create 2 instances of the Die object
            Die Player1Dice = new Die();            //default constructor
            Die Player2Dice = new Die(6, "Green");   //greedy constructor

            string menuChoice = "";
            do
            {
                Console.WriteLine("Game Menu: \n");
                Console.WriteLine("A) Set Die side count");
                Console.WriteLine("B) Roll the dice");
                Console.WriteLine("C) Display all game turn results");
                Console.WriteLine("X) Exit");
                Console.Write("Enter menu choice: ");
                menuChoice = Console.ReadLine();

                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //logic can de done using a methoud
                            //the methoud will need to have the
                            //  local variable Player1Dice and
                            //  Player2Dice passed to it.
                            //object are passed as references
                            SetDiceSide(Player1Dice,Player2Dice);
                            break;
                        }
                    case "B":
                        {
                            //logic can be done actually inside the case
                            //one does not have to always call a method

                            //Roll the dice for each player
                            //the dot cperator is used with your instance
                            //  to access a Property or a Behaviour
                            Player1Dice.Roll();
                            Player2Dice.Roll();

                            //record the result of the roll for this turn
                            //we need to create a new instance of the Turn
                            //      class
                            Turn aturn = new Turn();

                            //assign the facevalue of each dice to the Turn
                            //      instance
                            //           set                get 
                            aturn.Player1DiceValue = Player1Dice.FaceValue;
                            aturn.Player2DiceValue = Player2Dice.FaceValue;

                            //determine your bettle results
                            //It does not matter in this logic whether we
                            //  use the values from aturn or the Die variables
                            if (aturn.Player1DiceValue > Player2Dice.FaceValue)
                            {
                                aturn.TurnWinner = "Player1";
                            }
                            else if (aturn.Player2DiceValue > Player1Dice.FaceValue)
                            {
                                aturn.TurnWinner = "player2";
                            }
                            else
                            {
                                aturn.TurnWinner = "Draw";
                            }

                            //display the results to the user
                            Console.WriteLine("Results: Player1 rolled {0}" + 
                                                "Player rolled {1} " + 
                                                "Winner: {2}", 
                                                aturn.Player1DiceValue, 
                                                aturn.Player2DiceValue, 
                                                aturn.TurnWinner);
                            gameTurns.Add(aturn);
                            break;
                        }
                    case "C":
                        {
                            //display the current standing int the game
                            //foreach loop
                            //this loop will star processing your collection
                            //   from the first instance to the last instance
                            //   moving automatically to the next instance

                            //C# will strong dataype variable at compile time 
                            //      when the datatype is used in declaring the variable
                            //C# also has a dataype called var
                            //var dataype is set at execution time BUT is still
                            //    strongly datatype on its FIRST execution
                            foreach (var thisTurn in gameTurns)
                            {
                                Console.WriteLine("Results: Player1 rolled {0}" + 
                                                            "Player rolled {1} " + 
                                                            "Winner: {2}", 
                                                            thisTurn.Player1DiceValue, 
                                                            thisTurn.Player2DiceValue, 
                                                            thisTurn.TurnWinner);
                               
                            }
                            Console.WriteLine("\n");
                            break;
                        }

                    case "X":
                        {
                            //display summary results of game
                            int[] counts = new int[] { 0, 0, 0 };
                            foreach (var aturn in gameTurns)
                            {
                                if(aturn.TurnWinner.Equals("Player1"))
                                {
                                    counts[0]++;
                                }
                                else if(aturn.TurnWinner.Equals("Player2"))
                                {
                                    counts[1]++;
                                }
                                else
                                {
                                    counts[2]++;
                                }
                            }
                            Console.Write("Player1 wins {0} Player2 wins {1} Draw {2}", counts[0], counts[1], counts[2]);
                            Console.WriteLine("Thank you for playing. Come again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Try again.");
                            break;
                        }

                }


            } while (menuChoice.ToUpper() != "X");
            Console.ReadKey();

        }

        public static void SetDiceSide(Die player1dice, Die player2dice)
        {
            string indiceSize = "";
            int diceSize = 6;

            Console.WriteLine("Set dice face count of 6 to 20");
            Console.WriteLine("An invalid entry will default to 6");
            Console.Write("Enter number of sides: ");
            indiceSize = Console.ReadLine();

            //Validation
            //a) did the user enter a number
            if(!int.TryParse(indiceSize, out diceSize))
            {
                Console.WriteLine("Die size is invalid. Die size will be set to 6. ");
                diceSize = 6;

            }
            else
            {
                //b) is integer between 6 and 20 
                if (diceSize < 6 || diceSize > 20)
                {
                    Console.WriteLine("Die size is invalid. Die size will be set to 6");
                    diceSize = 6;
                }
                else
                {
                    Console.WriteLine("Die size will be set to {0}.", diceSize);
                }
            }
            player1dice.SetSides(diceSize);
            player2dice.SetSides(diceSize);

        }
    }
}
