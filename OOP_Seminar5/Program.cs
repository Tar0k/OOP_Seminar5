// See https://aka.ms/new-console-template for more information

using OOP_Seminar5.Controller;
using OOP_Seminar5.Data;

var random = new Random();

var controller = new GroupController();

var students = new List<Student>();
for (var i = 0; i < 10; i++)
{
    students.Add(new Student(studentId: random.Next(1, 99999),
        firstName: Faker.Name.First(),
        secondName: Faker.Name.Last(),
        patronymic: Faker.Name.Middle(),
        dateOfBirth: DateOnly.FromDateTime(Faker.Identification.DateOfBirth())));
}

var teacher = new Teacher(teacherId: random.Next(1, 99999),
    firstName: Faker.Name.First(),
    secondName: Faker.Name.Last(),
    patronymic: Faker.Name.Middle(),
    dateOfBirth: DateOnly.FromDateTime(Faker.Identification.DateOfBirth()));

controller.CreateGroup(teacher, students);
controller.GetPeopleId();

    