namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class MinesGame
	{
        private const int MaxCellsToOpen = 35;

        private static List<Score> bestPlayers = new List<Score>(6);
        private static char[,] gameField;
        private static char[,] bombs;
        private static bool startNewGame = true;
        private static bool gameOver = false;
        private static bool haveWinner = false;
        private static int openedCells = 0;
        private static int row = 0;
        private static int col = 0;

        public static void Main()
		{
			string command = string.Empty;

			CreateGameField();

			PutTheBombs();
			
			do
			{
				if (startNewGame)
				{
                    NewGame();
				}

				Console.Write("Enter row and column : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					    int.TryParse(command[2].ToString(), out col) &&
						row <= gameField.GetLength(0) && 
                        col <= gameField.GetLength(1))
					{
						command = "Turn";
					}
				}

                ProceedCommand(command);

				if (gameOver)
				{
                    EndGame();
				}

				if (haveWinner)
				{
                    EndGameWithWinner();
				}
			}
			while (command != "Exit");
			Console.Read();
		}

        private static void NewGame()
        {
            string outputMsg = "Let`s play “Mines”. Try to find all safe fields." +
                                       " The command 'Highscore' shows Top 6 Users and their results," +
                                       " 'Restart' starts new game, 'Exit' close the game!";

            Console.WriteLine(outputMsg);
            PrintGameFieldToConsole(gameField);
            startNewGame = false;
            gameOver = false;
            haveWinner = false;
        }

        private static void EndGame()
        {
            PrintGameFieldToConsole(bombs);
            Console.Write("\nGame over! Your score is {0}. Enter your nickname: ", openedCells);

            string nickname = Console.ReadLine();
            Score userScore = new Score(nickname, openedCells);

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

            CreateNewGame();
        }

        private static void EndGameWithWinner()
        {
            Console.WriteLine("\nWe have Winner! You open 35 cells without step on bomb.");

            PrintGameFieldToConsole(bombs);

            Console.WriteLine("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Score userScore = new Score(nickname, openedCells);

            bestPlayers.Add(userScore);

            CreateNewGame();
        }

        private static void CreateNewGame()
        {
            ShowHighscore();

            CreateGameField();

            PutTheBombs();

            openedCells = 0;
            haveWinner = false;
            startNewGame = true;
        }

        private static void ProceedCommand(string command)
        {
            switch (command)
            {
                case "Highscore":
                    ShowHighscore();
                    break;
                case "Restart":
                    RestartTheGame();
                    break;
                case "Exit":
                    Console.WriteLine("Goodbye!");
                    break;
                case "Turn":
                    ExecutePlayerMove();
                    break;
                default:
                    Console.WriteLine("\nInvalid input!\n");
                    break;
            }
        }

        private static void ExecutePlayerMove()
        {
            if (bombs[row, col] != '*')
            {
                if (bombs[row, col] == '-')
                {
                    GetCellValue(gameField, bombs);
                    openedCells++;
                }

                if (MaxCellsToOpen == openedCells)
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
        }

		private static void ShowHighscore()
		{
            bestPlayers.Sort((Score s1, Score s2) => s2.Name.CompareTo(s1.Name));
            bestPlayers.Sort((Score s1, Score s2) => s2.Points.CompareTo(s1.Points));

            Console.WriteLine("\nPoints:");
			if (bestPlayers.Count > 0)
			{
				for (int i = 0; i < bestPlayers.Count; i++)
				{
					Console.WriteLine(
                                      "{0}. {1} --> {2} cells opened.",
						              i + 1, 
                                      bestPlayers[i].Name,
                                      bestPlayers[i].Points);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No scores!\n");
			}
		}

        private static void RestartTheGame()
        {
            CreateGameField();
            PutTheBombs();
            PrintGameFieldToConsole(gameField);
            gameOver = false;
            startNewGame = false;
        }

		private static void GetCellValue(char[,] gameField, char[,] bombs)
		{
			char numberOfBombs = BombsAroundCell(bombs);
			bombs[row, col] = numberOfBombs;
			gameField[row, col] = numberOfBombs;
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

		private static void CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			gameField = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
                    gameField[i, j] = '?';
				}
			}
		}

		private static void PutTheBombs()
		{
			int rows = 5;
			int cols = 10;
			bombs = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					bombs[i, j] = '-';
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

			foreach (var bombPossition in bombsPossitions)
			{
				int col = bombPossition / cols;
				int row = bombPossition % cols;
				if (row == 0 && bombPossition != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}

				bombs[col, row - 1] = '*';
			}
		}
        
		private static char BombsAroundCell(char[,] field)
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
