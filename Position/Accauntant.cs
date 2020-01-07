using System;
using System.Collections.Generic;
using System.Text;

namespace Position
{
    public class Accauntant
    {  
        public bool AskBonus(EnumPos worker, int hours)
      {
            bool flag=false;
            if ((int)worker < hours)
            {
                flag = true;
                Console.WriteLine("Премия положена");
            }
            else
                Console.WriteLine("Премия не положена");
            return flag;
      }
    }
}
