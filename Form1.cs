﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_App
{
    public partial class Form1 : Form
    {
        //dark mode button boolean to ahck if darkmode is on or not
        bool dark_mode_enabled = false;

        //help button boolean to be able to hide the help text
        bool help_enabled = false;

        //Storing Records
        //Mens records
        double men_wr = 9.58;
        double men_eu = 9.86;
        double men_gb = 9.87;

        //Womens records
        double women_wr = 10.49;
        double women_eu = 10.73;
        double women_gb = 10.99;
        //Minimum racers = 4
        //Maximum racers = 8

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //bool dark_mode_enabled = false;

        }

        private void lbl_output_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_input_TextChanged(object sender, EventArgs e)
        {
            //lbl_output.Text = txtbox_input.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_toggle_dark_mode_Click(object sender, EventArgs e)
        {
            if (dark_mode_enabled == false) //false means light mode is on
            {
                dark_mode_enabled = true;

            }
        }

        private void listbox_racers_amount_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*for (int i = 0; i < )
            {

            }*/
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            if (help_enabled == false)
            {

            }

        }
    }
}
