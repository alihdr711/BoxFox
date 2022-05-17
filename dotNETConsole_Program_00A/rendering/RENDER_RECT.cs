using System;

namespace dotNETConsole_Program_00A
{
    internal class RENDER_RECT
    {
        //  ||===================================================||
        //  || Draw rectangle incl. variable position in console ||
        //  ||-------------------------------------------------------------------------------------------------------------------||
        //  || Initialization of parameters, variables and UTF8. Simple ASCII is not compatible with certain special characters. ||
        //  || This class method allows for drawing a simple rectangle by giving it a x and y length parameter, includes         ||
        //  || choosing a style parameter "BoxStyle" and two offset parameters for drawing the rectangle at an offset position.  ||
        //  ||___________________________________________________________________________________________________________________||
        //                                                                                                || Made by L. Polewski ||
        //                                                                                                ||=====================||
        public void _box(int width,
                         int height,
                         int offset_x,
                         int offset_y,
                         string style,
                         string color)
        {
            RENDER_COLOR _0SetColor = new RENDER_COLOR();

            int length_x, x;        // x length variable, determines the width of the rect  || variable x as iterator
            int length_y, y;        // y length variable, determines the length of the rect || variable y as iterator
            int p0_x;               // x coordinate of box render origin (lit.: position 0 of x axis on grid)
            int p0_y;               // y coordinate of box render origin (lit.: position 0 of y axis on grid)
            string BoxStyle = "";   // box style selector -- [doubleBox, thinBox, roundBox, laserBox]

            // argument interface variables
            p0_x     = offset_x;
            p0_y     = offset_y;
            length_x = width  + p0_x;
            length_y = height + p0_y;
            BoxStyle = style;

            int[,] gridMask = new int[length_x, length_y]; // 2D Array initialization

            gridMask[0 + p0_x, 0 + p0_y]         = 1; // top left corner flag
            gridMask[length_x - 1, 0 + p0_y]     = 2; // top right corner flag
            gridMask[0 + p0_x, length_y - 1]     = 3; // bottom left corner flag
            gridMask[length_x - 1, length_y - 1] = 4; // bottom right corner flag

            for (x = 1 + p0_x; x < length_x - 1; x++) // iterate edge length x -- excluding corners
            {
                gridMask[x, 0 + p0_y]     = 6;        // top rectangle edge flagging
                gridMask[x, length_y - 1] = 6;        // bottom rectangle edge flagging
            }

            for (y = 1 + p0_y; y < length_y - 1; y++) //iterate edge length y -- excluding corners
            {
                gridMask[0 + p0_x, y]     = 5;        // left rectangle edge flagging
                gridMask[length_x - 1, y] = 5;        // right rectangle edge flagging
            }

            // set formatting parameters
            _0SetColor._frontColor(color); // set color

            for (y = 0; y < length_y; y++) // draw rectangle -- whole grid render y axis
            {
                for (x = 0; x < length_x; x++) // draw rectangle -- whole grid render x axis
                {
                    if (gridMask[x, y] > 0) // draws selected flag if available [> 0]
                    {   
                        _renderFlags(gridMask, x, y, BoxStyle);
                    }
                    else { Console.SetCursorPosition(x, y); } // skips the [x,y] position by just placing the cursor at [x,y]
                }
            }

            // reset formatting parameters
            _0SetColor._colorReset(); // reset front color
        }

        public void _renderFlags(int[,] array2D, int x, int y, string style)
        {
            if (style == "doubleBox")
            {
                if      (array2D[x, y] == 0) { Console.Write(" "); }
                else if (array2D[x, y] == 1) { Console.Write("╔"); }
                else if (array2D[x, y] == 2) { Console.Write("╗"); }
                else if (array2D[x, y] == 3) { Console.Write("╚"); }
                else if (array2D[x, y] == 4) { Console.Write("╝"); }
                else if (array2D[x, y] == 5) { Console.Write("║"); }
                else if (array2D[x, y] == 6) { Console.Write("═"); }
            }
            if (style == "thinBox")
            {
                if      (array2D[x, y] == 0) { Console.Write(" "); }
                else if (array2D[x, y] == 1) { Console.Write("┌"); }
                else if (array2D[x, y] == 2) { Console.Write("┐"); }
                else if (array2D[x, y] == 3) { Console.Write("└"); }
                else if (array2D[x, y] == 4) { Console.Write("┘"); }
                else if (array2D[x, y] == 5) { Console.Write("│"); }
                else if (array2D[x, y] == 6) { Console.Write("─"); }
            }
            if (style == "roundBox")
            {
                if      (array2D[x, y] == 0) { Console.Write(" "); }
                else if (array2D[x, y] == 1) { Console.Write("╭"); }
                else if (array2D[x, y] == 2) { Console.Write("╮"); }
                else if (array2D[x, y] == 3) { Console.Write("╰"); }
                else if (array2D[x, y] == 4) { Console.Write("╯"); }
                else if (array2D[x, y] == 5) { Console.Write("│"); }
                else if (array2D[x, y] == 6) { Console.Write("─"); }
            }
            if (style == "laserBox")
            {
                if      (array2D[x, y] == 0) { Console.Write(" "); }
                else if (array2D[x, y] == 1) { Console.Write("╒"); }
                else if (array2D[x, y] == 2) { Console.Write("╕"); }
                else if (array2D[x, y] == 3) { Console.Write("╘"); }
                else if (array2D[x, y] == 4) { Console.Write("╛"); }
                else if (array2D[x, y] == 5) { Console.Write("│"); }
                else if (array2D[x, y] == 6) { Console.Write("═"); }
            }
        }
    }
}
