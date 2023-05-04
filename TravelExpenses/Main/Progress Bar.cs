using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class ProgressBarEmail : Form
    {
        
        public ProgressBarEmail()
        {
            InitializeComponent();
        }

        
        public string Message
        {
            set { labelMessage.Text = value; }
        }

        public void ProgressValue()
        {
            
        }
    }
}
