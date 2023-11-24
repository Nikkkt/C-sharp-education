namespace Maze
{
    public enum CellType { HALL, WALL, MEDAL, ENEMY, HERO };

    public class Cell
    {
        public static Bitmap[] Images = {
            new Bitmap(Properties.Resources.hall),
            new Bitmap(Properties.Resources.wall),
            new Bitmap(Properties.Resources.medal),
            new Bitmap(Properties.Resources.enemy), 
            new Bitmap(Properties.Resources.player)
        };

        public CellType Type { get; set; }

        public Image Texture { get; set; }

        public Cell(CellType type)
        {
            Type = type;
            Texture = Images[(int)Type];
        }
    }
}