using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETConsole_Program_00A
{
    internal class RENDER_LINE
    {
        public void _H_separator(int origin_x, int origin_y, int length, string style, string edgeLeft, string edgeRight)
        {
            string lineStyle = style;

            int[,] lineMask = new int[1,length];

            lineMask[0,0]          = 1;
            lineMask[0,length - 1] = 2;

            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(origin_x -1 + i ,origin_y);
                _render_H_Flags(lineMask, 0, i, lineStyle, edgeLeft, edgeRight);
            }
        }

        public void _V_separator(int origin_x, int origin_y, int length, string style, string edgeTop, string edgeBottom)
        {
            string lineStyle = style;

            int[,] lineMask = new int[length,1];

            lineMask[0,0]           = 1;
            lineMask[length - 1, 0] = 2;

            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(origin_x, origin_y -1 + i);
                _render_V_Flags(lineMask,i,0,lineStyle,edgeTop,edgeBottom);

            }
        }

        public void _render_H_Flags(int[,] array2D, int x, int y, string style, string edgeLeft, string edgeRight)
        {
            if             (style == "double")     { if (array2D[x,y] == 0) { Console.Write("═"); } }
            else if        (style == "thin")       { if (array2D[x,y] == 0) { Console.Write("─"); } }
            else if        (style == "doubleThin") { if (array2D[x,y] == 0) { Console.Write("─"); } }

            if          (edgeLeft == "double")     { if (array2D[x,y] == 1) { Console.Write("╠"); } }
            else if     (edgeLeft == "doubleThin") { if (array2D[x,y] == 1) { Console.Write("╟"); } }
            else if     (edgeLeft == "thin")       { if (array2D[x,y] == 1) { Console.Write("├"); } }
            else if     (edgeLeft == "thinDouble") { if (array2D[x,y] == 1) { Console.Write("╞"); } }

            if         (edgeRight == "double")     { if (array2D[x,y] == 2) { Console.Write("╣"); } }
            else if    (edgeRight == "doubleThin") { if (array2D[x,y] == 2) { Console.Write("╢"); } }
            else if    (edgeRight == "thin")       { if (array2D[x,y] == 2) { Console.Write("┤"); } }
            else if    (edgeRight == "thinDouble") { if (array2D[x,y] == 2) { Console.Write("╡"); } }
        }

        public void _render_V_Flags(int[,] array2D, int x, int y, string style, string edgeTop, string edgeBottom)
        {
            if               (style == "double")     { if (array2D[x,y] == 0) { Console.Write("║"); } }
            else if          (style == "thin")       { if (array2D[x,y] == 0) { Console.Write("│"); } }
            else if          (style == "doubleThin") { if (array2D[x,y] == 0) { Console.Write("│"); } }

            if            (edgeTop == "double")     { if (array2D[x,y] == 1) { Console.Write("╦"); } }
            else if       (edgeTop == "doubleThin") { if (array2D[x,y] == 1) { Console.Write("╤"); } }
            else if       (edgeTop == "thin")       { if (array2D[x,y] == 1) { Console.Write("┬"); } }
            else if       (edgeTop == "thinDouble") { if (array2D[x,y] == 1) { Console.Write("╥"); } }

            if         (edgeBottom == "double")     { if (array2D[x,y] == 2) { Console.Write("╩"); } }
            else if    (edgeBottom == "doubleThin") { if (array2D[x,y] == 2) { Console.Write("╧"); } }
            else if    (edgeBottom == "thin")       { if (array2D[x,y] == 2) { Console.Write("┴"); } }
            else if    (edgeBottom == "thinDouble") { if (array2D[x,y] == 2) { Console.Write("╨"); } }
        }
    }
}
