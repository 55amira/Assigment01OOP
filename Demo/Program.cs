namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct
            //Struct : Value Type : STACK
            //Point P01;
            ////Declear For Object From Typr Point
            ////PO01 : Object
            ////Allocate Uninitialized 8 Bytes At STACK

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);//unassigned

            ////P01.X = 12;
            ////P01.Y = 12;
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            // P01=new Point(1,2 );

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////Console.WriteLine(P01);
            //P01.Print(); 
            #endregion

            //OOP : Object Oriented Programing

            Employee E01=new Employee(1,"ahmed",1220);

            //E01.id= 1;
            //E01.name = "Ahmed";
            //E01.salary = 121000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);


           //E01.SetId(1);
           //E01.SetName("Ahmed");
           //E01.SetSalary(121000);
           //
           //Console.WriteLine(E01.GetId());
           //Console.WriteLine(E01.GetSalary());
           //Console.WriteLine(E01.GetName());

            Console.WriteLine(E01);







        }
    }
}
