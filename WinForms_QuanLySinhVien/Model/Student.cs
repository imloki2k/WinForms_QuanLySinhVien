using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_QuanLySinhVien
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Boolean Gender { get; set; }

        public String Major { get; set; }

        public DateTime DOB { get; set; }

        public decimal Schoolarship { get; set; }

        public Boolean Active { get; set; }

        public Student(int id, string name, bool gender, DateTime dOB, string major, decimal schoolarship, bool active)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Major = major;
            DOB = dOB;
            Schoolarship = schoolarship;
            Active = active;
        }


    }
}
