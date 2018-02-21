﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

       public Point()
        {
        }
        public Point(int _x, int _y, char _sym)

        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point( Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
         public void Move(int offset, Dirrection direction)
        {
            if (direction == Dirrection.RIGNT)
            {
                x = x + offset;
            }
            else if(direction == Dirrection.LEFT)
            {
                x = x - offset;
            }
            else
            {

            }
        }

        public void Draw()
        {

            Console.SetCursorPosition(x, y );
            Console.Write( sym );
            Console.Write(sym);

        }
    }
}
