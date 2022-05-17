using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETConsole_Program_00A
{
    internal class Program
    {        
        static void Main(string[] args)
        {   
            // console settings initialization
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            // class initialization
            RENDER_RECT _0DrawShape = new RENDER_RECT();
            RENDER_LINE _0Sep_Line = new RENDER_LINE();
            RENDER_STRINGBOX _0StringRect = new RENDER_STRINGBOX();

            //// parameter initialization
            bool mainLoop_Active = true;

            // window parameters
            int width  = 50;
            int height = 25;

            int cursorPos;
            int[] buttons;
            int selected;

            // draw boxes
            _0DrawShape._box(width, height, 1, 1, "roundBox", "white");
            _0Sep_Line._H_separator(1, 3, width, "double", "thinDouble", "thinDouble");
            _0Sep_Line._V_separator(15, 4, height - 2, "thin", "doubleThin", "thin");

            _0StringRect._StringBox(2, 0, "Main Menu", "roundBox", "nil", "white", "");

            _0DrawShape._box(10, 5, 18, 4, "laserBox", "red");
            _0StringRect._StringBox(29, 5, "red box!", "roundBox", "", "red", "");
            _0DrawShape._box(10, 5, 18, 10, "roundBox", "green");

            _0StringRect._StringBox(29, 11, "green box!", "roundBox", "nil", "green", "");
            _0DrawShape._box(10, 5, 18, 16, "doubleBox", "blue");
            _0StringRect._StringBox(29, 17, "blue box!", "roundBox", "nil", "blue", "");

            Console.WriteLine("⢿");
            Console.CursorVisible = false;

            while (mainLoop_Active == true)
            {
                
            }
        }
    }
}
