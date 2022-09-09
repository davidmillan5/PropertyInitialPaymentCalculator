using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialPayment
{
    internal class InitialPayment
    {
        //1st Attributes

        private String projectName;
        private double propertyValue;
        private double initialPaymentPercentage;
        private int months;
        private double additionalPayments;
        private double monthlyPayment;
        private double bankCredit;
        private double initialPayment;
        




        //2nd Encapsulation

        public string ProjectName { get => projectName; set => projectName = value; }
        public double PropertyValue { get => propertyValue; set => propertyValue = value; }
        public double InitialPaymentPercentage { get => initialPaymentPercentage; set => initialPaymentPercentage = value; }
        public double AdditionalPayments { get => additionalPayments; set => additionalPayments = value; }
        public int Months { get => months; set => months = value; }
        public double MonthlyPayment { get => monthlyPayment; set => monthlyPayment = value; }
        public double BankCredit { get => bankCredit; set => bankCredit = value; }
        



        //3rd Constructor


        public InitialPayment() { }



        public InitialPayment(string projectName, double propertyValue, double initialPaymentPercentage, double additionalPayments, int months, double monthlyPayment, double bankCredit)
        {
            this.projectName = projectName;
            this.propertyValue = propertyValue;
            this.initialPaymentPercentage = initialPaymentPercentage;
            this.additionalPayments = additionalPayments;
            this.months = months;
            this.monthlyPayment = monthlyPayment;
            this.bankCredit = bankCredit;
        }

        public InitialPayment(string projectName, double propertyValue, double initialPaymentPercentage, int months)
        {
            this.projectName = projectName;
            this.propertyValue = propertyValue;
            this.initialPaymentPercentage = initialPaymentPercentage;
            this.months = months;
            
        }

        public InitialPayment(string projectName, double propertyValue, double initialPaymentPercentage, int months, double additionalPayments) : this(projectName, propertyValue, initialPaymentPercentage, months)
        {
            this.additionalPayments = additionalPayments;
        }



        //4th Methods


        public void NewProperty()
        {
            Console.WriteLine();
            Console.Write("Enter the name of the project: ");
            projectName = Console.ReadLine();

            Console.Write("Enter the price of the project apartment/house: ");
            propertyValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the percentage of initial payment: ");
            initialPaymentPercentage = double.Parse(Console.ReadLine());

            Console.Write("Enter the amount of month for the initial payment: ");
            months = int.Parse(Console.ReadLine());

            InitialValue();
            MonthlyPaymentCharge();
            CreditRequest();
            PaymentReview();
        }

        public void newPropertySpecialPayment()
        {
            Console.WriteLine();
            Console.Write("Enter the name of the project: ");
            projectName = Console.ReadLine();

            Console.Write("Enter the price of the project apartment/house: ");
            propertyValue = double.Parse(Console.ReadLine());

            Console.Write("Enter the percentage of initial payment: ");
            initialPaymentPercentage = double.Parse(Console.ReadLine());

            Console.Write("Enter the amount of additional Payments: ");
            additionalPayments = double.Parse(Console.ReadLine());

            Console.Write("Enter the amount of month for the initial payment: ");
            months = int.Parse(Console.ReadLine());

            InitialValue();
            SpecialInitialMonthlyPayment();
            CreditRequest();
            PaymentReview();
        }

        public void InitialValue()
        {
            initialPayment = propertyValue * initialPaymentPercentage;
        }

        public void MonthlyPaymentCharge()
        {
            monthlyPayment = (propertyValue*initialPaymentPercentage)/months;
        }


        public void CreditRequest()
        {
            bankCredit = propertyValue - initialPayment;
        }

       
        public void SpecialInitialMonthlyPayment()
        {
            monthlyPayment = ((propertyValue * initialPaymentPercentage) - additionalPayments) / months;
        }

        public void PaymentReview()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t **************** FINANCIAL ANALYSIS ***********************");
            Console.WriteLine();
            Console.WriteLine("\tProject Name -------------------------------------------------> " + projectName);
            Console.WriteLine("\tProperty Value -----------------------------------------------> " +"$ "+ PropertyValue.ToString("C3") +" pesos");
            Console.WriteLine("\tInitial Percentage -------------------------------------------> " + initialPaymentPercentage+"%");
            Console.WriteLine("\tInitial Payment Months ---------------------------------------> " + months+" meses");
            Console.WriteLine("\tInitial Payment ----------------------------------------------> " +"$ " +initialPayment.ToString("C3") +" pesos");
            Console.WriteLine("\tMonthly Payment ----------------------------------------------> " + "$ " + monthlyPayment.ToString("C3") + " pesos");
            Console.WriteLine("\tCredit Amount ------------------------------------------------> " + "$ " + bankCredit.ToString("C3") + " pesos");
            Console.WriteLine();
            Console.WriteLine("\t**************************************************************");
        }

        public void CalculatorMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Monthly Payment Calculator, press: \n1. Monthly Payments without special agreement. \n2. Monthly Payment including special additional payments.");
            int options = int.Parse(Console.ReadLine());

            if(options == 1)
            {
                NewProperty();
            }
            else if(options == 2)
            {
                newPropertySpecialPayment();
            }
            else
            {
                Console.WriteLine("Enter a valid option.");
            }
        }




    }
}
