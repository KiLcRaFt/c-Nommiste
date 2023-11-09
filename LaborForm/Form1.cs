namespace LaborForm
{
    public partial class Form1 : Form
    {
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        PictureBox pb;
        //Point point;
        //bool BtnClicked = false;
        //string lbl = "lbl";
        //int posX, posY;
        public Form1()
        {
            this.Height = 450;
            this.Width = 400;
            this.Text = "Labor";
            
            lbl1= new Label();
            LabelChoise labl = new LabelChoise();
            labl.Labl(lbl1, "4", 150, 60);
            labl.DragAnDrop();
            this.Controls.Add(lbl1);

            lbl2 = new Label();
            LabelChoise labl2 = new LabelChoise();
            labl2.Labl(lbl2, "5", 150, 80);
            labl2.DragAnDrop();
            this.Controls.Add(lbl2);

            lbl3 = new Label();
            LabelChoise labl3 = new LabelChoise();
            labl3.Labl(lbl3, "6", 150, 100);
            labl3.DragAnDrop();
            this.Controls.Add(lbl3);

            lbl4 = new Label();
            LabelChoise labl4 = new LabelChoise();
            labl4.Labl(lbl4, "2+2=", 60, 60);
            labl4.DragAnDrop();
            this.Controls.Add(lbl4);


            pb = new PictureBox();
            pb.Location = new Point(50, 50);
            pb.Size = new Size(300, 300);
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);


            //List<string> answernames = new List<string>();
            //answernames.Add("4");
            //answernames.Add("5");
            //answernames.Add("6");

            //List<string> names = new List<string>();
            //answernames.Add("2+2=");
            //answernames.Add("10-5=");
            //answernames.Add("3*2=");


            //for (int i = 0; i <= 5; i++)
            //{

            //    Label name  = lbl + Convert.ToString(i);
            //    lbl1 = new Label();
            //    lbl1.Text = "2+2=";
            //    lbl1.Location = new Point(posX, posY);
            //    lbl1.Size = new Size(180, 160);
            //    lbl1.AutoSize = true;
            //    lbl1.MouseDown += Lbl_MouseDown;
            //    lbl1.MouseUp += Lbl_MouseUp;
            //    lbl1.MouseMove += Lbl_MouseMove;
            //    this.Controls.Add(lbl1);

            //    posX += 10;
            //    posY += 10;
            //}

        }



        //private void Lbl_MouseMove(object? sender, MouseEventArgs e)
        //{
        //    if (BtnClicked)
        //    {
        //        Point newPoint = lbl1.PointToScreen(new Point(e.X, e.Y));
        //        newPoint.Offset(point);
        //        lbl1.Location = newPoint;
        //    }
        //}

        //private void Lbl_MouseUp(object? sender, MouseEventArgs e)
        //{
        //    BtnClicked = false;
        //}

        //private void Lbl_MouseDown(object? sender, MouseEventArgs e)
        //{

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        BtnClicked = true;
        //        Point ptStartPosition = lbl1.PointToScreen(new Point(e.X, e.Y));

        //        point = new Point();
        //        point.X = lbl1.Location.X - ptStartPosition.X;
        //        point.Y = lbl1.Location.Y - ptStartPosition.Y;
        //    }
        //    else
        //    {
        //        BtnClicked = false;
        //    }
        //}
    }
}