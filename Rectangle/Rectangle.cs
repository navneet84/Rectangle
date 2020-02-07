﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            return this.length;

        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetWidth()
        {
            return this.width;
        }


        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return width * length;
        }

        





    }
}
