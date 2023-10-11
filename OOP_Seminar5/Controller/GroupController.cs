using OOP_Seminar5.Data;
using OOP_Seminar5.Service;

namespace OOP_Seminar5.Controller;

public class GroupController
{
    private StudentGroupService _groupService;


    public void CreateGroup(Teacher teacher, List<Student> students)
    {
        _groupService = new StudentGroupService(teacher, students);
    }

    public void GetPeopleId()
    {
        foreach (var record in _groupService.PeopleId())
        {
            Console.WriteLine($"{record.Key}: {string.Join(" ", record.Value)}");
        }
    }

}