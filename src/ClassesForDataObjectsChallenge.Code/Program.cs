using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassesForDataObjects
{
    class Program
    {
        // 6 students, 2 male, 4 female, 1 unspecified (U), 1 @ 19, 3 @ 20, 1 @ 21, 2 @ 22
        static Student s1 = new Student { Initials = "CE", Name = "Coraline Ehmke", Age = 22, Gender = "F", Hobby = "Music" };
        static Student s2 = new Student { Initials = "RF", Name = "Rod Flavell", Age = 20, Gender = "M", Hobby = "Sport" };
        static Student s3 = new Student { Initials = "EC", Name = "Emily Chang", Age = 21, Gender = "F", Hobby = "Films" };
        static Student s4 = new Student { Initials = "JF", Name = "James Fazzino", Age = 19, Gender = "M", Hobby = "Music" };
        static Student s5 = new Student { Initials = "DP", Name = "Doina Precup", Age = 20, Gender = "F", Hobby = "Sport" };
        static Student s6 = new Student { Initials = "LC", Name = "Lynn Conway", Age = 22, Gender = "U", Hobby = "Music" };
        static Student s7 = new Student { Initials = "MM", Name = "Marissa Mayer", Age = 20, Gender = "F", Hobby = "Sport" };
        // static void Main(string[] args)
        // {
        //     List<Student> students = new List<Student> { s1, s2, s3, s4, s5, s6, s7 };

        //     //TODO 1: Create a LINQ query that creates a set of students who are female and under 21.
        //     //Then create code that prints the name and age of the selected students in  
        //     //the format: "{Student Full Name} is {Age} years old"
        //     //The output should be:
        //     //Doina Precup is 20 years old
        //     //Marissa Mayer is 20 years old



        //     //TODO 2: Create a LINQ query that creates a collection the surnames and ages of female students
        //     //who are greater than or equal to 21. Then create code that prints the details in the
        //     //format "{Student Surname} is {Age} years old".
        //     //The output should be:
        //     //Ehmke is 22 years old
        //     //Chang is 21 years old



        //     //TODO 3: Use LINQ and/or lambda to create a create and print a collection of students that lists the popularity of hobbies in descending sequence within gender.
        //     //You will (probably) need to tackle the task using 2 separate queries and a pair of nested loops.
        //     //Look out for prompts 3a to 3d below.

        //     //The output should look like the following
        //     // Gender: F, Hobby: Sport, Count: 2
        //     // Gender: F, Hobby: Films, Count: 1
        //     // Gender: F, Hobby: Music, Count: 1
        //     // Gender: M, Hobby: Music, Count: 1
        //     // Gender: M, Hobby: Sport, Count: 1
        //     // Gender: U, Hobby: Music, Count: 1

        //     //TODO 3a: Create a LINQ query that groups students into genders. The resultant set needs to contain
        //     //a collection of objects that each have a Gender and a collection of students of that gender


        //     //TODO 3b: Loop through the students by gender resultset

        //     //TODO 3c: Within the loop created in step 3b, create a LINQ query that groups the current set of students by their hobbies and
        //     //sequence them in order of descending popularity and, to deal with counts that are equal, into alpbetical order by hobby.
        //     //The resultant set needs to contain a collection of objects that each have a Hobby and a collection of students who
        //     //claim to enjoy that hobby.
            
        //     //TODO 3d:  Loop around the studentsByHobbiesWithinGenderSequence collection and display the gender, hobby and count of 
        //     //students who like the hobby
        // }

                static void Main(string[] args)
        {
            List<Student> students = new List<Student> { s1, s2, s3, s4, s5, s6, s7 };

            //TODO 1: Create a LINQ query that creates a set of students who are female and under 21.
            //Then create code that prints the name and age of the selected students in  
            //the format: "{Student Full Name} is {Age} years old";
            //The output should be:
            //Doina Precup is 20 years old
            //Marissa Mayer is 20 years old

            IEnumerable<Student> femalesU21 = from s in students
                                              where s.Gender == "F" && s.Age < 21
                                              select s;
            Console.WriteLine("Here are the full names ans ages of female students who are under 21");
            foreach (Student s in femalesU21)
            {
                Console.WriteLine($"{s.Name} is {s.Age} years old");
            }

            //TODO 2: Create a LINQ query that creates a collection the surnames and ages of female students
            //who are greater than or equal to 21. Then create code that prints the details in the
            //format "{Student Surname} is {Age} years old".
            //The output should be:
            //Ehmke is 22 years old
            //Chang is 21 years old

            var FemaleSurnamesU21 = from s in students
                             where s.Gender == "F" && s.Age >= 21
                             select new { CapSurname = s.Name.Substring(s.Name.IndexOf(' ') + 1), s.Age };
            Console.WriteLine("Here are the surnames and ages of female students who are over 21");
            foreach (var s in FemaleSurnamesU21)
            {
                Console.WriteLine($"{s.CapSurname} is {s.Age} years old");
            }

            //TODO 3: Use LINQ and/or lambda to print the popularity of hobbies in descending sequence within gender.
            //You will (probably) need to tackle the task using 2 separate queries and a pair of nested loops. Look
            //out for the prompts.
            //The output should look like the following
            // Gender: F, Hobby: Sport, Count: 2
            // Gender: F, Hobby: Films, Count: 1
            // Gender: F, Hobby: Music, Count: 1
            // Gender: M, Hobby: Music, Count: 1
            // Gender: M, Hobby: Sport, Count: 1
            // Gender: U, Hobby: Music, Count: 1

            //TODO 3a: Create a LINQ query that groups students into genders. The resultant set needs to contain
            //a collection of objects that each have a Gender and a collection of students of that gender
            var studentsByGender = (from s in students
                                     group s by s.Gender into genders
                                     select new { StudentGender = genders.Key, genders }
                                     ).ToList();

            //TODO 3b: Loop through the students by gender resultset
            foreach (var genderisedStudents in studentsByGender)
            {
                //TODO 3c: Create a LINQ query that groups the current set of students by their hobbies and
                //sequence them in order of descending popularity and, to deal with counts that are equal, into alpbetical order by hobby.
                //The resultant set needs to contain a collection of objects that each have a Hobby and a collection of students who
                //claim to enjoy that hobby.
                var studentsByHobbiesWithinGenderSequence = (from s in genderisedStudents.genders
                                                             group s by s.Hobby into studentsByHobby
                                                             orderby studentsByHobby.Count() descending, studentsByHobby.Key
                                                             select new { Hobby = studentsByHobby.Key, studentsByHobby }
                     ).ToList();
                //TODO 3d:  Loop around the studentsByHobbiesWithinGenderSequence collection and display the gender, hobby and count of 
                //students who like the habby
                foreach (var studentHobby in studentsByHobbiesWithinGenderSequence)
                {
                    Console.WriteLine($"Gender: {genderisedStudents.StudentGender}, Hobby: {studentHobby.Hobby}, Count: {studentHobby.studentsByHobby.Count()}");
                }
            }
        }
    }
}
