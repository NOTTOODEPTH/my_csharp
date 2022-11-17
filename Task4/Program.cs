using System;
namespace HomeWork5
{
    class Program
    {

        static void Main(string[] args)
        {
            byte CheckAnswer()
            {
                string? myString;
                bool check;
                byte thisByte;
                do
                {
                    myString = Console.ReadLine();
                    check = byte.TryParse(myString, out thisByte);
                    if ((!check) || (thisByte > 5) || (thisByte < 1))
                    {
                        Console.WriteLine("Invalid input!");
                        check = false;
                    }
                }
                while (!check);
                return thisByte;
            }

            // First task 
            bool stop = false;
            byte answer;
            int firstPoint;
            int secondPoint;
            var points = new List<Point_1>();
            Console.WriteLine("First task");

            while (!stop)
            {
                Console.Write($"\n[1] Add point;\n[2] Find the length between two points;\n[3] Find out the parameters" +
                    $" of the selected point;\n[4] Find out the number of points;\n[5] Next task.\nSelect an action: ");
                answer = CheckAnswer();
                switch (answer)
                {
                    case 1:
                        points.Add(new Point_1());
                        break;
                    case 2:
                        if (Point_1.Counter >= 2)
                        {
                            Console.WriteLine("\nSelect the numbers of points to find the distance between them:");

                            for (int i = 0; i < points.Count; i++)
                            {
                                Console.WriteLine($"[{i + 1}] point coordinates: x = {points[i].X}; y = {points[i].Y}");
                            }

                            Console.Write("First point: ");
                            firstPoint = Point_1.CheckPoint(points.Count);
                            Console.Write("Second point: ");
                            secondPoint = Point_1.CheckPoint(points.Count);
                            Console.WriteLine($"The length between points: {Point_1.LengthPoints(points[firstPoint], points[secondPoint])}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough points!");
                            break;
                        }

                    case 3:
                        if (Point_1.Counter >= 1)
                        {
                            Console.WriteLine($"\nTotal points: {points.Count}");
                            Console.Write("Select the number of point: ");
                            firstPoint = Point_1.CheckPoint(points.Count);
                            Console.WriteLine($"Point coordinates: x = {points[firstPoint].X}; y = {points[firstPoint].Y}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nYou have not created any points yet!");
                            break;
                        }
                    case 4:
                        Console.WriteLine($"\nThe number of points: {Point_1.Counter}");
                        break;
                    case 5:
                        stop = true;
                        break;
                }
            }

            // Second task 

            stop = false;
            int chooseCompany;
            int chooseEmploy;
            var companys = new List<Company_2>();
            var employers = new List<Employee_2>();
            var employersForComp = new List<Employee_2>();
            Console.WriteLine("\nSecond task");

            void funkc()
            {
                Console.WriteLine("\n");
                for (int i = 0, j = 1; i < employers.Count; i++)
                {
                    if (employers[i].Company == companys[chooseCompany].Name)
                    {
                        Console.WriteLine($"[{j}] Employee name: {employers[i].Name}, employee age: {employers[i].age}, employee salary: {employers[i].Salary}, employee position: {employers[i].Position};");
                        j++;
                        employersForComp.Add(employers[i]);
                    }
                }
            }

            while (!stop)
            {
                Console.Write($"\n[1] Add company;\n[2] Add employee;\n[3] To manage a company;\n[4] List of company and employee;\n[5] Next task.\nSelect an action: ");
                answer = CheckAnswer();
                switch (answer)
                {
                    case 1:
                        companys.Add(new Company_2());
                        break;
                    case 2:
                        employers.Add(new Employee_2());
                        break;
                    case 3:
                        if (companys.Count == 0)
                        {
                            Console.WriteLine("\nYou don't have companies.");
                            break;
                        }
                        Console.WriteLine("\n");
                        for (int i = 0; i < companys.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] Company name: {companys[i].Name};");
                        }
                        chooseCompany = Point_1.CheckPoint(companys.Count);

                        Console.Write("\n[1] Сhange an employee's salary;\n[2] Сhange the position of an employee;\n[3] Fire/hire an employee in company;\n[4] About company;\n[5] Back.\nSelect an action: ");
                        answer = CheckAnswer();

                        switch (answer)
                        {
                            case 1:
                                Console.WriteLine("\n");
                                funkc();
                                if (employersForComp.Count == 0)
                                {
                                    Console.WriteLine("You don't have employers.");
                                    break;
                                }
                                chooseEmploy = Point_1.CheckPoint(employersForComp.Count);
                                Company_2.ChangeSalary(employersForComp[chooseEmploy]);
                                break;
                            case 2:
                                Console.WriteLine("\n");
                                funkc();
                                if (employersForComp.Count == 0)
                                {
                                    Console.WriteLine("You don't have employers.");
                                    break;
                                }
                                chooseEmploy = Point_1.CheckPoint(employersForComp.Count);
                                Company_2.ChangePosition(employersForComp[chooseEmploy]);
                                break;
                            case 3:
                                Console.WriteLine("\n");
                                if (employers.Count == 0)
                                {
                                    Console.WriteLine("You don't have employers.");
                                    break;
                                }
                                for (int i = 0; i < employers.Count; i++)
                                {
                                    Console.WriteLine($"[{i + 1}] Employee name: {employers[i].Name}, employee age: {employers[i].age}, place of work: {employers[i].Company}, employee salary: {employers[i].Salary}, employee position: {employers[i].Position};");
                                }
                                chooseEmploy = Point_1.CheckPoint(employers.Count);
                                Company_2.EmployDismiss(employers[chooseEmploy], companys[chooseCompany]);
                                break;
                            case 4:
                                Console.WriteLine("\n");
                                Console.WriteLine($"Company name: {companys[chooseCompany].Name};\nLocation: {companys[chooseCompany].Location};\nVacancies: {companys[chooseCompany].CountVacancy - companys[chooseCompany].CountMembers};\nMaximum age of new employees: {companys[chooseCompany].needAge}.");
                                break;
                            case 5:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        if ((companys.Count == 0) && (employers.Count == 0))
                        {
                            Console.WriteLine("You don't have companies and employers.");
                            break;
                        }
                        for (int i = 0; i < employers.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] Employee name: {employers[i].Name}, employee age: {employers[i].age}, place of work: {employers[i].Company}, employee salary: {employers[i].Salary}, employee position: {employers[i].Position};");
                        }
                        for (int i = 0; i < companys.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}] Company name: {companys[i].Name}, maximum age of new employees: {companys[i].needAge}.");
                        }
                        break;
                    case 5:
                        stop = true;
                        break;
                }
            }

            // Third task 
            Console.WriteLine("\nThird task\n");

            Dishwasher_3 dishwasher_3 = new Dishwasher_3("100", "80", "Semi", 60, "Lastochka", "Green");
            dishwasher_3.Start();
            Thread.Sleep(3000);
            dishwasher_3.GoWashDry();
            dishwasher_3.Stop();

            WashingMachine_3 washingMachine_3 = new WashingMachine_3("110", "100", " daily", 80, "Bobr", "Brown");
            washingMachine_3.Start();
            Thread.Sleep(3000);
            washingMachine_3.GoWashDry();
            washingMachine_3.Stop();
        }
    }
}
