using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_Form
{
    public partial class NewForm : Form
    {
        Button btn;
        public NewForm()
        {
            //InitializeComponent();
            this.Height = 400;
            this.Width = 400;
            this.Text = "Kolmnurk";
        }

        public NewForm(int x, int y, string nimetus)
        {
            //InitializeComponent();
            this.Height = y;
            this.Width = x;
            this.Text = nimetus;
        }

    }
}
