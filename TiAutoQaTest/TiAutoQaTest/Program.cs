using System;


namespace TiAutoQaTest
{
    internal class Program
    {
        private static double CountLength(double firstXcoordinate, double firstYcoordinate, double secondXcoordinate, double secondYcoordinate)
        {
            double result = Math.Sqrt(Math.Pow(secondXcoordinate - firstXcoordinate, 2) + Math.Pow(secondYcoordinate - firstYcoordinate, 2));
            return result;
        }
        static void Main(string[] args)
        {
            double Ax, Ay, Bx, By, Cx, Cy;
            Console.WriteLine("Enter coordinate x of dot A: ");
            Ax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A: ");
            Ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot B: ");
            Bx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B: ");
            By = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C: ");
            Cx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C: ");
            Cy = Convert.ToDouble(Console.ReadLine());

            double AB = CountLength(Ax, Ay, Bx, By), BC = CountLength(Bx, By, Cx, Cy), AC = CountLength(Ax, Ay, Cx, Cy);
            Console.WriteLine("Length of AB is: " + AB + "\n" + "Length of BC is: " + BC + "\n" + "Length of AC is: " + AC + "\n");

            if (AB+BC<=AC || AB+AC<=BC || BC + AC <= AB)
                throw new Exception($"There are no Triangle with these dots: A({Ax},{Ay}), B({Bx},{By}), C({Cx},{Cy})");
            string IsEquilateral = AB == AC && AB == BC ? "Triangle IS 'Equilateral'" : "Triangle IS NOT 'Equilateral'";
            string IsIsosceles = AB == AC || AB == BC || BC == AC ? "Triangle IS 'Isosceles'" : "Triangle IS NOT 'Isosceles'";
            string IsRight = AB * AB + BC * BC == AC * AC || AB * AB == BC * BC + AC * AC || AB * AB + AC * AC == BC * BC ?
                "Triangle IS 'Right'" : "Triangle IS NOT 'Right'";
            Console.WriteLine(IsEquilateral + "\n" + IsIsosceles + "\n" + IsRight);
            

            
            double Perimetr = AB + BC + AC;
            Console.WriteLine("Perimetr: " + Perimetr);
            for(int i = 0; i<Perimetr; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        
       
    }
}
