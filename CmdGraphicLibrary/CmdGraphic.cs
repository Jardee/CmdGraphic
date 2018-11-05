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

        public CmdGraphic(int height, int width)
        {
            _height = height;
            _width = width;
            Buffer = new char[_width, _height];
        }

        #endregion

        #region DrawingOnBuffer
        
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

        public void DrawVerticalLine(int x, int y, int length)
        {
            throw new NotImplementedException();
        }

        public void DrawHorizontalLine(int x, int y, int length)
        {
            throw new NotImplementedException();
        }

        public void DrawLine(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void DrawCircle(int x, int y, int r)
        {
            throw new NotImplementedException();
        }

        public void DrawRect(int x, int y, int sizex, int sizey)
        {
            throw new NotImplementedException();
        }

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

        public void DrawCharAt(int x, int y, char Char)
        {
            if ((y < _height && y >= 0) && (x < _width && x >= 0))
                 Buffer[x, y] = Char;
        }

        #endregion

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
