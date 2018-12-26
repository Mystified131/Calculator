using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{

    public class GetResult
    {
        public string Name { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public string Operation { get; set; }

        public GetResult(string name)
        {
           Name = name;
        }

        public double Sum(double Value1, double Value2)
        {
            double Resnum;
            Resnum = Value1 + Value2;
            return Resnum;

        }

        public double Difference(double Value1, double Value2)
        {
            double Resnum;
            Resnum = Value1 - Value2;
            return Resnum;

        }

        public double Product(double Value1, double Value2)
        {
            double Resnum;
            Resnum = Value1 * Value2;
            return Resnum;

        }

        public double Quotient(double Value1, double Value2)
        {
            double Resnum;
            Resnum = Value1 / Value2;
            return Resnum;

        }

    }
       
    }




