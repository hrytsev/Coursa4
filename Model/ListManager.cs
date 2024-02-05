using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова.Model
{
    internal static class ListManager
    {
        private static List<Employee> employeeList = new List<Employee>();
        private static List<Supervisor> supervisorList = new List<Supervisor>();

        public static void addNewEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
        public static void addNewSupervisor(Supervisor supervisor)
        {
            supervisorList.Add(supervisor);
        }
        public static void removeEmployeeAt(int index)
        {
            if (index < 0 || index >= employeeList.Count)
                return;
            employeeList.RemoveAt(index);
        }
        public static void removeSupervisorAt(int index)
        {
            if (index < 0 || index  >= supervisorList.Count)
                return;
            supervisorList.RemoveAt(index);
        }
    }
}
