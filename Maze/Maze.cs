namespace Maze
{
    public class Maze
    {
        public LevelForm Parent { get; set; } // ссылка на родительскую форму

        public Cell[,] cells;
        public static Random r = new Random();

        public Maze(LevelForm parent)
        {
            Parent = parent;
            cells = new Cell[Configuration.Rows, Configuration.Columns];
        }

        public void Generate()
        {
            for (ushort row = 0; row < Configuration.Rows; row++)
            {
                for (ushort col = 0; col < Configuration.Columns; col++)
                {
                    CellType cell = CellType.HALL;

                    // в 1 случае из 5 - ставим стену в текуще ячейке
                    if (r.Next(5) == 0)
                    {
                        cell = CellType.WALL;
                    }

                    // в 1 случае из 250 - кладём медаль
                    if (r.Next(250) == 0)
                    {
                        cell = CellType.MEDAL;
                    }

                    // в 1 случае из 250 - размещаем врага
                    if (r.Next(50) == 0)
                    {
                        cell = CellType.ENEMY;
                    }

                    // стены по периметру лабиринта
                    if (row == 0 || col == 0 ||
                        row == Configuration.Rows - 1 ||
                        col == Configuration.Columns - 1)
                    {
                        cell = CellType.WALL;
                    }

                    // наш персонажик
                    if (col == Parent.Hero.PosX &&
                        row == Parent.Hero.PosY)
                    {
                        cell = CellType.HERO;
                    }

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (col == Parent.Hero.PosX + 1 &&
                        row == Parent.Hero.PosY ||
                        col == Configuration.Columns - 1 &&
                        row == Configuration.Rows - 3)
                    {
                        cell = CellType.HALL;
                    }

                    cells[row, col] = new Cell(cell);

                    var picture = new PictureBox();
                    picture.Name = "pic" + row + "_" + col;
                    picture.Width = Configuration.PictureSide;
                    picture.Height = Configuration.PictureSide;
                    picture.Location = new Point(
                        col * Configuration.PictureSide,
                        row * Configuration.PictureSide);

                    picture.BackgroundImage = cells[row, col].Texture;
                    picture.Visible = false;
                    Parent.Controls.Add(picture);
                }
            }
        }

        public void Show()
        {
            foreach (var control in Parent.Controls)
            {
                ((PictureBox)control).Visible = true;
            }
        }
    }
}
