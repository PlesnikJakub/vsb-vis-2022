using Edisson.DataAccess;

namespace Edisson.Domain
{
    public class StudentService
    {
        public bool VerifyStudentHasScholarship(string login)
        {
            var student = StudentDataAccess.GetStudent();
            return student.HasScholarship();
        }
    }
}
