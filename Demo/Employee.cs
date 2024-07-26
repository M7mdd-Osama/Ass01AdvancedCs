using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $" {Id} ,{Name} , {Salary} ";
        } 
        public static bool operator ==(Employee left,Employee Right)
        {
            return(left.Id ==  Right.Id) && (left.Name == Right.Name) && (left.Salary == Right.Salary);
        }
        public static bool operator !=(Employee left, Employee Right)
        {
            return !left.Equals(Right);

        }
    }
}
