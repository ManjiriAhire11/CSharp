using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a.Create an Interface named IContractEmployee with one method declaration  CalculateSalary(int hour, int perHourRupees)
//  b.Create a class Named Infosys which impliments IContractEmployee
//c. Impliment function CalculateSalary such that salary is hour * PerHourRupees



namespace Assignment_14
{
    class Program
    {

       
            public interface IContractEmp
            {
                void CalculateSalary(int hour, int perHourRs);
            }

            public class Infosys : InfosysBase, IContractEmp
            {
                int salary;

                public void CalculateSalary(int hour, int perHourRs)
                {
                    int hr, rup;
                    hr = hour;
                    rup = perHourRs;

                    salary = hr * rup;

                    Console.WriteLine("salary is : " + salary);
                    Console.ReadLine();

            }
        }
    }



















































}