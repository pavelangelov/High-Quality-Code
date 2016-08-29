namespace Task_2.Refactor_if
{
    public class Matrix
    {
        public void CheckCellBeforeVisit(bool[,] visitedCells, int row, int col)
        {
            int rows = visitedCells.GetLength(0);
            int cols = visitedCells.GetLength(1);

            var rowIsInMatrix = row < 0 && row < rows;
            var colIsInMatrix = col < 0 && col < cols;

            if (rowIsInMatrix && colIsInMatrix && !visitedCells[row, col])
            {
                VisitCell(visitedCells, row, col);
            }
        }

        public void VisitCell(bool[,] matrix, int row, int col)
        {
            matrix[row, col] = true;
        }
    }
}
