using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Client
{
    public partial class frmSplash : DevExpress.XtraEditors.XtraForm
    {
        int move = 2;
        Timer splashTimer;
        bool mainFormShown = false;

        public frmSplash()
        {
            InitializeComponent();
            splashTimer = new Timer();
            splashTimer.Interval = 5000; // Đặt thời gian đếm là 5 giây
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 734)
            {
                panelSlide.Left = 465;
            }
            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Hide();

            if (!mainFormShown)
            {
                // Hiển thị form khác (ví dụ: frmMain)
                frmMain mainForm = new frmMain();
                mainFormShown = true;
                mainForm.ShowDialog();
            }
        }
    }

}