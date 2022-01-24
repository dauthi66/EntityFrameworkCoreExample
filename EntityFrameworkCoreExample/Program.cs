
using EntityFrameworkCoreExample;
//create your database object to handle connection to the DB
//using statement so that connection will be cleaned up in memory
using StudentContext dbContext = new();

//Add with EF Core
Student s1 = new()
{
    FullName = "Philip J. Fry",
    EmailAddress = "pizzakid@hotmail.com",
    DateOfBirth = new DateTime(1974,2,3)
};

dbContext.Students.Add(s1); //prepare student insert statement

Student s2 = new()
{
    FullName = "Dr. John A. Zoidberg",
    EmailAddress = "arealdoctor@.yahoo.com",
    DateOfBirth = new DateTime(2970, 5, 24)
};

dbContext.Students.Add(s2); //prepare student insert statement
dbContext.SaveChanges(); //executes pending prepared insert(update or delete) statements

//Retrieve Students from DB using method syntax
List<Student> allStudents = dbContext.Students.ToList();
//using query syntax
//allStudents = (from stu in dbContext.Students
//               select stu).ToList();
foreach (Student student in allStudents)
{
    Console.WriteLine($"{student.FullName} \n email address: {student.EmailAddress} \n Date of Birth: {student.DateOfBirth}");
}