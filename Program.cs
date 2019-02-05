using System;

namespace area_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("AREA OF A TRIANGLE");
            Console.WriteLine("enter the base of the ttriangle");
            int b=Convert.ToInt32(Console.ReadLine());
            //int g=
            Console.WriteLine("enter the heigth of the triangle");
            int h=Convert.ToInt32(Console.ReadLine());
            var area_of_triangle=0.5f*b*h;
            Console.WriteLine(area_of_triangle);
            */



            Console.WriteLine("VOLUME OF A CUBOID");
            Console.WriteLine("Enter the lenght of the cuboid");
            int lenght=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the cuboid");
            int width=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the cuboid");
            int height=int.Parse(Console.ReadLine());
            int VOLUME=lenght*width*height;
            Console.WriteLine(VOLUME);
        }
    }
}
