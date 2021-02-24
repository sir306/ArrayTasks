using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            char[] grades = new char[5];
            grades[0] = 'A';
            grades[1] = 'B';
            grades[2] = 'D';
            grades[3] = 'F';

            foreach (char item in grades)
            {
                Console.WriteLine("grade: {0}", item);
            }
            char gradeC = 'C';
            int pos = Convert.ToInt32(grades.Length / 2) + 1;
            Console.WriteLine(pos);
            char[] arraycopy = new char[6];
            Console.WriteLine(grades.Length);
            for (int i = 0; i < grades.Length + 1; i++)
            {
                if (i < pos - 1)
                {
                    arraycopy[i] = grades[i];
                }
                else if (i == pos - 1)
                {
                    arraycopy[i] = gradeC;
                }
                else if (grades[i - 1] == ' ')
                {
                    i++;
                }
                else
                {
                    arraycopy[i] = grades[i - 1];
                }
            }

            foreach (char item in arraycopy)
            {
                Console.WriteLine("grade: {0}", item);
            }

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = arraycopy[i];
            }
            foreach (char item in grades)
            {
                Console.WriteLine("grade: {0}", item);
            }

            //Task 2
            string[] subjects = new string[3];
            subjects[0] = "math";
            subjects[1] = "english";
            subjects[2] = "IT";
            Console.WriteLine("Second element of array: {0}", subjects[1]);

            Array.Resize(ref subjects, 5);

            subjects[3] = "painting";
            subjects[4] = "sports";

            foreach (string item in subjects)
            {
                Console.WriteLine("This subject is {0}", item);
            }

        }
    }
}
