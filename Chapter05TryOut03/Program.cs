﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05TryOut03
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    struct route
    {
        public orientation direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) South\n3) East\n4) West\n");
            do
            {
                Console.Write("Select a direction: ");
                myDirection = Convert.ToInt32(Console.ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));
            Console.Write("Input a distance: ");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine("myRoute specifies a direction of {0} and a distance of {1}", myRoute.direction, myRoute.distance);
            Console.ReadKey();
        }
    }
}
