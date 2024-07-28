using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $" {Id} ,{Name} , {Salary} ";
        }
        //public static bool operator ==(Employee left,Employee Right)
        //{
        //    return(left.Id ==  Right.Id) && (left.Name == Right.Name) && (left.Salary == Right.Salary);
        //}
        //public static bool operator !=(Employee left, Employee Right)
        //{
        //    return !left.Equals(Right);

        //}

        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj;
            return (this.Id == employee?.Id) && (this.Name == employee?.Name) && (this.Salary == employee?.Salary);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode() + Name?.GetHashCode()+ Salary.GetHashCode());
            //return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? 0 + this.Salary.GetHashCode();
        }

        public int CompareTo(object? obj)
        {
            //if(obj is Employee PassedEmployee)
            //{
            //    return this.Salary.CompareTo(PassedEmployee.Salary);
            //}
            //return 1;
            Employee? PassedEmployee = obj as Employee;
            return this.Salary.CompareTo(PassedEmployee?.Salary);
        }
    }
}
