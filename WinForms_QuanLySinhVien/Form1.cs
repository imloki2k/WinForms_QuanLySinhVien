using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_QuanLySinhVien.Logics;

namespace WinForms_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }


        private Student GetStudentInfo()
        {
            try
            {
                Student s = new Student(
                    Convert.ToInt32(tbID.Text),
                    tbName.Text.Trim(),
                    rbMale.Checked,
                    dtpDOB.Value,
                    cbMajor.SelectedItem.ToString(),
                    (int)nudSchoolarship.Value,
                    cbActive.Checked);
                return s;

            }catch(FormatException)
            {
                MessageBox.Show("Id phai la so nguyen");
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] majors = {"SE","IA","GD" };
            cbMajor.DataSource = majors;
            dtpDOB.Value = new DateTime(DateTime.Now.Year - 18, 1, 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = GetStudentInfo();
            if(student != null)
            {
                /*if(dataGridView1 != null)
                {
                    dataGridView1.Rows.Add(student);
                }*/
                students.Add(student);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"Documents:\";
            dialog.DefaultExt = "txt";
            dialog.Filter = "Text file|*.txt|Csharp File|*.cs";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StudentManager.saveToFile(dialog.FileName, students);
                MessageBox.Show("Ghi du lieu thanh cong");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"Documents:\";
            dialog.DefaultExt = "txt";
            dialog.Filter = "Text file|*.txt|Csharp File|*.cs";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                StudentManager.readFromFile(dialog.FileName, dataGridView1,students);
                MessageBox.Show("Mo file thanh cong");
            }
            tbLink.Text = dialog.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = tbLink.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StudentManager.saveToFile(dialog.FileName, students);
                MessageBox.Show("Ghi du lieu thanh cong");
            }
        }
    }
}
