using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Simulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnA.TabStop = false;
            btnB.TabStop = false;
            btnD.TabStop = false;
            bntC.TabStop = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormD formD = new FormD(this);
            formD.ShowDialog();
        }

        private void bntC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormC pFSR_Form = new FormC(this);
            pFSR_Form.ShowDialog();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormB formB = new FormB(this);
            formB.ShowDialog();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBanker FormA = new FormBanker(this);
            FormA.ShowDialog();
        }
    }
}
