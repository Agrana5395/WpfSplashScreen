using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfSplashScreen
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }
          Timer time;
        private void FormPlayer_Load(object sender, EventArgs e)
        {
           
        
        
            
            time = new Timer();
            time.Interval = 30000;
            time.Start();
            time.Tick += new EventHandler(time_Tick);
        }
         void time_Tick(object sender, EventArgs e)
         {
             time.Stop();
             xSplashForm1 f = new xSplashForm1();
             f.Show();
             this.Hide();
         }

         private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
         {
             axWindowsMediaPlayer1.Ctlcontrols.play();
         }

        
       }
     }
    

