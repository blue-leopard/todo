﻿namespace ConsoleVerification
{
    using System;
    using Todo.Controllers;

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Add a task: ");
                var input = Console.ReadLine();
                var task = new Task(input);
                Console.WriteLine("Description: " + task.Description);
                Console.WriteLine("Due Date: " + task.DueDate);
                Console.WriteLine();
            }
        }
    }
}