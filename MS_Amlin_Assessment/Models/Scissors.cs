using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Amlin_Assessment.Models
{
    public class Scissors : Shape
    {
        public override int Beats(Rock rock)
        {
            return -1;
        }

        public override int Beats(Paper paper)
        {
            return 1;
        }

        public override int Beats(Scissors scissors)
        {
            return 0;
        }

        public override int Beats(Shape shape)
        {
            return shape.Beats(this);
        }
    }
}