namespace InfinityDropMenu
{
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
            InitializeMainMenu();
        }

        private void InitializeMainMenu()
        {
            // Create the main menu item with text "1"
            ToolStripMenuItem mainMenuItem = new ToolStripMenuItem("1");

            // Wire up the event handler for dynamic child menu creation
            mainMenuItem.MouseEnter += MainMenuItem_MouseEnter;

            // Add the main menu item to the menu strip
            MainMenuStrip.Items.Add(mainMenuItem);
        }

        private void MainMenuItem_MouseEnter(object sender, EventArgs e)
        {
            count++;
            ToolStripMenuItem parentMenuItem = (ToolStripMenuItem)sender;
            // Check if the parent menu item already has child items
            if (parentMenuItem.DropDownItems.Count == 0)
            {
                int numberOfChildren = 1; // Adjust the range as needed

                // Create and add child menu items to the parent menu
                for (int i = 0; i < numberOfChildren; i++)
                {

                    ToolStripMenuItem childMenuItem = new ToolStripMenuItem((count).ToString());

                    // Wire up the event handler for dynamic child menu creation
                    childMenuItem.MouseEnter += MainMenuItem_MouseEnter;

                    // Add the child menu item to the parent menu
                    parentMenuItem.DropDownItems.Add(childMenuItem);
                }
            }
        }
    }
}