using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Box
    {
        private int b; //ширина
        private int l; //длина
        private int h; //высота

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if(value > 0) b = value;
            }
        }

        public int L
        {
            get
            {
                return l;
            }
            set
            {
                if (value > 0) l = value;
            }
        }

        public int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0) h = value;
            }
        }

        public Box()
        {
            B = 0;
            L = 0;
            H = 0;
        }

        public Box(int a, int b,int c)
        {
            B = a;
            L = b;
            H = c;
        }

        public float Volume()
        {
            float v = l*b*h;
            return v;
        }

        public void Show()
        {
            Console.WriteLine($"Объем коробки ширина = {B}, длина = {L}, высота = {H}");
            return;
        }

        
    }
}
