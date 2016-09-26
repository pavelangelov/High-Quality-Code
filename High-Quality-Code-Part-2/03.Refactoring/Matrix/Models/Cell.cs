using MatrixHomework.Contracts;

namespace MatrixHomework.Models
{
    public class Cell : ICell
    {
        public Cell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
