namespace Algorithm_Simulator
{
    partial class FormBanker
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
            this.radiobtnRequest = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.txtResReq = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtProcReq = new System.Windows.Forms.TextBox();
            this.lblResReq = new System.Windows.Forms.Label();
            this.lblProcReq = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblAlloc = new System.Windows.Forms.Label();
            this.radiobtnSafe = new System.Windows.Forms.RadioButton();
            this.btnAlloc = new System.Windows.Forms.Button();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtAlloc = new System.Windows.Forms.TextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.txtNRes = new System.Windows.Forms.TextBox();
            this.txtNProc = new System.Windows.Forms.TextBox();
            this.lblResInput = new System.Windows.Forms.Label();
            this.lblProcInput = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.lblNeed = new System.Windows.Forms.Label();
            this.richNeed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richAlloc = new System.Windows.Forms.RichTextBox();
            this.richWork = new System.Windows.Forms.RichTextBox();
            this.richMax = new System.Windows.Forms.RichTextBox();
            this.grpBoxOutput = new System.Windows.Forms.GroupBox();
            this.grpBoxInput = new System.Windows.Forms.GroupBox();
            this.grpBoxMode = new System.Windows.Forms.GroupBox();
            this.grpBoxOutput.SuspendLayout();
            this.grpBoxInput.SuspendLayout();
            this.grpBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiobtnRequest
            // 
            this.radiobtnRequest.AutoSize = true;
            this.radiobtnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnRequest.Location = new System.Drawing.Point(221, 20);
            this.radiobtnRequest.Name = "radiobtnRequest";
            this.radiobtnRequest.Size = new System.Drawing.Size(92, 24);
            this.radiobtnRequest.TabIndex = 27;
            this.radiobtnRequest.TabStop = true;
            this.radiobtnRequest.Text = "Request";
            this.radiobtnRequest.UseVisualStyleBackColor = true;
            this.radiobtnRequest.CheckedChanged += new System.EventHandler(this.radiobtnRequest_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(192, 626);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 49);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(12, 625);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 49);
            this.btnCheck.TabIndex = 24;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(200, 157);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(109, 31);
            this.btnMax.TabIndex = 23;
            this.btnMax.Text = "Add row";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // txtResReq
            // 
            this.txtResReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResReq.Location = new System.Drawing.Point(207, 135);
            this.txtResReq.Name = "txtResReq";
            this.txtResReq.Size = new System.Drawing.Size(181, 27);
            this.txtResReq.TabIndex = 18;
            this.txtResReq.Visible = false;
            // 
            // txtMax
            // 
            this.txtMax.Enabled = false;
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(17, 161);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(154, 27);
            this.txtMax.TabIndex = 21;
            // 
            // txtProcReq
            // 
            this.txtProcReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcReq.Location = new System.Drawing.Point(207, 88);
            this.txtProcReq.Name = "txtProcReq";
            this.txtProcReq.Size = new System.Drawing.Size(181, 24);
            this.txtProcReq.TabIndex = 17;
            this.txtProcReq.Visible = false;
            // 
            // lblResReq
            // 
            this.lblResReq.AutoSize = true;
            this.lblResReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResReq.Location = new System.Drawing.Point(17, 141);
            this.lblResReq.Name = "lblResReq";
            this.lblResReq.Size = new System.Drawing.Size(151, 20);
            this.lblResReq.TabIndex = 13;
            this.lblResReq.Text = "Request resources";
            this.lblResReq.Visible = false;
            // 
            // lblProcReq
            // 
            this.lblProcReq.AutoSize = true;
            this.lblProcReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcReq.Location = new System.Drawing.Point(17, 88);
            this.lblProcReq.Name = "lblProcReq";
            this.lblProcReq.Size = new System.Drawing.Size(136, 20);
            this.lblProcReq.TabIndex = 14;
            this.lblProcReq.Text = "Request process";
            this.lblProcReq.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(6, 138);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(91, 20);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "Max matrix";
            // 
            // lblAlloc
            // 
            this.lblAlloc.AutoSize = true;
            this.lblAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlloc.Location = new System.Drawing.Point(6, 203);
            this.lblAlloc.Name = "lblAlloc";
            this.lblAlloc.Size = new System.Drawing.Size(133, 20);
            this.lblAlloc.TabIndex = 9;
            this.lblAlloc.Text = "Allocation matrix";
            // 
            // radiobtnSafe
            // 
            this.radiobtnSafe.AutoSize = true;
            this.radiobtnSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnSafe.Location = new System.Drawing.Point(30, 20);
            this.radiobtnSafe.Name = "radiobtnSafe";
            this.radiobtnSafe.Size = new System.Drawing.Size(113, 24);
            this.radiobtnSafe.TabIndex = 28;
            this.radiobtnSafe.TabStop = true;
            this.radiobtnSafe.Text = "Safe check";
            this.radiobtnSafe.UseVisualStyleBackColor = true;
            this.radiobtnSafe.CheckedChanged += new System.EventHandler(this.radiobtnSafe_CheckedChanged);
            // 
            // btnAlloc
            // 
            this.btnAlloc.Enabled = false;
            this.btnAlloc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlloc.Location = new System.Drawing.Point(200, 222);
            this.btnAlloc.Name = "btnAlloc";
            this.btnAlloc.Size = new System.Drawing.Size(109, 31);
            this.btnAlloc.TabIndex = 26;
            this.btnAlloc.Text = "Add row";
            this.btnAlloc.UseVisualStyleBackColor = true;
            this.btnAlloc.Click += new System.EventHandler(this.btnAlloc_Click);
            // 
            // txtAvail
            // 
            this.txtAvail.Enabled = false;
            this.txtAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvail.Location = new System.Drawing.Point(17, 291);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(181, 26);
            this.txtAvail.TabIndex = 22;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(363, 59);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(123, 32);
            this.btnContinue.TabIndex = 20;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtAlloc
            // 
            this.txtAlloc.Enabled = false;
            this.txtAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlloc.Location = new System.Drawing.Point(17, 226);
            this.txtAlloc.Name = "txtAlloc";
            this.txtAlloc.Size = new System.Drawing.Size(154, 27);
            this.txtAlloc.TabIndex = 19;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvail.Location = new System.Drawing.Point(6, 268);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(127, 20);
            this.lblAvail.TabIndex = 12;
            this.lblAvail.Text = "Available matrix";
            // 
            // txtNRes
            // 
            this.txtNRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRes.Location = new System.Drawing.Point(200, 90);
            this.txtNRes.Name = "txtNRes";
            this.txtNRes.Size = new System.Drawing.Size(120, 24);
            this.txtNRes.TabIndex = 16;
            this.txtNRes.TextChanged += new System.EventHandler(this.txtNRes_TextChanged);
            // 
            // txtNProc
            // 
            this.txtNProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNProc.Location = new System.Drawing.Point(200, 37);
            this.txtNProc.Name = "txtNProc";
            this.txtNProc.Size = new System.Drawing.Size(120, 24);
            this.txtNProc.TabIndex = 8;
            this.txtNProc.TextChanged += new System.EventHandler(this.txtNProc_TextChanged);
            // 
            // lblResInput
            // 
            this.lblResInput.AutoSize = true;
            this.lblResInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResInput.Location = new System.Drawing.Point(6, 92);
            this.lblResInput.Name = "lblResInput";
            this.lblResInput.Size = new System.Drawing.Size(162, 20);
            this.lblResInput.TabIndex = 15;
            this.lblResInput.Text = "Total resource types";
            // 
            // lblProcInput
            // 
            this.lblProcInput.AutoSize = true;
            this.lblProcInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcInput.Location = new System.Drawing.Point(6, 39);
            this.lblProcInput.Name = "lblProcInput";
            this.lblProcInput.Size = new System.Drawing.Size(129, 20);
            this.lblProcInput.TabIndex = 10;
            this.lblProcInput.Text = "Total processes";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 39);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Banker\'s Algorithm";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Turquoise;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(369, 626);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 49);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(508, 440);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(57, 20);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Result";
            // 
            // richOutput
            // 
            this.richOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richOutput.Location = new System.Drawing.Point(512, 463);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(507, 199);
            this.richOutput.TabIndex = 7;
            this.richOutput.Text = "";
            // 
            // lblNeed
            // 
            this.lblNeed.AutoSize = true;
            this.lblNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeed.Location = new System.Drawing.Point(2, 440);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(99, 20);
            this.lblNeed.TabIndex = 1;
            this.lblNeed.Text = "Need matrix";
            // 
            // richNeed
            // 
            this.richNeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richNeed.Location = new System.Drawing.Point(6, 463);
            this.richNeed.Name = "richNeed";
            this.richNeed.Size = new System.Drawing.Size(500, 199);
            this.richNeed.TabIndex = 4;
            this.richNeed.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Allocation matrix";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWork.Location = new System.Drawing.Point(2, 233);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(99, 20);
            this.lblWork.TabIndex = 1;
            this.lblWork.Text = "Work matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max matrix";
            // 
            // richAlloc
            // 
            this.richAlloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richAlloc.Location = new System.Drawing.Point(512, 40);
            this.richAlloc.Name = "richAlloc";
            this.richAlloc.Size = new System.Drawing.Size(500, 182);
            this.richAlloc.TabIndex = 4;
            this.richAlloc.Text = "";
            // 
            // richWork
            // 
            this.richWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richWork.Location = new System.Drawing.Point(6, 256);
            this.richWork.Name = "richWork";
            this.richWork.Size = new System.Drawing.Size(1013, 182);
            this.richWork.TabIndex = 4;
            this.richWork.Text = "";
            // 
            // richMax
            // 
            this.richMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richMax.Location = new System.Drawing.Point(6, 40);
            this.richMax.Name = "richMax";
            this.richMax.Size = new System.Drawing.Size(500, 182);
            this.richMax.TabIndex = 1;
            this.richMax.Text = "";
            // 
            // grpBoxOutput
            // 
            this.grpBoxOutput.Controls.Add(this.richMax);
            this.grpBoxOutput.Controls.Add(this.richWork);
            this.grpBoxOutput.Controls.Add(this.richAlloc);
            this.grpBoxOutput.Controls.Add(this.label2);
            this.grpBoxOutput.Controls.Add(this.lblWork);
            this.grpBoxOutput.Controls.Add(this.label1);
            this.grpBoxOutput.Controls.Add(this.richNeed);
            this.grpBoxOutput.Controls.Add(this.lblNeed);
            this.grpBoxOutput.Controls.Add(this.richOutput);
            this.grpBoxOutput.Controls.Add(this.lblOutput);
            this.grpBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOutput.Location = new System.Drawing.Point(509, 12);
            this.grpBoxOutput.Name = "grpBoxOutput";
            this.grpBoxOutput.Size = new System.Drawing.Size(1025, 668);
            this.grpBoxOutput.TabIndex = 30;
            this.grpBoxOutput.TabStop = false;
            this.grpBoxOutput.Text = "Output";
            // 
            // grpBoxInput
            // 
            this.grpBoxInput.Controls.Add(this.lblProcInput);
            this.grpBoxInput.Controls.Add(this.lblResInput);
            this.grpBoxInput.Controls.Add(this.txtNProc);
            this.grpBoxInput.Controls.Add(this.txtNRes);
            this.grpBoxInput.Controls.Add(this.lblAvail);
            this.grpBoxInput.Controls.Add(this.txtAlloc);
            this.grpBoxInput.Controls.Add(this.btnMax);
            this.grpBoxInput.Controls.Add(this.btnContinue);
            this.grpBoxInput.Controls.Add(this.txtAvail);
            this.grpBoxInput.Controls.Add(this.txtMax);
            this.grpBoxInput.Controls.Add(this.btnAlloc);
            this.grpBoxInput.Controls.Add(this.lblAlloc);
            this.grpBoxInput.Controls.Add(this.lblMax);
            this.grpBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInput.Location = new System.Drawing.Point(12, 64);
            this.grpBoxInput.Name = "grpBoxInput";
            this.grpBoxInput.Size = new System.Drawing.Size(491, 328);
            this.grpBoxInput.TabIndex = 32;
            this.grpBoxInput.TabStop = false;
            this.grpBoxInput.Text = "Input";
            // 
            // grpBoxMode
            // 
            this.grpBoxMode.Controls.Add(this.txtProcReq);
            this.grpBoxMode.Controls.Add(this.radiobtnSafe);
            this.grpBoxMode.Controls.Add(this.lblProcReq);
            this.grpBoxMode.Controls.Add(this.radiobtnRequest);
            this.grpBoxMode.Controls.Add(this.lblResReq);
            this.grpBoxMode.Controls.Add(this.txtResReq);
            this.grpBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMode.Location = new System.Drawing.Point(12, 410);
            this.grpBoxMode.Name = "grpBoxMode";
            this.grpBoxMode.Size = new System.Drawing.Size(491, 173);
            this.grpBoxMode.TabIndex = 33;
            this.grpBoxMode.TabStop = false;
            this.grpBoxMode.Text = "Mode";
            // 
            // FormBanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 687);
            this.Controls.Add(this.grpBoxMode);
            this.Controls.Add(this.grpBoxInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBanker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banker Form";
            this.Load += new System.EventHandler(this.FormBanker_Load);
            this.grpBoxOutput.ResumeLayout(false);
            this.grpBoxOutput.PerformLayout();
            this.grpBoxInput.ResumeLayout(false);
            this.grpBoxInput.PerformLayout();
            this.grpBoxMode.ResumeLayout(false);
            this.grpBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.TextBox txtResReq;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtProcReq;
        private System.Windows.Forms.Label lblResReq;
        private System.Windows.Forms.Label lblProcReq;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblAlloc;
        private System.Windows.Forms.RadioButton radiobtnSafe;
        private System.Windows.Forms.Button btnAlloc;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtAlloc;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.TextBox txtNRes;
        private System.Windows.Forms.TextBox txtNProc;
        private System.Windows.Forms.Label lblResInput;
        private System.Windows.Forms.Label lblProcInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox richOutput;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.RichTextBox richNeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richAlloc;
        private System.Windows.Forms.RichTextBox richWork;
        private System.Windows.Forms.RichTextBox richMax;
        private System.Windows.Forms.GroupBox grpBoxOutput;
        private System.Windows.Forms.GroupBox grpBoxInput;
        private System.Windows.Forms.GroupBox grpBoxMode;
    }
}