using System;

namespace CmdGraphicLibrary
{

    public class CmdGraphic
    {
        #region Variables

        private int _height = 20;
        private int _width = 40;
        private char[,] _buffer;

        public char[,] Buffer { get => _buffer; set => _buffer = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        #endregion

        #region Constructors

        public CmdGraphic()
        {
            Buffer = new char[_width, _height];
        }
        /// <summary>
        /// Set other than default height and width
        /// </summary>
        /// <param name="height">Height of the canvas</param>
        /// <param name="width">Width of the canvas</param>
        public CmdGraphic(int height, int width)
        {
            _height = height;
            _width = width;
            Buffer = new char[_width, _height];
        }

        #endregion

        #region DrawingOnBuffer
        /// <summary>
        /// Fill whole canvas with specified character
        /// </summary>
        /// <param name="fillChar">Char which should fill whole canvas</param>
        public void Fill(char fillChar)
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Buffer[j, i] = fillChar;
                }
            }
        }
        /// <summary>
        /// Draws vertical Line on buffer
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <param name="length">Length of the line</param>
        /// <param name="Char">Char to print</param>
        public void DrawVerticalLine(int x, int y, int length, char Char)
        {
            for (int i = 0; i < length; i++)
            {
                DrawCharAt(x, y + i, Char);
            }
        }
        /// <summary>
        /// Draws horizontal Line on buffer
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <param name="length">Length of the line</param>
        /// <param name="Char">Char to print</param>
        public void DrawHorizontalLine(int x, int y, int length, char Char)
        {
            for (int i = 0; i < length; i++)
            {
                DrawCharAt(x + i, y, Char);
            }

        }

        public void DrawLine(int x, int y, char Char)
        {
            //TO-DO Bresenham's line algorithm
            throw new NotImplementedException();
        }

        public void DrawCircle(int x, int y, int r, char Char)
        {
            //TO-DO Midpoint circle algorithm
            throw new NotImplementedException();
        }

        public void DrawRect(int x, int y, int sizex, int sizey, char Char)
        {
            throw new NotImplementedException();
        }

        public void DrawFilledRect(int x, int y, int sizex, int sizey, char Char, char fillChar)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Draws string horizontally on screen
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <param name="text">Text to draw</param>
        public void DrawTextHorizontally(int x, int y, string text)
        {
            char[] charArrayText = text.ToCharArray();
            for (int i = 0, j = x; i < text.Length; i++, j++)
            {
                if ((y < _height && y >= 0) && (j < _width && j >= 0))
                    Buffer[j, y] = charArrayText[i];
            }
        }

        public void DrawTextVertically(int x, int y, string text)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Draw one char at specified X Y
        /// </summary>
        /// <param name="x">X coordinates</param>
        /// <param name="y">Y coordinates</param>
        /// <param name="Char">Char to print</param>
        public void DrawCharAt(int x, int y, char Char)
        {
            if ((y < _height && y >= 0) && (x < _width && x >= 0))
                 Buffer[x, y] = Char;
        }

        #endregion

        /// <summary>
        /// Gets already processed "Canvas"
        /// </summary>
        /// <returns>Returns string to draw on screen</returns>
        public String GetBuffer()
        {
            string builder = "";
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    builder += Buffer[j, i];
                }

                builder += '\n';
            }

            return builder;
        }
    }
}
