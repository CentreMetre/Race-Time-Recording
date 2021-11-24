using System;
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

        //array for input boxes names
        String[] input_box_names = { "txtbox_time_1", "txtbox_time_2", "txtbox_time_3", "txtbox_time_4", "txtbox_time_5", "txtbox_time_6", "txtbox_time_7", "txtbox_time_8" };
        /*for (int i = 0; i <= 7; i++)
        {
            int j = i + 1;
            input_box_names[i] = "txtbox_time_" + j;
        }*/

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //string input_box_name_array = "txtbox_time_";
            //bool dark_mode_enabled = false;
            lbl_test.Text = input_box_names[1];
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
            //trying to enbale them using arryas, not worked
            /*for (int i = 0; i <= Convert.ToInt32(listbox_racers_amount.SelectedItem); i++)
            {
                int j = i + 1;
                input_box_names[i] = "txtbox_time_" + j + ".Enabled";



            }*/
            //lbl_test.Text = listbox_racers_amount.SelectedItem;

            //hard coding it :(
            int racers_amount = Convert.ToInt32(listbox_racers_amount.SelectedItem);
            if (racers_amount == 4)
            {
                txtbox_time_1.Enabled = true;
                txtbox_time_2.Enabled = true;
                txtbox_time_3.Enabled = true;
                txtbox_time_4.Enabled = true;

                //disabling
                txtbox_time_5.Enabled = false;
                txtbox_time_6.Enabled = false;
                txtbox_time_7.Enabled = false;
                txtbox_time_8.Enabled = false;
            }
            else if (racers_amount == 5)
            {
                txtbox_time_1.Enabled = true;
                txtbox_time_2.Enabled = true;
                txtbox_time_3.Enabled = true;
                txtbox_time_4.Enabled = true;
                txtbox_time_5.Enabled = true;

                //disabling
                txtbox_time_6.Enabled = false;
                txtbox_time_7.Enabled = false;
                txtbox_time_8.Enabled = false;
            }
            else if (racers_amount == 6)
            {
                txtbox_time_1.Enabled = true;
                txtbox_time_2.Enabled = true;
                txtbox_time_3.Enabled = true;
                txtbox_time_4.Enabled = true;
                txtbox_time_5.Enabled = true;
                txtbox_time_6.Enabled = true;

                //disabling
                txtbox_time_7.Enabled = false;
                txtbox_time_8.Enabled = false;
            }
            else if (racers_amount == 7)
            {
                txtbox_time_1.Enabled = true;
                txtbox_time_2.Enabled = true;
                txtbox_time_3.Enabled = true;
                txtbox_time_4.Enabled = true;
                txtbox_time_5.Enabled = true;
                txtbox_time_6.Enabled = true;
                txtbox_time_7.Enabled = true;

                //disabling
                txtbox_time_8.Enabled = false;
            }
            else if (racers_amount == 8)
            {
                txtbox_time_1.Enabled = true;
                txtbox_time_2.Enabled = true;
                txtbox_time_3.Enabled = true;
                txtbox_time_4.Enabled = true;
                txtbox_time_5.Enabled = true;
                txtbox_time_6.Enabled = true;
                txtbox_time_7.Enabled = true;
                txtbox_time_8.Enabled = true;
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //Chose the sex of the racers and how many racers there are. Then input their time in the corrosponing lane input box. Then press the 'sort' button.

            if (help_enabled == false)
            {

            }

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (radbtn_male.Checked == true)
            {
                bool racer_is_male = true;
            }
            else
            {
                bool racer_is_male = false;
            }
            /*
            for (int i = 0; i < listbox_racers_amount.SelectedIndex; i++)
            {
                txtbox_time_i = txtbox_time_1 + i;
            }*/ // was for not allowing inputs on boxes th user didnt want, not sure how to do it 

            Array[] input_box_names = new Array[8];
        }

        private void radbtn_female_CheckedChanged_1(object sender, EventArgs e)
        {
            listbox_racers_amount.Enabled = true;
        }

        private void radbtn_male_CheckedChanged_1(object sender, EventArgs e)
        {
            listbox_racers_amount.Enabled = true;
        }
    }
}
