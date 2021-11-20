
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
            this.btn_toggle_dark_mode = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btn_toggle_dark_mode
            // 
            this.btn_toggle_dark_mode.Location = new System.Drawing.Point(9, 266);
            this.btn_toggle_dark_mode.Name = "btn_toggle_dark_mode";
            this.btn_toggle_dark_mode.Size = new System.Drawing.Size(75, 34);
            this.btn_toggle_dark_mode.TabIndex = 0;
            this.btn_toggle_dark_mode.Text = "Toggle Dark Mode";
            this.btn_toggle_dark_mode.UseVisualStyleBackColor = true;
            this.btn_toggle_dark_mode.Click += new System.EventHandler(this.btn_toggle_dark_mode_Click);
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
            // 
            // listbox_racers_amount
            // 
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
            this.txtbox_time_7.Location = new System.Drawing.Point(313, 205);
            this.txtbox_time_7.Name = "txtbox_time_7";
            this.txtbox_time_7.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_7.TabIndex = 18;
            // 
            // txtbox_time_8
            // 
            this.txtbox_time_8.Location = new System.Drawing.Point(313, 231);
            this.txtbox_time_8.Name = "txtbox_time_8";
            this.txtbox_time_8.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_8.TabIndex = 19;
            // 
            // txtbox_time_6
            // 
            this.txtbox_time_6.Location = new System.Drawing.Point(313, 179);
            this.txtbox_time_6.Name = "txtbox_time_6";
            this.txtbox_time_6.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_6.TabIndex = 17;
            // 
            // txtbox_time_5
            // 
            this.txtbox_time_5.Location = new System.Drawing.Point(313, 153);
            this.txtbox_time_5.Name = "txtbox_time_5";
            this.txtbox_time_5.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_5.TabIndex = 16;
            // 
            // txtbox_time_3
            // 
            this.txtbox_time_3.Location = new System.Drawing.Point(313, 101);
            this.txtbox_time_3.Name = "txtbox_time_3";
            this.txtbox_time_3.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_3.TabIndex = 14;
            // 
            // txtbox_time_4
            // 
            this.txtbox_time_4.Location = new System.Drawing.Point(313, 127);
            this.txtbox_time_4.Name = "txtbox_time_4";
            this.txtbox_time_4.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_4.TabIndex = 15;
            // 
            // txtbox_time_2
            // 
            this.txtbox_time_2.Location = new System.Drawing.Point(313, 75);
            this.txtbox_time_2.Name = "txtbox_time_2";
            this.txtbox_time_2.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_2.TabIndex = 13;
            // 
            // txtbox_time_1
            // 
            this.txtbox_time_1.Location = new System.Drawing.Point(313, 49);
            this.txtbox_time_1.Name = "txtbox_time_1";
            this.txtbox_time_1.Size = new System.Drawing.Size(100, 20);
            this.txtbox_time_1.TabIndex = 12;
            // 
            // lbl_times
            // 
            this.lbl_times.AutoSize = true;
            this.lbl_times.Location = new System.Drawing.Point(310, 32);
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
            this.lbl_lanes.Location = new System.Drawing.Point(226, 9);
            this.lbl_lanes.Name = "lbl_lanes";
            this.lbl_lanes.Size = new System.Drawing.Size(39, 13);
            this.lbl_lanes.TabIndex = 24;
            this.lbl_lanes.Text = "Lanes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "What time did they achieve?";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(90, 277);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(44, 23);
            this.btn_help.TabIndex = 26;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lbl_lane_1
            // 
            this.lbl_lane_1.AutoSize = true;
            this.lbl_lane_1.Location = new System.Drawing.Point(226, 52);
            this.lbl_lane_1.Name = "lbl_lane_1";
            this.lbl_lane_1.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_1.TabIndex = 27;
            this.lbl_lane_1.Text = "Lane 1:";
            // 
            // lbl_lane_2
            // 
            this.lbl_lane_2.AutoSize = true;
            this.lbl_lane_2.Location = new System.Drawing.Point(226, 78);
            this.lbl_lane_2.Name = "lbl_lane_2";
            this.lbl_lane_2.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_2.TabIndex = 28;
            this.lbl_lane_2.Text = "Lane 2:";
            // 
            // lbl_lane_3
            // 
            this.lbl_lane_3.AutoSize = true;
            this.lbl_lane_3.Location = new System.Drawing.Point(226, 104);
            this.lbl_lane_3.Name = "lbl_lane_3";
            this.lbl_lane_3.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_3.TabIndex = 29;
            this.lbl_lane_3.Text = "Lane 3:";
            // 
            // lbl_lane_4
            // 
            this.lbl_lane_4.AutoSize = true;
            this.lbl_lane_4.Location = new System.Drawing.Point(226, 130);
            this.lbl_lane_4.Name = "lbl_lane_4";
            this.lbl_lane_4.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_4.TabIndex = 30;
            this.lbl_lane_4.Text = "Lane 4:";
            // 
            // lbl_lane_5
            // 
            this.lbl_lane_5.AutoSize = true;
            this.lbl_lane_5.Location = new System.Drawing.Point(226, 156);
            this.lbl_lane_5.Name = "lbl_lane_5";
            this.lbl_lane_5.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_5.TabIndex = 31;
            this.lbl_lane_5.Text = "Lane 5:";
            // 
            // lbl_lane_6
            // 
            this.lbl_lane_6.AutoSize = true;
            this.lbl_lane_6.Location = new System.Drawing.Point(226, 182);
            this.lbl_lane_6.Name = "lbl_lane_6";
            this.lbl_lane_6.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_6.TabIndex = 32;
            this.lbl_lane_6.Text = "Lane 6:";
            // 
            // lbl_lane_7
            // 
            this.lbl_lane_7.AutoSize = true;
            this.lbl_lane_7.Location = new System.Drawing.Point(226, 208);
            this.lbl_lane_7.Name = "lbl_lane_7";
            this.lbl_lane_7.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_7.TabIndex = 33;
            this.lbl_lane_7.Text = "Lane 7:";
            // 
            // lbl_lane_8
            // 
            this.lbl_lane_8.AutoSize = true;
            this.lbl_lane_8.Location = new System.Drawing.Point(226, 234);
            this.lbl_lane_8.Name = "lbl_lane_8";
            this.lbl_lane_8.Size = new System.Drawing.Size(43, 13);
            this.lbl_lane_8.TabIndex = 34;
            this.lbl_lane_8.Text = "Lane 8:";
            // 
            // lbl_sorted_times
            // 
            this.lbl_sorted_times.AutoSize = true;
            this.lbl_sorted_times.Location = new System.Drawing.Point(499, 9);
            this.lbl_sorted_times.Name = "lbl_sorted_times";
            this.lbl_sorted_times.Size = new System.Drawing.Size(64, 13);
            this.lbl_sorted_times.TabIndex = 35;
            this.lbl_sorted_times.Text = "A sorted list:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(741, 311);
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
            this.Controls.Add(this.btn_toggle_dark_mode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_toggle_dark_mode;
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
    }
}

