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
    public partial class FormB : Form
    {
        private Form MainForm;
        public FormB(Form callingForm)
        {
            InitializeComponent();
            MainForm = callingForm;
        }

        private string status = "none"; // trạng thái thuật toán
        private int n = 0; // số lượng process 
        private int ganttX = 0; // biến thành viên để ghi nhớ vị trí x hiện tại

        public class Process
        {
            public string Name { get; set; }
            public int Arrival { get; set; }
            public int Burst { get; set; }
            public int Priority { get; set; }
            public int StartTime { get; set; } = -1;
            public int CompletionTime { get; set; }
            public int TurnAroundTime { get; set; }
            public int WaitingTime { get; set; }
        }

        private List<Process> ganttSegments = new List<Process>();
        Process currentSegment = null;

        private void CreateLb(string text)
        {
            PanelInfor.Controls.Clear(); //Xóa hết lb đang tồn tại
            Label lbl = new Label();
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lbl.ForeColor = Color.Black;
            PanelInfor.Controls.Add(lbl);
        }

        private void AddStatus(string message, Color color)
        {
            Label lbl = new Label();
            lbl.Text = message;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lbl.ForeColor = color;

            // Tính vị trí Y dựa trên label cuối cùng
            int y = 0;
            if (PanelInfor.Controls.Count > 0)
            {
                var last = PanelInfor.Controls[PanelInfor.Controls.Count - 1];
                y = last.Bottom + 5;
            }

            // Thêm tạm để đo kích thước
            PanelInfor.Controls.Add(lbl);

            // Tính X để canh giữa
            int x = (PanelInfor.Width - lbl.Width) / 2;
            lbl.Location = new Point(x, y);

            PanelInfor.ScrollControlIntoView(lbl);
        }

        private void CPU_Distribution_Load(object sender, EventArgs e)
        {
            HideQuantumControls();
            UnablePio();
        }

        private void UnablePio()
        {
            trBarPrio.Enabled = false;
        }

        private void ablePio()
        {
            trBarPrio.Enabled = true;
        }

        private void HideQuantumControls()
        {
            // Ẩn traBar quantum
            lblQuantum.Visible = false;
            trBarQuantum.Visible = false;
        }

        private void trBarBurst_Scroll(object sender, EventArgs e)
        {
            lblBurst.Text = "Burst Time: " + trBarBurst.Value.ToString();
        }

        private void trBarPrio_Scroll(object sender, EventArgs e)
        {
            lblPriority.Text = "Priority: " + trBarPrio.Value.ToString();
        }

        private void trBarArrival_Scroll(object sender, EventArgs e)
        {
            lblArrival.Text = "Arrival Time: " + trBarArrival.Value.ToString();
        }

        private int GetDelay()
        {
            return (11 - trBarSpeed.Value) * 100; //Điều chỉnh tốc độ
        }

        private void SetupProcess()
        {
            string newProcess = txtProcess.Text.Trim();

            if (string.IsNullOrWhiteSpace(newProcess))
            {
                MessageBox.Show("Vui lòng nhập tên Process.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Thêm vào DataGridView
            int index = dgvProcess.Rows.Add();
            dgvProcess.Rows[index].Cells["ProcessName"].Value = newProcess;
            dgvProcess.Rows[index].Cells["Arrival"].Value = trBarArrival.Value;
            dgvProcess.Rows[index].Cells["Burst"].Value = trBarBurst.Value;
            dgvProcess.Rows[index].Cells["Priority"].Value = trBarPrio.Value;

            txtProcess.Clear();
        }

        private void SetupDgvResult()
        {
            // Tạo cột nếu chưa có
            if (dgvResult.Columns.Count == 0)
            {
                dgvResult.AllowUserToAddRows = false;

                dgvResult.Columns.Add("PrName", "Process");
                dgvResult.Columns.Add("TAT", "Turn Around Time");
                dgvResult.Columns.Add("WT", "Waiting Time");

                dgvResult.Columns["PrName"].Width = 50;
                dgvResult.Columns["TAT"].Width = 90;
                dgvResult.Columns["WT"].Width = 90;

                dgvResult.Columns["PrName"].ReadOnly = true;
                dgvResult.Columns["TAT"].ReadOnly = true;
                dgvResult.Columns["WT"].ReadOnly = true;

                dgvResult.Columns["PrName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResult.Columns["TAT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvResult.Columns["WT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvProcess.Rows.Count > 0)
            {
                DataGridViewRow lastRow = dgvProcess.Rows[dgvProcess.Rows.Count - 1];
                if (!lastRow.IsNewRow)
                {
                    string processName = lastRow.Cells["ProcessName"].Value?.ToString() ?? "";
                    int index = dgvResult.Rows.Add();
                    dgvResult.Rows[index].Cells["PrName"].Value = processName;
                    dgvResult.Rows[index].Cells["TAT"].Value = "";
                    dgvResult.Rows[index].Cells["WT"].Value = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetupProcess();
            n += 1;
            txtProcess.Text = "P" + n.ToString();
            SetupDgvResult();
        }

        private void DeleteProcess()
        {
            if (dgvProcess.Rows.Count > 0)
            {
                // Xóa dòng cuối (trừ khi đó là dòng mới đang nhập nếu AllowUserToAddRows = true)
                int lastRowIndex = dgvProcess.AllowUserToAddRows ? dgvProcess.Rows.Count - 2 : dgvProcess.Rows.Count - 1;

                if (lastRowIndex >= 0)
                {
                    dgvProcess.Rows.RemoveAt(lastRowIndex);
                    dgvResult.Rows.RemoveAt((int)lastRowIndex);
                }
            }
            else
            {
                MessageBox.Show("Không có tiến trình nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProcess();
            if (n != 0)
            {
                n -= 1;
                txtProcess.Text = "P" + n.ToString();
            }
        }

        private List<Process> GetProcesses()
        {
            var processes = new List<Process>();

            foreach (DataGridViewRow row in dgvProcess.Rows)
            {
                if (row.IsNewRow) continue;

                var process = new Process
                {
                    Name = row.Cells["ProcessName"].Value?.ToString() ?? "",
                    Arrival = Convert.ToInt32(row.Cells["Arrival"].Value),
                    Burst = Convert.ToInt32(row.Cells["Burst"].Value),
                    Priority = Convert.ToInt32(row.Cells["Priority"].Value)
                };

                processes.Add(process);
            }

            return processes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
        }

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            HideQuantumControls();
            status = "FCFS";
            CreateLb("Describe:\nCác tiến trình được thực thi theo thứ tự chúng xuất hiện trong hàng đợi sẵn sàng.");
            UnablePio();
        }

        private void btnSJF_Click(object sender, EventArgs e)
        {
            HideQuantumControls();
            status = "SJF";
            CreateLb("Describe:\nThuật toán không ưu tiên trong đó tiến trình có thời gian bùng phát nhỏ nhất sẽ được thực thi trước.");
            UnablePio();
        }

        private void btnSRTF_Click(object sender, EventArgs e)
        {
            HideQuantumControls();
            status = "SRTF";
            CreateLb("Describe:\nPhiên bản ưu tiên của SJF trong đó tiến trình có thời gian còn lại nhỏ nhất sẽ được thực thi trước.");
            ablePio();
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            HideQuantumControls();
            status = "PS";
            CreateLb("Describe:\nCác tiến trình được thực hiện dựa trên mức độ ưu tiên. Số càng thấp thì mức độ ưu tiên càng cao.");
            ablePio();
        }

        private void btnRR_Click(object sender, EventArgs e)
        {
            lblQuantum.Visible = true;
            trBarQuantum.Visible = true;
            status = "RR";
            CreateLb("Describe:\nMỗi tiến trình được chỉ định một khoảng thời gian cố định hoạt động theo cách tuần hoàn.");
            UnablePio();
        }

        private void trBarQuantum_Scroll(object sender, EventArgs e)
        {
            lblQuantum.Text = "Quantum Time: " + trBarQuantum.Value.ToString();
        }

        private void trBarSpeed_Scroll(object sender, EventArgs e)
        {
            lblSpeed.Text = "Simulation Speed: " + trBarSpeed.Value.ToString() + "x";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            n = 0;
            txtProcess.Text = "P" + n.ToString();
            status = "none";
            dgvProcess.Rows.Clear();
            dgvAVG.Rows.Clear();
            dgvAVG.Columns.Clear();
            dgvResult.Rows.Clear();
            dgvResult.Columns.Clear();
            PanelGantt.Controls.Clear();
            PanelInfor.Controls.Clear();
        }

        private void ClearGanttChart()
        {
            PanelGantt.Controls.Clear();
            ganttX = 0; // reset vị trí vẽ
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Kiểm tra thuật toán
            if (status == "none")
            {
                MessageBox.Show("Vui lòng chọn thuật toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Algo = status;
            // Đọc dữ liệu từ DataGridView
            List<Process> processes = GetProcesses();
            if (processes == null || processes.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tiến trình.");
                return;
            }

            // Khóa trạng thái
            btnStart.Enabled = false;
            btnReset.Enabled = false;
            Run(processes);
        }

        private async void Run(List<Process> processes)
        {
            // 1. Lấy danh sách tiến trình gốc
            var proc = GetProcesses();

            // 2. Lấy quantum
            int quantum = trBarQuantum.Value;

            // 3. Xóa/khởi tạo lại các phần hiển thị
            PanelInfor.Controls.Clear();       // Clear PanelInfor 
            ClearGanttChart();                 // Clear Gantt chart
            ganttSegments.Clear();             // Clear danh sách đoạn Gantt
            dgvResult.Rows.Clear();            // Clear kết quả tiến trình
            dgvAVG.Rows.Clear();               // Clear AVG TAT/WT

            // 4. Tạo bảng kết quả
            InitializeResultTable(proc);       // Ghi tên tiến trình trước, TAT/WT cập nhật sau

            // Lấy trạng thái
            string Algo = status;

            switch (Algo)
            {
                case "FCFS":
                    // 5. Gọi thuật toán FCFS
                    var res = await FCFS(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res);
                    break;
                case "SJF":
                    // 5. Gọi thuật toán SJF
                    var res1 = await SJF(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res1);
                    break;
                case "SRTF":
                    // 5. Gọi thuật toán SRTF
                    var res2 = await SRTF(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res2);
                    break;
                case "PS":
                    // 5. Gọi thuật toán PS
                    var res3 = await PS(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res3);
                    break;
                case "RR":
                    // 5. Gọi thuật toán RR, khóa trabar
                    trBarQuantum.Enabled = false;
                    var result = await RR(proc, quantum);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(result);
                    break;
            }

            // Bật lại trạng thái
            btnStart.Enabled = true;
            btnReset.Enabled = true;
        }

        // Thuật toán FCFS
        private async Task<List<Process>> FCFS(List<Process> processes)
        {
            var all = processes
                .Select(p => new Process
                {
                    Name = p.Name,
                    Arrival = p.Arrival,
                    Burst = p.Burst,
                    Priority = p.Priority
                })
                .ToList();

            int currentTime = 0;
            var result = new List<Process>();

            var sorted = all.OrderBy(p => p.Arrival).ToList();

            foreach (var p in sorted)
            {
                if (currentTime < p.Arrival)
                {
                    AddStatus($"{currentTime}s: CPU Trống", Color.Gray);
                    currentTime = p.Arrival;
                }

                AddStatus($"{currentTime}s: Process {p.Name} bắt đầu chạy", Color.Green);

                await Task.Delay(GetDelay());

                p.StartTime = currentTime;
                p.CompletionTime = currentTime + p.Burst;
                p.TurnAroundTime = p.CompletionTime - p.Arrival;
                p.WaitingTime = p.TurnAroundTime - p.Burst;

                var segment = new Process
                {
                    Name = p.Name,
                    StartTime = p.StartTime,
                    Burst = p.Burst,
                    CompletionTime = p.CompletionTime
                };

                ganttSegments.Add(segment);
                AddGanttBlock(segment);
                DisplayProcessResult(p);
                AddStatus($"{currentTime + p.Burst}s: Process {p.Name} đã kết thúc", Color.Red);

                currentTime = p.CompletionTime;
                result.Add(p);
            }

            return result.OrderBy(p => p.Name).ToList();
        }

        // Thuật toán SJF
        private async Task<List<Process>> SJF(List<Process> processes)
        {
            var all = processes
                .Select(p => new Process
                {
                    Name = p.Name,
                    Arrival = p.Arrival,
                    Burst = p.Burst,
                    Priority = p.Priority
                })
                .ToList();

            var result = new List<Process>();
            int currentTime = 0;

            var readyQueue = new List<Process>();
            var notArrived = all.OrderBy(p => p.Arrival).ToList();

            while (result.Count < processes.Count)
            {
                // Thêm tiến trình đã đến vào hàng đợi
                var newlyArrived = notArrived.Where(p => p.Arrival <= currentTime).ToList();
                foreach (var p in newlyArrived)
                {
                    AddStatus($"{currentTime}s: Process {p.Name} được thêm vào hàng đợi", Color.Blue);
                    readyQueue.Add(p);
                }
                notArrived.RemoveAll(p => p.Arrival <= currentTime);

                if (readyQueue.Count == 0)
                {
                    AddStatus($"{currentTime}s: CPU Trống", Color.Gray);
                    currentTime = notArrived.First().Arrival;
                    continue;
                }

                var next = readyQueue
                    .OrderBy(p => p.Burst)
                    .ThenBy(p => p.Arrival)
                    .ThenBy(p => p.Name)
                    .First();

                readyQueue.Remove(next);

                AddStatus($"{currentTime}s: Process {next.Name} bắt đầu chạy", Color.Green);
                await Task.Delay(GetDelay());

                next.StartTime = currentTime;
                next.CompletionTime = currentTime + next.Burst;
                next.TurnAroundTime = next.CompletionTime - next.Arrival;
                next.WaitingTime = next.TurnAroundTime - next.Burst;

                var segment = new Process
                {
                    Name = next.Name,
                    StartTime = currentTime,
                    Burst = next.Burst,
                    CompletionTime = next.CompletionTime
                };
                ganttSegments.Add(segment);
                AddGanttBlock(segment);
                DisplayProcessResult(next);

                AddStatus($"{next.CompletionTime}s: Process {next.Name} đã kết thúc", Color.Green);

                currentTime = next.CompletionTime;
                result.Add(next);
            }

            return result.OrderBy(p => p.Name).ToList();
        }

        // Thuật toán SRTF
        private async Task<List<Process>> SRTF(List<Process> processes)
        {
            processes = processes.OrderBy(p => p.Arrival).ToList();
            int n = processes.Count;
            int time = 0, completed = 0;

            var result = new List<Process>();
            var all = processes.Select(p => new Process
            {
                Name = p.Name,
                Arrival = p.Arrival,
                Burst = p.Burst,
                Priority = p.Priority,
                StartTime = -1
            }).ToList();

            var remainingTime = all.ToDictionary(p => p.Name, p => p.Burst);
            string lastRunning = "-";
            Process currentSegment = null;
            ganttSegments.Clear();

            while (completed < n)
            {
                var available = all
                    .Where(p => p.Arrival <= time && remainingTime[p.Name] > 0)
                    .ToList();

                Process current = null;

                current = available
                        .OrderBy(p => remainingTime[p.Name])
                        .ThenBy(p => p.Arrival)
                        .FirstOrDefault();
                if (current != null)
                {
                    if (current.StartTime == -1)
                        current.StartTime = time;

                    // Nếu đổi tiến trình
                    if (lastRunning != current.Name)
                    {
                        if (currentSegment != null && lastRunning != "-")
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                        }

                        currentSegment = new Process
                        {
                            Name = current.Name,
                            StartTime = time
                        };

                        AddStatus($"{time}s: Process {current.Name} bắt đầu chạy", Color.Green);
                    }

                    await Task.Delay(GetDelay());

                    remainingTime[current.Name]--;
                    time++;

                    if (remainingTime[current.Name] == 0)
                    {
                        // Kết thúc đoạn đang chạy
                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        current.CompletionTime = time;
                        current.TurnAroundTime = time - current.Arrival;
                        current.WaitingTime = current.TurnAroundTime - current.Burst;

                        completed++;
                        DisplayProcessResult(current);
                        AddStatus($"{time}s: Process {current.Name} đã kết thúc", Color.Red);
                        result.Add(current);

                        lastRunning = "-";
                        continue;
                    }

                    lastRunning = current.Name;
                }
                else
                {
                    // CPU idle
                    if (lastRunning != "-")
                    {
                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        AddStatus($"{time}s: CPU Trống", Color.Gray);
                    }

                    await Task.Delay(GetDelay());
                    time++;
                    lastRunning = "-";
                }
            }

            // Kết thúc đoạn cuối cùng nếu còn
            if (currentSegment != null)
            {
                currentSegment.CompletionTime = time;
                currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                ganttSegments.Add(currentSegment);
                AddGanttBlock(currentSegment);
            }

            return result.OrderBy(p => p.Name).ToList();
        }

        // Thuật toán Priority Scheduling
        private async Task<List<Process>> PS(List<Process> processes)
        {
            var result = new List<Process>();
            int currentTime = 0;

            var all = processes.Select(p => new Process
            {
                Name = p.Name,
                Arrival = p.Arrival,
                Burst = p.Burst,
                Priority = p.Priority,
                StartTime = -1
            }).ToList();

            var remainingTime = all.ToDictionary(p => p.Name, p => p.Burst);
            int time = 0, completed = 0;
            Process currentSegment = null;
            string lastRunning = "-";

            while (completed < all.Count)
            {
                var available = all
                    .Where(p => p.Arrival <= time && remainingTime[p.Name] > 0)
                    .OrderBy(p => p.Priority)
                    .ThenBy(p => p.Arrival)
                    .ToList();

                Process current = available.FirstOrDefault();

                if (current != null)
                {
                    if (current.StartTime == -1)
                        current.StartTime = time;

                    if (lastRunning != current.Name)
                    {
                        if (currentSegment != null && lastRunning != "-")
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                        }

                        currentSegment = new Process
                        {
                            Name = current.Name,
                            StartTime = time
                        };

                        AddStatus($"{time}s: Process {current.Name} bắt đầu chạy (Priority {current.Priority})", Color.Green);
                    }

                    await Task.Delay(GetDelay());
                    remainingTime[current.Name]--;
                    time++;

                    if (remainingTime[current.Name] == 0)
                    {
                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        current.CompletionTime = time;
                        current.TurnAroundTime = time - current.Arrival;
                        current.WaitingTime = current.TurnAroundTime - current.Burst;

                        DisplayProcessResult(current);
                        AddStatus($"{time}s: Process {current.Name} đã kết thúc", Color.Red);
                        result.Add(current);
                        completed++;

                        lastRunning = "-";
                        continue;
                    }

                    lastRunning = current.Name;
                }
                else
                {
                    if (lastRunning != "-")
                    {
                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = time;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        AddStatus($"{time}s: CPU Trống", Color.Gray);
                    }

                    await Task.Delay(GetDelay());
                    time++;
                    lastRunning = "-";
                }
            }

            if (currentSegment != null)
            {
                currentSegment.CompletionTime = currentTime;
                currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                ganttSegments.Add(currentSegment);
                AddGanttBlock(currentSegment);
            }

            return result.OrderBy(p => p.Name).ToList();
        }

        // Thuật toán Round Robin
        private async Task<List<Process>> RR(List<Process> processes, int quantum)
        {
            processes = processes.OrderBy(p => p.Arrival).ToList();
            int n = processes.Count;
            int time = 0, completed = 0;

            var result = new List<Process>();
            var all = processes.Select(p => new Process
            {
                Name = p.Name,
                Arrival = p.Arrival,
                Burst = p.Burst,
                Priority = p.Priority,
                StartTime = -1
            }).ToList();

            var remainingTime = all.ToDictionary(p => p.Name, p => p.Burst);
            var readyQueue = new Queue<Process>();

            int i = 0;
            while (i < n && all[i].Arrival <= time)
                readyQueue.Enqueue(all[i++]);

            string lastRunning = "-";
            Process currentSegment = null;

            while (completed < n)
            {
                if (readyQueue.Count == 0)
                {
                    if (lastRunning != "-")
                        AddStatus($"{time}s: CPU IDLE", Color.Gray);

                    await Task.Delay(GetDelay());
                    time++;

                    while (i < n && all[i].Arrival <= time)
                        readyQueue.Enqueue(all[i++]);

                    lastRunning = "-";
                    continue;
                }

                Process current;

                current = readyQueue.Dequeue();

                if (current.StartTime == -1)
                    current.StartTime = time;

                // Nếu bị ngắt, lưu đoạn Gantt cũ
                if (lastRunning != current.Name)
                {
                    if (currentSegment != null && lastRunning != "-")
                    {
                        currentSegment.CompletionTime = time;
                        currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                        ganttSegments.Add(currentSegment);
                        AddGanttBlock(currentSegment);
                    }

                    currentSegment = new Process
                    {
                        Name = current.Name,
                        StartTime = time
                    };

                    AddStatus($"{time}s: Process {current.Name} bắt đầu chạy", Color.Green);
                }

                int execTime = Math.Min(quantum, remainingTime[current.Name]);

                for (int t = 0; t < execTime; t++)
                {
                    await Task.Delay(GetDelay());
                    time++;
                    remainingTime[current.Name]--;

                    // Trong quá trình chạy, thêm process mới vào
                    while (i < n && all[i].Arrival <= time)
                        readyQueue.Enqueue(all[i++]);
                }

                if (remainingTime[current.Name] > 0)
                {
                    readyQueue.Enqueue(current);
                    AddStatus($"{time}s: Process {current.Name} quay lại hàng đợi", Color.Gold);
                }
                else
                {
                    current.CompletionTime = time;
                    current.TurnAroundTime = current.CompletionTime - current.Arrival;
                    current.WaitingTime = current.TurnAroundTime - current.Burst;

                    DisplayProcessResult(current);
                    AddStatus($"{time}s: Process {current.Name} đã kết thúc", Color.Red);
                    result.Add(current);
                    completed++;
                }


                lastRunning = current.Name;
            }

            if (currentSegment != null)
            {
                currentSegment.CompletionTime = time;
                currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                ganttSegments.Add(currentSegment);
                AddGanttBlock(currentSegment);
            }
            trBarQuantum.Enabled = true;

            return result.OrderBy(p => p.Name).ToList();

        }

        private void DisplayProcessResult(Process p)
        {
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                if (row.Cells["PrName"].Value != null &&
                    row.Cells["PrName"].Value.ToString().Equals(p.Name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["TAT"].Value = p.TurnAroundTime;
                    row.Cells["WT"].Value = p.WaitingTime;
                    return;
                }
            }

            int rowIndex = dgvResult.Rows.Add();
            dgvResult.Rows[rowIndex].Cells["PrName"].Value = p.Name;
            dgvResult.Rows[rowIndex].Cells["TAT"].Value = p.TurnAroundTime;
            dgvResult.Rows[rowIndex].Cells["WT"].Value = p.WaitingTime;
        }


        private void DisplayAVG(List<Process> processes)
        {
            if (processes == null || processes.Count == 0)
                return;

            double avgTAT = processes.Average(p => p.TurnAroundTime);
            double avgWT = processes.Average(p => p.WaitingTime);

            // Tạo cột
            if (dgvAVG.Columns.Count == 0)
            {
                dgvAVG.Columns.Add("TAT", "Average TAT");
                dgvAVG.Columns.Add("WT", "Average WT");

                dgvAVG.Columns["TAT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAVG.Columns["WT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAVG.Columns["TAT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAVG.Columns["WT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvAVG.AllowUserToAddRows = false;
                dgvAVG.RowHeadersVisible = false;
                dgvAVG.ReadOnly = true;
            }

            // Xóa dữ liệu cũ
            dgvAVG.Rows.Clear();

            // Thêm dòng mới
            dgvAVG.Rows.Add(avgTAT.ToString("F2"), avgWT.ToString("F2"));
        }


        private void AddGanttBlock(Process p)
        {
            int unitWidth = 30;
            int height = 50;
            int width = p.Burst * unitWidth;

            // Start time label
            Label startTime = new Label();
            startTime.Text = p.StartTime.ToString();
            startTime.Location = new Point(ganttX, height + 15);
            startTime.AutoSize = true;
            PanelGantt.Controls.Add(startTime);

            // Process block
            Label box = new Label();
            box.Text = (p.Name == "-") ? "IDLE" : p.Name;
            box.TextAlign = ContentAlignment.MiddleCenter;

            // Màu sắc tiến trình
            box.BackColor = Color.LightBlue;

            box.BorderStyle = BorderStyle.FixedSingle;
            box.Location = new Point(ganttX, 10);
            box.Size = new Size(width, height);
            PanelGantt.Controls.Add(box);

            ganttX += width;

            // End time label
            Label endTime = new Label();
            endTime.Text = p.CompletionTime.ToString();
            endTime.Location = new Point(ganttX, height + 15);
            endTime.AutoSize = true;
            PanelGantt.Controls.Add(endTime);
        }

        private void InitializeResultTable(List<Process> processes)
        {
            dgvResult.Rows.Clear();
            if (dgvResult.Columns.Count == 0)
            {
                dgvResult.Columns.Add("PrName", "Process");
                dgvResult.Columns.Add("TAT", "Turnaround Time");
                dgvResult.Columns.Add("WT", "Waiting Time");

                dgvResult.Columns["PrName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvResult.Columns["TAT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvResult.Columns["WT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvResult.AllowUserToAddRows = false;
                dgvResult.RowHeadersVisible = false;
                dgvResult.ReadOnly = true;
            }

            foreach (var p in processes)
            {
                int index = dgvResult.Rows.Add();
                dgvResult.Rows[index].Cells["PrName"].Value = p.Name;
            }
        }
    }
}