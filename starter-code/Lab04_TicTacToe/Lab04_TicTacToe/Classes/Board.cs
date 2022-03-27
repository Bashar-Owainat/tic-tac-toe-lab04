using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
   public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
			
		};


		public void DisplayBoard(string[,] arr2d)
		{

			//TODO: Output the board to the console
			for (int i = 0; i < arr2d.GetLength(0); i++)
			{
				for (int j = 0; j < arr2d.GetLength(1); j++)
				{
					Console.Write(arr2d[i, j] + "\t");
				}
				Console.WriteLine();
			}

		}
	}
}
