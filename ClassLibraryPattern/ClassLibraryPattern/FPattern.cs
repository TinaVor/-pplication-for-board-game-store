using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryPattern
{
    public partial class FPattern : Form
    {
        int wight = 1000;
        int height = 720;


        public FPattern()
        {
            InitializeComponent();
        }

        private void FPattern_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(204, 204, 204);
        }

        private void FPattern_Resize(object sender, EventArgs e)
        {
            if (this.Width < 200 || this.Height < 200)
            {
               Size size = new Size(wight, height);
               this.Size = size;
            }
            
        }
    }
}
