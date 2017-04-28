using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Amlin_Assessment.Models
{
    public class Player
    {
        public Shape ShowShape(string shapeName)
        {
            return Shape.newShape(shapeName);
        }
    }
}