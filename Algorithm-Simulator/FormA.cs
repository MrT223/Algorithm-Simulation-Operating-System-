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


        private Form MainForm;
        public FormBanker(Form callingForm) 
        {
            InitializeComponent();
            MainForm = callingForm;
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNProc.Text, out int nProc) || nProc <= 0)
            {
                MessageBox.Show("Số tiến trình không hợp lệ. Vui lòng nhập số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtNRes.Text, out int nRes) || nRes <= 0)
            {
                MessageBox.Show("Số tài nguyên không hợp lệ. Vui lòng nhập số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nprocesses = nProc;
            nresources = nRes;
            count_alloc = 0;
            count_max = 0;
            lblAlloc.Text = "Allocation matrix (" + (nprocesses - count_max) + ")";
            lblMax.Text = "Max matrix (" + (nprocesses - count_alloc) + ")";
            radiobtnSafe.Enabled = true;
            radiobtnRequest.Enabled = true;
            txtMax.Enabled = true;
            btnMax.Enabled = true;

            txtNProc.Enabled = false;
            txtNRes.Enabled = false;
            btnContinue.Enabled = false;

            Allocation = new int[nprocesses][];
            Max = new int[nprocesses][];
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string s = txtMax.Text.Trim();

            string[] parts = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != nresources)
            {
                MessageBox.Show($"Bạn cần nhập đúng {nresources} giá trị cách nhau bởi dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[] row = Array.ConvertAll(parts, int.Parse);

                if (Array.Exists(row, x => x < 0))
                {
                    MessageBox.Show("Không được nhập số âm trong Max.", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Max[count_max] = row;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập các số nguyên hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Một số bạn nhập quá lớn. Vui lòng nhập số nguyên nhỏ hơn.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            richMax.AppendText($"P{count_max} -> {string.Join(" ", Max[count_max])}\n");

            txtMax.Clear();
            count_max++;
            lblMax.Text = "Max matrix (" + (nprocesses - count_max) + ")";

            if (count_max == nprocesses)
            {
                txtMax.Enabled = false;
                btnMax.Enabled = false;
                txtAlloc.Enabled = true;
                btnAlloc.Enabled = true;
            }
            if (count_alloc == nprocesses && count_max == nprocesses)
            {
                btnCheck.Enabled = true;
            }
        }

        private void btnAlloc_Click(object sender, EventArgs e)
        {
            string s = txtAlloc.Text.Trim();

            string[] parts = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != nresources)
            {
                MessageBox.Show($"Bạn cần nhập đúng {nresources} giá trị cách nhau bởi dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[] row = Array.ConvertAll(parts, int.Parse);

                if (Array.Exists(row, x => x < 0))
                {
                    MessageBox.Show("Không được nhập số âm trong Allocation.", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < nresources; i++)
                {
                    if (row[i] > Max[count_alloc][i])
                    {
                        MessageBox.Show($"Allocation tại tiến trình P{count_alloc} vượt quá Max cho tài nguyên R{i}.\n" +
                            $"Giá trị Allocation: {row[i]}, Max: {Max[count_alloc][i]}",
                            "Lỗi logic Allocation > Max",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Cho nhập lại dòng đó
                    }
                }

                Allocation[count_alloc] = row;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng chỉ nhập các số nguyên hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Một số bạn nhập quá lớn. Vui lòng nhập số nguyên nhỏ hơn.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            richAlloc.AppendText($"P{count_alloc} -> {string.Join(" ", Allocation[count_alloc])}\n");

            txtAlloc.Clear();
            count_alloc++;
            lblAlloc.Text = "Allocation matrix (" + (nprocesses - count_alloc) + ")";

            if (count_alloc == nprocesses)
            {
                txtAlloc.Enabled = false;
                btnAlloc.Enabled = false;
                txtAvail.Enabled = true;
            }

            if (count_alloc == nprocesses && count_max == nprocesses)
            {
                btnCheck.Enabled = true;
            }
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
            string[] availParts = txtAvail.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (availParts.Length != nresources)
            {
                MessageBox.Show($"Available: Bạn cần nhập đúng {nresources} số nguyên cách nhau bằng dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                available = Array.ConvertAll(availParts, int.Parse);
                if (available.Any(x => x < 0))
                {
                    MessageBox.Show("Available: Không được chứa số âm.", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Available: Vui lòng chỉ nhập các số nguyên hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Available: Có số quá lớn. Vui lòng nhập số nhỏ hơn.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            state = new bool[nprocesses];
            processes = new List<process>();
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
            string n = "  \t";
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
                    richWork.AppendText(step + "\n");

                richOutput.AppendText(s + "\n");
            }
            else
            {
                int pp;
                try
                {
                    pp = int.Parse(txtProcReq.Text.Trim());
                    if (pp < 0 || pp >= nprocesses)
                    {
                        MessageBox.Show($"Process: Chỉ được nhập số nguyên từ 0 đến {nprocesses - 1}.", "Lỗi chỉ số quá trình", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Process: Vui lòng chỉ nhập số nguyên hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Process: Số quá lớn. Vui lòng nhập nhỏ hơn.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] reqParts = txtResReq.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (reqParts.Length != nresources)
                {
                    MessageBox.Show($"Request: Cần nhập đúng {nresources} giá trị cách nhau bằng dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    req = Array.ConvertAll(reqParts, int.Parse).ToList();
                    if (req.Any(x => x < 0))
                    {
                        MessageBox.Show("Request: Không được có số âm.", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Request: Vui lòng chỉ nhập các số nguyên hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Request: Có số quá lớn. Vui lòng nhập nhỏ hơn.", "Lỗi tràn số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
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
