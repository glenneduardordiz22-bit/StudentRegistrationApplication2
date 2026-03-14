using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication2
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string lastName = textLastName.Text;
            string firstName = textFirstName.Text;
            string middleName = textMiddleName.Text;
            string programs = comboP.SelectedItem.ToString();

            string gender = radioMale.Checked ? "Male" : "Female";


            string dateOfBirth = $"{comboMonth.SelectedItem}/{comboDay.SelectedItem}/{comboYear.SelectedItem}";


            string message =
                $"Student name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of birth: {dateOfBirth}\n" +
                $"Program: {programs}";
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            for (int day = 1; day <= 31; day++)
            {
                comboDay.Items.Add(day);
            }


            string[] months = {
            "January","February","March","April","May","June",
            "July","August","September","October","November","December"
};
            foreach (string mName in months)
                comboMonth.Items.Add(mName);


            for (int year = 1950; year <= DateTime.Now.Year; year++)
            {
                comboYear.Items.Add(year);
            }


         ArrayList programs = new ArrayList
{
           "Bachelor of Science in Computer Science",
           "Bachelor of Science in Information Technology",
           "Bachelor of Science in Information Systems",
           "Bachelor of Science in Computer Engineering"
};

           
            foreach (string p in programs)
            {
                comboP.Items.Add(p);
            }








        }
    }
}