using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AForge.Genetic
{
    /// <summary>
    /// 
    /// </summary>
    public class MusicFunction : OptimizationFunction1D
    {
        /// <summary>
        /// 
        /// </summary>
        public MusicFunction() :
             base( new Range( 0, 255 ) ) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public override double OptimizationFunction(double x)
        {
            double result = 1 / System.Math.Sqrt(x / 10);
            //return System.Math.Cos(x / 23) * System.Math.Sin(x / 50) + 2;
            return result;
            //return System.Math.Cos(x / 23) ;
        }
    }
}
