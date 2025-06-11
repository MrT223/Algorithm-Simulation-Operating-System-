using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Simulator
{
    public partial class formD : Form
    {
        private List<System.Windows.Forms.Button> generatedButtons = new List<System.Windows.Forms.Button>();
        private string typeAlgorithm = "FCFS";
        public formD()
        {
            InitializeComponent();
        }

        private void txtRequests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '|')
            {
                e.Handled = true;
            }

        }
        private List<int> ParseRequests()
        {
            return txtRequests.Text.Split('|')
                .Select(s => int.Parse(s.Trim()))
                .ToList();
        }

        private int ParseHead()
        {
            return int.Parse(txtHead.Text.Trim());
        }

        private void btnLoadInput_Click(object sender, EventArgs e)
        {
            lbInput1.Visible = true;
            lbInput2.Visible = true;
            txtRequests.Enabled = false;
            txtHead.Enabled = false;

            string input = txtRequests.Text;
            string[] parts = input.Split('|');

            int x = lbInput1.Location.X + lbInput1.Width + 10; 
            int y = lbInput1.Location.Y - 5;
            int x_temp = x;
            int spacing = 10;

            foreach (string part in parts)
            {
                if (int.TryParse(part.Trim(), out int number))
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = number.ToString();
                    btn.Size = new Size(60, 30);
                    btn.Location = new Point(x, y);

                    this.Controls.Add(btn);
                    generatedButtons.Add(btn);
                    x += btn.Width + spacing;
                }
            }
            System.Windows.Forms.Button btnT = new System.Windows.Forms.Button();
            btnT.Text = txtHead.Text;
            btnT.Size = new Size(60, 30);
            btnT.Location = new Point(x_temp, lbInput2.Location.Y - 5);

            this.Controls.Add(btnT);
            generatedButtons.Add(btnT);
            x += btnT.Width + spacing;

            btnLoadInput.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var button in generatedButtons)
            {
                this.Controls.Remove(button);
                button.Dispose();
            }
            generatedButtons.Clear();

            txtRequests.Enabled = true;
            txtHead.Enabled = true;

            btnLoadInput.Enabled = true;
            btnReset.Enabled = false;
        }
        private void HighlightSelected(Button selected)
        {
            foreach (var btn in new[] { btnFCFS, btnSSTF, btnSCAN, btnCSCAN })
            {
                btn.BackColor = SystemColors.Control;
            }

            selected.BackColor = Color.LightGreen;
        }

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            HighlightSelected(btnFCFS);
            typeAlgorithm = "FCFS";
        }

        private void btnSSTF_Click(object sender, EventArgs e)
        {
            HighlightSelected(btnSSTF);
            typeAlgorithm = "SSTF";
        }

        private void btnSCAN_Click(object sender, EventArgs e)
        {
            HighlightSelected(btnSCAN);
            typeAlgorithm = "SCAN";
        }

        private void btnCSCAN_Click(object sender, EventArgs e)
        {
            HighlightSelected(btnCSCAN);
            typeAlgorithm = "CSCAN";
        }

        private void HighlightRequest(int value)
        {
            foreach (var btn in generatedButtons)
            {
                if (btn.Text == value.ToString())
                {
                    btn.BackColor = Color.Yellow;
                    btn.Refresh(); // Cập nhật lại màu ngay lập tức
                    break;
                }
            }
        }

        private async void FCFS(List<int> requests, int head)
        {
            TextBox txtProgress;

    
            if (this.Controls.ContainsKey("txtProgress"))
            {
                txtProgress = (TextBox)this.Controls["txtProgress"];
                txtProgress.Text = ""; 
            }
            else
            {
                // Tạo mới TextBox nếu chưa có
                txtProgress = new TextBox();
                txtProgress.Name = "txtProgress";
                txtProgress.Size = new Size(791, 190);
                txtProgress.Font = new Font("Segoe UI", 12);
                txtProgress.BackColor = Color.White;
                txtProgress.BorderStyle = BorderStyle.FixedSingle;
                txtProgress.Multiline = true;
                txtProgress.ScrollBars = ScrollBars.Vertical;
                txtProgress.ReadOnly = true;
                txtProgress.Location = new Point(lbProgress.Location.X, lbProgress.Location.Y + lbProgress.Height + 10);
                this.Controls.Add(txtProgress);
            }


            int seek = 0;
            int prev = head;

            txtProgress.AppendText("Bắt đầu giải thuật FCFS...\r\n");
            await Task.Delay(800);

            for (int i = 0; i < requests.Count; i++)
            {
                int r = requests[i];
                int distance = Math.Abs(prev - r);
                seek += distance;

                HighlightRequest(r);

                string stepText = $"Bước {i + 1}: seek = {seek - distance}, head = {prev} => seek + ({r} - {prev}) = {seek}";
                txtProgress.AppendText(stepText + "\r\n");

                prev = r;
                await Task.Delay(1000);
            }

            txtProgress.AppendText("Kết thúc giải thuật FCFS.\r\n");
        }


        private async void SSTF(List<int> requests, int head)
        {
            TextBox txtProgress;

            if (this.Controls.ContainsKey("txtProgress"))
            {
                txtProgress = (TextBox)this.Controls["txtProgress"];
                txtProgress.Text = ""; 
            }
            else
            {
                txtProgress = new TextBox();
                txtProgress.Name = "txtProgress";
                txtProgress.Size = new Size(791, 190);
                txtProgress.Font = new Font("Segoe UI", 12);
                txtProgress.BackColor = Color.White;
                txtProgress.BorderStyle = BorderStyle.FixedSingle;
                txtProgress.Multiline = true;
                txtProgress.ScrollBars = ScrollBars.Vertical;
                txtProgress.ReadOnly = true;
                txtProgress.Location = new Point(lbProgress.Location.X, lbProgress.Location.Y + lbProgress.Height + 10);
                this.Controls.Add(txtProgress);
            }

            txtProgress.AppendText("Bắt đầu giải thuật SSTF...\r\n");
            await Task.Delay(800);

            int seek = 0;
            int prev = head;
            List<int> remaining = new List<int>(requests);

            int step = 1;
            while (remaining.Count > 0)
            {
                int nearest = remaining.OrderBy(x => Math.Abs(x - prev)).First();
                int delta = nearest - prev;
                int distance = Math.Abs(delta);
                int seekPrev = seek;
                seek += distance;

                HighlightRequest(nearest);

                string stepText = $"Bước {step++}: head = {prev}, seek = {seekPrev} => seek + (|{nearest} - {prev}|) = {seek}";
                txtProgress.AppendText(stepText + "\r\n");

                prev = nearest;
                remaining.Remove(nearest);
                await Task.Delay(1000);
            }


            txtProgress.AppendText("Kết thúc giải thuật SSTF.\r\n");
        }

        private async void SCAN(List<int> requests, int head)
        {
            TextBox txtProgress;

            if (this.Controls.ContainsKey("txtProgress"))
            {
                txtProgress = (TextBox)this.Controls["txtProgress"];
                txtProgress.Text = "";
            }
            else
            {
                txtProgress = new TextBox();
                txtProgress.Name = "txtProgress";
                txtProgress.Size = new Size(791, 190);
                txtProgress.Font = new Font("Segoe UI", 12);
                txtProgress.BackColor = Color.White;
                txtProgress.BorderStyle = BorderStyle.FixedSingle;
                txtProgress.Multiline = true;
                txtProgress.ScrollBars = ScrollBars.Vertical;
                txtProgress.ReadOnly = true;
                txtProgress.Location = new Point(lbProgress.Location.X, lbProgress.Location.Y + lbProgress.Height + 10);
                this.Controls.Add(txtProgress);
            }

            // Lấy track max từ txtDiskSize (giả sử nhập đúng số nguyên)
            if (!int.TryParse(txtDiskSize.Text, out int trackMax) || trackMax <= 0)
            {
                MessageBox.Show("Vui lòng nhập kích thước ổ đĩa hợp lệ (số nguyên dương)!");
                return;
            }

            txtProgress.AppendText("Bắt đầu giải thuật SCAN...\r\n");
            await Task.Delay(800);

            List<int> all = new List<int>(requests);
            all.Add(head);
            all.Sort();

            int headIndex = all.IndexOf(head);
            int seek = 0;
            int prev = head;

            List<int> upward = all.GetRange(headIndex + 1, all.Count - (headIndex + 1)); // Các track lớn hơn head
            List<int> downward = all.GetRange(0, headIndex); // Các track nhỏ hơn head
            downward.Reverse(); // duyệt xuống theo thứ tự giảm dần

            List<int> seekSequence = new List<int>(); // lưu thứ tự track đã duyệt

            txtProgress.AppendText("➡️ Duyệt theo chiều lên (tăng): " + string.Join(", ", upward) + "\r\n");
            await Task.Delay(800);

            foreach (var current in upward)
            {
                int distance = Math.Abs(current - prev);
                seek += distance;

                HighlightRequest(current);
                txtProgress.AppendText($"Head từ {prev} → {current} | seek += {distance} => {seek}\r\n");

                prev = current;
                seekSequence.Add(current);

                await Task.Delay(1000);
            }

            // Nếu chưa ở cuối track, di chuyển đến cuối (trackMax -1)
            if (prev != trackMax - 1)
            {
                int distanceToEnd = (trackMax - 1) - prev;
                seek += distanceToEnd;

                txtProgress.AppendText($"Head từ {prev} → {trackMax - 1} (cuối đĩa) | seek += {distanceToEnd} => {seek}\r\n");
                prev = trackMax - 1;
                await Task.Delay(1000);
            }


            txtProgress.AppendText("⬅️ Duyệt theo chiều xuống (giảm): " + string.Join(", ", downward) + "\r\n");
            await Task.Delay(800);

            foreach (var current in downward)
            {
                int distance = Math.Abs(current - prev);
                seek += distance;

                HighlightRequest(current);
                txtProgress.AppendText($"Head từ {prev} → {current} | seek += {distance} => {seek}\r\n");

                prev = current;
                seekSequence.Add(current);

                await Task.Delay(1000);
            }

            txtProgress.AppendText("\r\nKết thúc giải thuật SCAN.\r\n");
            txtProgress.AppendText($"Tổng số lần seek operations = {seek}\r\n");
            txtProgress.AppendText("Chuỗi thứ tự track đã duyệt: " + string.Join(" -> ", seekSequence) + "\r\n");
        }


        private async void CSCAN(List<int> requests, int head)
        {
            TextBox txtProgress;

            if (this.Controls.ContainsKey("txtProgress"))
            {
                txtProgress = (TextBox)this.Controls["txtProgress"];
                txtProgress.Text = "";
            }
            else
            {
                txtProgress = new TextBox();
                txtProgress.Name = "txtProgress";
                txtProgress.Size = new Size(791, 190);
                txtProgress.Font = new Font("Segoe UI", 12);
                txtProgress.BackColor = Color.White;
                txtProgress.BorderStyle = BorderStyle.FixedSingle;
                txtProgress.Multiline = true;
                txtProgress.ScrollBars = ScrollBars.Vertical;
                txtProgress.ReadOnly = true;
                txtProgress.Location = new Point(lbProgress.Location.X, lbProgress.Location.Y + lbProgress.Height + 10);
                this.Controls.Add(txtProgress);
            }

            if (!int.TryParse(txtDiskSize.Text, out int trackMax) || trackMax <= 0)
            {
                MessageBox.Show("Vui lòng nhập kích thước ổ đĩa hợp lệ (số nguyên dương)!");
                return;
            }

            txtProgress.AppendText("Bắt đầu giải thuật CSCAN...\r\n");
            await Task.Delay(800);

            List<int> all = new List<int>(requests);
            all.Add(head);
            all.Sort();

            int headIndex = all.IndexOf(head);
            int seek = 0;
            int prev = head;

            // Các phần tử lớn hơn head
            List<int> upward = all.GetRange(headIndex + 1, all.Count - (headIndex + 1));
            // Các phần tử nhỏ hơn head
            List<int> downward = all.GetRange(0, headIndex);

            // Danh sách lưu thứ tự track đã duyệt
            List<int> seekSequence = new List<int>();

            txtProgress.AppendText("➡️ Duyệt theo chiều tăng: " + string.Join(", ", upward) + "\r\n");
            await Task.Delay(800);

            // Duyệt các phần tử tăng dần
            foreach (var current in upward)
            {
                int distance = Math.Abs(current - prev);
                seek += distance;

                HighlightRequest(current);
                txtProgress.AppendText($"Head từ {prev} → {current} | seek += {distance} => {seek}\r\n");

                prev = current;
                seekSequence.Add(current);

                await Task.Delay(1000);
            }

            if (prev != trackMax - 1)
            {
                int distanceToEnd = (trackMax - 1) - prev;
                seek += distanceToEnd;

                txtProgress.AppendText($"Head từ {prev} → {trackMax - 1} (cuối đĩa) | seek += {distanceToEnd} => {seek}\r\n");
                prev = trackMax - 1;
                await Task.Delay(1000);
            }

            txtProgress.AppendText($"🔄 Nhảy từ {prev} về 0 \r\n");
            await Task.Delay(1000);
            prev = 0;

            if (downward.Count > 0)
            {
                txtProgress.AppendText("\r\n⬆️ Duyệt tiếp từ 0: " + string.Join(", ", downward) + "\r\n");
                await Task.Delay(800);

                foreach (var current in downward)
                {
                    int distance = Math.Abs(current - prev);
                    seek += distance;

                    HighlightRequest(current);
                    txtProgress.AppendText($"Head từ {prev} → {current} | seek += {distance} => {seek}\r\n");

                    prev = current;
                    seekSequence.Add(current);

                    await Task.Delay(1000);
                }
            }

            // In tổng seek và chuỗi thứ tự track đã duyệt
            txtProgress.AppendText("\r\nKết thúc giải thuật CSCAN.\r\n");
            txtProgress.AppendText($"Tổng số lần seek operations = {seek + trackMax-1}\r\n");

            txtProgress.AppendText("Chuỗi thứ tự track đã duyệt: " + string.Join(" -> ", seekSequence) + "\r\n");
        }


        private async void btnRunAlgo_Click(object sender, EventArgs e)
        {
            lbProgress.Visible = true;
            var requests = ParseRequests();
            var head = ParseHead();

            foreach (var btn in generatedButtons)
                btn.BackColor = SystemColors.Control;

            switch (typeAlgorithm)
            {
                case "FCFS":
                    FCFS(requests, head);
                    break;
                case "SSTF":
                    SSTF(requests, head);
                    break;
                case "SCAN":
                    SCAN(requests, head);
                    break;
                case "CSCAN":
                    CSCAN(requests, head);
                    break;

            }
        }

        private void lbInput2_Click(object sender, EventArgs e)
        {

        }
    }
}
