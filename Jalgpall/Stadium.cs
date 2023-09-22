using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Stadium
    {
        public int Width { get; }
        public int Height { get; }
        List<Figure> wallList;
        public Stadium(int width, int height)
        {
            Width = width;
            Height = height;
            wallList = new List<Figure>();
            HorizontalLine upline = new HorizontalLine(0, Width-1, 0, '-');
            HorizontalLine downline = new HorizontalLine(0, Width-1, Height-1, '-');
            VerticalLine leftline = new VerticalLine(0, Height-1, 0, '|');
            VerticalLine rightline = new VerticalLine(0, Height-1, Width-1, '|');
            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        public bool IsIn(double x, double y) // находится ли мяч на поле?
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
