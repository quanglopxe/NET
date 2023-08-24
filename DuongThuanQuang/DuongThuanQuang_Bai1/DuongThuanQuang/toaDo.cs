using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang
{
    class toaDo
    {
        protected int x, y;
        protected string ten;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public toaDo()
        {
            this.x = 0;
            this.y = 0;
            this.ten = null;
        }
        public toaDo(int x,int y,string ten)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public void toString()
        {
            Console.Write("Toa do {0}({1},{2})", ten, x, y);
        }
    }
}
