using System;
using Курсова.Model;

internal class Supervisor : Employee
{
    public Supervisor(string _name, DateTime _birthday, int _id, float _rate) : base(_name, _birthday, _id, _rate)
    {
    }

    public void removeEmployeeAt(int index)
    {
        ListManager.removeEmployeeAt(index);
    }
    public void removeSupervisorAt(int index)
    {
        ListManager.removeSupervisorAt(index);
    }
    public void crеateAndAddNewEmployee(string _name, DateTime _birthday, int _id, float _rate)
    {
        Employee NewEmployee = new Employee(_name, _birthday, _id, _rate);
        ListManager.addNewEmployee(NewEmployee);
    }
    public void crеateAndAddNewSupervisor(string _name, DateTime _birthday, int _id, float _rate)
    {
        Supervisor NewSupervisor = new Supervisor(_name, _birthday, _id, _rate);
        ListManager.addNewSupervisor(NewSupervisor);
    }
}