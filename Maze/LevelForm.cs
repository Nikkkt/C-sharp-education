using System.Windows.Forms;

namespace Maze
{
    public partial class LevelForm : Form
    {
        public Maze maze; // ссылка на логику всего происход€щего в лабиринте
        public Character Hero;
        private int hp = 100;
        private int steps = 0;
        private StatusStrip statusStrip;

        public LevelForm()
        {
            InitializeComponent();
            FormSettings();
            StartGameProcess();

            UpdateTitle();

            StatusStrip statusStrip = new StatusStrip();
            ToolStripStatusLabel healthLabel = new ToolStripStatusLabel("Health: " + hp);
            ToolStripStatusLabel stepsLabel = new ToolStripStatusLabel("Steps: 0");

            statusStrip.Items.Add(healthLabel);
            statusStrip.Items.Add(stepsLabel);
            Controls.Add(statusStrip);

            UpdateTitle();
        }

        public void FormSettings()
        {
            Text = Configuration.Title;
            BackColor = Configuration.Background;

            // размеры клиентской области формы
            ClientSize = new Size(
                Configuration.Columns * Configuration.PictureSide,
                Configuration.Rows * Configuration.PictureSide);

            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGameProcess()
        {
            Hero = new Character(this);
            maze = new Maze(this);
            maze.Generate();
            maze.Show();
        }
        private void UpdateTitle()
        {
            Text = "HP: " + hp;
        }

        private void UpdateHealthLabel()
        {
            // Update the health label in the StatusStrip
            ((ToolStripStatusLabel)statusStrip.Items[0]).Text = "Health: " + hp;
        }

        private void UpdateStepsLabel(int steps)
        {
            // Update the steps label in the StatusStrip
            ((ToolStripStatusLabel)statusStrip.Items[1]).Text = "Steps: " + steps;
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    steps++;  // Increment the steps count

                    // Update the steps label in the StatusStrip
                    toolStripStatusSteps.Text = "Steps: " + steps;
                }
                if (e.KeyCode == Keys.Right)
                {
                    // проверка на то, свободна ли €чейка справа
                    if (maze.cells[Hero.PosY, Hero.PosX + 1].Type != CellType.WALL)
                    {
                        if (maze.cells[Hero.PosY, Hero.PosX + 1].Type == CellType.ENEMY)
                        {
                            hp -= 25;
                            UpdateTitle();
                            if (hp == 0)
                            {
                                UpdateTitle();
                                MessageBox.Show("You lose");
                                Application.Exit();
                            }
                        }
                        Hero.Clear();
                        Hero.MoveRight();
                        Hero.Show();
                    }
                }
                else if (e.KeyCode == Keys.Left && Hero.PosX != 0)
                {
                    // проверка на то, свободна ли €чейка слева
                    if (maze.cells[Hero.PosY, Hero.PosX - 1].Type != CellType.WALL)
                    {
                        if (maze.cells[Hero.PosY, Hero.PosX - 1].Type == CellType.ENEMY)
                        {
                            hp -= 25;
                            UpdateTitle();
                            if (hp == 0)
                            {
                                UpdateTitle();
                                MessageBox.Show("You lose");
                                Application.Exit();
                            }
                        }
                        Hero.Clear();
                        Hero.MoveLeft();
                        Hero.Show();
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    // проверка на то, свободна ли €чейка выше
                    if (maze.cells[Hero.PosY - 1, Hero.PosX].Type != CellType.WALL)
                    {
                        if (maze.cells[Hero.PosY - 1, Hero.PosX].Type == CellType.ENEMY)
                        {
                            hp -= 25;
                            UpdateTitle();
                            if (hp == 0)
                            {
                                UpdateTitle();
                                MessageBox.Show("You lose");
                                Application.Exit();
                            }
                        }
                        Hero.Clear();
                        Hero.MoveUp();
                        Hero.Show();
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    // проверка на то, свободна ли €чейка ниже
                    if (maze.cells[Hero.PosY + 1, Hero.PosX].Type != CellType.WALL)
                    {
                        if (maze.cells[Hero.PosY + 1, Hero.PosX].Type == CellType.ENEMY)
                        {
                            hp -= 25;
                            UpdateTitle();
                            if (hp == 0)
                            {
                                UpdateTitle();
                                MessageBox.Show("You lose");
                                Application.Exit();
                            }
                        }
                        Hero.Clear();
                        Hero.MoveDown();
                        Hero.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("You win");
            }
        }
    }
}