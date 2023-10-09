using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Naidis_Vorm
{
    public partial class TreeForm : Form
    {
        TreeView tree;
        Button btn, btn2, btn3;
        Label lbl;
        TextBox txt_box;
        RadioButton r1, r2;
        CheckBox c1, c2;
        PictureBox pb;
        ListBox lb;
        public TreeForm()
        {
            this.Height = 600;
            this.Width = 800;
            this.Text = "Vorm põhielementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.BorderStyle = BorderStyle.Fixed3D;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode treeNode = new TreeNode("Elemendid");
            //Button
            treeNode.Nodes.Add(new TreeNode("Nupp-Button"));
            btn = new Button();
            btn.Height = 40;
            btn.Width = 100;
            btn.Text = "Valjuta mind!";
            btn.Location = new Point(150, 50);
            this.Controls.Add(btn);
            btn.Visible = false;
            btn.Click += Btn_Click;
            btn.MouseMove += Btn_MouseMove;
            btn.MouseLeave += Btn_MouseLeave;
            //Label
            treeNode.Nodes.Add(new TreeNode("Silt-Label"));
            lbl = new Label { };
            this.Controls.Add(lbl);
            lbl.Visible = false;
            lbl.Text = "PapaBemaGenaBori --> BeatBox";
            lbl.Location = new Point(tree.Right, 0);
            lbl.Size = new Size(Width + tree.Width, btn.Top - 5);
            lbl.BackColor = Color.LightCyan;
            lbl.Font = new Font("Tahoma", 24);


            //Textbox
            treeNode.Nodes.Add(new TreeNode("Tekstkast-Textbox"));
            txt_box = new TextBox();
            txt_box.BorderStyle = BorderStyle.Fixed3D;
            txt_box.Height = 50;
            txt_box.Width = 100;
            txt_box.Text = ".....";
            txt_box.Location = new Point(tree.Width, btn.Top + btn.Height + 5);
            txt_box.KeyDown += new KeyEventHandler(Txt_box_KeyDown);
            this.Controls.Add(txt_box);


            //RadioButton
            treeNode.Nodes.Add(new TreeNode("Radionupp-RadioButton"));
            r1 = new RadioButton();
            r1.Text = "valik 1";
            r1.Location = new Point(tree.Width + txt_box.Location.Y + txt_box.Height);
            r2 = new RadioButton();
            r2.Text = "valik 2";
            r2.Location = new Point(r1.Location.X + r1.Width, txt_box.Location.Y + txt_box.Height);
            r1.CheckedChanged += new EventHandler(RadioButtons_Changed);
            r2.CheckedChanged += new EventHandler(RadioButtons_Changed);
            txt_box.Visible = false;
            r1.Visible = false;
            r2.Visible = false;
            this.Controls.Add(r1);
            this.Controls.Add(r2);

            //CheckBox
            treeNode.Nodes.Add(new TreeNode("Checknupp-CheckBox"));
            c1 = new CheckBox();
            c1.Text = "valik 1";
            c1.Location = new Point(tree.Width + r2.Location.Y + r2.Height);
            c2 = new CheckBox();
            c2.Text = "valik 2";
            c2.Location = new Point(tree.Width, c1.Location.Y + c1.Height);
            c1.CheckedChanged += new EventHandler(CheckButtons_Changed);
            c2.CheckedChanged += new EventHandler(CheckButtons_Changed);
            c1.Visible = false;
            c2.Visible = false;
            this.Controls.Add(c1);
            this.Controls.Add(c2);

            //Image
            treeNode.Nodes.Add(new TreeNode("Image"));
            pb = new PictureBox();
            pb.Location = new Point(tree.Width, c2.Location.Y + c2.Height);
            pb.Image = new Bitmap("../../../Cute.jpg");
            pb.Size = new Size(300, 300);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(pb);
            pb.Visible = false;

            //Loetelu - ListBox
            treeNode.Nodes.Add(new TreeNode("ListBox"));
            lb = new ListBox();
            lb.Items.Add("Roheline");
            lb.Items.Add("Sinine");
            lb.Items.Add("Hall");
            lb.Items.Add("Kollane");
            lb.Location = new Point(tree.Width, pb.Location.Y + pb.Height);
            lb.Visible = false;
            btn2 = new Button();
            btn2.Height = 50;
            btn2.Width = 100;
            btn2.Text = "Lisa";
            btn2.Click += Btn2_Click;
            btn2.Location = new Point(lb.Left, lb.Bottom);
            btn3 = new Button();
            btn3.Height = 50;
            btn3.Width = 100;
            btn3.Text = "Kustuta";
            btn3.Location = new Point(lb.Left, btn2.Bottom);
            btn3.Click += Btn3_Click;

            this.ControlsAdd(
            new Control[] {tree};
            new Control[] {btn, lbl, txt_box, r1, r2, c1, c2, pb, lb, btn2, btn3 });

            //data
            treeNode.Nodes.Add(new TreeNode("DataGridView"));
            DataSet ds = new DataSet("XML fail. Menüü");
            ds.ReadXml(@"..\..\..\CustomersOrders.xml");
            DataGridView dataGrid = new DataGridView();
            dataGrid.Location = new Point(tree.Width+pb.Width, pb.Location.Y);
            dataGrid.Height = 200;
            dataGrid.Width = 300;
            dataGrid.DataSource = ds;
            dataGrid.AutoGenetareColumns=true;
            ds.Visible = false;
            
            dataGrid.DataMember = "Orders";
            this.Controls.Add(dataGrid);
            
            
            

            
            



            tree.Nodes.Add(treeNode);
            this.Controls.Add(tree);
        }

        private void Txt_box_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("Kas sa oled kindel?", "Küsimus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txt_box.Enabled = false;
                    this.Text=txt_box.Text;
                }
                else
                {
                    string tekst = Interaction.InputBox("Sisesta pealkiri", "Pealkiri muutmine", "Uus pealkiri");
                    if (tekst.Length > 0)
                    {
                        this.Text = tekst;
                    }
                }
            }
        }

        private void CheckButtons_Changed(object? sender, EventArgs e)
        {
            if (c1.Checked = true && c2.Checked == true)
            {
                c1.ForeColor = Color.Purple;
                c2.ForeColor = Color.Purple;
            }
            else if (c1.Checked == true && c2.Checked == false)
            {
                c1.ForeColor = Color.Red;
            }
            else if (c1.Checked == false && c2.Checked == true)
            {
                c1.ForeColor = Color.Blue;
            }
            else if (c1.Checked = false && c2.Checked == false)
            {
                c1.ForeColor = Color.White;
                c2.ForeColor = Color.White;
            }
        }

        private void RadioButtons_Changed(object? sender, EventArgs e)
        {
            if (r1.Checked)
            {
                r1.ForeColor = Color.Green;
            }
            else if (r2.Checked)
            {
                r2.ForeColor = Color.Red;
            }
            else
            {
                r1.ForeColor = Color.White;
                r2.ForeColor = Color.White;
            }
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            if (lb.SelectedItem!=null)
            {
                lb.Items.Remove(lb.SelectedItem)
            }
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            string tekst = Interaction.InputBox("Lisa uus väli", "Pealkiri muutmine", "Väli");
            if (tekst.Lenght>0 && !lb.Items.Contains(tekst))
            {
                lb.Items.Add(tekst);
            }
        }

        private void Btn_MouseLeave(object? sender, EventArgs e)
        {
            btn.Height = 50;
            btn.Width = 150;
        }

        private void Btn_MouseMove(object? sender, MouseEventArgs e)
        {
            btn.Height = 75;
            btn.Width = 200;
        }

        private void Tree_AfterSelect(object? sender, TreeViewEventArgs e)
        {

            if (e.Node.Text == "Nupp-Button" && btn.Visible == false)
            {
                this.btn.Visible = true;
            }
            else if (e.Node.Text == "Nupp-Button" && btn.Visible == true)
            {
                this.btn.Visible = false;
            }
            if (e.Node.Text == "Silt-Label" && lbl.Visible == false)
            {
                this.lbl.Visible = true;
            }
            else if (e.Node.Text == "Silt-Label" && lbl.Visible == true)
            {
                this.lbl.Visible = false;
            }

            if (e.Node.Text == "Tekstkast-Textbox" && txt_box.Visible == true)
            {
                txt_box.Visible = false;
            }
            else if (e.Node.Text == "Tekstkast-Textbox" && txt_box.Visible == false)
            {
                txt_box.Visible = true;
            }
            if (e.Node.Text == "Radionupp-RadioButton" && r1.Visible == true)
            {
                r1.Visible = false;
                r2.Visible = false;
            }
            else if (e.Node.Text == "Radionupp-RadioButton" && r2.Visible == false)
            {
                r1.Visible = true;
                r2.Visible = true;
            }
            if (e.Node.Text == "Checknupp-CheckBox" && c1.Visible == true)
            {
                c1.Visible = false;
                c2.Visible = false;
            }
            else if (e.Node.Text == "Checknupp-CheckBox" && c2.Visible == false)
            {
                c1.Visible = true;
                c2.Visible = true;
            }
            if (e.Node.Text == "Image" && pb.Visible == true)
            {
                pb.Visible = false;
            }
            else if (e.Node.Text == "Image" && pb.Visible == false)
            {
                pb.Visible = true;
            }
            if (e.Node.Text == "ListBox" && lb.Visible == true)
            {
                lb.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
            }
            else if (e.Node.Text == "ListBox" && lb.Visible == false)
            {
                lb.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
            }
            if (e.Node.Text == "DataGridView" && ds.Visible == true)
            {
                ds.Visible = false;
            }
            else if (e.Node.Text == "DataGridView" && ds.Visible == false)
            {
                ds.Visible = true;
            }
            tree.SelectedNode = null;

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (btn.BackColor == Color.Black)
            {
                btn.BackColor = Color.Yellow;
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.Yellow;
            }
        }
    }
}