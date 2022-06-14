using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Parse("1/1/2004");
            comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        public void loadStudent()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Major");
            dt.Columns.Add("DOB");
            dt.Columns.Add("Schoolarship");
            dt.Columns.Add("Active");
            foreach (Student student in students)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = student.Id;
                dr["Name"] = student.Name;
                dr["Gender"] = student.Gender;
                dr["Major"] = student.Major;
            }
            
            
        }

        

    }
}
