/* 
 * This program determines whether Grade Point Average and Admission Test Scores meet the requirements for admission.
 * 
 * User inputs a grade point average (e.g., 3.2) and an admission test score (e.g., 75).
 * 
 * Program outputs the message "Accept" if the input meets requirements or 
 * "Reject" if it doesn't.
 * 
 * Program does not loop
 */

using System;
using static System.Console;

namespace Admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MIN_GPA = 3.0;
            int LOW_TEST_SCORE = 60;
            int HIGH_TEST_SCORE = 80;

            double gradePointAverage;
            int admissionTestScore;
            string userInput;

            //Prompt for Grade Point Average
            Write("Please enter your Grade Point Average: ");
            userInput = ReadLine();
            gradePointAverage = Convert.ToDouble(userInput);

            //Prompt for Admission Test Score
            Write("Enter your Admission Test Score: ");
            userInput = ReadLine();
            admissionTestScore = Convert.ToInt32(userInput);

            //Calculate and output result
            if ((gradePointAverage >= MIN_GPA && admissionTestScore >= LOW_TEST_SCORE) || (gradePointAverage < MIN_GPA && admissionTestScore >= HIGH_TEST_SCORE))
                WriteLine("Accept");
            else
                WriteLine("Reject");
        }
    }
}