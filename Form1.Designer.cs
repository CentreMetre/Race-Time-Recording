
namespace Winforms_App
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
            this.radbtn_male = new System.Windows.Forms.RadioButton();
            this.radbtn_female = new System.Windows.Forms.RadioButton();
            this.listbox_racers_amount = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtbox_time_7 = new System.Windows.Forms.TextBox();
            this.txtbox_time_8 = new System.Windows.Forms.TextBox();
            this.txtbox_time_6 = new System.Windows.Forms.TextBox();
            this.txtbox_time_5 = new System.Windows.Forms.TextBox();
            this.txtbox_time_3 = new System.Windows.Forms.TextBox();
            this.txtbox_time_4 = new System.Windows.Forms.TextBox();
            this.txtbox_time_2 = new System.Windows.Forms.TextBox();
            this.txtbox_time_1 = new System.Windows.Forms.TextBox();
            this.lbl_times = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_racers_amount = new System.Windows.Forms.Label();
            this.lbl_lanes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.lbl_lane_1 = new System.Windows.Forms.Label();
            this.lbl_lane_2 = new System.Windows.Forms.Label();
            this.lbl_lane_3 = new System.Windows.Forms.Label();
            this.lbl_lane_4 = new System.Windows.Forms.Label();
            this.lbl_lane_5 = new System.Windows.Forms.Label();
            this.lbl_lane_6 = new System.Windows.Forms.Label();
            this.lbl_lane_7 = new System.Windows.Forms.Label();
            this.lbl_lane_8 = new System.Windows.Forms.Label();
            this.lbl_sorted_times = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.lbl_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radbtn_male
            // 
            this.radbtn_male.AutoSize = true;
            this.radbtn_male.Location = new System.Drawing.Point(9, 49);
            this.radbtn_male.Name = "radbtn_male";
            this.radbtn_male.Size = new System.Drawing.Size(48, 17);
            this.radbtn_male.TabIndex = 1;
            this.radbtn_male.TabStop = true;
            this.radbtn_male.Text = "Male";
            this.radbtn_male.UseVisualStyleBackColor = true;
            this.radbtn_male.CheckedChanged += new System.EventHandler(this.radbtn_male_CheckedChanged_1);
            // 
            // radbtn_female
            // 
            this.radbtn_female.AutoSize = true;
            this.radbtn_female.Location = new System.Drawing.Point(9, 72);
            this.radbtn_female.Name = "radbtn_female";
            this.radbtn_female.Size = new System.Drawing.Size(59, 17);
            this.radbtn_female.TabIndex = 2;
            this.radbtn_female.TabStop = true;
            this.radbtn_female.Text = "Female";
            this.radbtn_female.UseVisualStyleBackColor = true;
            this.radbtn_female.CheckedChanged += new System.EventHandler(this.radbtn_female_CheckedChanged_1);
            // 
            // listbox_racers_amount
            // 
            this.listbox_racers_amount.Enabled = false;
            this.listbox_racers_amount.FormattingEnabled = true;
            this.listbox_racers_amount.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.listbox_racers_amount.Location = new System.Drawing.Point(9, 157);
            this.listbox_racers_amount.Name = "listbox_racers_amount";
            this.listbox_racers_amount.Size = new System.Drawing.Size(59, 69);
            this.listbox_racers_amount.TabIndex = 4;
            this.listbox_racers_amount.SelectedIndexChanged += new System.EventHandler(this.listbox_racers_amount_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-210, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-210, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(-210, 198);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 7;
            // 
            // txtbox_time_7
            // 
            this.txtbox_time_7.Enabled = false;
            this.txtbox_time_7.Location = new System.Drawing.Point(274, 205);
            this.txtbox_time_7.Name = "txtbox_time_7";
            this.txtbox_time_7.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_7.TabIndex = 18;
            // 
            // txtbox_time_8
            // 
            this.txtbox_time_8.Enabled = false;
            this.txtbox_time_8.Location = new System.Drawing.Point(274, 231);
            this.txtbox_time_8.Name = "txtbox_time_8";
            this.txtbox_time_8.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_8.TabIndex = 19;
            // 
            // txtbox_time_6
            // 
            this.txtbox_time_6.Enabled = false;
            this.txtbox_time_6.Location = new System.Drawing.Point(274, 179);
            this.txtbox_time_6.Name = "txtbox_time_6";
            this.txtbox_time_6.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_6.TabIndex = 17;
            // 
            // txtbox_time_5
            // 
            this.txtbox_time_5.Enabled = false;
            this.txtbox_time_5.Location = new System.Drawing.Point(274, 153);
            this.txtbox_time_5.Name = "txtbox_time_5";
            this.txtbox_time_5.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_5.TabIndex = 16;
            // 
            // txtbox_time_3
            // 
            this.txtbox_time_3.Enabled = false;
            this.txtbox_time_3.Location = new System.Drawing.Point(274, 101);
            this.txtbox_time_3.Name = "txtbox_time_3";
            this.txtbox_time_3.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_3.TabIndex = 14;
            // 
            // txtbox_time_4
            // 
            this.txtbox_time_4.Enabled = false;
            this.txtbox_time_4.Location = new System.Drawing.Point(274, 127);
            this.txtbox_time_4.Name = "txtbox_time_4";
            this.txtbox_time_4.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_4.TabIndex = 15;
            // 
            // txtbox_time_2
            // 
            this.txtbox_time_2.Enabled = false;
            this.txtbox_time_2.Location = new System.Drawing.Point(274, 75);
            this.txtbox_time_2.Name = "txtbox_time_2";
            this.txtbox_time_2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_2.TabIndex = 13;
            // 
            // txtbox_time_1
            // 
            this.txtbox_time_1.Enabled = false;
            this.txtbox_time_1.Location = new System.Drawing.Point(274, 49);
            this.txtbox_time_1.Name = "txtbox_time_1";
            this.txtbox_time_1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_1.TabIndex = 12;
            // 
            // lbl_times
            // 
            this.lbl_times.AutoSize = true;
            this.lbl_times.Location = new System.Drawing.Point(271, 32);
            this.lbl_times.Name = "lbl_times";
            this.lbl_times.Size = new System.Drawing.Size(87, 13);
            this.lbl_times.TabIndex = 21;
            this.lbl_times.Text = "Times (seconds):";
            // 
            // lbl_gender
            // 
            this.lbl_gender.Location = new System.Drawing.Point(6, 9);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(147, 37);
            this.lbl_gender.TabIndex = 22;
            this.lbl_gender.Text = "What is the sex of the people participating in the race?";
            // 
            // lbl_racers_amount
            // 
            this.lbl_racers_amount.Location = new System.Drawing.Point(6, 118);
            this.lbl_racers_amount.Name = "lbl_racers_amount";
            this.lbl_racers_amount.Size = new System.Drawing.Size(147, 36);
            this.lbl_racers_amount.TabIndex = 23;
            this.lbl_racers_amount.Text = "How many people are participating in the race?";
            // 
            // lbl_lanes
            // 
            this.lbl_lanes.AutoSize = true;
            this.lbl_lanes.Location = new System.Drawing.Point(187, 9);
            this.lbl_lanes.Name = "lbl_lanes";
            this.lbl_lanes.Size = new System.Drawing.Size(39, 13);
            this.lbl_lanes.TabIndex = 24;
            this.lbl_lanes.Text = "Lanes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "What time did they achieve?";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(9, 264);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(44, 35);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_lane_1
            // 
            this.lbl_lane_1.AutoSize = true;
            this.lbl_lane_1.Location = new System.Drawing.Point(187, 52);
            this.lbl_lane_1.Name = "lbl_lane_1";
            this.lbl_lane_1.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_1.TabIndex = 27;
            this.lbl_lane_1.Text = "Lane 1:";
            // 
            // lbl_lane_2
            // 
            this.lbl_lane_2.AutoSize = true;
            this.lbl_lane_2.Location = new System.Drawing.Point(187, 78);
            this.lbl_lane_2.Name = "lbl_lane_2";
            this.lbl_lane_2.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_2.TabIndex = 28;
            this.lbl_lane_2.Text = "Lane 2:";
            // 
            // lbl_lane_3
            // 
            this.lbl_lane_3.AutoSize = true;
            this.lbl_lane_3.Location = new System.Drawing.Point(187, 104);
            this.lbl_lane_3.Name = "lbl_lane_3";
            this.lbl_lane_3.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_3.TabIndex = 29;
            this.lbl_lane_3.Text = "Lane 3:";
            // 
            // lbl_lane_4
            // 
            this.lbl_lane_4.AutoSize = true;
            this.lbl_lane_4.Location = new System.Drawing.Point(187, 130);
            this.lbl_lane_4.Name = "lbl_lane_4";
            this.lbl_lane_4.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_4.TabIndex = 30;
            this.lbl_lane_4.Text = "Lane 4:";
            // 
            // lbl_lane_5
            // 
            this.lbl_lane_5.AutoSize = true;
            this.lbl_lane_5.Location = new System.Drawing.Point(187, 156);
            this.lbl_lane_5.Name = "lbl_lane_5";
            this.lbl_lane_5.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_5.TabIndex = 31;
            this.lbl_lane_5.Text = "Lane 5:";
            // 
            // lbl_lane_6
            // 
            this.lbl_lane_6.AutoSize = true;
            this.lbl_lane_6.Location = new System.Drawing.Point(187, 182);
            this.lbl_lane_6.Name = "lbl_lane_6";
            this.lbl_lane_6.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_6.TabIndex = 32;
            this.lbl_lane_6.Text = "Lane 6:";
            // 
            // lbl_lane_7
            // 
            this.lbl_lane_7.AutoSize = true;
            this.lbl_lane_7.Location = new System.Drawing.Point(187, 208);
            this.lbl_lane_7.Name = "lbl_lane_7";
            this.lbl_lane_7.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_7.TabIndex = 33;
            this.lbl_lane_7.Text = "Lane 7:";
            // 
            // lbl_lane_8
            // 
            this.lbl_lane_8.AutoSize = true;
            this.lbl_lane_8.Location = new System.Drawing.Point(187, 234);
            this.lbl_lane_8.Name = "lbl_lane_8";
            this.lbl_lane_8.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_8.TabIndex = 34;
            this.lbl_lane_8.Text = "Lane 8:";
            // 
            // lbl_sorted_times
            // 
            this.lbl_sorted_times.AutoSize = true;
            this.lbl_sorted_times.Location = new System.Drawing.Point(460, 9);
            this.lbl_sorted_times.Name = "lbl_sorted_times";
            this.lbl_sorted_times.Size = new System.Drawing.Size(64, 13);
            this.lbl_sorted_times.TabIndex = 35;
            this.lbl_sorted_times.Text = "A sorted list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Lane 8:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Lane 7:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Lane 6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Lane 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Lane 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Lane 3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Lane 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Lane 1:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(59, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 35);
            this.label10.TabIndex = 44;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(380, 229);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(48, 23);
            this.btn_sort.TabIndex = 45;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(597, 81);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(41, 13);
            this.lbl_test.TabIndex = 46;
            this.lbl_test.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 305);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_sorted_times);
            this.Controls.Add(this.lbl_lane_8);
            this.Controls.Add(this.lbl_lane_7);
            this.Controls.Add(this.lbl_lane_6);
            this.Controls.Add(this.lbl_lane_5);
            this.Controls.Add(this.lbl_lane_4);
            this.Controls.Add(this.lbl_lane_3);
            this.Controls.Add(this.lbl_lane_2);
            this.Controls.Add(this.lbl_lane_1);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_lanes);
            this.Controls.Add(this.lbl_racers_amount);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_times);
            this.Controls.Add(this.txtbox_time_7);
            this.Controls.Add(this.txtbox_time_8);
            this.Controls.Add(this.txtbox_time_6);
            this.Controls.Add(this.txtbox_time_5);
            this.Controls.Add(this.txtbox_time_3);
            this.Controls.Add(this.txtbox_time_4);
            this.Controls.Add(this.txtbox_time_2);
            this.Controls.Add(this.txtbox_time_1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.listbox_racers_amount);
            this.Controls.Add(this.radbtn_female);
            this.Controls.Add(this.radbtn_male);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radbtn_male;
        private System.Windows.Forms.RadioButton radbtn_female;
        private System.Windows.Forms.ListBox listbox_racers_amount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtbox_time_7;
        private System.Windows.Forms.TextBox txtbox_time_8;
        private System.Windows.Forms.TextBox txtbox_time_6;
        private System.Windows.Forms.TextBox txtbox_time_5;
        private System.Windows.Forms.TextBox txtbox_time_3;
        private System.Windows.Forms.TextBox txtbox_time_4;
        private System.Windows.Forms.TextBox txtbox_time_2;
        private System.Windows.Forms.TextBox txtbox_time_1;
        private System.Windows.Forms.Label lbl_times;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_racers_amount;
        private System.Windows.Forms.Label lbl_lanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lbl_lane_1;
        private System.Windows.Forms.Label lbl_lane_2;
        private System.Windows.Forms.Label lbl_lane_3;
        private System.Windows.Forms.Label lbl_lane_4;
        private System.Windows.Forms.Label lbl_lane_5;
        private System.Windows.Forms.Label lbl_lane_6;
        private System.Windows.Forms.Label lbl_lane_7;
        private System.Windows.Forms.Label lbl_lane_8;
        private System.Windows.Forms.Label lbl_sorted_times;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label lbl_test;
    }
}

