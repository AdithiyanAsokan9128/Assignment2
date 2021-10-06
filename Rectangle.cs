using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Rectangle
    {
        private int length;
        private int width;
        private int height;
        //Default constructors
        public Rectangle()
        {
            this.length = 0;
            this.width = 0;
            this.height = 0;
        }
        //Parameterized Constructors
        public Rectangle(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }
        //accessors and mutators for the triangle
        public int GetLength()
        {
            return this.length;

        }
        public int GetHeight()
        {
            return this.height;

        }
        public int GetWidth()
        {
            return this.width;

        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;

        }
        public int SetWidtth(int width)
        {
            this.width = width;
            return this.width;

        }
        public int Setheight(int height)
        {
            this.height = height;
            return this.height;

        }
        public int GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
