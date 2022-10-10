namespace Edisson.Domain.Domain
{
    public class StudentDomainModel
    {
        public string Login { get; set; }

        public List<SubjectScore> Scores { get; set; }

        public bool HasScholarship()
        {
            var sum = 0;
            var min = 100;
            foreach (var score in Scores)
            {
                sum += score.Value;

                if(score.Value < min)
                {
                    min = score.Value;
                }
            }

            var average = sum / Scores.Count;

            return average > 90 && min > 80;
        }
    }
}
