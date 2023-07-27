using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Task1
{
    public class EngineerStudentGrade : IStudentGrade
    {
        public List<Evaluation> Results { get; set; }
        public EngineerStudentGrade(List<Evaluation> results) { Results = results; }
        
        public double Evaluate()
        {
            return Math.Round(Results.Average(x => x.Exam * 0.50 + x.Homeworks * 0.20 + x.Project * 0.30), 1);
        }
        
    }
}
