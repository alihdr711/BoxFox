using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETConsole_Program_00A
{
    internal class RENDER_STRINGBOX
    {
        public void _StringBox (int offset_x, int offset_y, string displayText, string boxStyle, string edgeStyle, string boxCol ,string fontCol)
        {
            RENDER_RECT _0DrawBox = new RENDER_RECT();
            RENDER_COLOR _0SetColor = new RENDER_COLOR();

            string text = displayText;

            _0SetColor._frontColor(boxCol);
            _0DrawBox._box(text.Length + 2, 3, offset_x, offset_y, boxStyle, boxCol);

            _0SetColor._frontColor(fontCol);
            Console.SetCursorPosition(offset_x , offset_y + 1);
            Console.Write(text);

            _0SetColor._colorReset();
        }
    }
}
