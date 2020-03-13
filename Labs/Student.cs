using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Student
    {
        public string fio { get; set; }
        public string group { get; set; }
        public double averageMark { get; set; }
        public double salary { get; set; }

        public Student() { }
        public Student(string fio, string group, double averageMark, double salary)
        {
            this.fio = fio;
            this.group = group;
            this.averageMark = averageMark;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "FIO: " + this.fio +
                                   "\nGroup: " + this.group +
                                   "\nAverage Mark: " + this.averageMark +
                                   "\nSalary: " + this.salary + "\n";
        }

    }
    class Students
    {
        public List<Student> students;
        public List<Student> lessDoubleMinSalaryStudents;
        public List<Student> moreDoubleMinSalaryStudents;
        public int minSalary = 50;

        public Students() { }
        public Students(List<Student> students)
        {
            this.students = students;
            this.lessDoubleMinSalaryStudents = new List<Student>();
            this.moreDoubleMinSalaryStudents = new List<Student>();
            InitilizeLists();
        }

        private void InitilizeLists()
        {
            foreach (Student item in students)
            {   
                if(item.salary < minSalary * 2)
                {
                    lessDoubleMinSalaryStudents.Add(item);
                }
                else
                {
                    moreDoubleMinSalaryStudents.Add(item);
                }
            }
        }

        public void CreateResList()
        {
            moreDoubleMinSalaryStudents.Sort((s1, s2) => 
            {
                return s2.averageMark.CompareTo(s1.averageMark);
            });
            
        }

        public void PrintList()
        {
            List<Student> resList = lessDoubleMinSalaryStudents.Concat(moreDoubleMinSalaryStudents).ToList();
            foreach (Student item in resList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
