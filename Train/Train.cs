using System;
using System.Collections.Generic;
using System.Text;

namespace Train
{
    struct Train
    { private string destination;
      private int trNumber;
      private DateTime depTime;
      public string Destination
      {
            get { return destination; }
            set { destination = value; }
      }
      public int TrNumber
      {
            get { return trNumber; }
            set { trNumber = value; }
      }
     public DateTime DepTime
     {
            get { return depTime; }
            set { depTime = value; }
        }
    }
   
}
