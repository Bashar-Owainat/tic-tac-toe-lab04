using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

using System;


namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Tic-Tac-Toe Game!");
            StartGame();


        }

        //this method creates the players, initializes their names and markers then call the play method
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            
            //create two players
            //Call the constructor in the game class
            //call the play using an object

            Player p1 = new Player();
            p1.Name = "Player2";
            p1.Marker = "O";
            Player p2 = new Player();
            p2.Name = "Player1";
            p2.Marker = "X";

            Game game1 = new Game(p1, p2);
            game1.Play();

        }


    }
}
