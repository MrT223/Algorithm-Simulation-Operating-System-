using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Simulator
{

    struct process
    {
        public int id;
        public List<int> Max;            // 2D array Max[i,1] = k, means pi need max k instances of resource 1
        public List<int> Allocation; // 2D array Allocation[i,1] = k, means pi has k instances of resource 1
        public List<int> Need;           // 2D array Need[i,1] = k, means pi need k instances of resource 1 to start exec
    };


    public partial class FormBanker : Form
    {
        static int nprocesses, nresources;
        int count_alloc = 0, count_max = 0;
        List<int> seq = new List<int>();
        int[] available;              // num of instances for each resource
        List<process> processes = new List<process>();
        List<int> req = new List<int>();
        int choice = 1;
        int[][] Allocation;
        int[][] Max;
        public bool[] state;


        public FormBanker()
        {
            InitializeComponent();
        }


        private void radiobtnSafe_CheckedChanged(object sender, EventArgs e)
        {
            choice = 1;
            lblProcReq.Visible = false;
            lblResReq.Visible = false;
            txtProcReq.Visible = false;
            txtResReq.Visible = false;
        }

        private void radiobtnRequest_CheckedChanged(object sender, EventArgs e)
        {
            choice = 2;
            lblProcReq.Visible = true;
            lblResReq.Visible = true;
            txtProcReq.Visible = true;
            txtResReq.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            state = new bool[nprocesses];
            for (int i = 0; i < nprocesses; i++)
            {
                process p = new process();

                p.id = i;
                p.Allocation = Allocation[i].ToList<int>();
                p.Max = Max[i].ToList<int>();
                p.Need = new List<int>();
                for (int j = 0; j < nresources; j++)
                {
                    p.Need.Add(p.Max[j] - p.Allocation[j]);
                }
                processes.Add(p);
                state[i] = false;

                available = Array.ConvertAll(txtAvail.Text.Split(' '), int.Parse);

                // print Need matrix
                richNeed.Clear();
                string n = "";
                for (int j = -1; j < nprocesses; j++)
                {
                    n = "";
                    if (j == -1)
                    {
                        n += "  \t";
                        for (int a = 0; a < nresources; a++)
                        {
                            n += "R" + a + "\t";
                        }
                        richNeed.AppendText(n + "\n");
                        continue;
                    }
                    n += "P" + j + "\t";
                    for (int a = 0; a < nresources; a++)
                        n += processes[j].Need[a] + "\t";
                    richNeed.AppendText(n + "\n");

                }
                string s = "";
                if (choice == 1)
                {
                    if (IsSafe(processes, available))
                    {
                        s = "Yes , Safe state <";
                        for (int a = 0; a < nprocesses; a++)
                        {

                            s = s + "P" + seq[a];
                            if (a != nprocesses - 1) s += ",";
                            else s += ">";
                        }
                        richOutput.AppendText(s + "\n");
                    }
                    else richOutput.AppendText("No\n");
                }
                else
                {
                    int pp = 0;
                    s = "";
                    pp = int.Parse(txtProcReq.Text);
                    req = Array.ConvertAll(txtResReq.Text.Split(' '), int.Parse).ToList<int>();

                    if (Request(processes, available, pp, req))
                    {
                        s += "Yes , Safe state <";
                        s += "P" + pp + "req,";
                        for (int a = 0; a < nprocesses; a++)
                        {
                            s += "P" + seq[a];
                            /*
                            if(seq[i]==p) cout<<"P"<<seq[i]<<"req";
                            else  cout<<"P"<<seq[i];
                            */
                            if (a != nprocesses - 1) s += ",";
                            else s += ">";
                        }
                    }
                    else
                    {
                        s += "No";
                    }
                    richOutput.AppendText(s + "\n");
                }
            }
        }

        private bool IsSafe(List<process> processes, int[] available)
        {

            int finished = nprocesses;
            int j = 0;
            while (finished != 0)
            {
                int counter = finished;
                foreach (var i in processes)
                {
                    if (state[i.id] == false)
                    {
                        for (j = 0; j < nresources; j++)
                            if (i.Need[j] > available[j]) break;
                        if (j == nresources)
                        {
                            finished--;
                            //processes[i.id].status = true;
                            state[i.id] = true;

                            for (int k = 0; k < nresources; k++)
                                available[k] += i.Allocation[k];
                            seq.Add(i.id);

                        }
                    }
                }
                if (counter == finished)
                {
                    return false;
                }

            }
            return true;

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string s = txtMax.Text;

            Max[count_max] = Array.ConvertAll(txtMax.Text.Split(' '), int.Parse);
            richMax.AppendText("P" + count_max + " -> " + s + "\n");
            txtMax.Clear();
            count_max++;
            lblMax.Text = "Ma trận cần thiết (" + (nprocesses - count_max) + ")";
            if (count_max == nprocesses)
            {
                txtMax.Enabled = false;
                btnMax.Enabled = false;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            nprocesses = int.Parse(txtNProc.Text);
            nresources = int.Parse(txtNRes.Text);
            count_alloc = 0;
            count_max = 0;
            lblAlloc.Text = "Ma trận cung cấp (" + (nprocesses - count_max) + ")";
            lblMax.Text = "Ma trận cần thiết (" + (nprocesses - count_alloc) + ")";
            txtAlloc.Enabled = true;
            btnAlloc.Enabled = true;
            txtAvail.Enabled = true;
            radiobtnSafe.Enabled = true;
            radiobtnRequest.Enabled = true;
            txtMax.Enabled = true;
            btnMax.Enabled = true;

            txtNProc.Enabled = false;
            txtNRes.Enabled = false;
            btnContinue.Enabled = false;


            Allocation = new int[nprocesses][];
            Max = new int[nprocesses][];
            btnCheck.Enabled = true;
            /*
            for (int i = 0; i < nprocesses; i++)
            {
                Allocation[i] = new int[nresources];
            }
            */
        }


        private void btnAlloc_Click(object sender, EventArgs e)
        {
            string s = txtAlloc.Text;

            Allocation[count_alloc] = Array.ConvertAll(txtAlloc.Text.Split(' '), int.Parse);
            richAlloc.AppendText("P" + count_alloc + " -> " + s + "\n");
            txtAlloc.Clear();
            count_alloc++;
            lblAlloc.Text = "Ma trận cung cấp (" + (nprocesses - count_alloc) + ")";
            if (count_alloc == nprocesses)
            {
                txtAlloc.Enabled = false;
                btnAlloc.Enabled = false;
            }





            //rich_allocation.AppendText(allocation.ToString()+"\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAlloc.Text = "";
            txtAvail.Text = "";
            txtMax.Text = "";
            txtNProc.Text = "";
            txtNRes.Text = "";
            txtProcReq.Text = "";
            txtResReq.Text = "";
            richAlloc.Text = "";
            richMax.Text = "";
            richNeed.Text = "";
            richOutput.Text = "";

            lblMax.Text = "Ma trận cần thiết";
            lblAlloc.Text = "Ma trận cung cấp";
            txtAlloc.Enabled = false;
            btnAlloc.Enabled = false;
            txtMax.Enabled = false;
            btnMax.Enabled = false;
            txtAvail.Enabled = false;

            txtNProc.Enabled = true;
            txtNRes.Enabled = true;
            btnContinue.Enabled = true;

            radiobtnSafe.Checked = true;
            radiobtnRequest.Checked = false;
            radiobtnSafe.Enabled = false;
            radiobtnRequest.Enabled = false;

            // clear the data 
            processes.Clear();
            seq.Clear();
            req.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
            btnCheck.Enabled = false;
            btnContinue.Enabled = false;
        }

        private void FormBanker_Load(object sender, EventArgs e)
        {
            btnContinue.Enabled = false;
            btnCheck.Enabled = false;
        }

        private void txtNProc_TextChanged(object sender, EventArgs e)
        {
            if (txtNProc.Text != "" && txtNRes.Text != "")
            {
                btnContinue.Enabled = true;
            }
            else
            {
                btnContinue.Enabled = false;
            }
        }

        private void txtNRes_TextChanged(object sender, EventArgs e)
        {
            if (txtNProc.Text != "" && txtNRes.Text != "")
            {
                btnContinue.Enabled = true;
            }
            else
            {
                btnContinue.Enabled = false;
            }
        }

        private bool Request(List<process> processes, int[] available, int p, List<int> req)
        {
            int j;
            for (j = 0; j < nresources; j++)
                if (req[j] > available[j] || req[j] > processes[p].Need[j]) break;
            if (j != nresources) return false;
            for (int i = 0; i < nprocesses; i++)
            {
                process pp = processes[0];
                processes.RemoveAt(0);
                if (pp.id == p)
                {
                    for (j = 0; j < nresources; j++)
                    {
                        pp.Allocation[j] += req[j];
                        pp.Need[j] -= req[j];
                        available[j] -= req[j];
                    }
                }
                processes.Add(pp);
            }

            /*
            int finished = nprocesses;
            while (finished != 0)
            {
                int counter = finished;
                foreach (var i in processes)
                {
                    if (state[i.id] == false)
                    {
                        for (j = 0; j < nresources; j++)
                            if (i.Need[j] > available[j]) break;
                        if (j == nresources)
                        {
                            finished--;
                            //processes[i.id].status = true;
                            state[i.id] = true;

                            for (int k = 0; k < nresources; k++)
                                available[k] += i.Allocation[k];
                            seq.Add(i.id);

                        }
                    }
                }
                if (counter == finished)
                {
                    return false;
                }

            }
            return true;
            */
            return IsSafe(processes, available);
        }



    }
}
