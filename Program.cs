using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    class Staff
    {
        private float hourlyRate;
        private int hWorked;
        public float TotalPay{ get; protected set;}
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked
        {
            get{ return hWorked; }
            set
            {
                if (value > 0)
                {
                   hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }

        public Staff(string name, float rate)
        {
           NameOfStaff = name;
           hourlyRate = rate;
        }
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * HoursWorked;
            TotalPay = BasicPay;       
        }

        public override string ToString()
        {
            return "\nStaff Name = " + NameOfStaff
                + "\nHourly Rate ="  + "\nHours Worked = " + HoursWorked
                +"\nBasic Pay = " + "\nTotalPay = " + TotalPay;
        }
    }

    class Manager:Staff
    {
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }
        public Manager(string name) : base(name, managerHourlyRate){ }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 0;

            if (HoursWorked > 160)
            {
                Allowance = 1000;
                TotalPay = BasicPay + Allowance;
            }
            else
            {
                TotalPay = TotalPay;
            }
        }

        public override string ToString()
        {
            return "\nStaff Name = " + NameOfStaff
                + "\nHourly Rate =" + "\nHours Worked = " + HoursWorked
                + "\nBasic Pay = " + "\nTotalPay = " + TotalPay;
        }
    }

    class Admin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        public float Overtime { get; private set; }

        public Admin(string name): base(name, adminHourlyRate){ }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Overtime = 0;

            if (HoursWorked > 160)
            {
                Overtime = overtimeRate*(HoursWorked - 160);
                TotalPay = BasicPay + Overtime;
            }
            else
            {
                TotalPay = TotalPay;
            }
        }

        public override string ToString()
        {
            return "\nStaff Name = " + NameOfStaff
                + "\nHourly Rate =" + "\nHours Worked = " + HoursWorked
                + "\nBasic Pay = " + "\nTotalPay = " + TotalPay;
        }
    }

    class FileReader
    {

    }

    class PaySlip
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
