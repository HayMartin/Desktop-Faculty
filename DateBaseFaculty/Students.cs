using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBaseFaculty
{
    public partial class Students : Form
    {
       

        public Students()
        {
            InitializeComponent();
        }

        CRUD crud = new CRUD();


        private void AddBtn_Click(object sender, EventArgs e)
        {
            crud.ID = int.Parse(txtBoxId.Text);
            crud.FirstName = FirstTxtBox.Text;
            crud.LastName = LastTxtBox.Text;
            crud.Age = int.Parse(AgeTxtBox.Text);
            crud.City = CitytxtBox.Text;
            crud.Address = AddressTxtBox.Text;
            crud.Phone = int.Parse(PhoneTxtBox.Text);




            bool succsess = crud.Insert(crud);
            if (succsess == true)
            {
                MessageBox.Show("New Student Succssesfuly Inserted");
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to add New Student.Try Again.");
            }
            DataTable dt = crud.Select();
            dataGridView1.DataSource = dt;

        }

        private void Students_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.Select();
            dataGridView1.DataSource = dt;
        }
        public void Clear()
        {

            txtBoxId.Text = " ";
            LastTxtBox.Text = "";
            FirstTxtBox.Text = "";
            AgeTxtBox.Text = "";
            AddressTxtBox.Text = "";
            CitytxtBox.Text = "";
            PhoneTxtBox.Text = "";


        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            crud.ID = int.Parse(txtBoxId.Text);
            crud.LastName = LastTxtBox.Text;
            crud.FirstName = FirstTxtBox.Text;
            crud.Age = int.Parse(AgeTxtBox.Text);
            crud.City = CitytxtBox.Text;
            crud.Address = AddressTxtBox.Text;
            crud.Phone = int.Parse(PhoneTxtBox.Text);

            bool success = crud.Update(crud);
            if (success == true)
            {
                MessageBox.Show("Student has been successefully Updated.");
                DataTable dt = crud.Select();
                dataGridView1.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed Update Student.Please Try Again.");

            }
        }



        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {

            bool success = crud.Delete(crud);
            if (success == true)
            {
                MessageBox.Show("Student is Successefuly deleted.");
                DataTable dt = crud.Select();
                dataGridView1.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Deleted Student.Please try again.");
            }
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBoxId.Text= dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            LastTxtBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            FirstTxtBox.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            AgeTxtBox.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            CitytxtBox.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            AddressTxtBox.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            PhoneTxtBox.Text= dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();


        }

        public void RadioBtnStudent_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
              if (radioButton.Checked)
              {
                TrueOrFalse.f = true;
              }        
           
        }

        private void RadioBtnTeacher_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                TrueOrFalse.f = false;
            }
        }
    }

}

