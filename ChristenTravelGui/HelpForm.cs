using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristenTravelGui {
    public partial class HelpForm : Form {
        private MainForm mainForm;

    

        public HelpForm(MainForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonKnow_Click(object sender, EventArgs e) {
            mainForm.Enabled = true;
            this.Close();
            
            
        }


    
    }
}
