using System;

namespace oops
{

    public class Matrix
    {
        int a;
        int b;
        int c;
        int d;

        public Matrix(int a, int b, int c,int d)
        {
            this.a = a;
            this.b = b;    
            this.c = c;
            this.d = d;
        }

        public static Matrix operator +(Matrix mat1, Matrix mat2)
        {
            return new Matrix(mat1.a + mat2.a, mat1.b + mat2.b, mat1.c + mat2.c, mat1.d + mat2.d);
        }

        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }

        public static void Main(string[] args)
        {
            Matrix mat1 = new Matrix(10, 20, 30, 40);
            Matrix mat2 = new Matrix(20, 30, 40, 50);
            Matrix mat3 = mat1 + mat2;

            Console.WriteLine(mat3);
            Console.ReadLine();
        }
    }
    public class Program
    {
        public virtual void Method1()
        {
            Console.WriteLine("Method of parent class");
            Console.ReadLine();
        }
    }

    public class Child : Program
    {   
        public override void Method1()
        {
            Console.WriteLine("Method of child class");
            Console.ReadLine();
        }
        //public static void Main(string[] args) { 
        //    //Child c = new Child();
        //    //c.Method1();

        //    int a = 1000001110;
        //    int x = -12 - a;
        //    int[] arr = new int[x];
        //    Console.WriteLine(arr.Length);
        //    Console.ReadLine() ;
        //}
    }
}
