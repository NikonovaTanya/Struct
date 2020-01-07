using System;

namespace Position
{
    class Program
    {
        static void Main(string[] args)
        { EnumPos pos=EnumPos.programmer;
          Accauntant acc = new Accauntant();
            Console.WriteLine(pos+" "+(int)pos);
          acc.AskBonus(pos, 190);
        }
    }
}
