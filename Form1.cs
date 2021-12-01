using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Time_Recording_Branch
{
    public partial class Form1 : Form
    {
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

        bool racersAreMale;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLockIn_Click(object sender, EventArgs e)
        {
            lblErrorOutput.Text = "";
            if (radBtnFemale.Checked == true || radBtnMale.Checked == true)
                if (listBoxRacersAmount.SelectedIndex != -1)
                {
                //locking the first inputs
                radBtnFemale.Enabled = false;
                radBtnMale.Enabled = false;
                listBoxRacersAmount.Enabled = false;
                btnLockIn.Enabled = false;

                //enabling some controls
                dgvMain.Enabled = true;
                btnReset.Enabled = true;

                //adding rows using iteration
                DataTable dataTable = new DataTable();
                for (int i = 0; i < Convert.ToInt32(listBoxRacersAmount.SelectedItem); i++)
                    {
                        //var row = dataTable.NewRow();
                        dgvMain.Rows.Add(dataTable.NewRow());
                    }
                }
                else
                {
                    lblErrorOutput.Text = "Please select a racers amount.";
                }
            else
            {
                lblErrorOutput.Text = "Please select a gender.";
            }



            //assigning values to variables

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //enabling those controls again#
            //enbaling radio buttons
            radBtnFemale.Enabled = true;
            radBtnMale.Enabled = true;
            //unchecking radio buttons
            radBtnFemale.Checked = false;
            radBtnMale.Checked = false;

            //enabling listbox
            listBoxRacersAmount.Enabled = true;
            //clearing listbox selected item
            listBoxRacersAmount.SelectionMode = SelectionMode.None;
            listBoxRacersAmount.SelectionMode = SelectionMode.One;
            
            //enabling the lock in button
            btnLockIn.Enabled = true;


            //disabling the reset button and datagridview
            dgvMain.Enabled = false;
            btnReset.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listBoxRacersAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblErrorOutput.Text = Convert.ToString(listBoxRacersAmount.SelectedIndex);
        }

        private void dgvMain_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            /*int racerAmount = Convert.ToInt32(listBoxRacersAmount.SelectedItem);
            lblErrorOutput.Text = "Row added";
            if (dgvMain.Rows.Count == racerAmount + 1)

            {
                dgvMain.AllowUserToAddRows = false;
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
