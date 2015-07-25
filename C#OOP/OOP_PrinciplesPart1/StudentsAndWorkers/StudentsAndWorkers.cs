/*
 * Problem 2. Students and workers

Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
 * */

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StudentsAndWorkers
    {
        static void Main()
        {
            Student gosho = new Student("Gosho", "Goshov", 4);
            Student pesho = new Student("Pesho", "Peshov", 5);
            Student minka = new Student("Minka", "Goshova", 6);
            Student mariika = new Student("Mariq", "Toshova", 5);
            Student tosho = new Student("Todor", "Todorov", 6);
            Student ivancho = new Student("Ivan", "Kalpazanov", 8);
            Student miro = new Student("Miroslav", "Goshov", 3);
            Student stamat = new Student("Stamat", "Stamatov", 4);
            Student vasil = new Student("Vasil", "Petrov", 4);
            Student stoqn = new Student("Stoqn", "Hristov", 4);

            List<Student> studentsList = new List<Student>();
            studentsList.Add(gosho);
            studentsList.Add(pesho);
            studentsList.Add(minka);
            studentsList.Add(mariika);
            studentsList.Add(tosho);
            studentsList.Add(ivancho);
            studentsList.Add(miro);
            studentsList.Add(stamat);
            studentsList.Add(vasil);
            studentsList.Add(stoqn);

            var sortedStudentList = studentsList.OrderBy(s => s.Grade);

            Console.WriteLine("Students:");
            Console.WriteLine();

            foreach (var item in sortedStudentList)
            {
                Console.WriteLine("{0,-10} - grade: {1}", item.FirstName, item.Grade);
            }

            Console.WriteLine(new string('_', 20));
            Console.WriteLine();

            Worker filip = new Worker("Kristian", "Tumbev", 50, 8);
            Worker kolio = new Worker("Nikola", "Nikolov", 20, 4);
            Worker hristo = new Worker("Hristo", "Iordanov", 100, 8);
            Worker dancho = new Worker("Iordan", "Vylkov", 100, 8);
            Worker sasho = new Worker("Aleksandyr", "Uzunov", 100, 2);
            Worker georgi = new Worker("Georgi", "Georgiev", 60, 8);
            Worker ceco = new Worker("Cvetomir", "Nachev", 100, 8);
            Worker presiqn = new Worker("Presiqn", "Aleksandrov", 100, 4);
            Worker detelin = new Worker("Detelin", "Tumbev", 80, 8);
            Worker cveta = new Worker("Cvetomira", "Nacheva", 150, 8);

            List<Worker> listWorkers = new List<Worker>();

            listWorkers.Add(filip);
            listWorkers.Add(kolio);
            listWorkers.Add(hristo);
            listWorkers.Add(dancho);
            listWorkers.Add(sasho);
            listWorkers.Add(georgi);
            listWorkers.Add(ceco);
            listWorkers.Add(presiqn);
            listWorkers.Add(detelin);
            listWorkers.Add(cveta);

            var sortedListWorkers = listWorkers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine("Workers:");
            Console.WriteLine();

            foreach (var item in sortedListWorkers)
            {
                Console.WriteLine("{0,-10} - money per hour: {1}", item.FirstName, item.MoneyPerHour());
            }

            var both = new List<Human>();

            both.AddRange(sortedStudentList);
            both.AddRange(sortedListWorkers);

            var sortedBoth = both.OrderBy(b => b.FirstName).ThenBy(b => b.LastName);

            Console.WriteLine();
            Console.WriteLine(new string('-', 10));
            Console.WriteLine();
            Console.WriteLine("Students and workers:");
            Console.WriteLine();

            foreach (var item in sortedBoth)
            {
                Console.WriteLine("{0,-10} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
