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

        }
    }
}
