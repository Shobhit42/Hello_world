using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public abstract class IAnimal
    {
        public abstract void NoOfLegs();
    }
    internal class InterfacePractice : IAnimal
    {
        public override void NoOfLegs()
        {
            Console.WriteLine("khbef");
        }
        public static void Main(string[] args)
        {
            InterfacePractice obj = new InterfacePractice();
            obj.NoOfLegs();
        }

        public void NoOfLegs()
        {
            Console.WriteLine("2");
        }
    }
}
