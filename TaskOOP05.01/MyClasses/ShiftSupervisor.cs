// // +Класс ShiftSupervisor. На некой фабрике начальник смены является штатным
// // +сотрудником, который руководит сменой. В дополнение к фиксированному
// // +окладу начальник смены получает годовую премию за выполнение его сменой
// // +производственного плана. 
// // +Напишите класс ShiftSupervisor (Начальник смены),
// // +который является подклассом класса Ernployee, созданного в задаче по
// // программированию 1. Класс ShiftSupervisor должен содержать атрибут данных для
// // годового оклада и атрибут данных для годовой производственной премии,
// // которую заработал начальник смены. Продемонстрируйте класс, написав
// // программу, которая применяет объект ShiftSupervisor.

using EmployeeWork;
namespace ShiftSupervisorWork;

public class ShiftSupervisor : Employee
{

    public int PayOfYear;

    public int ProcOfYear;
    public ShiftSupervisor(string name, int id, int payofyear, int procofyear)
    {
        Name = name;
        Id = id;
        PayOfYear = payofyear;
        ProcOfYear = procofyear;
    }

    public void ItogPremy()
    {
        int itogprem = PayOfYear * ProcOfYear / 100;
        System.Console.WriteLine($"{Id}, {Name}, {itogprem}");
    }

}