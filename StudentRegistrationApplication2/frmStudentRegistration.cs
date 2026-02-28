using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            
            string gender = radioMale.Checked ? "Male" : "Female";

            
            string dateOfBirth = $"{comboMonth.SelectedItem}/{comboDay.SelectedItem}/{comboYear.SelectedItem}";

            
            string message =
                $"Student name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of birth: {dateOfBirth}";

            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

     

            private void Form1_Load(object sender, EventArgs e)
            {
                
                for (int day = 1; day <= 31; day++)
                {
                    comboDay.Items.Add(day);
                }

               
                for (int month = 1; month <= 12; month++)
                {
                    comboMonth.Items.Add(month);
                }


            for (int year = 1950; year <= DateTime.Now.Year; year++)
            {
                comboYear.Items.Add(year);
            }
        }

    }
}

