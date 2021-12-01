
namespace Race_Time_Recording_Branch
{
    partial class Form1
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
            this.radBtnMale = new System.Windows.Forms.RadioButton();
            this.radBtnFemale = new System.Windows.Forms.RadioButton();
            this.listBoxRacersAmount = new System.Windows.Forms.ListBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvColumnLane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRacersAmount = new System.Windows.Forms.Label();
            this.btnLockIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // radBtnMale
            // 
            this.radBtnMale.AutoSize = true;
            this.radBtnMale.Location = new System.Drawing.Point(15, 30);
            this.radBtnMale.Name = "radBtnMale";
            this.radBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radBtnMale.TabIndex = 0;
            this.radBtnMale.TabStop = true;
            this.radBtnMale.Text = "Male";
            this.radBtnMale.UseVisualStyleBackColor = true;
            // 
            // radBtnFemale
            // 
            this.radBtnFemale.AutoSize = true;
            this.radBtnFemale.Location = new System.Drawing.Point(15, 53);
            this.radBtnFemale.Name = "radBtnFemale";
            this.radBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radBtnFemale.TabIndex = 1;
            this.radBtnFemale.TabStop = true;
            this.radBtnFemale.Text = "Female";
            this.radBtnFemale.UseVisualStyleBackColor = true;
            // 
            // listBoxRacersAmount
            // 
            this.listBoxRacersAmount.FormattingEnabled = true;
            this.listBoxRacersAmount.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.listBoxRacersAmount.Location = new System.Drawing.Point(15, 111);
            this.listBoxRacersAmount.Name = "listBoxRacersAmount";
            this.listBoxRacersAmount.Size = new System.Drawing.Size(38, 69);
            this.listBoxRacersAmount.TabIndex = 2;
            this.listBoxRacersAmount.SelectedIndexChanged += new System.EventHandler(this.listBoxRacersAmount_SelectedIndexChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnLane,
            this.dgvColumnFirstName,
            this.dgvColumnSurname,
            this.dgvColumnTime});
            this.dgvMain.Enabled = false;
            this.dgvMain.Location = new System.Drawing.Point(190, 13);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMain.Size = new System.Drawing.Size(441, 260);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            this.dgvMain.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvMain_UserAddedRow);
            // 
            // dgvColumnLane
            // 
            this.dgvColumnLane.HeaderText = "Lane";
            this.dgvColumnLane.Name = "dgvColumnLane";
            // 
            // dgvColumnFirstName
            // 
            this.dgvColumnFirstName.HeaderText = "First Name";
            this.dgvColumnFirstName.Name = "dgvColumnFirstName";
            // 
            // dgvColumnSurname
            // 
            this.dgvColumnSurname.HeaderText = "Surname";
            this.dgvColumnSurname.Name = "dgvColumnSurname";
            // 
            // dgvColumnTime
            // 
            this.dgvColumnTime.HeaderText = "Time";
            this.dgvColumnTime.Name = "dgvColumnTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What is the sex of the racers?";
            // 
            // lblRacersAmount
            // 
            this.lblRacersAmount.AutoSize = true;
            this.lblRacersAmount.Location = new System.Drawing.Point(12, 95);
            this.lblRacersAmount.Name = "lblRacersAmount";
            this.lblRacersAmount.Size = new System.Drawing.Size(134, 13);
            this.lblRacersAmount.TabIndex = 5;
            this.lblRacersAmount.Text = "How many racers are there";
            // 
            // btnLockIn
            // 
            this.btnLockIn.Location = new System.Drawing.Point(15, 186);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(75, 23);
            this.btnLockIn.TabIndex = 0;
            this.btnLockIn.Text = "Lock In";
            this.btnLockIn.UseVisualStyleBackColor = true;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(15, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.Location = new System.Drawing.Point(15, 246);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(0, 13);
            this.lblErrorOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 321);
            this.Controls.Add(this.lblErrorOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.lblRacersAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.listBoxRacersAmount);
            this.Controls.Add(this.radBtnFemale);
            this.Controls.Add(this.radBtnMale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnMale;
        private System.Windows.Forms.RadioButton radBtnFemale;
        private System.Windows.Forms.ListBox listBoxRacersAmount;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnLane;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRacersAmount;
        private System.Windows.Forms.Button btnLockIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErrorOutput;
    }
}

