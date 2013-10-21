using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Work4
{
    class Grades
    {
        private string student;
        private string course;
        private string teacher;
        private string grade;

        public string getstudent() { return student; }
        public void setStudent(string student) { this.student = student; }

        public string getCourse() { return course; }
        public void setCourse(string course) { this.course = course; }

        public string getTeacher() { return teacher; }
        public void setTeacher(string teacher) { this.teacher = teacher; }

        public string getGrades() { return grade; }
        public void setGrades(string grade) { this.grade = grade; }

    }
}
