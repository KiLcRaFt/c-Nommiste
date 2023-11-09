using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborForm
{
    public class LabelChoise
    {
        Point point;
        bool BtnClicked = false;
        private Label _lbl;

        public void Labl(Label lbl, string text, int x, int y)
        {
            _lbl = lbl;
            _lbl.Text = text;
            _lbl.Location = new Point(x, y);
        }

        public void DragAnDrop()
        {
            _lbl.MouseDown += Lbl_MouseDown;
            _lbl.MouseUp += Lbl_MouseUp;
            _lbl.MouseMove += Lbl_MouseMove;
        
        }

        private void Lbl_MouseMove(object? sender, MouseEventArgs e)
        {
            if (BtnClicked)
            {
                Point newPoint = _lbl.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(point);
                _lbl.Location = newPoint;
            }
        }

        private void Lbl_MouseUp(object? sender, MouseEventArgs e)
        {
            BtnClicked = false;
        }

        private void Lbl_MouseDown(object? sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                BtnClicked = true;
                Point ptStartPosition = _lbl.PointToScreen(new Point(e.X, e.Y));

                point = new Point();
                point.X = _lbl.Location.X - ptStartPosition.X;
                point.Y = _lbl.Location.Y - ptStartPosition.Y;
            }
            else
            {
                BtnClicked = false;
            }
        }
    }
}
