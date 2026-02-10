// See https://aka.ms/new-console-template for more information
using classMap.Entities;

Console.WriteLine("Hello, World!");


var teacher = new Teacher();
teacher.Salary = 1500000;
teacher.Name = "Yoel";
teacher.LastName = "Lebron";
teacher.Subject = "Math";
teacher.DisplayInfo();

//------
var student = new Student();
student.Carreer = "Software";
student.SutendSerial = 20250051;
student.Average = 95.7;
student.Name = "Jhon Does";
student.DisplayInfo();

//--
var exStudent = new ExStudent();
exStudent.Name = "Maria";
exStudent.Carreer = "Math";
exStudent.SutendSerial = 2012001;
exStudent.Average = 91.6;
exStudent.LastName = "Garcia";
exStudent.DisplayInfo();

//--
var administrator = new Administrator();
administrator.Department = "Academic Managment";
administrator.Name = "Lia";
administrator.LastName = "Jhan";
administrator.Salary = 25000;
administrator.DisplayInfo();


