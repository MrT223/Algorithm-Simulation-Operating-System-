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
        public List<int> Max;
        public List<int> Allocation;
        public List<int> Need;
    };


    public partial class FormBanker : Form
    {
        static int nprocesses, nresources;
        int count_alloc = 0, count_max = 0;
        List<int> seq = new List<int>();
        int[] available;
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
            txtProcReq.Clear();
            txtResReq.Clear();
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
            processes = new List<process>();

            available = Array.ConvertAll(txtAvail.Text.Split(' '), int.Parse);

            for (int i = 0; i < nprocesses; i++)
            {
                process p = new process();
                p.id = i;
                p.Allocation = Allocation[i].ToList();
                p.Max = Max[i].ToList();
                p.Need = new List<int>();

                for (int j = 0; j < nresources; j++)
                {
                    p.Need.Add(p.Max[j] - p.Allocation[j]);
                }
                processes.Add(p);
                state[i] = false;
            }

            richNeed.Clear();
            string n = "";
            n += "  \t";
            for (int a = 0; a < nresources; a++)
                n += "R" + a + "\t";
            richNeed.AppendText(n + "\n");

            for (int j = 0; j < nprocesses; j++)
            {
                n = "P" + j + "\t";
                for (int a = 0; a < nresources; a++)
                {
                    n += processes[j].Need[a] + "\t";
                }
                richNeed.AppendText(n + "\n");
            }

            string s = "";
            if (choice == 1)
            {
                List<string> explanation;
                if (IsSafe(processes, available, out explanation))
                {
                    s = "Yes , Safe state <";
                    for (int a = 0; a < nprocesses; a++)
                    {
                        s = s + "P" + seq[a];
                        if (a != nprocesses - 1) s += ",";
                        else s += ">";
                    }
                }
                else
                {
                    s = "No";
                }

                richWork.Clear();
                foreach (string step in explanation)
                    richWork.AppendText(step + "\n");

                richOutput.AppendText(s + "\n");
            }
            else
            {
                int pp = int.Parse(txtProcReq.Text);
                req = Array.ConvertAll(txtResReq.Text.Split(' '), int.Parse).ToList<int>();

                List<string> explanation;
                if (Request(processes, available, pp, req, out explanation))
                {
                    s = "Yes , Safe state <";
                    s += "P" + pp + "req,";
                    for (int a = 0; a < nprocesses; a++)
                    {
                        s += "P" + seq[a];
                        if (a != nprocesses - 1) s += ",";
                        else s += ">";
                    }
                }
                else
                {
                    s = "No";
                }

                richWork.Clear();
                foreach (string step in explanation)
                {
                    richWork.AppendText(step + "\n");
                }
                richOutput.AppendText(s + "\n");
            }
        }

        private bool IsSafe(List<process> processes, int[] available, out List<string> explanation)
        {
            explanation = new List<string>();
            int finished = nprocesses;
            int[] Work = (int[])available.Clone();
            bool[] localState = new bool[nprocesses];
            seq = new List<int>();

            explanation.Add("Initial Work: " + string.Join(" ", Work));

            while (finished != 0)
            {
                int counter = finished;
                foreach (var i in processes)
                {
                    if (!localState[i.id])
                    {
                        bool canExecute = true;
                        for (int j = 0; j < nresources; j++)
                        {
                            if (i.Need[j] > Work[j])
                            {
                                canExecute = false;
                                break;
                            }
                        }

                        if (canExecute)
                        {
                            explanation.Add($"P{i.id} can be executed. Work before: {string.Join(" ", Work)}");

                            for (int k = 0; k < nresources; k++)
                                Work[k] += i.Allocation[k];

                            explanation.Add($"P{i.id} finishes. Updated Work: {string.Join(" ", Work)}");

                            finished--;
                            localState[i.id] = true;
                            seq.Add(i.id);
                        }
                    }
                }

                if (counter == finished)
                {
                    explanation.Add("No process can proceed. System is NOT in a safe state.");
                    return false;
                }
            }

            explanation.Add("All processes can finish. System is in a SAFE state.");
            return true;
        }


        private void btnMax_Click(object sender, EventArgs e)
        {
            string s = txtMax.Text;

            Max[count_max] = Array.ConvertAll(txtMax.Text.Split(' '), int.Parse);
            richMax.AppendText("P" + count_max + " -> " + s + "\n");
            txtMax.Clear();
            count_max++;
            lblMax.Text = "Max matrix (" + (nprocesses - count_max) + ")";
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
            lblAlloc.Text = "Allocation matrix (" + (nprocesses - count_max) + ")";
            lblMax.Text = "Max matrix (" + (nprocesses - count_alloc) + ")";
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
        }


        private void btnAlloc_Click(object sender, EventArgs e)
        {
            string s = txtAlloc.Text;

            Allocation[count_alloc] = Array.ConvertAll(txtAlloc.Text.Split(' '), int.Parse);
            richAlloc.AppendText("P" + count_alloc + " -> " + s + "\n");
            txtAlloc.Clear();
            count_alloc++;
            lblAlloc.Text = "Allocation matrix (" + (nprocesses - count_alloc) + ")";
            if (count_alloc == nprocesses)
            {
                txtAlloc.Enabled = false;
                btnAlloc.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            processes.Clear();
            seq.Clear();
            req.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
            btnCheck.Enabled = false;
            btnContinue.Enabled = false;
            radiobtnSafe.Checked = true;
        }

        private void FormBanker_Load(object sender, EventArgs e)
        {
            btnContinue.Enabled = false;
            btnCheck.Enabled = false;
            radiobtnSafe.Checked = true;
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

        private bool Request(List<process> processes, int[] available, int p, List<int> req, out List<string> explanation)
        {
            explanation = new List<string>();

            for (int j = 0; j < nresources; j++)
            {
                if (req[j] > available[j])
                {
                    explanation.Add($"Request denied: req[{j}] = {req[j]} > available[{j}] = {available[j]}");
                    return false;
                }
                if (req[j] > processes[p].Need[j])
                {
                    explanation.Add($"Request denied: req[{j}] = {req[j]} > need[{j}] = {processes[p].Need[j]}");
                    return false;
                }
            }

            explanation.Add($"Request from P{p} is valid. Proceeding to check safety.");

            int[] tempAvailable = (int[])available.Clone();
            List<process> tempProcesses = new List<process>();

            foreach (var proc in processes)
            {
                var clone = new process
                {
                    id = proc.id,
                    Allocation = new List<int>(proc.Allocation),
                    Max = new List<int>(proc.Max),
                    Need = new List<int>(proc.Need)
                };

                if (proc.id == p)
                {
                    for (int j = 0; j < nresources; j++)
                    {
                        clone.Allocation[j] += req[j];
                        clone.Need[j] -= req[j];
                        tempAvailable[j] -= req[j];
                    }
                }

                tempProcesses.Add(clone);
            }

            List<string> safeExplanation;
            bool safe = IsSafe(tempProcesses, tempAvailable, out safeExplanation);

            explanation.AddRange(safeExplanation);

            return safe;
        }
    }
}
