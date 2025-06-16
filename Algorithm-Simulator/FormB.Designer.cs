namespace Algorithm_Simulator
{
    partial class FormB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblAVG = new System.Windows.Forms.Label();
            this.dgvAVG = new System.Windows.Forms.DataGridView();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.grBoxGrantt = new System.Windows.Forms.GroupBox();
            this.PanelGantt = new System.Windows.Forms.Panel();
            this.checkPriority = new System.Windows.Forms.CheckBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grBoxRun = new System.Windows.Forms.GroupBox();
            this.grBoxAlgorithm = new System.Windows.Forms.GroupBox();
            this.PanelInfor = new System.Windows.Forms.Panel();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.trBarQuantum = new System.Windows.Forms.TrackBar();
            this.btnRR = new System.Windows.Forms.Button();
            this.btnPS = new System.Windows.Forms.Button();
            this.btnSRTF = new System.Windows.Forms.Button();
            this.btnSJF = new System.Windows.Forms.Button();
            this.btnFCFS = new System.Windows.Forms.Button();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProcessname = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.trBarArrival = new System.Windows.Forms.TrackBar();
            this.trBarPrio = new System.Windows.Forms.TrackBar();
            this.lblBurst = new System.Windows.Forms.Label();
            this.trBarBurst = new System.Windows.Forms.TrackBar();
            this.grBoxlis = new System.Windows.Forms.GroupBox();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVG)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.groupResult.SuspendLayout();
            this.panelProcess.SuspendLayout();
            this.grBoxGrantt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarSpeed)).BeginInit();
            this.grBoxRun.SuspendLayout();
            this.grBoxAlgorithm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarQuantum)).BeginInit();
            this.grBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarPrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarBurst)).BeginInit();
            this.grBoxlis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(449, 200);
            this.dgvResult.TabIndex = 1;
            // 
            // lblAVG
            // 
            this.lblAVG.AutoSize = true;
            this.lblAVG.Location = new System.Drawing.Point(6, 275);
            this.lblAVG.Name = "lblAVG";
            this.lblAVG.Size = new System.Drawing.Size(76, 17);
            this.lblAVG.TabIndex = 2;
            this.lblAVG.Text = "AVG Result";
            // 
            // dgvAVG
            // 
            this.dgvAVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAVG.Location = new System.Drawing.Point(0, 0);
            this.dgvAVG.Name = "dgvAVG";
            this.dgvAVG.RowHeadersWidth = 51;
            this.dgvAVG.RowTemplate.Height = 24;
            this.dgvAVG.Size = new System.Drawing.Size(449, 214);
            this.dgvAVG.TabIndex = 0;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.dgvAVG);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(3, 295);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(449, 214);
            this.panelTotal.TabIndex = 3;
            // 
            // groupResult
            // 
            this.groupResult.Controls.Add(this.panelTotal);
            this.groupResult.Controls.Add(this.lblAVG);
            this.groupResult.Controls.Add(this.panelProcess);
            this.groupResult.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResult.Location = new System.Drawing.Point(1068, 15);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(455, 512);
            this.groupResult.TabIndex = 25;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "Result";
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.dgvResult);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProcess.Location = new System.Drawing.Point(3, 21);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(449, 200);
            this.panelProcess.TabIndex = 1;
            // 
            // grBoxGrantt
            // 
            this.grBoxGrantt.Controls.Add(this.PanelGantt);
            this.grBoxGrantt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxGrantt.Location = new System.Drawing.Point(29, 533);
            this.grBoxGrantt.Name = "grBoxGrantt";
            this.grBoxGrantt.Size = new System.Drawing.Size(1494, 138);
            this.grBoxGrantt.TabIndex = 24;
            this.grBoxGrantt.TabStop = false;
            this.grBoxGrantt.Text = "Gantt Chart";
            // 
            // PanelGantt
            // 
            this.PanelGantt.AutoScroll = true;
            this.PanelGantt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelGantt.Location = new System.Drawing.Point(3, 26);
            this.PanelGantt.Name = "PanelGantt";
            this.PanelGantt.Size = new System.Drawing.Size(1488, 109);
            this.PanelGantt.TabIndex = 0;
            // 
            // checkPriority
            // 
            this.checkPriority.AutoSize = true;
            this.checkPriority.Location = new System.Drawing.Point(62, 212);
            this.checkPriority.Name = "checkPriority";
            this.checkPriority.Size = new System.Drawing.Size(76, 21);
            this.checkPriority.TabIndex = 19;
            this.checkPriority.Text = "Priority";
            this.checkPriority.UseVisualStyleBackColor = true;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(18, 129);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(138, 17);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Simulation Speed: 1x";
            // 
            // trBarSpeed
            // 
            this.trBarSpeed.Location = new System.Drawing.Point(21, 149);
            this.trBarSpeed.Minimum = 1;
            this.trBarSpeed.Name = "trBarSpeed";
            this.trBarSpeed.Size = new System.Drawing.Size(166, 56);
            this.trBarSpeed.TabIndex = 17;
            this.trBarSpeed.Value = 1;
            this.trBarSpeed.Scroll += new System.EventHandler(this.trBarSpeed_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(119, 56);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 39);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(6, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 39);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grBoxRun
            // 
            this.grBoxRun.Controls.Add(this.checkPriority);
            this.grBoxRun.Controls.Add(this.lblSpeed);
            this.grBoxRun.Controls.Add(this.trBarSpeed);
            this.grBoxRun.Controls.Add(this.btnReset);
            this.grBoxRun.Controls.Add(this.btnStart);
            this.grBoxRun.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxRun.Location = new System.Drawing.Point(847, 245);
            this.grBoxRun.Name = "grBoxRun";
            this.grBoxRun.Size = new System.Drawing.Size(212, 282);
            this.grBoxRun.TabIndex = 23;
            this.grBoxRun.TabStop = false;
            this.grBoxRun.Text = "Run";
            // 
            // grBoxAlgorithm
            // 
            this.grBoxAlgorithm.Controls.Add(this.PanelInfor);
            this.grBoxAlgorithm.Controls.Add(this.lblQuantum);
            this.grBoxAlgorithm.Controls.Add(this.trBarQuantum);
            this.grBoxAlgorithm.Controls.Add(this.btnRR);
            this.grBoxAlgorithm.Controls.Add(this.btnPS);
            this.grBoxAlgorithm.Controls.Add(this.btnSRTF);
            this.grBoxAlgorithm.Controls.Add(this.btnSJF);
            this.grBoxAlgorithm.Controls.Add(this.btnFCFS);
            this.grBoxAlgorithm.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxAlgorithm.Location = new System.Drawing.Point(29, 245);
            this.grBoxAlgorithm.Name = "grBoxAlgorithm";
            this.grBoxAlgorithm.Size = new System.Drawing.Size(812, 282);
            this.grBoxAlgorithm.TabIndex = 22;
            this.grBoxAlgorithm.TabStop = false;
            this.grBoxAlgorithm.Text = "Scheduling Algorithm";
            // 
            // PanelInfor
            // 
            this.PanelInfor.AutoScroll = true;
            this.PanelInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfor.Location = new System.Drawing.Point(3, 193);
            this.PanelInfor.Name = "PanelInfor";
            this.PanelInfor.Size = new System.Drawing.Size(806, 86);
            this.PanelInfor.TabIndex = 22;
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantum.Location = new System.Drawing.Point(24, 141);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(116, 17);
            this.lblQuantum.TabIndex = 17;
            this.lblQuantum.Text = "Time Quantum: 2";
            this.lblQuantum.Visible = false;
            // 
            // trBarQuantum
            // 
            this.trBarQuantum.Location = new System.Drawing.Point(13, 153);
            this.trBarQuantum.Minimum = 1;
            this.trBarQuantum.Name = "trBarQuantum";
            this.trBarQuantum.Size = new System.Drawing.Size(792, 56);
            this.trBarQuantum.TabIndex = 17;
            this.trBarQuantum.Value = 2;
            this.trBarQuantum.Visible = false;
            this.trBarQuantum.Scroll += new System.EventHandler(this.trBarQuantum_Scroll);
            // 
            // btnRR
            // 
            this.btnRR.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRR.Location = new System.Drawing.Point(269, 99);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(250, 39);
            this.btnRR.TabIndex = 20;
            this.btnRR.Text = "Round Robin";
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.btnRR_Click);
            // 
            // btnPS
            // 
            this.btnPS.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPS.Location = new System.Drawing.Point(13, 99);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(250, 39);
            this.btnPS.TabIndex = 19;
            this.btnPS.Text = "Priority Scheduling";
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // btnSRTF
            // 
            this.btnSRTF.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRTF.Location = new System.Drawing.Point(525, 39);
            this.btnSRTF.Name = "btnSRTF";
            this.btnSRTF.Size = new System.Drawing.Size(281, 39);
            this.btnSRTF.TabIndex = 18;
            this.btnSRTF.Text = "Shortest Remaining Time First (SRTF)";
            this.btnSRTF.UseVisualStyleBackColor = true;
            this.btnSRTF.Click += new System.EventHandler(this.btnSRTF_Click);
            // 
            // btnSJF
            // 
            this.btnSJF.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSJF.Location = new System.Drawing.Point(269, 39);
            this.btnSJF.Name = "btnSJF";
            this.btnSJF.Size = new System.Drawing.Size(250, 39);
            this.btnSJF.TabIndex = 17;
            this.btnSJF.Text = "Shortest Job First (SJF)";
            this.btnSJF.UseVisualStyleBackColor = true;
            this.btnSJF.Click += new System.EventHandler(this.btnSJF_Click);
            // 
            // btnFCFS
            // 
            this.btnFCFS.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFCFS.Location = new System.Drawing.Point(13, 39);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(250, 39);
            this.btnFCFS.TabIndex = 16;
            this.btnFCFS.Text = "First Come First Serve (FCFS)";
            this.btnFCFS.UseVisualStyleBackColor = true;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Burst
            // 
            this.Burst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Burst.HeaderText = "Burst";
            this.Burst.MinimumWidth = 6;
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            // 
            // grBoxAdd
            // 
            this.grBoxAdd.Controls.Add(this.btnExit);
            this.grBoxAdd.Controls.Add(this.btnDelete);
            this.grBoxAdd.Controls.Add(this.btnAdd);
            this.grBoxAdd.Controls.Add(this.lblProcessname);
            this.grBoxAdd.Controls.Add(this.txtProcess);
            this.grBoxAdd.Controls.Add(this.lblArrival);
            this.grBoxAdd.Controls.Add(this.lblPriority);
            this.grBoxAdd.Controls.Add(this.trBarArrival);
            this.grBoxAdd.Controls.Add(this.trBarPrio);
            this.grBoxAdd.Controls.Add(this.lblBurst);
            this.grBoxAdd.Controls.Add(this.trBarBurst);
            this.grBoxAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxAdd.Location = new System.Drawing.Point(29, 15);
            this.grBoxAdd.Name = "grBoxAdd";
            this.grBoxAdd.Size = new System.Drawing.Size(441, 224);
            this.grBoxAdd.TabIndex = 20;
            this.grBoxAdd.TabStop = false;
            this.grBoxAdd.Text = "Add New Process";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(295, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 39);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(159, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Process";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 39);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Process";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProcessname
            // 
            this.lblProcessname.AutoSize = true;
            this.lblProcessname.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessname.Location = new System.Drawing.Point(24, 30);
            this.lblProcessname.Name = "lblProcessname";
            this.lblProcessname.Size = new System.Drawing.Size(94, 17);
            this.lblProcessname.TabIndex = 13;
            this.lblProcessname.Text = "Process Name";
            // 
            // txtProcess
            // 
            this.txtProcess.Enabled = false;
            this.txtProcess.Location = new System.Drawing.Point(27, 49);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(100, 25);
            this.txtProcess.TabIndex = 12;
            this.txtProcess.Text = "P0";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(201, 21);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(99, 17);
            this.lblArrival.TabIndex = 10;
            this.lblArrival.Text = "Arrival Time: 0";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(201, 107);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(69, 17);
            this.lblPriority.TabIndex = 11;
            this.lblPriority.Text = "Priority: 1";
            // 
            // trBarArrival
            // 
            this.trBarArrival.Location = new System.Drawing.Point(190, 30);
            this.trBarArrival.Maximum = 20;
            this.trBarArrival.Name = "trBarArrival";
            this.trBarArrival.Size = new System.Drawing.Size(157, 56);
            this.trBarArrival.TabIndex = 8;
            this.trBarArrival.Scroll += new System.EventHandler(this.trBarArrival_Scroll);
            // 
            // trBarPrio
            // 
            this.trBarPrio.Location = new System.Drawing.Point(190, 116);
            this.trBarPrio.Minimum = 1;
            this.trBarPrio.Name = "trBarPrio";
            this.trBarPrio.Size = new System.Drawing.Size(157, 56);
            this.trBarPrio.TabIndex = 9;
            this.trBarPrio.Value = 1;
            this.trBarPrio.Scroll += new System.EventHandler(this.trBarPrio_Scroll);
            // 
            // lblBurst
            // 
            this.lblBurst.AutoSize = true;
            this.lblBurst.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurst.Location = new System.Drawing.Point(24, 107);
            this.lblBurst.Name = "lblBurst";
            this.lblBurst.Size = new System.Drawing.Size(90, 17);
            this.lblBurst.TabIndex = 7;
            this.lblBurst.Text = "Burst Time: 1";
            // 
            // trBarBurst
            // 
            this.trBarBurst.Location = new System.Drawing.Point(13, 116);
            this.trBarBurst.Maximum = 20;
            this.trBarBurst.Minimum = 1;
            this.trBarBurst.Name = "trBarBurst";
            this.trBarBurst.Size = new System.Drawing.Size(157, 56);
            this.trBarBurst.TabIndex = 6;
            this.trBarBurst.Value = 1;
            this.trBarBurst.Scroll += new System.EventHandler(this.trBarBurst_Scroll);
            // 
            // grBoxlis
            // 
            this.grBoxlis.Controls.Add(this.dgvProcess);
            this.grBoxlis.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxlis.Location = new System.Drawing.Point(488, 15);
            this.grBoxlis.Name = "grBoxlis";
            this.grBoxlis.Size = new System.Drawing.Size(574, 224);
            this.grBoxlis.TabIndex = 21;
            this.grBoxlis.TabStop = false;
            this.grBoxlis.Text = "Process List";
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.Arrival,
            this.Burst,
            this.Priority});
            this.dgvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcess.Location = new System.Drawing.Point(3, 21);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            this.dgvProcess.RowHeadersWidth = 51;
            this.dgvProcess.RowTemplate.Height = 24;
            this.dgvProcess.Size = new System.Drawing.Size(568, 200);
            this.dgvProcess.TabIndex = 0;
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProcessName.HeaderText = "Process";
            this.ProcessName.MinimumWidth = 6;
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Width = 83;
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.groupResult);
            this.Controls.Add(this.grBoxGrantt);
            this.Controls.Add(this.grBoxRun);
            this.Controls.Add(this.grBoxAlgorithm);
            this.Controls.Add(this.grBoxAdd);
            this.Controls.Add(this.grBoxlis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormB";
            this.Load += new System.EventHandler(this.CPU_Distribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVG)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.panelProcess.ResumeLayout(false);
            this.grBoxGrantt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trBarSpeed)).EndInit();
            this.grBoxRun.ResumeLayout(false);
            this.grBoxRun.PerformLayout();
            this.grBoxAlgorithm.ResumeLayout(false);
            this.grBoxAlgorithm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarQuantum)).EndInit();
            this.grBoxAdd.ResumeLayout(false);
            this.grBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBarArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarPrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBarBurst)).EndInit();
            this.grBoxlis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lblAVG;
        private System.Windows.Forms.DataGridView dgvAVG;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.GroupBox grBoxGrantt;
        private System.Windows.Forms.CheckBox checkPriority;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trBarSpeed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grBoxRun;
        private System.Windows.Forms.GroupBox grBoxAlgorithm;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.TrackBar trBarQuantum;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Button btnPS;
        private System.Windows.Forms.Button btnSRTF;
        private System.Windows.Forms.Button btnSJF;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Burst;
        private System.Windows.Forms.GroupBox grBoxAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProcessname;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TrackBar trBarArrival;
        private System.Windows.Forms.TrackBar trBarPrio;
        private System.Windows.Forms.Label lblBurst;
        private System.Windows.Forms.TrackBar trBarBurst;
        private System.Windows.Forms.GroupBox grBoxlis;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.Panel PanelGantt;
        private System.Windows.Forms.Panel PanelInfor;
    }
}