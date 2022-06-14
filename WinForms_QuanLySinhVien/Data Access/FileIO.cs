using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinForms_QuanLySinhVien.Data_Access
{
    class FileIO
    {
        private string filename;

        public FileIO(string filename)
        {
            this.filename = filename;
        }

        public void WriteToFile(List<Student> students)
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (Student s in students)
            {
                writer.WriteLine($"{s.Id}|{s.Name}|{s.Gender}|{s.DOB.ToShortDateString()}|{s.Major}|{s.Schoolarship}|{s.Active}");
            }
            writer.Close();
        }

        public void LoadToDataGridView(DataGridView dg, List<Student> students)
        {
            students.Clear();
            String[] lines = File.ReadAllLines(filename);
            foreach(String line in lines)
            {
                String[] data = line.Split('|');
                Student s = new Student(
                    Convert.ToInt32(data[0]),
                    data[1],
                    bool.Parse(data[2]),
                    DateTime.Parse(data[3]),
                    data[4],
                    Convert.ToInt32(data[5]),
                    bool.Parse(data[6]));
                students.Add(s);
            }
            dg.DataSource = students;
        }
       
    }
}
