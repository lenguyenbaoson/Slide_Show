using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class SlideShow : Form
    {
        public SlideShow()
        {
            InitializeComponent();
        }

        private int picCurent = 0;

        private  void nextSlide()
        {
            

            if (picCurent == 10) picCurent = 1;
            
            picShow.ImageLocation = String.Format(@"Images\{0}.png", (picCurent ) % 10 );

            thumb1.ImageLocation = String.Format(@"Images\{0}.png", (picCurent) % 10 );

            thumb2.ImageLocation = String.Format(@"Images\{0}.png", (picCurent + 1) % 10 );

            thumb3.ImageLocation = String.Format(@"Images\{0}.png", (picCurent + 2) % 10 );

            thumb4.ImageLocation = String.Format(@"Images\{0}.png", (picCurent + 3) % 10);

            thumb5.ImageLocation = String.Format(@"Images\{0}.png", (picCurent + 4) % 10);
            picCurent++;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextSlide();
        }
    }
}
