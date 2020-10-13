using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSCTSV
{
    public partial class ViewImage : Form
    {
        public ViewImage()
        {
            InitializeComponent();
        }
        public void setupImage(Image imageStudent)
        {
            ptImage.Image = imageStudent;
        }

        private void ptImage_Click(object sender, EventArgs e)
        {

        }
    }
}
