using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP.Task1

{
    public class Student: IStudentGrade
    {
        public string Name { get; set; }
        private IStudentGrade studentGrade { get; }

        public Student(string name, List<Evaluation> results, bool isEngineeringStudent)
        {
            Name = name;
            studentGrade = GetStudentGrade(results, isEngineeringStudent);
        }

        public double Evaluate()
        {
            return studentGrade.Evaluate();
        }

        private IStudentGrade GetStudentGrade(List<Evaluation> results, bool isEngineeringStudent)
        {
            return isEngineeringStudent ? new EngineerStudentGrade(results) : new ArtStudentGrade(results);
        }

        
    }
}
