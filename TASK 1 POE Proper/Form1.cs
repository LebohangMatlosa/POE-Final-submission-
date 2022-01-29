using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_1_POE_Proper
{
     

   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<Tile> tile = new List<Tile>();
            weapon LongSword = new weapon();
            weapon Dagger = new weapon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
