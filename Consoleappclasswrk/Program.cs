using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleappclasswrk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadLine();

            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("what is your fav colour?");
            string color = Console.ReadLine();
            Console.WriteLine($"Hello {name}!.You are {age} years old and your favorite color is {color}");
            Console.ReadLine();

            Console.WriteLine("enter the first number");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sum = {a + b}");
            Console.WriteLine($"difference = {a - b}");
            Console.WriteLine($"product = {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"division = {a / b}");
            }
            else
            {
                Console.WriteLine($" for division, invalid input ");
            }
            Console.ReadLine();

            Console.WriteLine("enter temperature in celsius:");
            double celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the temperature in Fahrenheit is {(celsius * 9 / 5) + 32}");
            Console.ReadLine();


            Console.WriteLine("enter the principal amount :");
            double p = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the Rate of interest :");
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the time in years :");
            double t = Double.Parse(Console.ReadLine());
            Console.WriteLine($"the simple interest is {(p * r * t) / 100}");
            Console.ReadLine();

            Console.WriteLine("enter the radius of the circle:");
            double r = Double.Parse(Console.ReadLine());
            const double PI = 3.14159;
            Console.WriteLine($"the area of circle is : {PI * r * r}");
            Console.ReadLine();



            Console.WriteLine("enetr the time in seconds: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            int hour = sec / 3600;
            int min = (sec % 3600) / 60;
            int seconds = sec % 60;
            Console.WriteLine($"{hour} hours \n{min} minutes \n{seconds} seconds");
            Console.ReadLine();

            Console.WriteLine("enter a string:");
            string str = Console.ReadLine();
            int len = str.Length;
            int temp = 0;
            for (int i = 0; i < len; i++)
            {
                if (str[i] != ' ')
                {
                    temp++;
                }

            }
            Console.WriteLine($"length excluding spaces: {temp}");
            Console.ReadLine();

            //bmi calculation

            Console.WriteLine("enter height in metres:");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter weight in kilogram:");
            double weight = Double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI ={bmi}");
            Console.ReadLine();


            int integer = 10;
            float floatnumber = 10.123f;
            double doublenumber = 12.2134567;
            char charvalue = 'a';
            string str = "hi hello";
            bool boolvalue = false;
            Console.WriteLine($"{integer} is an integer type value ");
            Console.WriteLine($"{floatnumber} is a float  type value");
            Console.WriteLine($"{doublenumber} is a double type value");
            Console.WriteLine($"{charvalue} is a char type value");
            Console.WriteLine($"{str} is a string type value");
            Console.WriteLine($"{boolvalue} is a bool type value");
            Console.ReadLine();


            Console.WriteLine("enter the radius of the circle:");
            double r = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter the base and height of the triangle:");
            double b = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());

            const double PI = 3.14159;
            Console.WriteLine($"the area of circle is : {PI * r * r}");

            const double C = 0.5;
            Console.WriteLine($"the area of triangle is : {C * b * h}");


            Console.ReadLine();




            const double PI = 3.14159;
            const int DAYS_IN_WEEK = 7;

            Console.WriteLine("enter the radius of the circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the circumference of the circle is {2 * PI * radius}. There are {DAYS_IN_WEEK} days in a week.");
            Console.ReadLine();


            Console.WriteLine("enter the width in cm");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the height in cm");
            double height = Double.Parse(Console.ReadLine());
            double area = width * height;
            const double CMTOINCH = 0.3937;
            double area_in_inches = CMTOINCH * CMTOINCH * area;
            Console.WriteLine($"{area} is the area in cm square and {area_in_inches} is the area in inch square");
            Console.ReadLine();


            Console.WriteLine("enter the name of employee :");
            string emp_name = Console.ReadLine();
            Console.WriteLine("enter your age:");
            int emp_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your monthly salary :");
            double emp_sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Employ name : {emp_name}");
            Console.WriteLine($"Employ age : {emp_age}");
            Console.WriteLine($"Employ salary per month : {emp_sal}");
            Console.ReadLine();


            int num1 = 5;
            int num2 = 3;
            Console.WriteLine(num1 + num2);
            Console.ReadLine();


            Console.WriteLine("Enter the base of the number:");
            double base_n = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponential :");
            double exp_n = Double.Parse(Console.ReadLine());
            double result = Math.Pow(base_n, exp_n);
            Console.WriteLine($"{base_n} raised to the power of {exp_n} = {result}");
            Console.ReadLine();


            Console.WriteLine("Enter the age of person :");
            double age = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the citizenship status of the person :");
            string status = Console.ReadLine().ToLower();
            if (age >= 18 && status == "indian")
            {
                Console.WriteLine("the person is eligible to vote ");

            }
            else
            {
                Console.WriteLine("the person is not eligible to vote ");
            }
            Console.ReadLine();




            Console.WriteLine("enter the age :");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the yearly income :");
            double income = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("outstanding loan status (yes/no) :");
            string status = Console.ReadLine().ToLower();
            if (age >= 21 && income >= 30000 && status == "no")
            {
                Console.WriteLine("the person is eligible for loan ");

            }
            else
            {
                Console.WriteLine("the person is not eligible for loan");

            }
            Console.ReadLine();


            Console.WriteLine("enter the age :");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" work experience in years :");
            double exp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Do you have a college degree ? (yes/no) :");
            string status = Console.ReadLine().ToLower();
            if (status == "yes" && exp >= 2 && (age <= 35 || age >= 18))
            {
                Console.WriteLine(" you are eligible to apply");
            }

            else if (status == "no" && exp >= 5 && (age <= 35 || age >= 18))
            {
                Console.WriteLine(" you are eligible to apply");

            }
            else
            {
                Console.WriteLine("you are not eligible to apply");
            }

            Console.ReadLine();



            Console.WriteLine("enter the character :");
            string input = Console.ReadLine().ToLower();
            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                Console.WriteLine(" the character is a vowel ");
            }
            else
            {
                Console.WriteLine("the character is not a vowel");
            }
            Console.ReadLine();



            Console.WriteLine("enter the number");
            double value = Double.Parse(Console.ReadLine());
            if (value > 0)
            {
                Console.WriteLine("the number is positive");

            }
            else if (value < 0)
            {
                Console.WriteLine("the number is negative");

            }
            else
            {
                Console.WriteLine("the number is zero");
            }
            Console.ReadLine();



            Console.WriteLine("enter the number");
            double num = Double.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("the number is divisible by both 5 and 11");
            }
            else
            {
                Console.WriteLine("the number is not divisible by both 5 and 11");
            }
            Console.ReadLine();


            Console.WriteLine("enter the number a :");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b :");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator (+,-,*,/):");
            string c = Console.ReadLine();

            if (c == "+")
            {
                Console.WriteLine($"sum = {a + b}");

            }
            else if (c == "-")
            {
                Console.WriteLine($"dif = {a - b}");
            }
            else if (c == "*")
            {
                Console.WriteLine($" product = {a * b}");
            }
            else if (c == "/")
            {
                Console.WriteLine($" division = {a / b}");
            }
            Console.ReadLine();





            Console.WriteLine("enter the marks out of 100 :");
            double marks = Double.Parse(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("the grade is A");
            }
            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine(" the grade is B");
            }
            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine("the grade is C");
            }
            else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine("the grade is D");
            }
            else if (marks < 60)
            {
                Console.WriteLine("the grade is F");
            }
            Console.ReadLine();



            Console.WriteLine("enter the number a :");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b :");
            double b = Double.Parse(Console.ReadLine());

            double temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"the number a = {a}");
            Console.WriteLine($"the number b ={b}");


            Console.WriteLine("enter the number a :");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b :");
            double y = Double.Parse(Console.ReadLine());

            double sum = x + y;
            x = sum - x; y = sum - y;
            Console.WriteLine($"the number a = {x}");
            Console.WriteLine($"the number b ={y}");


            Write a program that takes two numbers as input and performs all arithmetic operations on them
            (addition, subtraction, multiplication, division, modulus, increment, and decrement).

            Console.WriteLine("enter number a :");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter number b :");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine($"addition = {a} + {b} = {a + b}");
            Console.WriteLine($"subtraction = {a} - {b} = {a - b}");
            Console.WriteLine($"multiplication = {a} * {b} = {a * b}");

            Console.WriteLine($"modulus = {a} % {b} = {a % b}");
            Console.WriteLine($"increment of {a} = {a + 1} and increment of {b} = {b + 1}");
            Console.WriteLine($"decrement of {a} ={a - 1} and decrement of {b} = {b - 1}");

            if (b != 0)
            {
                Console.WriteLine($"division = {a} / {b} = {a / b}");

            }
            else
            {
                Console.WriteLine("division not possible");
            }




            Write a C# program that takes three numbers as input from the user and calculates the average of 
            those numbers.The result should be displayed with two decimal places


            Console.WriteLine("enter three numbers :");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            double res = (a + b + c) / 3;
            Console.WriteLine($"the average ={res:f2}");




            Write a C# program to convert a given amount of money from USD to another currency (e.g., 
            EUR). Assume a conversion rate, for example, 1 USD = 0.85 EUR.The program should take the
            amount in USD as input and display the equivalent amount in EUR.



            Console.WriteLine("enter amount in usd :");
            double usd = Double.Parse(Console.ReadLine());
            const double CR = 0.85;
            double eur = CR * usd;
            Console.WriteLine($"amount in eur : {eur}");




            write a program that checks if the input number is within a certain range(e.g., between 1 and
            100) and also checks if it is even or odd using relational and logical operators. 


            Console.WriteLine("enter the number");
            double num = Double.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                Console.WriteLine($" {num} is in the range of 1 to 100");
            }
            else
            {
                Console.WriteLine($"{num} is not in range of 1 to 100");
            }

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }


            Write a program to check whether a number is divisible by both 3 and 5 using an if statement.



            Console.WriteLine("enter the number");
            double num = Double.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("both divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("not divisible by both 3 and 5");
            }





            Write a program to check whether a year is a leap year or not using an if-else statement.


            Console.WriteLine("enter the year:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y % 4 == 0)
            {
                if (y % 100 == 0)
                {
                    if (y % 400 == 0)
                    {
                        Console.WriteLine("it is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("it is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("it is a leap year");
                }
            }
            else
            {
                Console.WriteLine(" it is not a leap year");
            }


            //            Write a program that checks whether an input number is positive, even, and greater than 50 using
            //nested if statements.

            Console.WriteLine("enter the number");
            double num = Double.Parse(Console.ReadLine());

            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    if (num > 50)
                    {
                        Console.WriteLine($"{num} is positive,even and greater than 50");
                    }
                    else
                    {
                        goto label;
                    }
                }
                else
                {
                    goto label;
                }
            }
            else
            {
                goto label;
            }
        label:
            Console.WriteLine($"{num} doesn't satisfy all the condition");





            Write a program that accepts the grades(marks) of a student in three subjects. The program
            should determine the following: 
            1.If the student has passed in all subjects(passing mark is 40 in each subject). 
            2.If the student has passed, check if the average grade is 70 or above.If so, print
            "Distinction".
            3.If the student has not passed in any subject, print the number of subjects failed.


            Console.WriteLine("enter marks of sub1 out of 100");
            double m1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of sub2 out of 100");
            double m2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("enter the markds of sub3 out of 100");
            double m3 = Double.Parse(Console.ReadLine());
            int count = 0;

            if (m1 >= 40 && m2 >= 40 && m3 >= 40)
            {
                double av = (m1 + m2 + m3) / 3;
                Console.Write("the student had passed all the subjects");
                if (av > 70)
                {
                    Console.Write($" with distiction");
                }
            }
            else
            {
                if (m1 < 40)
                {
                    count++;
                }
                if (m2 < 40)
                { count++; }
                if (m3 < 40)
                { count++; }

                Console.WriteLine($"the number of subjects failed is {count}");
            }


            Write a program that calculates the tax to be paid based on the annual salary of an employee. The
tax rules are as follows: 
            1.If the salary is less than $10,000, no tax is applied.
            2.If the salary is between $10,000 and $50,000, a 10 % tax is applied.
            3.If the salary is above $50,000, a 20 % tax is applied.
            4.If the employee is a senior citizen(aged 60 or above), they get an additional tax
            exemption of $5,000 from their taxable income.
            5.Your program should
             Prompt the user to enter their annual salary and age. 
             Use nested if statements to calculate the appropriate tax based on the salary and age.
             Print the tax amount to be paid.


            Console.WriteLine("enter the salary and age:");
            double salary = Double.Parse(Console.ReadLine());
            double age = Double.Parse(Console.ReadLine());

            if (salary < 10000)
            {
                Console.WriteLine("no tax to be paid");
            }
            else if (salary >= 10000 && salary <= 50000)

            {
                if (age < 60)
                {
                    double tax = salary * 0.1;
                    Console.WriteLine($"The tax to be paid is {tax}");
                }
                else
                {
                    double tax = (salary * 0.1) - 5000;
                    Console.WriteLine($"The tax to be paid is {tax}");
                }
            }

            else if (salary > 50000)
            {
                if (age < 60)
                {
                    double tax = (salary * 0.2);
                    Console.WriteLine($"The tax to be paid is {tax}");
                }
                else
                {

                    double tax = (salary * 0.2) - 5000;
                    Console.WriteLine($"The tax to be paid is {tax}");

                }

            }



            Console.ReadLine();

            //****************************************DAY2***************************************************************************


            //Write a C# program to print the multiplication table of a given number using the for loop.


            //Console.WriteLine("enter the number :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"{a} * {i} = {a * i}");
            //}
            //Console.ReadLine();


            ////Write a C# program to display a right-angled triangle pattern using nested for loops.

            //Console.WriteLine("enter the number of rows:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            //Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while loop


            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;

            //}
            //Console.WriteLine($"the sum of even numbers from 1 to 100 = {sum}");
            //Console.ReadLine();



            //Write a C# program to print a multiplication table from 1 to 5 using nested while loops.

            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i} * {j} = {j * i}");
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}

            //Console.ReadLine();


            //Write a C# program to keep asking the user to enter a positive number and print it. The program
            ////should stop when the user enters a negative number.


            //while (true)

            //{
            //    Console.WriteLine("enter a positive number :");
            //    double num = Double.Parse(Console.ReadLine());
            //    if (num < 0)
            //    {
            //        Console.WriteLine("enterred a negative number");
            //        break;
            //    }

            //}
            //Console.ReadLine();


            //            Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.









            //string op;
            //double num1, num2, result;

            //do
            //{
            //    Console.WriteLine("Choose operator (+, -, *, /) or type 'exit' to quit:");
            //    op = Console.ReadLine().ToLower();

            //    if (op == "exit")
            //    {
            //        Console.WriteLine("Exiting the program...");
            //        break;
            //    }

            //    // Read two numbers
            //    Console.Write("Enter the first number: ");
            //    num1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    num2 = double.Parse(Console.ReadLine());

            //    // Perform the operation
            //    switch (op)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //            break;

            //        case "-":
            //            result = num1 - num2;
            //            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //        case "*":
            //            result = num1 * num2;
            //            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //            break;

            //        case "/":
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator. Please enter +, -, *, /, or 'exit' to quit.");
            //            break;
            //    }

            //} while (op != "exit");




            //            Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.



            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i > 50)
            //    {
            //        break;
            //    }


            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();


            //Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.


            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"the sum of odd numbers from 1 to 100 is {sum}");
            //Console.ReadLine();



            //Write a C# program to calculate the factorial of a given number using a while loop.


            //Console.WriteLine("enter the number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int fact = 1;
            //while (i <= num)
            //{
            //    fact *= i;
            //    i++;
            //}
            //Console.WriteLine($"the factorial is {fact}");
            //Console.ReadLine();


            //Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:


            //int i = 1;

            //while(i<=5)
            //{
            //    int j = 1;
            //    while(j<=i)
            //    {
            //        Console.Write(i);
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadLine();



            //            Write a C# program to create a simple calculator using a switch-case statement. The program
            //should handle addition, subtraction, multiplication, and division.


            //Console.WriteLine("enter two numbers :");
            //double num1 = Double.Parse(Console.ReadLine());
            //double num2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("enter 1. for addition 2. for subtraction 3.for multiplication 4.for division");
            //int op = Convert.ToInt32(Console.ReadLine());

            //switch(op)
            //{
            //    case 1: Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //        break;
            //    case 2: Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            //        break;
            //    case 3: Console.WriteLine($"{num1} * {num2} = {num1*num2}");
            //        break;
            //    case 4: 
            //        if(num2!=0)
            //        { 
            //        Console.WriteLine($"{num1} / {num2} = {num1}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"no answer");
            //        }
            //        break;
            //    default: Console.WriteLine("Please enter valid number for operation");
            //        break;
            //}
            //Console.ReadLine();




            //            Write a C# program that accepts a number from the user and calculates the sum of its digits using
            //a do -while loop.

            //Console.WriteLine("enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    int digit = num % 10;
            //    sum += digit;
            //    num = num/10;
            //}
            //while(num > 0);
            //Console.WriteLine($"the sum of digits: {sum}");
            //Console.ReadLine();


            //            Write a C# program that accepts 10 numbers from the user and finds the largest number using a
            //for loop.



            //Console.WriteLine("enter the numbers :");
            //int[] arr = new int[10];
            //int i = 0;
            //for (i = 0; i < 10; i++)
            //{
            //    arr[i]= Convert.ToInt32(Console.ReadLine());
            //}
            //int largest = arr[0];
            //for (i = 0; i<10; i++)
            //{
            //    if (arr[i]>largest)
            //    {
            //        largest = arr[i];
            //    }
            //}
            //Console.WriteLine($"the largest number is {largest} ");
            //Console.ReadLine();



            //            Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided
            //number using a while loop.


            //Console.WriteLine("enter the number :");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while(i<=num)
            //{
            //    sum += (i * i);
            //    i++;    
            //} 
            //Console.WriteLine($"the sum of squares = {sum}");
            //Console.ReadLine();

            //            Write a C# program to find and print the first multiple of 5 in a given list of numbers. Use the 
            //break statement to exit the loop once a multiple of 5 is found.


            //double[] arr = new double[100];
            //Console.WriteLine("enter the number of elements");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //for(i=0;i<num;i++)
            //{
            //    arr[i]= Convert.ToDouble(Console.ReadLine());   
            //}
            //bool found = false;

            //for (i=0;i<arr.Length;i++)
            //{
            //    if (arr[i] %5 == 0)
            //    {
            //        Console.WriteLine($"the first multiple of 5 in the list is {arr[i]}");
            //        found = true;
            //        break;
            //    }
            //}

            //if(!found)
            //{
            //    Console.WriteLine("there is no multiple of 5 found");
            //}
            //Console.ReadLine();



            //            Write a C# program to print numbers from 1 to 20, but skip numbers that are divisible by 3 using 
            //the continue statement.


            //for(int i = 1;i<=20;i++)
            // {
            //     if(i%3==0)
            //     {
            //         continue;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"{i}");
            //     }
            // }


            //Write a C# program to check if a given number is a palindrome using a while loop. 

            //Console.WriteLine("enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int temp = num;
            //int sum = 0;
            //while(num>0)
            //{
            //    int d = num%10;
            //    sum = sum * 10 + d;
            //    num=num/10;
            //}
            //if(temp==sum)
            //{
            //    Console.WriteLine("it is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("it is not a palindrome");
            //}


            //            Write a C# program to calculate the average of positive numbers entered by the user. The 
            //program should stop when the user enters a negative number using a do -while loop.



            //double sum = 0;
            //int count = 0;
            //int num;
            //do
            //{
            //    Console.WriteLine("enter a positive number or a negative number to stop");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num >= 0)
            //    {
            //        sum += num;
            //        count++;
            //    }

            //}
            //while (num > 0);

            //if (count > 0)
            //{
            //    double avg = sum / count;
            //    Console.WriteLine($"the average of numbers is {avg}");
            //}
            //else
            //{
            //    Console.WriteLine("no average");
            //}

            //Write a C# program to reverse a given number using a do-while loop. 


            //Console.WriteLine("enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    int d = num%10;
            //    sum = sum * 10 + d;
            //    num=num/10;

            //}
            //while(num>0);

            //Console.WriteLine($"the reverse is {sum}");


            //            Write a C# program that presents a menu to the user for various string operations: 
            //1.Reverse the string
            //2.Convert to uppercase
            //3.Convert to lowercase
            //4.Find the length of the string
            //Use a switch-case statement to implement this

            //Console.WriteLine("enter a string");
            //string str = Console.ReadLine();
            //Console.WriteLine("enter \r\n 1. Reverse the string \r\n2. Convert to uppercase \r\n3. Convert to lowercase \r\n4. Find the length of the string");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch(num)
            //{
            //    case 1:
            //{
            //    char[] charArr = str.ToCharArray();
            //    Array.Reverse(charArr);
            //    string reversedString = new string(charArr);
            //    Console.WriteLine("Reversed String: " + reversedString);
            //    break;
            //}
            //    case 2:
            //{
            //    string STR = str.ToUpper();
            //    Console.WriteLine("Uppercase String: " + STR);
            //    break;
            //}
            //    case 3:
            //{
            //    string lowerCaseStr = str.ToLower();
            //    Console.WriteLine("Lowercase String: " + lowerCaseStr);
            //    break;
            //}
            //    case 4:
            //{
            //    int length = str.Length;
            //    Console.WriteLine("Length of String: " + length);
            //    break;
            //}
            //    default:
            //    {
            //    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
            //    break;
            //}

            //}


            //            Write a C# program to print numbers from 1 to 50 but skip numbers that are divisible by 4 using 
            //the continue statement.


            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //Write a C# program to print the first 10 numbers in the Fibonacci sequence using a for loop

            //int num1 = 0, num2 = 1, nextNum;

            //Console.WriteLine("The first 10 numbers in the Fibonacci sequence are:");

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(num1 + " ");

            //    nextNum = num1 + num2;
            //    num1 = num2;
            //    num2 = nextNum;
            //}



            //            Write a C# program to find all Armstrong numbers between 1 and 500 using a while loop. (An 
            //Armstrong number is a number that is equal to the sum of the cubes of its digits). 


            //int num = 1;

            //Console.WriteLine("Armstrong numbers between 1 and 500 are:");

            //while (num <= 500)
            //{
            //    int sum = 0, temp = num;
            //    while (temp > 0)
            //    {
            //        int digit = temp % 10;
            //        sum += digit * digit * digit;
            //        temp /= 10;
            //    }

            //    if (sum == num)
            //    {
            //        Console.WriteLine(num);
            //    }

            //    num++;
            //}



            //Write a C# program to reverse a given string using a for loop.

            //Console.WriteLine("Enter a string to reverse:");
            //string input = Console.ReadLine();

            //string reversedString = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString += input[i];
            //}

            //Console.WriteLine("Reversed string: " + reversedString);




            //Write a C# program to count the number of vowels and consonants in a given string using a for 
            //loop. 

        //    Console.WriteLine("Enter a string:");
        //    string input = Console.ReadLine().ToLower();

        //    int vowelCount = 0, consonantCount = 0;

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char ch = input[i];



        //        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        //        {
        //            vowelCount++;
        //        }
        //        else
        //        {
        //            consonantCount++;
        //        }

        //    }

        //    Console.WriteLine("Number of vowels: " + vowelCount);
        //    Console.WriteLine("Number of consonants: " + consonantCount);


        //    Console.ReadLine();
        //}
    }
}



        
   

