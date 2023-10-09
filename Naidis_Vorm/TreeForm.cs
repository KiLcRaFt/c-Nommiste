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
        Button btn;
        Label lbl;
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



            tree.Nodes.Add(treeNode);
            this.Controls.Add(tree);
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