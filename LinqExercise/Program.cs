﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            Console.WriteLine("Working with the Numbers List:");
            Console.WriteLine(" ");

            //DONE: Print the Sum of numbers

            Console.WriteLine($"Sum: {numbers.Sum()}");

            //DONE: Print the Average of numbers

            Console.WriteLine($"Average: {numbers.Average()}");

            Console.WriteLine(" ");

            //DONE: Order numbers in ascending order and print to the console

            Console.WriteLine("Numbers in Ascending Order:");
            numbers.OrderBy(num => num).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(" ");

            //DONE: Order numbers in decsending order and print to the console

            Console.WriteLine("Numbers in Descending Order:");
            numbers.OrderByDescending(num => num).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(" ");

            //DONE: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers Greater than 6:");
            numbers.Where(num => num > 6).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(" ");

            //DONE: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Print Only 4 of Ascending List:");
            numbers.OrderBy(num => num).Take(4).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(" ");

            //DONE: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Add My Age and Print in Descending Order:");
            numbers.Select((num, i) => i == 4 ? 34 : num).OrderByDescending(num => num).ToList().ForEach(Console.WriteLine);

            Console.WriteLine(" ");



            Console.WriteLine("Transition to Employees List:");
            Console.WriteLine(" ");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            
            //DONE: Print all the employees' FullName properties to the console only if their
            //FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employees with a First Name starting with C or S in Ascending Order:");
            employees.Where(employee => employee.FirstName.StartsWith('C') || employee.FirstName.StartsWith('S'))
                .OrderBy(employee => employee.FirstName)
                .ToList().ForEach(employee => Console.WriteLine(employee.FullName));

            Console.WriteLine(" ");

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the
            //console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees Over 26 Ordered by Age and then by First Name:");
            employees.Where(employee => employee.Age > 26)
                .OrderBy(employee => employee.Age)
                .ThenBy(employee => employee.FirstName)
                .ToList().ForEach(employee => Console.WriteLine($"Age: {employee.Age} & Full Name: {employee.FullName}"));

            Console.WriteLine(" ");

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35.

            var YOE = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35);

            Console.WriteLine("Employees with 10 or Less Years of Experience and an Age Greater than 35:"); 
            Console.WriteLine($"YOE Sum for those employees: {YOE.Sum(employee => employee.YearsOfExperience)}");
            Console.WriteLine($"YOE Average for those employees: {YOE.Average(employee => employee.YearsOfExperience)}");
            Console.WriteLine(" ");

            //DONE: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine($"Employees List with a New Employee:");
            employees.Append(new Employee("Terry", "Cloth", 48, 3)).ToList().ForEach(employee => Console.WriteLine($"Full Name: {employee.FullName}, Age: {employee.Age}"));

            Console.WriteLine(" "); 


        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
