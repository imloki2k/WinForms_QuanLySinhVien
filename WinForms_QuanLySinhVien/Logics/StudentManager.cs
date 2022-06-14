using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_QuanLySinhVien.Data_Access;

namespace WinForms_QuanLySinhVien.Logics
{
    class StudentManager
    {
        public static void saveToFile(string FileName, List<Student> students)
        {
            FileIO file = new FileIO(FileName);
            file.WriteToFile(students);
        }

        public static void readFromFile(string FileName, DataGridView dg, List<Student> students)
        {
            FileIO file = new FileIO(FileName);
            file.LoadToDataGridView(dg,students);
        }



    }
}
