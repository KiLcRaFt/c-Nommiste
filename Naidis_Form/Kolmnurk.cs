using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_Form
{
    public partial class Kolmnurk : Form
    {
        double side;
        Button btn, btn2;
        Label lbl, lblA, lblB, lblC, lblH;
        TextBox txt, txtA, txtB, txtC, txtH;
        ListView lv;
        PictureBox pb;
        RadioButton rA, rB, rC;

        public Kolmnurk()
        {
            this.Width = 800;
            this.Height = 600;
            this.Text = "Kolmnurk";
            side = 0;

            //label
            lbl = new Label();
            lbl.Text = "Kolmnurk";
            lbl.Location = new Point(0, 0);
            lbl.Size = new Size(200, 50);
            lbl.Font = new Font("Tahoma", 24);
            this.Controls.Add(lbl);

            //ListView
            lv = new ListView();
            lv.View = View.Details;
            lv.Size = new Size(400, 200);
            lv.Location = new Point(lbl.Left + 10, lbl.Bottom + 5);

            lv.Columns.Add("Andmed", 100);
            lv.Columns.Add("Value", 100);

            lv.Items.Add("Külg A: ");
            lv.Items.Add("Külg B: ");
            lv.Items.Add("Külg C: ");
            lv.Items.Add("Olemas: ");
            lv.Items.Add("Perimeeter: ");
            lv.Items.Add("Ruut: ");

            this.Controls.Add(lv);

            //Lable & TextBox
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblH = new Label();
            lblA.Size = new Size(100, 50);
            lblB.Size = new Size(100, 50);
            lblC.Size = new Size(100, 50);
            lblH.Size = new Size(100, 50);
            lblA.Text = "Külg A:";
            lblA.Location = new Point(lv.Left, lv.Bottom + 20);
            lblB.Text = "Külg B:";
            lblB.Location = new Point(lv.Left, lblA.Bottom + 2);
            lblC.Text = "Külg C:";
            lblC.Location = new Point(lv.Left, lblB.Bottom + 2);
            this.Controls.Add(lblA);
            this.Controls.Add(lblB);
            this.Controls.Add(lblC);

            //Textbox
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtH = new TextBox();
            txtA.Size = new Size(100, 50);
            txtB.Size = new Size(100, 50);
            txtC.Size = new Size(100, 50);
            txtH.Size = new Size(100, 50);

            txtA.Text = "0";
            txtB.Text = "0";
            txtC.Text = "0";
            txtH.Text = "0";

            txtA.Location = new Point(lblA.Right, lblA.Location.Y);
            txtB.Location = new Point(lblB.Right, lblB.Location.Y);
            txtC.Location = new Point(lblC.Right, lblC.Location.Y);
            txtH.Location = new Point(lblH.Right, lblH.Location.Y);
            this.Controls.Add(txtA);
            this.Controls.Add(txtB);
            this.Controls.Add(txtC);
            this.Controls.Add(txtH);

            //PictureBox
            pb = new PictureBox();
            pb.Location = new Point(lv.Width + 50, lbl.Bottom + 10);
            //pb.Image = new Bitmap("../../../Triangle.jpg");
            pb.Size = new Size(300, 300);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);
            //pb.Visible = false;

            //Button
            btn = new Button();
            btn.Size = new Size(100, 50);
            btn.Location = new Point(lv.Width + 150, pb.Bottom + 25);
            btn.Text = "Ok";
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            btn2 = new Button();
            btn2.Size = new Size(60, 25);
            btn2.Location = new Point(btn.Right + 60, btn.Bottom + 50);
            btn2.Text = "Uus vorm";
            btn2.Click += Btn2_Click;
            this.Controls.Add(btn2);
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            Kolmnurk2 form2 = new Kolmnurk2();
            form2.Show();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            double a, b, c, h;
            Triangle triangle;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
                triangle = new Triangle();
                if (triangle.ExistTriangle(a, b, c) != true) { throw new Exception(); };
                
                if (a == b && b == c && c == a)
                    {
                        pb.Image = new Bitmap("../../../Triangle.jpg");
                    };

                if (a == b || b == c || c == a)
                    {
                        pb.Image = new Bitmap("../../../2sideTriangle.png");
                    };

                if (a != b && b != c && c != a)
                {
                    pb.Image = new Bitmap("../../../NoOneSideTriangle.png");
                };

                lv.Items[0].SubItems.Add(triangle.OutputA(a));
                lv.Items[1].SubItems.Add(triangle.OutputB(b));
                lv.Items[2].SubItems.Add(triangle.OutputC(c));

                lv.Items[3].SubItems.Add(Convert.ToString(triangle.ExistTriangle(a, b, c)));
                lv.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter(a, b, c)));
                lv.Items[5].SubItems.Add(Convert.ToString(triangle.Surface(a, b, c)));
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Kolmnurka ei ole võimalik ehitada", "Viga");
            }
        }
    }
}