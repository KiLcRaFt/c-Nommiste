using System.Web;

namespace LaborForm
{
    public partial class Form1 : Form
    {
        Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        PictureBox pb;
        Button checkBtn;
        int LastClicked;
        bool ans1, ans2, ans3;
        public Form1()
        {
            this.Height = 450;
            this.Width = 400;
            this.Text = "Matemaatika test";
            this.StartPosition= FormStartPosition.CenterScreen;

            Random rnd = new Random();

            List<string> znaki = new List<string>();
            znaki.Add("+");
            znaki.Add("-");
            znaki.Add("*");
            znaki.Add("/");

            List<string> primers1 = new List<string>();
            List<string> answers1 = new List<string>();

            for (int i = 0; i < 12; i++)
            {
                int znak = rnd.Next(0, znaki.Count);

                int x1 = rnd.Next(1, 40);
                int x2 = rnd.Next(1, 40);
                string answe = Convert.ToString(x1) + znaki[znak] + Convert.ToString(x2);
                primers1.Add(answe);

                if (znaki[znak] == "+")
                {
                    int ans = x1 + x2;
                    answers1.Add(Convert.ToString(ans));
                }
                if (znaki[znak] == "-")
                {
                    int ans = x1 - x2;
                    answers1.Add(Convert.ToString(ans));
                }
                if (znaki[znak] == "*")
                {
                    int ans = x1 * x2;
                    answers1.Add(Convert.ToString(ans));
                }
                if (znaki[znak] == "/")
                {
                    double ans = x1 / x2;
                    answers1.Add(Convert.ToString(ans));
                }
            }

            int ind1 = rnd.Next(0, answers1.Count);
            int ind2 = rnd.Next(0, answers1.Count);
            int ind3 = rnd.Next(0, answers1.Count);
            while (true)
            {
                if (ind2 == ind1 || ind2 == ind3)
                {
                    ind2 = rnd.Next(0, answers1.Count);
                }
                if (ind3 == ind1 || ind3 == ind2)
                {
                    ind3 = rnd.Next(0, answers1.Count);
                }
                else
                {
                    break;
                }
            }

            lbl1 = new Label();
            LabelChoise labl = new LabelChoise();
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Tahoma", 36);
            labl.Labl(lbl1, answers1[ind1], 250, 260);
            labl.DragAnDrop();
            lbl1.MouseUp += Lbl1_MouseUp;
            this.Controls.Add(lbl1);

            lbl2 = new Label();
            LabelChoise labl2 = new LabelChoise();
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Tahoma", 36);
            labl2.Labl(lbl2, answers1[ind2], 250, 60);
            labl2.DragAnDrop();
            lbl2.MouseUp += Lbl2_MouseUp;
            this.Controls.Add(lbl2);

            lbl3 = new Label();
            LabelChoise labl3 = new LabelChoise();
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Tahoma", 36);
            labl3.Labl(lbl3, answers1[ind3], 250, 160);
            labl3.DragAnDrop();
            lbl3.MouseUp += Lbl3_MouseUp;
            this.Controls.Add(lbl3);

            lbl4 = new Label();
            LabelChoise labl4 = new LabelChoise();
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Tahoma", 36);
            labl4.Labl(lbl4, primers1[ind1], 60, 60);
            labl4.DragAnDrop();
            lbl4.MouseUp += Lbl1_MouseUp;
            this.Controls.Add(lbl4);

            lbl5 = new Label();
            LabelChoise labl5 = new LabelChoise();
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Tahoma", 36);
            labl5.Labl(lbl5, primers1[ind2], 60, 160);
            labl5.DragAnDrop();
            lbl5.MouseUp += Lbl2_MouseUp;
            this.Controls.Add(lbl5);

            lbl6 = new Label();
            LabelChoise labl6 = new LabelChoise();
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Tahoma", 36);
            labl6.Labl(lbl6, primers1[ind3], 60, 260);
            labl6.DragAnDrop();
            lbl6.MouseUp += Lbl3_MouseUp;
            this.Controls.Add(lbl6);


            pb = new PictureBox();
            pb.Location = new Point(50, 50);
            pb.Size = new Size(300, 300);
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);

            checkBtn = new Button();
            checkBtn.Location = new Point(275, 360);
            checkBtn.Text = "Kontroll";
            checkBtn.Click += CheckBtn_Click;

            this.Controls.Add(checkBtn);


            startmenu();

        }

        private void CheckBtn_Click(object? sender, EventArgs e)
        {
            if (ans1 && ans2 && ans3)
            {

                lbl1.BackColor = Color.LightGreen;
                lbl2.BackColor = Color.LightGreen;
                lbl3.BackColor = Color.LightGreen;
                lbl4.BackColor = Color.LightGreen;
                lbl5.BackColor = Color.LightGreen;
                lbl6.BackColor = Color.LightGreen;

                string message = "Kõik on täesti õige!";
                string caption = "Matemaatika test";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                string message = "Midagi on valesti.";
                string caption = "Matemaatika test";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ans1= false;
                    ans2= false;
                    ans3= false;
                    lbl1.Location = new Point(250, 260);
                    lbl2.Location = new Point(250, 60);
                    lbl3.Location = new Point(250, 160);
                    lbl4.Location = new Point(60, 60);
                    lbl5.Location = new Point(60, 160);
                    lbl6.Location = new Point(60, 260);
                }
            }

        }

        private void startmenu()
        {
            string message = "Selle testi lahendamiseks peate soovitud vastuse näite juurde lohistama.";
            string caption = "Matemaatika test";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void LastClicked_func()
        {
            if (LastClicked == 1)
            {
                if ((lbl1.Location.X < lbl4.Location.X + lbl4.Width) && (lbl1.Location.X > lbl4.Location.X))
                {
                    if ((lbl1.Location.Y > lbl4.Location.Y) && (lbl1.Location.Y < lbl4.Location.Y + lbl4.Height))
                    {
                        ans1 = true;
                    }
                }
            }
            if (LastClicked== 2)
            {
                if ((lbl2.Location.X < lbl5.Location.X + lbl5.Width) && (lbl2.Location.X > lbl5.Location.X))
                {
                    if ((lbl2.Location.Y > lbl5.Location.Y) && (lbl2.Location.Y < lbl5.Location.Y + lbl5.Height))
                    {
                        ans2 = true;
                    }
                }
            }
            if (LastClicked== 3)
            {
                if ((lbl3.Location.X < lbl6.Location.X + lbl6.Width) && (lbl3.Location.X > lbl6.Location.X))
                {
                    if ((lbl3.Location.Y > lbl6.Location.Y) && (lbl3.Location.Y < lbl6.Location.Y + lbl6.Height))
                    {
                        ans3 = true;
                    }
                }
            }
        }

        private void Lbl3_MouseUp(object? sender, MouseEventArgs e)
        {
            LastClicked = 3;
            LastClicked_func();
        }

        private void Lbl2_MouseUp(object? sender, MouseEventArgs e)
        {
            LastClicked = 2;
            LastClicked_func();
        }

        private void Lbl1_MouseUp(object? sender, MouseEventArgs e)
        {
            LastClicked = 1;
            LastClicked_func();

        }
    }
}