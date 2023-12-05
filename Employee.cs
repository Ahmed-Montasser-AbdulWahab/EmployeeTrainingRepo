using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal enum Degree
    {
        Employee,
        Manager
    }
    public enum Governorate
    {
        Cairo,
        Alexandria,
        Other
    }
    public class Employee
    {
        private Degree _degree = Degree.Employee;



        public string DegreeOfEmployee
        {
            get
            {
                return _degree switch
                {
                    Degree.Employee => "Employee",
                    Degree.Manager => "Manager",
                    _ => "Other"
                };
            }
            set
            {
                value = value.ToUpper();
                _degree = value[0] switch
                {
                    'E' => Degree.Employee,
                    'M' => Degree.Manager,
                    _ => Degree.Employee
                };
                SetDegree();
            }
        }

        private int[] _fullId = new int[3]; //0:Gov 1:Id 2:Degree
        public string FullId
        {
            get
            {
                return string.Join("/", _fullId);
            }
        }

        private int this[int index] //Indexer
        {
            get
            {
                return _fullId[index];
            }

            set
            {
                _fullId[index] = value;
            }
        }


        public Employee(int gov, string Degree)
        {
            SetGovernorate((Governorate) gov);
            SetRandomId();
            DegreeOfEmployee = Degree;
        }
        public Employee() : this(2, "Employee")
        {
            this[1] = 0;
        }

        //Methods

        public string GetGovernorate()
        {

            return this[0] switch
            {
                0 => "Cairo",
                1 => "Alexandria",
                _ => "Other"
            };
        }


        public void SetGovernorate(Governorate gov)
        {
            this[0] = gov switch
            {
                Governorate.Cairo => 0,
                Governorate.Alexandria => 1,
                _ => 2
            };
        }

        public string GetId()
        {

            return $"{this[1]}";

        }
        public void SetRandomId()
        {
            Random rd = new Random();
            this[1] = rd.Next(1000,9999);
        }

        private void SetDegree()
        {
            this[2] = (int) _degree ;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Employee FullId : {FullId}");
            Console.WriteLine($"Employee Governorate : {GetGovernorate()}");
            Console.WriteLine($"Employee Id : {GetId()}");
            Console.WriteLine($"Employee Degree : {DegreeOfEmployee}");
        }

    }
}
