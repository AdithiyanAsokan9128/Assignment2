//Authors:         Adithiyan Asokan
//Created On:       10 / 05 / 2021
//Copy Rights:      Conestoga College
//Description:      Includes the logic for Calculating the volume of a triangle.
using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int length = -1;
            do
            {
                Console.WriteLine("Please enter the Length");
                length = Convert.ToInt32(Console.ReadLine());
            } while (length <= 0);
            rectangle.SetLength(length);

            int width = -1;
            do
            {
                Console.WriteLine("Please enter the Width");
                width = Convert.ToInt32(Console.ReadLine());
            } while (width <= 0);
            rectangle.SetWidtth(width);

            int height = -1;
            do
            {
                Console.WriteLine("Please enter the height");
                height = Convert.ToInt32(Console.ReadLine());
            } while (height <= 0);
            rectangle.Setheight(height);       
            int options = 0;
            do {
                options = giveOptions();
                switch (options)
                {

                    case 1:
                        Console.WriteLine("The length of the rectangle is " + length);
                        break;

                    case 2:
                        length = -1;
                        do
                        {
                            Console.WriteLine("Please enter the Length");
                            length = Convert.ToInt32(Console.ReadLine());
                        } while (length <= 0);
                        rectangle.SetLength(length);
                        Console.WriteLine("The length of the rectangle is " + rectangle.GetLength());
                        break;

                    case 3:
                        Console.WriteLine("The Width of the rectangle is " + width);
                        break;
                    case 4:
                        width = -1;
                        do
                        {
                            Console.WriteLine("Please enter the Width");
                            width = Convert.ToInt32(Console.ReadLine());
                        } while (width <= 0);
                        rectangle.SetWidtth(width);
                        Console.WriteLine("The width of the rectangle is " + rectangle.GetWidth());
                        break;
                    case 5:
                        Console.WriteLine("The height of the rectangle is " + height);
                        break;
                    case 6:
                        height = -1;
                        do
                        {
                            Console.WriteLine("Please enter the Width");
                            height = Convert.ToInt32(Console.ReadLine());
                        } while (height <= 0);
                        rectangle.Setheight(height);
                        Console.WriteLine("The height of the rectangle is " + rectangle.GetHeight());
                        break;

                    case 7:
                        Console.WriteLine("The Volume of the rectangle is " + rectangle.GetVolume());
                        break;
                    case 8:
                        Console.WriteLine("Thank You!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option between 1 and 8");
                        break;

                }
            } while(options != 8);
            
        }
        //This method Used to give the option to the used to get and set the dimentions of the triangle
        public static int giveOptions()
        {
            Console.WriteLine("1 -  Get Length of the Rectangle");
            Console.WriteLine("2 -  Change the Length of the Rectangle");
            Console.WriteLine("3 -  Get width of the Rectangle");
            Console.WriteLine("4 -  Change the width of the Rectangle");
            Console.WriteLine("5 -  Get the Height of the Rectangle");
            Console.WriteLine("6 -  Change the Height of the Rectangle");
            Console.WriteLine("7 -  Get the volume of the Rectangle");
            Console.WriteLine("8 - Exit");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
    
}
