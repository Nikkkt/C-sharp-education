namespace Delegates {
    class Program {
        delegate void Menu();
        static void NewGame() {
            Console.Clear();
            Console.WriteLine("New game");
        }
        static void LoadGame() {
            Console.Clear();
            Console.WriteLine("Load game"); 
        }
        static void Rules() {
            Console.Clear();
            Console.WriteLine("Rules"); 
        }
        static void AboutAuthor() {
            Console.Clear();
            Console.WriteLine("About author"); 
        }
        static void Exit() {
            Console.Clear();
            Console.WriteLine("Exit");
            Environment.Exit(0);
        }
        static void Main(string[] args) {
            Menu menu = Exit;
            menu += NewGame;
            menu += LoadGame;
            menu += Rules;
            menu += AboutAuthor;

            while (true) {
                Console.Clear();

                Console.WriteLine("1 - new game");
                Console.WriteLine("2 - load game");
                Console.WriteLine("3 - rules");
                Console.WriteLine("4 - about author");
                Console.WriteLine("0 - exit\n");
                Console.Write(">>> ");
                int choice = int.Parse(Console.ReadLine());

                if (choice < 0 || choice > 4) {
                    Console.Clear();
                    Console.WriteLine("ERROR. INCORRECT CHOICE");
                    Thread.Sleep(1000);
                    continue;
                }

                Delegate[] menuList = menu.GetInvocationList();
                Menu option = (Menu)menuList[choice];
                option.Invoke();
                Thread.Sleep(1000);
            }
        }
    }
}