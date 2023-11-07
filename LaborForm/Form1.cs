namespace LaborForm
{
    public partial class Form1 : Form
    {
        PictureBox pb;
        Label lbl, lbla;
        int posX;
        int posY;
        bool lblClicked;
        public Form1()
        {
            this.Height = 800;
            this.Width = 800;
            this.Text = "Labor";

            pb = new PictureBox();
            
            lbl= new Label();
            lbl.Text = "2+2=";
            lbl.Location = new Point(50,50);
            lbl.MouseDown += Lbl_MouseDown;
            lbl.MouseUp += Lbl_MouseUp;
            lbl.MouseMove += Lbl_MouseMove;
            this.Controls.Add(lbl);


            lbla = new Label();
            lbla.Text = "4";
            lbla.Location = new Point(50, 100);
            this.Controls.Add(lbla);

        }

        private void Lbl_MouseMove(object? sender, MouseEventArgs e)
        {
            if (lblClicked)
            {
                posX = e.X - lbl.Location.X;
                posY = e.Y - lbl.Location.Y;
            }

            lbl.Invalidate();
        }

        private void Lbl_MouseUp(object? sender, MouseEventArgs e)
        {
            lblClicked= false;
        }

        private void Lbl_MouseDown(object? sender, MouseEventArgs e)
        {
            if((e.X < lbl.Location.X + lbl.Width) && (e.X > lbl.Location.X))
            {
                if((e.Y < lbl.Location.Y + lbl.Height)&&(e.Y > lbl.Location.Y))
                {
                    lblClicked = true;

                    posX = e.X - lbl.Location.X;
                    posY = e.Y - lbl.Location.Y;
                }
            }
        }
    }
}