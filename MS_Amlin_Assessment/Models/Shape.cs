using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MS_Amlin_Assessment.Models
{
    public abstract class Shape
    {

        public static Shape newShape(String shapeName)
        {
		    try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes()
                    .First(t => t.Name == shapeName);
                return (Shape)Activator.CreateInstance(type);
            }
		    catch(Exception e) {
			    throw new Exception("Not a valid Gesture name", e);			
		    }
	    }

        public abstract int Beats(Rock rock);
        public abstract int Beats(Paper paper);
        public abstract int Beats(Scissors scissors);
        public abstract int Beats(Shape shape);
    }

    public enum Shapes { Rock, Paper, Scissors}
}