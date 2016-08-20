using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mines
{
	public class MinesGame
	{
		public class Score
		{
			string name;
			int points;

			public string Name
			{
				get
                {
                    return this.name;
                }
				set
                {
                    this.name = value;
                }
			}

			public int Points
			{
				get
                {
                    return points;
                }
				set
                {
                    points = value;
                }
			}

			public Score()
            {
            }

			public Score(string name, int points)
			{
				this.Name = name;
				this.Points = points;
			}
		}

		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] gameField = CreateGameField();
			char[,] bombs = PutTheBombs();
			int counter = 0;
			bool gameOver = false;
			List<Score> bestPlayers = new List<Score>(6);
			int row = 0;
			int col = 0;
			bool startNewGame = true;
			const int maxMoves = 35;
			bool haveWinner = false;

			do
			{
				if (startNewGame)
				{
					Console.WriteLine("Let`s play “Mines”. Try to find all safe fields." +
                    " The command 'Highscore' shows Top 6 Users and their results, 'Restart' starts new game, 'Exit' close the game!");
					PrintGameFieldToConsole(gameField);
					startNewGame = false;
				}
				Console.Write("Enter row and column : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out col) &&
						row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "Highscore":
						Highscore(bestPlayers);
						break;
					case "Restart":
						gameField = CreateGameField();
						bombs = PutTheBombs();
						PrintGameFieldToConsole(gameField);
						gameOver = false;
						startNewGame = false;
						break;
					case "Exit":
						Console.WriteLine("Goodbye!");
						break;
					case "turn":
						if (bombs[row, col] != '*')
						{
							if (bombs[row, col] == '-')
							{
								tisinahod(gameField, bombs, row, col);
								counter++;
							}
							if (maxMoves == counter)
							{
								haveWinner = true;
							}
							else
							{
								PrintGameFieldToConsole(gameField);
							}
						}
						else
						{
							gameOver = true;
						}
						break;
					default:
						Console.WriteLine("\nInvalid input!\n");
						break;
				}
				if (gameOver)
				{
					PrintGameFieldToConsole(bombs);
					Console.Write("\nGame over! Your score is {0}. " +
						"Enter your nickname: ", counter);
					string nickname = Console.ReadLine();
					Score userScore = new Score(nickname, counter);
					if (bestPlayers.Count < 5)
					{
						bestPlayers.Add(userScore);
					}
					else
					{
						for (int i = 0; i < bestPlayers.Count; i++)
						{
							if (bestPlayers[i].Points < userScore.Points)
							{
								bestPlayers.Insert(i, userScore);
								bestPlayers.RemoveAt(bestPlayers.Count - 1);
								break;
							}
						}
					}
					bestPlayers.Sort((Score s1, Score s2) => s2.Name.CompareTo(s1.Name));
					bestPlayers.Sort((Score s1, Score s2) => s2.Points.CompareTo(s1.Points));
					Highscore(bestPlayers);

					gameField = CreateGameField();
					bombs = PutTheBombs();
					counter = 0;
					gameOver = false;
					startNewGame = true;
				}
				if (haveWinner)
				{
					Console.WriteLine("\nWe have Winner! You open 35 cells without step on bomb.");
					PrintGameFieldToConsole(bombs);
					Console.WriteLine("Enter your nickname: ");
					string nickname = Console.ReadLine();
					Score userScore = new Score(nickname, counter);
					bestPlayers.Add(userScore);
					Highscore(bestPlayers);
					gameField = CreateGameField();
					bombs = PutTheBombs();
					counter = 0;
					haveWinner = false;
					startNewGame = true;
				}
			}
			while (command != "exit");
			Console.Read();
		}

		private static void Highscore(List<Score> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No scores!\n");
			}
		}

		private static void tisinahod(char[,] gameField,
			char[,] bombs, int row, int col)
		{
			char currentBombsSum = CalculateBombs(bombs, row, col);
			bombs[row, col] = currentBombsSum;
			gameField[row, col] = currentBombsSum;
		}

		private static void PrintGameFieldToConsole(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PutTheBombs()
		{
			int rows = 5;
			int cols = 10;
			char[,] field = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					field[i, j] = '-';
				}
			}

			List<int> bombsPossitions = new List<int>();
			while (bombsPossitions.Count < 15)
			{
				Random random = new Random();
				int randomNumber = random.Next(50);
				if (!bombsPossitions.Contains(randomNumber))
				{
					bombsPossitions.Add(randomNumber);
				}
			}

			foreach (int bombPossition in bombsPossitions)
			{
				int col = (bombPossition / cols);
				int row = (bombPossition % cols);
				if (row == 0 && bombPossition != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				field[col, row - 1] = '*';
			}

			return field;
		}

		private static void smetki(char[,] field)
		{
			int rows = field.GetLength(0);
			int cols = field.GetLength(1);

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (field[row, col] != '*')
					{
						char currentBombsSum = CalculateBombs(field, row, col);
						field[row, col] = currentBombsSum;
					}
				}
			}
		}

		private static char CalculateBombs(char[,] field, int row, int col)
		{
			int result = 0;
			int rows = field.GetLength(0);
			int cols = field.GetLength(1);

			if (row - 1 >= 0)
			{
				if (field[row - 1, col] == '*')
				{ 
					result++; 
				}
			}
			if (row + 1 < rows)
			{
				if (field[row + 1, col] == '*')
				{ 
					result++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (field[row, col - 1] == '*')
				{ 
					result++;
				}
			}
			if (col + 1 < cols)
			{
				if (field[row, col + 1] == '*')
				{ 
					result++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (field[row - 1, col - 1] == '*')
				{ 
					result++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (field[row - 1, col + 1] == '*')
				{ 
					result++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (field[row + 1, col - 1] == '*')
				{ 
					result++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (field[row + 1, col + 1] == '*')
				{ 
					result++; 
				}
			}
			return char.Parse(result.ToString());
		}
	}
}
