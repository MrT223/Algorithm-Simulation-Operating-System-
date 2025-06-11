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
            PFSR_Form pFSR_Form = new PFSR_Form();
            pFSR_Form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formD formD = new formD();
            formD.ShowDialog();
            this.Close();
        }

        private void btnCPU_Distribution_Click(object sender, EventArgs e)
        {
            this.Hide();                  // Ẩn MainForm tạm thời
            FormB formB = new FormB(this);
            formB.Show();
        }
    }
}
