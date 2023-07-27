using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Task1
{
    public class ArtStudentGrade : IStudentGrade
    {
        public List<Evaluation> Results { get; set; }
        public ArtStudentGrade(List<Evaluation> results) { Results = results; }
        public double Evaluate()
        {
            return Math.Round(Results.Average(x => x.Project * ((x.Homeworks > 10) ? 0.60 : 0.40) + x.Exam), 1);
        }
    }
}
