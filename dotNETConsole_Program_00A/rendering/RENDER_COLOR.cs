using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETConsole_Program_00A
{
    internal class RENDER_COLOR
    {
        public void _frontColor(string color)
        {
            switch (color)
            {
                case ""            : Console.ForegroundColor = ConsoleColor.White;       break;
                case "black"       : Console.ForegroundColor = ConsoleColor.Black;       break;
                case "white"       : Console.ForegroundColor = ConsoleColor.White;       break;
                case "red"         : Console.ForegroundColor = ConsoleColor.Red;         break;
                case "blue"        : Console.ForegroundColor = ConsoleColor.Blue;        break;
                case "green"       : Console.ForegroundColor = ConsoleColor.Green;       break;
                case "magenta"     : Console.ForegroundColor = ConsoleColor.Magenta;     break;
                case "yellow"      : Console.ForegroundColor = ConsoleColor.Yellow;      break;
                case "cyan"        : Console.ForegroundColor = ConsoleColor.Cyan;        break;
                case "gray"        : Console.ForegroundColor = ConsoleColor.Gray;        break;
                case "darkRed"     : Console.ForegroundColor = ConsoleColor.DarkRed;     break;
                case "darkBlue"    : Console.ForegroundColor = ConsoleColor.DarkBlue;    break;
                case "darkGreen"   : Console.ForegroundColor = ConsoleColor.DarkGreen;   break;
                case "darkMagenta" : Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case "darkYellow"  : Console.ForegroundColor = ConsoleColor.DarkYellow;  break;
                case "darkCyan"    : Console.ForegroundColor = ConsoleColor.DarkCyan;    break;
                case "darkGray"    : Console.ForegroundColor = ConsoleColor.DarkGray;    break;
            }
        }

        public void _colorReset()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
