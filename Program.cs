using System;
using System.Collections.Generic;
/*
    Name: Tic-Tac-Toe

*/
namespace cse210_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up the basic array
            List<string> gameArray = new List<string>();
            for (int i = 1; i < 10; i++){
                string c = i.ToString();
                gameArray.Add(c);
            }

        //set up a while loop here
        int turns = 1;
        char turn = 'N';
        
       // while(turns < 10)
        while(turns < 10)
        {
            printBoard(gameArray);

            if (turns % 2 == 1)
                turn ='x';
            else if (turns % 2 == 0)
                turn = 'o';    
        
            playRound(turn, gameArray);

            bool won = checkIfWon(turn, gameArray);
            if (won == true)
            {
                Console.WriteLine(turn.ToString() + " won!");
                break;
            }

            turns++;

        }
            

        }

        static void printBoard(List<string> array)
        {
            Console.WriteLine();
            Console.WriteLine(array[0] + "|" + array[1] + "|" + array[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(array[3] + "|" + array[4] + "|" + array[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(array[6] + "|" + array[7] + "|" + array[8]);
        }

        static void playRound(char whoseTurn, List<string> array)
        {
            Console.WriteLine(whoseTurn +"'s turn to choose a square (1-9): ");
            string input = Console.ReadLine();
            int position = int.Parse(input);

            // if the number isn't here, then the spot is taken
            if (array[position - 1] != input.ToString())
                Console.WriteLine("This is already put in!");
            else
                array[position - 1] = whoseTurn.ToString();
        }

        static bool checkIfWon(char whoseTurn, List<String> array)
        {
            if (array[0] == array[1] && array[1] == array[2]) //if row 1 matches
                return true;
            else if (array[3] == array[4] && array[4] == array[5])//If row 2 matches
                return true; 
            else if (array[6] == array[7] && array[7] == array[8]) // if row 3 matches
                return true;
            else if (array[0] == array[3] && array[3] == array[6]) //if col 1 matches
                return true;
            else if (array[1] == array[4] && array[4] == array[7]) //if col 2 matches
                return true;
            else if (array[2] == array[5] && array[5] == array[8]) // if col 3 matches
                return true;
            else if (array[0] == array[4] && array[4] == array[8]) //if left diagonal down matches
                return true;
            else if (array[2] == array[4] && array[4] == array[6]) // if right diagonal down matches
                return true;
            else    
                return false;
            //List options for X to win of how it can win, then check if possiblle for O to win
        
        }
    }
    
}
