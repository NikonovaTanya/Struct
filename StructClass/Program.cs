using System;

namespace StructClass
{
    class Program
    {   static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] a1rgs)
        {
            MyStruct myS= new MyStruct { change="не изменено" };
            MyClass myC = new MyClass("не изменено");
            Console.WriteLine(myC.change);
            Console.WriteLine(myS.change);
            Console.WriteLine("-----------------------------------------------------------------------------");
            ClassTaker(myC);
            StructTaker(myS);
            Console.WriteLine(myC.change);
            Console.WriteLine(myS.change);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Поле change не изменилось при выполнении метода  ");
            Console.WriteLine("static void StructTaker(MyStruct myStruct), так как параметр myStruct передан по значению");
        }
    }
}
