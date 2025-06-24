using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private int ganttX = 0; // biến để ghi nhớ vị trí x hiện tại để vẽ biểu gantt

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
            public int Remaining { get; set; }
        }

        private List<Process> ganttSegments = new List<Process>();

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
            string newProcess = txtProcess.Text;
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
                dgvResult.Columns.Add("PrName", "Process");
                dgvResult.Columns.Add("TAT", "Turn Around Time");
                dgvResult.Columns.Add("WT", "Waiting Time");

                dgvResult.Columns["PrName"].Width = 50;
                dgvResult.Columns["TAT"].Width = 90;
                dgvResult.Columns["WT"].Width = 90;

                dgvResult.Columns["PrName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResult.Columns["TAT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvResult.Columns["WT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvProcess.Rows.Count > 0)
            {
                DataGridViewRow lastRow = dgvProcess.Rows[dgvProcess.Rows.Count - 1];
                string processName = lastRow.Cells["ProcessName"].Value?.ToString() ?? "";
                int index = dgvResult.Rows.Add();
                dgvResult.Rows[index].Cells["PrName"].Value = processName;
                dgvResult.Rows[index].Cells["TAT"].Value = "";
                dgvResult.Rows[index].Cells["WT"].Value = "";
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
                // Xóa dòng cuối
                int lastRowIndex = dgvProcess.Rows.Count - 1;

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
                string name = row.Cells["ProcessName"].Value?.ToString() ?? "";
                int arrival = (int)row.Cells["Arrival"].Value;
                int burst = (int)row.Cells["Burst"].Value;
                int priority = (int)row.Cells["Priority"].Value;

                var process = new Process
                {
                    Name = name,
                    Arrival = arrival,
                    Burst = burst,
                    Priority = priority
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

        private void btnTurnoff()
        {
            btnFCFS.Enabled = false;
            btnSJF.Enabled = false;
            btnSRTF.Enabled = false;
            btnRR.Enabled = false;
            btnPS.Enabled = false;
        }

        private void btnTurnon()
        {
            btnFCFS.Enabled = true;
            btnSJF.Enabled = true;
            btnSRTF.Enabled = true;
            btnRR.Enabled = true;
            btnPS.Enabled = true;
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
            // Khóa trạng thái
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnTurnoff();

            // Kiểm tra thuật toán
            if (status == "none")
            {
                MessageBox.Show("Vui lòng chọn thuật toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            // Lấy trạng thái
            string Algo = status;

            switch (Algo)
            {
                case "FCFS":
                    // 4. Gọi thuật toán FCFS
                    var res = await FCFS(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res);
                    break;
                case "SJF":
                    // 4. Gọi thuật toán SJF
                    var res1 = await SJF(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res1);
                    break;
                case "SRTF":
                    // 4. Gọi thuật toán SRTF
                    var res2 = await SRTF(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res2);
                    break;
                case "PS":
                    // 4. Gọi thuật toán PS
                    var res3 = await PS(proc);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(res3);
                    break;
                case "RR":
                    // 4. Gọi thuật toán RR, khóa trabar
                    trBarQuantum.Enabled = false;
                    var result = await RR(proc, quantum);
                    //Hiển thị AVG sau khi toàn bộ tiến trình hoàn tất
                    DisplayAVG(result);
                    break;
            }

            // Bật lại trạng thái
            btnStart.Enabled = true;
            btnReset.Enabled = true;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            btnTurnon();
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
                    // Hiển thị trạng thái
                    AddStatus($"{currentTime}s: CPU Trống", Color.Gray);

                    // Tạo đoạn IDLE để vẽ Gantt chart cho trường hợp CPU trống
                    var idleSegment = new Process
                    {
                        Name = "-",
                        StartTime = currentTime,
                        CompletionTime = p.Arrival,
                        Burst = p.Arrival - currentTime
                    };

                    ganttSegments.Add(idleSegment);
                    AddGanttBlock(idleSegment);

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

            return result.ToList();
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
                //iLọc các tiến trình đã đến (arrival time ≤ currentTime) và đưa vào readyQueue. Đồng thời xóa khỏi notArrived.

                var newlyArrived = notArrived.Where(p => p.Arrival <= currentTime).ToList();
                foreach (var p in newlyArrived)
                {
                    readyQueue.Add(p);
                }
                notArrived.RemoveAll(p => p.Arrival <= currentTime);

                if (readyQueue.Count == 0)
                {
                    var idleStart = currentTime;
                    currentTime = notArrived.First().Arrival;   // currentTime được cập nhật đến thời điểm tiến trình kế tiếp đến

                    AddStatus($"{idleStart}s: CPU Trống", Color.Gray);

                    // Tạo đoạn IDLE để vẽ Gantt chart cho trường hợp CPU trống
                    var idleSegment = new Process
                    {
                        Name = "-",
                        StartTime = idleStart,
                        CompletionTime = currentTime,
                        Burst = currentTime - idleStart
                    };
                    ganttSegments.Add(idleSegment);
                    AddGanttBlock(idleSegment);

                    continue;
                }

                var next = readyQueue
                    .OrderBy(p => p.Burst)
                    .ThenBy(p => p.Arrival)
                    
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

                AddStatus($"{next.CompletionTime}s: Process {next.Name} đã kết thúc", Color.Red);

                currentTime = next.CompletionTime;
                result.Add(next);
            }

            return result.ToList();
        }

        // Thuật toán SRTF
        private async Task<List<Process>> SRTF(List<Process> processes)
        {
            var all = processes
                .Select(p => new Process
                {
                    Name = p.Name,
                    Arrival = p.Arrival,
                    Burst = p.Burst,
                    Priority = p.Priority,
                    Remaining = p.Burst,
                    StartTime = -1
                })
                .ToList();

            var result = new List<Process>();
            int currentTime = 0;
            var readyQueue = new List<Process>();
            var notArrived = all.OrderBy(p => p.Arrival).ToList();

            Process current = null;

            while (result.Count < processes.Count)
            {
                // Thêm tiến trình mới vào hàng đợi
                var arrived = notArrived.Where(p => p.Arrival <= currentTime).ToList();
                foreach (var p in arrived)
                {
                    AddStatus($"{currentTime}s: Process {p.Name} được thêm vào hàng đợi", Color.Blue);
                    readyQueue.Add(p);
                }
                notArrived.RemoveAll(p => p.Arrival <= currentTime);

                // CPU trống
                if (current == null && readyQueue.Count == 0)
                {
                    int idleStart = currentTime;
                    int nextArrival = notArrived.First().Arrival; //Lấy thời gian Arrival của tiến trình gần nhất

                    currentTime = nextArrival;

                    AddStatus($"{idleStart}s - {currentTime}s: CPU Trống", Color.Gray);
                    ganttSegments.Add(new Process
                    {
                        Name = "-",
                        StartTime = idleStart,
                        CompletionTime = currentTime,
                        Burst = currentTime - idleStart
                    });
                    AddGanttBlock(ganttSegments.Last());
                    continue;
                }

                // Chọn tiến trình có thời gian còn lại nhỏ nhất
                if (readyQueue.Count > 0)
                {
                    var shortest = readyQueue
                        .OrderBy(p => p.Remaining)
                        .ThenBy(p => p.Arrival)
                        
                        .First();

                    if (current != shortest)
                    {
                        // Nếu đang chạy tiến trình khác, chốt đoạn cũ
                        if (current != null && current.StartTime < currentTime)
                        {
                            ganttSegments.Add(new Process
                            {
                                Name = current.Name,
                                StartTime = current.StartTime,
                                CompletionTime = currentTime,
                                Burst = currentTime - current.StartTime
                            });
                            AddGanttBlock(ganttSegments.Last());
                        }

                        // Chuyển sang tiến trình mới
                        current = shortest;

                        if (current.StartTime == -1 || current.StartTime < currentTime)
                            current.StartTime = currentTime;

                        AddStatus($"{currentTime}s: Process {current.Name} bắt đầu chạy", Color.Green);
                    }

                    await Task.Delay(GetDelay());
                    current.Remaining--;
                    currentTime++;

                    if (current.Remaining == 0)
                    {
                        current.CompletionTime = currentTime;
                        current.TurnAroundTime = current.CompletionTime - current.Arrival;
                        current.WaitingTime = current.TurnAroundTime - current.Burst;

                        // Chốt đoạn cuối
                        ganttSegments.Add(new Process
                        {
                            Name = current.Name,
                            StartTime = current.StartTime,
                            CompletionTime = currentTime,
                            Burst = currentTime - current.StartTime
                        });
                        AddGanttBlock(ganttSegments.Last());

                        DisplayProcessResult(current);
                        AddStatus($"{currentTime}s: Process {current.Name} đã kết thúc", Color.Red);

                        result.Add(current);
                        readyQueue.Remove(current);
                        current = null;
                    }
                }
                else
                {
                    currentTime++;
                }
            }

            return result.ToList();
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
                StartTime = -1,
                Remaining = p.Burst
            }).ToList();

            int completed = 0;
            string lastRunning = "-";
            Process currentSegment = null;
            int? idleStart = null;

            while (completed < all.Count)
            {
                //Lấy tiến trình có độ ưu tiên cao nhất
                var ready = all
                    .Where(p => p.Arrival <= currentTime && p.Remaining > 0)
                    .OrderBy(p => p.Priority)
                    .ThenBy(p => p.Arrival)
                    .ToList();

                var current = ready.FirstOrDefault();

                if (current != null)
                {
                    // Nếu vừa thoát khỏi trạng thái trống
                    if (idleStart.HasValue)
                    {
                        AddStatus($"{idleStart.Value}s - {currentTime}s: CPU Trống", Color.Gray);
                        ganttSegments.Add(new Process
                        {
                            Name = "-",
                            StartTime = idleStart.Value,
                            CompletionTime = currentTime,
                            Burst = currentTime - idleStart.Value
                        });
                        AddGanttBlock(ganttSegments.Last());
                        idleStart = null;
                    }
                    
                    //Nếu lần đầu chạy
                    if (current.StartTime == -1)
                        current.StartTime = currentTime;

                    //Nếu có tiến trình thay đổi, nhường cpu
                    if (lastRunning != current.Name)
                    {
                        if (currentSegment != null && lastRunning != "-")
                        {
                            currentSegment.CompletionTime = currentTime;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                        }

                        currentSegment = new Process
                        {
                            Name = current.Name,
                            StartTime = currentTime
                        };

                        AddStatus($"{currentTime}s: Process {current.Name} bắt đầu chạy (Priority {current.Priority})", Color.Green);
                    }

                    await Task.Delay(GetDelay());
                    current.Remaining--;
                    currentTime++;

                    if (current.Remaining == 0)
                    {
                        current.CompletionTime = currentTime;
                        current.TurnAroundTime = current.CompletionTime - current.Arrival;
                        current.WaitingTime = current.TurnAroundTime - current.Burst;

                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = currentTime;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        DisplayProcessResult(current);
                        AddStatus($"{currentTime}s: Process {current.Name} đã kết thúc", Color.Red);
                        result.Add(current);
                        completed++;
                        lastRunning = "-";
                    }
                    else
                    {
                        lastRunning = current.Name;
                    }
                }
                else
                {
                    // CPU Trống
                    if (!idleStart.HasValue)
                        idleStart = currentTime;

                    if (lastRunning != "-")
                    {
                        if (currentSegment != null)
                        {
                            currentSegment.CompletionTime = currentTime;
                            currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                            ganttSegments.Add(currentSegment);
                            AddGanttBlock(currentSegment);
                            currentSegment = null;
                        }

                        lastRunning = "-";
                    }

                    await Task.Delay(GetDelay());
                    currentTime++;
                }
            }

            return result.ToList();
        }

        // Thuật toán Round Robin
        private async Task<List<Process>> RR(List<Process> processes, int quantum)
        {
            processes = processes.OrderBy(p => p.Arrival).ToList();
            n = processes.Count;
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

            var remainingTime = all.ToDictionary(p => p.Name, p => p.Burst); // Lưu thời gian còn lại
            var readyQueue = new Queue<Process>();  // hàng đợi

            // Đưa tất cả tiến trình đã đến vào hàng đợi
            int i = 0;
            while (i < n && all[i].Arrival <= time)
                readyQueue.Enqueue(all[i++]);

            string lastRunning = "-";
            Process currentSegment = null;
            int? idleStart = null;

            while (completed < n)
            {
                // Nếu CPU bắt đầu trống
                if (readyQueue.Count == 0)
                {
                    if (!idleStart.HasValue)
                        idleStart = time;

                    await Task.Delay(GetDelay());
                    time++;

                    while (i < n && all[i].Arrival <= time)
                        readyQueue.Enqueue(all[i++]);

                    if (readyQueue.Count > 0 && idleStart.HasValue)
                    {
                        //Kết thúc thời gian trống
                        AddStatus($"{idleStart.Value}s - {time}s: CPU Trống", Color.Gray);
                        var idleSegment = new Process
                        {
                            Name = "-",
                            StartTime = idleStart.Value,
                            CompletionTime = time,
                            Burst = time - idleStart.Value
                        };
                        ganttSegments.Add(idleSegment);
                        AddGanttBlock(idleSegment);
                        idleStart = null;
                    }

                    lastRunning = "-";
                    continue;
                }

                Process current = readyQueue.Dequeue();

                if (current.StartTime == -1)
                    current.StartTime = time;

                // Nếu đổi tiến trình đang chạy, ghi đoạn cũ
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

                    // Khi process mới đến trong thời gian thực thi
                    while (i < n && all[i].Arrival <= time)
                        readyQueue.Enqueue(all[i++]);
                }
                if (remainingTime[current.Name] > 0) // vẫn còn thời gian thực thi
                {
                    readyQueue.Enqueue(current);

                    // Nếu còn nhiều hơn 1 tiến trình, mới thông báo
                    if (readyQueue.Count > 1 || i < n)
                    {
                        AddStatus($"{time}s: Process {current.Name} quay lại hàng đợi", Color.Gold);
                    }
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

            // Ghi gantt cuối nếu còn
            if (currentSegment != null)
            {
                currentSegment.CompletionTime = time;
                currentSegment.Burst = currentSegment.CompletionTime - currentSegment.StartTime;
                ganttSegments.Add(currentSegment);
                AddGanttBlock(currentSegment);
            }

            trBarQuantum.Enabled = true;
            return result.ToList();
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
            box.Text = (p.Name == "-") ? "CPU trống" : p.Name;
            box.TextAlign = ContentAlignment.MiddleCenter;

            // Màu sắc tiến trình
            box.BackColor = (p.Name == "-") ? Color.LightGray : Color.LightBlue;

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
    }
}