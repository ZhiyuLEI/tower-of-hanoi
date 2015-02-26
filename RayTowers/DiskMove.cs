// Purpose: Store the index of the disk making the move and the new Peg it is dropped on.
// Author: Zhiyu Lei
// Date: 20/10/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RayTowers
{
    public class DiskMove
    {
        private string diskIDStr, pegNumStr;

        // The constructor that takes two integers (for disk index and peg) as parameters
        public DiskMove(Int32 aDisk, Int32 aPeg)
        {
            diskIDStr = aDisk.ToString();
            pegNumStr = aPeg.ToString();
        }

        // The constructor that takes a string in the form “2,1” as its parameter
        public DiskMove(String aDisk, String aPeg)
        {
            diskIDStr = aDisk;
            pegNumStr = aPeg;
        }

        // Have an AsText () method that gives this information as a string
        public string AsText()
        {
            return ("Disk" + diskIDStr + " to Peg " + pegNumStr);
        }

            
       


    }
}
