using System;
using System.Text;

using MatrixHomework.Contracts;
using MatrixHomework.Models;

namespace MatrixHomework.Utils
{
    public class MatrixUtils
    {
        /// <summary>
        /// A rotating walk in the matrix is walk that starts form the top left corner of the matrix and goes in down-right direction. When no continuation is available at the current direction , the direction is changed to the next possible clockwise.
        /// </summary>
        /// <param name="matrix">Matrix to fill.</param>
        internal static void FillRotatingWalkMatrix(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            int row = Constants.StartRow;
            int col = Constants.StartCol;
            int cellValue = Constants.CellsStartValue;
            var direction = Constants.directions[0];

            var deltas = DeltaUtils.GetDeltasByDirection(direction);
            bool hasFreeCells = true;

            while (hasFreeCells)
            {
                matrix[row, col] = cellValue;

                if (!CheckForNextMove(matrix, row, col))
                {
                    ICell nextFreeCell = FindUnvisitedCell(matrix);
                    if (nextFreeCell.Row > -1 && nextFreeCell.Col > -1)
                    {
                        row = nextFreeCell.Row;
                        col = nextFreeCell.Col;
                        cellValue++;
                        direction = Constants.directions[0];
                        deltas = DeltaUtils.GetDeltasByDirection(direction);
                    }
                    else
                    {
                        // All cells in matrix are filled.
                        hasFreeCells = false;
                    }

                }
                else
                {
                    var nextRow = row + deltas.X;
                    var nextCol = col + deltas.Y;
                    if (!CheckIfNextMoveIsValid(matrix, nextRow, nextCol))
                    {
                        while (!CheckIfNextMoveIsValid(matrix, nextRow, nextCol))
                        {
                            direction = ChangeDirection(direction);
                            deltas = DeltaUtils.GetDeltasByDirection(direction);
                            nextRow = row + deltas.X;
                            nextCol = col + deltas.Y;
                        }
                    }

                    row += deltas.X;
                    col += deltas.Y;
                    cellValue++;
                }
            }
        }
        
        /// <summary>
        /// Returns string builded from matrix data.
        /// </summary>
        /// <param name="matrix">Matrix from where to get data.</param>
        /// <returns>Returns string.</returns>
        internal static string GetMatrixToString(int[,] matrix)
        {
            var result = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result.Append(string.Format("{0,3}", matrix[row, col]));
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private static string ChangeDirection(string currentDirection)
        {
            string newDirection = string.Empty;

            switch (currentDirection)
            {
                case "DownRight":
                    newDirection = "Down";
                    break;
                case "Down":
                    newDirection = "DownLeft";
                    break;
                case "DownLeft":
                    newDirection = "Left";
                    break;
                case "Left":
                    newDirection = "UpLeft";
                    break;
                case "UpLeft":
                    newDirection = "Up";
                    break;
                case "Up":
                    newDirection = "UpRight";
                    break;
                case "UpRight":
                    newDirection = "Right";
                    break;
                case "Right":
                    newDirection = "DownRight";
                    break;
                default:
                    throw new ArgumentException("Invalid direction!");
            }

            return newDirection;
        }


        private static bool CheckForNextMove(int[,] matrix, int currentRow, int currentCol)
        {
            var directions = new[]
            {
                "DownRight",
                "Down",
                "DownLeft",
                "Left",
                "UpLeft",
                "Up",
                "UpRight",
                "Right"
            };

            for (int i = 0; i < directions.Length; i++)
            {
                var currentDirection = directions[i];
                var deltas = DeltaUtils.GetDeltasByDirection(currentDirection);
                var nextRow = currentRow + deltas.X;
                var nextCol = currentCol + deltas.Y;
                if (CheckIfNextMoveIsValid(matrix, nextRow, nextCol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckIfNextMoveIsValid(int[,] matrix, int nextRow, int nextCol)
        {
            bool isRowInside = 0 <= nextRow && nextRow < matrix.GetLength(0);
            bool isColInside = 0 <= nextCol && nextCol < matrix.GetLength(1);

            bool isInside = isRowInside && isColInside;

            if (isInside)
            {
                return matrix[nextRow, nextCol] == 0;
            }
            else
            {
                return false;
            }
        }

        private static ICell FindUnvisitedCell(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        return new Cell(row, col);
                    }
                }
            }

            return new Cell(-1, -1);
        }

    }
}
