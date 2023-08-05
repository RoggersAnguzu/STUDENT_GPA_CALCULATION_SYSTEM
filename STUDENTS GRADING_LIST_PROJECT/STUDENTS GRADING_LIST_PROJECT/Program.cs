using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace STUDENT_GRADING_LIST
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calling this Method combines all the methods that are necessary for Calculating the current GPA, CGPA, grades, and Deans List.
            Student_Grade_System();
        }
        public static void Student_Grade_System() 
        {
            //Gives out the Welcome statement and the calls the AFFIRMATION method which combines all the other Methods. 
            Console.WriteLine("*********WELCOME TO THE STUDENT GPA CALCULATION SYSTEM**********\n");
            Console.WriteLine("Please Enter your Name before Using the GPA Calculator:");
            string name = Console.ReadLine();
            Console.WriteLine($"Dear {name}\nThanks for logging into the GPA calculator System\n");
            Affirmation();
        }
        public static void Affirmation()
        {
            //This Function Allows a user to select the Number of Courses they are doing.
            //It  then allows them to provide grade marks in response to the number of Courses.
            Console.WriteLine("How Many courses are you doing this semester:? \n1.Four\n2.Five");
            int suggestion = int.Parse(Console.ReadLine());
            switch (suggestion)
            {
                case 1:
                    Calculate_GPA_For_FOUR_Courses();
                    break;
                case 2:
                    Calculate_GPA_For_FIVE_Courses();
                    break;
                default:
                    Console.WriteLine("Please Enter the Correct option from the ones above!");
                    Affirmation();
                    break;
            }
        }
        public static void Calculate_GPA_For_FOUR_Courses()
        {
            // This method is the one that prompts a user to Enter Four grade marks if he / she
           //is doing Four courses, then calculates the average of the grade makes to get the grades.
            Console.WriteLine("Please Enter your grades marks for Current Semester below");
            int begin = 1;int sum = 0;
            while(begin<5)
            {
                Console.WriteLine($"Please Enter your grade mark:");
                int a = int.Parse(Console.ReadLine());
                sum += a;
                begin++;
            }
            int average_grades = sum / 4;
            Convert(average_grades);
        }
        public static   void Calculate_GPA_For_FIVE_Courses()
        {
            //This method is the one that prompts a user to Enter Five grades marks if he/she is doing Five courses
            //then calculates the average of the grade makes to get the grade
            Console.WriteLine("Please Enter your grade Marks for Current Semester below.");
            int begin = 1; int sum = 0;
            while (begin < 6)
            {
                Console.WriteLine($"Please Enter your grade mark:");
                int a = int.Parse(Console.ReadLine());
                sum += a;
                begin++;
            }
            int average_grades = sum / 5;
            Convert(average_grades);
        } 
        public static void Convert(double Average_grade) 
        {
            //This function checks and grades the student if certain Conditions are Met 
            //It also gets the Deans list incase u are above 3.5 GPA
            //Gives out the GPA,CGPA. 
            //It also calculates your Current grade.
            double units = 3;
            if (Average_grade >= 90)
            {
                Console.WriteLine("This is Grade A");
                double result1 = 4.0;
                double Calculator = (result1 * units)/3;
                Console.WriteLine($"Your Current GPA is {Calculator}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result1;
                double x = CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if (x >= 3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
            else if (Average_grade >= 80)
            {
                Console.WriteLine("This is Grade B");
                double result2 = 3.6;
                double Calculator1 = (result2 * units) / 3;
                Console.WriteLine($"Your Current GPA is {Calculator1}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result2;
                double x = CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if(x>=3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
            else if (Average_grade >= 70)
            {
                Console.WriteLine("This is Grade C");
                double  result3 = 3.1;
                double Calculator2 = (result3 * units) / 3;
                Console.WriteLine($"Your Current GPA is {Calculator2}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result3;
                double x = CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if (x >= 3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
            else if (Average_grade >= 60)
            {
                Console.WriteLine("This is Grade D");
                double result4 = 2.5;
                double Calculator3 = (result4 * units) / 3;
                Console.WriteLine($"Your Current GPA is {Calculator3}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result4;
                double x = CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if (x >= 3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
            else if (Average_grade >= 50)
            {
                Console.WriteLine("This is Grade E");
                double result5 = 2.0;
                double Calculator4 = (result5 * units) / 3;
                Console.WriteLine($"Your Current GPA is {Calculator4}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result5;
                double x = CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if (x >= 3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
            else
            {
                Console.WriteLine("You have got Grade F");
                double  result6 = 1.0;
                double Calculator5 = (result6 * units) / 3;
                Console.WriteLine($"Your Current GPA is {Calculator5}");
                Console.WriteLine("Enter your previous GPA to calculate the CGPA: ");
                double grade = double.Parse(Console.ReadLine());
                double CGPA = grade + result6;
                double x = (double)CGPA / 2;
                Console.WriteLine($"Your CGPA is {x}");
                if (x >= 3.5)
                {
                    Console.WriteLine("You are on the Dean's List ");
                }
                else
                {
                    Console.WriteLine("Sorry you are not Eligible for the dean's List");
                }
                Exit();
            }
        }
        
        public static void Exit()
        {
            // This Method is used to allow the user whether to Exit or Continue Using the System
            Console.WriteLine("Would you like to Exit? \n1.Yes\n2.No");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                  case 1:
                    break;
                case 2:
                    Affirmation();
                    break;
                default:
                    Console.WriteLine("Please Enter the right choice next time!");
                    break;  
            }
        }
    }
}
