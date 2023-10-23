using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    public class StudentKeyListener
    {
        public delegate void KeyHandler(string msg);
        public event KeyHandler Enter;
        public event KeyHandler Space;
        public event KeyHandler Escape;
        public event KeyHandler F1;
        public event KeyHandler Left;
        public event KeyHandler Right;
        public event KeyHandler Up;
        public event KeyHandler Down;

        public void Listen(ConsoleKey key)
        {
            if (key == ConsoleKey.Enter) Enter?.Invoke("Enter");
            else if (key == ConsoleKey.Spacebar) Space?.Invoke("Space");
            else if (key == ConsoleKey.Escape) Escape?.Invoke("Escape");
            else if (key == ConsoleKey.F1) F1?.Invoke("F1");
            else if (key == ConsoleKey.LeftArrow) Left?.Invoke("Left");
            else if (key == ConsoleKey.RightArrow) Right?.Invoke("Right");
            else if (key == ConsoleKey.UpArrow) Up?.Invoke("Up");
            else if (key == ConsoleKey.DownArrow) Down?.Invoke("Down");
        }
    }
}
