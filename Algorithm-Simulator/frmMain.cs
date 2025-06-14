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

        private void PFSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormC pFSR_Form = new FormC();
            pFSR_Form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormD formD = new FormD();
            formD.ShowDialog();
            this.Close();
        }

        private void btnCPU_Distribution_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormB formB = new FormB(this);
            formB.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBanker FormA = new FormBanker();
            FormA.ShowDialog();
            this.Close();
        }
    }
}
