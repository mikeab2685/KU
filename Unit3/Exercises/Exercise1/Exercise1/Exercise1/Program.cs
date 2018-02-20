using System;

namespace Exercise1
{
    class Loops
    {
        static void Main(string[] arges)
        {
            int total; // sum of the grades entered by user
            int gradeCounter; // number of the grade to be entered next
            int grade; // grade value entered by the user
            int average; // average of the grades
            total = 0; // initialize the total
            gradeCounter = 1; // initialize the loop counter
                                  // processing phase
            while (gradeCounter <= 10) // loop 10 times
            {


                Console.Write("Enter grade: "); // prompt the user
                grade = Convert.ToInt32(Console.ReadLine()); // read grade
                total = total + grade; // add the grade to total
                gradeCounter = gradeCounter + 1; // increment the counter by 1
                                                 // end while
                                                 // termination phase
                average = total / 10; // integer division yields integer result
                                      // display total and average of grades

                Console.WriteLine("\nTotal of all 10 grades is {0}", total);
                Console.WriteLine("Class average is {0}", average);
                Console.ReadKey();

            }
            
        } // end method DetermineClassAverage
    } // end class GradeBook
} //End of Program
