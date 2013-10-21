using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class course
    {
        private List<string> Teachers;
        private List<string> Student;

        public void courseAddTeachers(string Teacher)
        {
            Teachers.Add(Teacher);
        }
        public void courseAddStudents(String student)
        {
            Student.Add(student);
        }
        public void gradesByTeacher(student student, teacher teacher, string grade, Grades Course)
        {
            Course = new Grades();
            Course.setGrades(grade);
            Course.setTeacher(teacher.getname());
            Course.setStudent(student.getname());
            student.grades.Add(Course);
   
        }
    }
}
