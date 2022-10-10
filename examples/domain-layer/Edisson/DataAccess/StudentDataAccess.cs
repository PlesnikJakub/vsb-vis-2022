using Edisson.Domain;
using Edisson.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edisson.DataAccess
{
    public class StudentDataAccess
    {
        public static StudentDomainModel GetStudent()
        {
            return new StudentDomainModel
            {
                Login = "PLE1234",
                Scores = new List<SubjectScore>()
                {
                    new SubjectScore
                    {
                        Name = "VIS",
                        Value = 51
                    },
                    new SubjectScore
                    {
                        Name = "OOP",
                        Value = 99
                    }
                }
            };
        }
    }
}
