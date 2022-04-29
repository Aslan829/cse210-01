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
            List<char> gameArray = new List<char>();
            for (int i = 1; i < 10; i++){
                char c = Convert.ToChar(i);
                gameArray.Add(c);
            }

        //set up a while loop here
        int turns = 1;
        
       // while(turns < 10)

            printBoard(gameArray);

            char turn;
            if (turns % 2 == 1)
                turn ='x';
            else
                turn = 'o';    
            
            playRound(turn, gameArray);
            

        }

        static void printBoard(List<char> array)
        {
            Console.WriteLine(array[0] + "|" + array[1] + "|" + array[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(array[3] + "|" + array[4] + "|" + array[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(array[6] + "|" + array[7] + "|" + array[8]);
        }

        static void playRound(char whoseTurn, List<char> array)
        {
            Console.WriteLine(whoseTurn +"'s turn to choose a square (1-9): ");
            char input = Console.ReadKey().KeyChar;
            int position = int.Parse(input.ToString());

            // if the number isn't here, then the spot is taken
            if (array[position - 1] != position)
                Console.WriteLine("This is already put in!");
            else
                array[position - 1] = whoseTurn;
            
        }
    }
    
}
