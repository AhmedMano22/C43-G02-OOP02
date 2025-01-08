namespace Assignment02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Person person1 = new Person("saeed", 25);
            //Console.WriteLine(person1);

            ////////////////////////
            /////

            //Person[] people = new Person[3];
            //people[0] = new Person { Name = "Ahmed", Age = 25 };
            //people[1] = new Person { Name = "Saed", Age = 30 };
            //people[2] = new Person { Name = "Ali", Age = 35 };
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}



            #endregion


            #region Q2
            //Console.WriteLine("Enter coordinates for Point 1 (X and Y): ");
            //Point p1 = new Point { X = double.Parse(Console.ReadLine()), Y = double.Parse(Console.ReadLine()) };

            //Console.WriteLine("Enter coordinates for Point 2 (X and Y): ");
            //Point p2 = new Point { X = double.Parse(Console.ReadLine()), Y = double.Parse(Console.ReadLine()) };

            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine($"Distance between points: {distance:F2}");
            #endregion


            #region Q3
            // i use the same struct of previos Person Struct
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Person {i + 1}: ");
            //    Console.Write("Name: ");
            //    people[i].Name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}

            //Person oldest = people[0];
            //foreach (var person in people)
            //{
            //    if (person.Age > oldest.Age)
            //        oldest = person;
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion

            #region Q4
            //Rectangle R = new Rectangle();

            //Console.Write("Enter Width: ");
            //R.Width = double.Parse(Console.ReadLine());

            //Console.Write("Enter Height: ");
            //R.Height = double.Parse(Console.ReadLine());

            //R.DisplayInfo();
            #endregion
        }
    }
}
