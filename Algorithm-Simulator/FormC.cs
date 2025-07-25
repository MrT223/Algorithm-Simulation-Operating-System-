﻿using System;
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
    public partial class FormC : Form
    {
        int n = 0;
        int h = 0;
        private string selectedAlgorithm = null;
        private int currentStep = 0;
        private List<int> pages = new List<int>();
        private int[] frame;
        private bool stepByStep = false;

        private Form MainForm;
        public FormC(Form callingForm)
        {
            InitializeComponent();
            MainForm = callingForm;
            DisableAlgorithmButtons();
            DisableStartRestartButtons();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStep.Text, out n) || !int.TryParse(txtPage.Text, out h))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho bước và số khung!", "Lỗi nhập liệu");
                return;
            }
            if (n <= 0 || h <= 0)
            {
                MessageBox.Show("Giá trị phải lớn hơn 0!", "Lỗi nhập liệu");
                return;
            }
            if (n > 20 || h > 10)
            {
                MessageBox.Show("Giá trị quá lớn! Tối đa: 20 bước, 10 khung.", "Cảnh báo");
                return;
            }
            CreateGrid(n, h);
            EnableAlgorithmButtons();
            DisableStartRestartButtons();
        }

        private void CreateGrid(int columns, int rows)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns.Add($"col{i}", (i + 1).ToString());
            }

            dataGridView.Rows.Add();
            dataGridView.Rows[0].DefaultCellStyle.BackColor = Color.LightYellow;
            dataGridView.Rows[0].ReadOnly = false;
            for (int i = 0; i < rows; i++)
            {
                int idx = dataGridView.Rows.Add();
                dataGridView.Rows[idx].ReadOnly = true;
            }
            int changeRow = dataGridView.Rows.Add();
            dataGridView.Rows[changeRow].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView.Rows[changeRow].ReadOnly = true;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = 30;
            }
            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn reset hoàn toàn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();

                n = 0;
                h = 0;
                currentStep = 0;
                selectedAlgorithm = null;
                pages.Clear();
                frame = null;
                pointer = 0;
                fifoQueue.Clear();
                lruQueue.Clear();
                useBit = null;

                btnStart.Text = "Start";
                DisableAlgorithmButtons();
                DisableStartRestartButtons();
                ResetAlgorithmButtonColors();

                txtStep.Text = "";
                txtPage.Text = "";

                dataGridView.ClearSelection();
                dataGridView.CurrentCell = null;

            }
        }

        // Chọn thuật toán
        private void btnOPT_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = "OPT";
            ResetAlgorithmButtonColors();
            btnOPT.BackColor = Color.LightGreen;
            DisableAlgorithmButtons();
            EnableStartRestartButtons();
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = "FIFO";
            ResetAlgorithmButtonColors();
            btnFIFO.BackColor = Color.LightGreen;
            DisableAlgorithmButtons();
            EnableStartRestartButtons();
        }

        private void btnLRU_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = "LRU";
            ResetAlgorithmButtonColors();
            btnLRU.BackColor = Color.LightGreen;
            DisableAlgorithmButtons();
            EnableStartRestartButtons();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = "Clock";
            ResetAlgorithmButtonColors();
            btnClock.BackColor = Color.LightGreen;
            DisableAlgorithmButtons();
            EnableStartRestartButtons();
        }



        private void DisableAlgorithmButtons()
        {
            btnFIFO.Enabled = false;
            btnLRU.Enabled = false;
            btnOPT.Enabled = false;
            btnClock.Enabled = false;
        }

        private void EnableAlgorithmButtons()
        {
            btnFIFO.Enabled = true;
            btnLRU.Enabled = true;
            btnOPT.Enabled = true;
            btnClock.Enabled = true;
        }

        private void DisableStartRestartButtons()
        {
            btnStart.Enabled = false;
            btnRestart.Enabled = false;
        }

        private void EnableStartRestartButtons()
        {
            btnStart.Enabled = true;
            btnRestart.Enabled = true;
        }

        private void ResetAlgorithmButtonColors()
        {
            btnFIFO.BackColor = SystemColors.Control;
            btnLRU.BackColor = SystemColors.Control;
            btnOPT.BackColor = SystemColors.Control;
            btnClock.BackColor = SystemColors.Control;
        }

        private List<int> ReadInput()
        {
            List<int> inputPages = new List<int>();

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                var cellValue = dataGridView.Rows[0].Cells[i].Value;
                if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    MessageBox.Show("Không được để trống dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                if (!int.TryParse(cellValue.ToString(), out int page) || page < 0 || page > 100)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                inputPages.Add(page);
            }
            return inputPages;
        }



        private void ClearResultRows()
        {
            for (int row = 1; row < dataGridView.RowCount; row++)
            {
                for (int col = 0; col < dataGridView.ColumnCount; col++)
                {
                    dataGridView.Rows[row].Cells[col].Value = null;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var input = ReadInput();
            if (input == null)
            {
                return;
            }

            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;

            if (selectedAlgorithm == null)
            {
                MessageBox.Show("Vui lòng chọn thuật toán.");
                return;
            }

            stepByStep = chkStepByStep.Checked;

            if (currentStep == 0)
            {
                pages = ReadInput();
                h = int.Parse(txtPage.Text);
                frame = new int[h];
                for (int i = 0; i < h; i++) frame[i] = -1;
                pointer = 0;
                useBit = new bool[h];
                fifoQueue.Clear(); // xóa dữ liệu cũ
                ClearResultRows();
            }

            switch (selectedAlgorithm)
            {
                case "FIFO":
                    SimulateFIFO_Step();
                    break;
                case "LRU":
                    SimulateLRU_Step();
                    break;
                case "OPT":
                    SimulateOPT_Step();
                    break;
                case "Clock":
                    SimulateClock_Step();
                    break;
            }

            if (stepByStep)
            {
                currentStep++;
                if (currentStep < pages.Count)
                {
                    btnStart.Text = "Continue";
                }
                else
                {
                    btnStart.Text = "Start";
                    currentStep = 0;
                }
            }
            else
            {
                // Nếu không step by step chạy cho đến hết
                currentStep++;
                while (currentStep < pages.Count)
                {
                    btnStart_Click(sender, e);
                    return;
                }
                btnStart.Text = "Start";
                currentStep = 0;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            selectedAlgorithm = null;
            currentStep = 0;
            btnStart.Text = "Start";
            EnableAlgorithmButtons();
            DisableStartRestartButtons();
            ClearResultRows();
            ResetAlgorithmButtonColors();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
        }


        /*------------------ Thuật toán -------------------*/

        Queue<int> fifoQueue = new Queue<int>();
        private void SimulateFIFO_Step()
        {
            if (currentStep >= pages.Count) return;

            int page = pages[currentStep];
            bool hit = false;

            for (int j = 0; j < h; j++)
            {
                if (frame[j] == page)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                if (fifoQueue.Count < h)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (frame[j] == -1)
                        {
                            frame[j] = page;
                            fifoQueue.Enqueue(j);
                            break;
                        }
                    }
                }
                else
                {
                    int idx = fifoQueue.Dequeue();
                    frame[idx] = page;
                    fifoQueue.Enqueue(idx);
                }

                dataGridView.Rows[h + 1].Cells[currentStep].Value = "X";
            }

            for (int j = 0; j < h; j++)
            {
                if (frame[j] != -1)
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = frame[j];
            }
        }



        private void SimulateOPT_Step()
        {
            if (currentStep >= pages.Count) return;

            int page = pages[currentStep];
            bool hit = false;

            for (int j = 0; j < h; j++)
            {
                if (frame[j] == page)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                if (fifoQueue.Count < h)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (frame[j] == -1)
                        {
                            frame[j] = page;
                            fifoQueue.Enqueue(j);
                            break;
                        }
                    }
                }
                else
                {
                    int idxToReplace = -1;
                    int farthest = currentStep;

                    for (int j = 0; j < h; j++)
                    {
                        if (frame[j] == -1) continue;

                        int nextUse = -1;
                        for (int k = currentStep + 1; k < pages.Count; k++)
                        {
                            if (pages[k] == frame[j])
                            {
                                nextUse = k;
                                break;
                            }
                        }

                        if (nextUse == -1)
                        {
                            idxToReplace = j;
                            break;
                        }
                        else if (nextUse > farthest)
                        {
                            farthest = nextUse;
                            idxToReplace = j;
                        }
                    }

                    if (idxToReplace == -1)
                        idxToReplace = fifoQueue.Dequeue();
                    else
                    {
                        var tempList = fifoQueue.ToList();
                        tempList.Remove(idxToReplace);
                        fifoQueue = new Queue<int>(tempList);
                    }

                    frame[idxToReplace] = page;
                    fifoQueue.Enqueue(idxToReplace);
                }

                dataGridView.Rows[h + 1].Cells[currentStep].Value = "X";
            }

            for (int j = 0; j < h; j++)
            {
                if (frame[j] != -1)
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = frame[j];
                else
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = "";
            }
        }



        private Queue<int> lruQueue = new Queue<int>();
        private void SimulateLRU_Step()
        {
            if (currentStep >= pages.Count) return;

            int page = pages[currentStep];
            bool hit = false;

            for (int j = 0; j < h; j++)
            {
                if (frame[j] == page)
                {
                    hit = true;
                    var tempList = lruQueue.ToList();
                    tempList.Remove(j);
                    tempList.Add(j);
                    lruQueue = new Queue<int>(tempList);
                    break;
                }
            }

            if (!hit)
            {
                if (lruQueue.Count < h)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (frame[j] == -1)
                        {
                            frame[j] = page;
                            lruQueue.Enqueue(j);
                            break;
                        }
                    }
                }
                else
                {
                    int idx = lruQueue.Dequeue();
                    frame[idx] = page;
                    lruQueue.Enqueue(idx);
                }

                dataGridView.Rows[h + 1].Cells[currentStep].Value = "X";
            }

            for (int j = 0; j < h; j++)
            {
                if (frame[j] != -1)
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = frame[j];
                else
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = "";
            }
        }



        private int pointer = 0;
        private bool[] useBit;
        private void SimulateClock_Step()
        {
            if (currentStep >= pages.Count) return;

            int page = pages[currentStep];
            bool hit = false;

            for (int j = 0; j < h; j++)
            {
                if (frame[j] == page)
                {
                    hit = true;
                    useBit[j] = true;
                    break;
                }
            }

            if (!hit)
            {
                while (true)
                {
                    if (!useBit[pointer])
                    {
                        frame[pointer] = page;
                        useBit[pointer] = true;
                        pointer = (pointer + 1) % h;
                        break;
                    }
                    else
                    {
                        useBit[pointer] = false;
                        pointer = (pointer + 1) % h;
                    }
                }

                dataGridView.Rows[h + 1].Cells[currentStep].Value = "X";
            }

            for (int j = 0; j < h; j++)
            {
                if (frame[j] != -1)
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = frame[j];
                else
                    dataGridView.Rows[1 + j].Cells[currentStep].Value = "";
            }
        }
    }
}