// Purpose: The disk class store the disk’s diameter, colour, current level and current peg number.
// The disk class should have methods that allow access to the data items.
// Author: Zhiyu Lei
// Date: 20/10/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RayTowers
{
    

    class Disk
    {
        private int diskID,
                      disk_Diam,
                      disk_PegNum;

        private Color disk_Colour;

        // The Custructor store the disk’s diameter, colour, current level and current peg number. 
        public Disk(int aDiskID, int aDiameter, Color aColour, int aPeg)
        {
            diskID = aDiskID;
            disk_Diam = aDiameter;
            disk_Colour = aColour;
            disk_PegNum = aPeg;
        }

        // The disk class allows access to set disk_PegNum
        public void setPegNum(int newPeg)
        {
            disk_PegNum = newPeg;
        }

        // The disk class allows access to get diskID
        public int getDiskID()
        {
            return diskID;
        }

        // The disk class allows access to get disk_Colour
        public Color getDiskColour()
        {
            return disk_Colour;
        }

        // The disk class allows access to get disk_Diam
        public int getDiameter()
        {
            return disk_Diam;
        }

        // The disk class allows access to get disk_PegNum
        public int getPegNum()
        {
            return disk_PegNum;
        }


    }
}
