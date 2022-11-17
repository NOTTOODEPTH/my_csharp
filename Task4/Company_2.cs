using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Company_2
    {
        public Company_2()
        {
            Console.Write("\nCompany name: ");
            Name = Checks.StrCheck();
            Console.Write("Company location: ");
            Location = Checks.StrCheck();
            Console.Write("Number of vacancies: ");
            CountVacancy = Checks.CheckByte();
            Console.Write("Age limit for applying for a job: ");
            NeedAge = Checks.CheckByte();
        }

        public string? Name { get; set; }
        public byte CountMembers { get; set; }
        public byte CountVacancy { get; set; }
        public string? Location { get; set; }
        public byte needAge = 35;
        public byte NeedAge
        {
            get { return needAge; }
            set
            {

                if (value > 65)
                {
                    needAge = 65;
                    Console.WriteLine("\nWe do not need employees over 65!");
                }
                else if (value < 18)
                {
                    needAge = 18;
                    Console.WriteLine("\nWe do not need employees under 18!");
                }
                else
                {
                    needAge = value;
                }

            }
        }

        public static void ChangeSalary(Employee_2 person)
        {
            Console.Write("\nEmployee salary: ");
            person.Salary = Checks.CheckUint();
        }

        public static void ChangePosition(Employee_2 person)
        {
            Console.Write("\nEmployee position: ");
            person.Position = Console.ReadLine();
        }

        public static void EmployDismiss(Employee_2 person, Company_2 company)
        {
            if (person.Company == company.Name)
            {
                Console.Write("\nThe employee was fired");
                person.Company = " ";
                company.CountMembers--;
            }
            else if ((company.CountMembers < company.CountVacancy) && (person.age <= company.needAge))
            {
                Console.Write("\nAn employee has been hired");
                person.Company = company.Name;
                company.CountMembers++;
            }
            else
            {
                Console.Write("\nNo vacancies for employer");
            }
        }
    }
}


