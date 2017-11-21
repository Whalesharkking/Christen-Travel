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
    /// <summary>
    /// Class to Show the Help Formular
    /// </summary>
    public partial class HelpForm : Form {
        private MainForm mainForm;
    
        /// <summary>
        /// Initaliseren of HelpForm Cunstructor
        /// </summary>
        /// <param name="mainForm"></param>
        public HelpForm(MainForm mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        /// <summary>
        /// When close button clicked close HelpForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Klicked(object sender, EventArgs e) {
            enableMainForm();
            this.Close();
        }

        /// <summary>
        /// Enable Main Form after Closing HelpForm
        /// </summary>
        private void enableMainForm() {
            mainForm.Enabled = true;
        }

        /// <summary>
        /// Close Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e) {
            enableMainForm();
        }
    }
}
