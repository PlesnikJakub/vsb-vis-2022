// IS Edisson

using Edisson.DataAccess;
using Edisson.Domain;
using Edisson.Domain.TransactionScript;

Console.WriteLine("Hello, World!");

// Login Transaction Script
var name = Console.ReadLine();
var password = Console.ReadLine();
var loginscript = new LoginTransactionScript();
var isSuccess = loginscript.Login(name, password);

// Domain Model

if(isSuccess)
{
    Console.WriteLine("login succesfull");
}
else
{
    Console.WriteLine("Incorrect password");
}

// Direct use of Domain model
var student = StudentDataAccess.GetStudent();
student.HasScholarship();
// Since I have model I can do anything
student.Login = "sdfsdf";

// Student Service
var service = new StudentService();
service.VerifyStudentHasScholarship("PLE1234");