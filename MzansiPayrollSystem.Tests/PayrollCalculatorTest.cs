using Microsoft.VisualStudio.TestTools.UnitTesting;
using MzansiPayrollSystem;
using System;

namespace MzansiPayrollSystem.Tests
{
    [TestClass]
    public class PayrollCalculatorTest
    {
        public TestContext TestContext { get; set; }
        private PayrollCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new PayrollCalculator();
        }
        [TestMethod]
        [TestCategory("Unit Test")]
        public void GrossPay_ShouldReturnR16150_WhenHoursWorkedIs17()
        {
            double hoursWorked = 17;
            double expected = 16150.00;

            double actual = calculator.CalculateGrossPay(hoursWorked);

            Console.WriteLine($"Hours: {hoursWorked}, Expected: R{expected}, Actual: R{actual}");
            Assert.AreEqual(expected, actual, 0.01, "Gross Pay calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void UIF_ShouldReturn1Percent_OfGrossPay()
        {
            double grossPay = 16150.00;
            double expected = 161.50;

            double actual = calculator.CalculateUIF(grossPay);

            Console.WriteLine($"Gross: R{grossPay}, Expected UIF: R{expected}, Actual: R{actual}");
            Assert.AreEqual(expected, actual, 0.01, "UIF calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void MembershipFee_ShouldReturn13Percent_OfGrossPay()
        {
            double grossPay = 16150.00;
            double expected = 2099.50;

            double actual = calculator.CalculateMembershipFee(grossPay);

            Console.WriteLine($"Gross: R{grossPay}, Expected Membership: R{expected}, Actual: R{actual}");
            Assert.AreEqual(expected, actual, 0.01, "Membership Fee calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void PAYE_ShouldReturnCorrectAmount_WhenGiven3Dependents()
        {
            double grossPay = 16150.00;
            int dependents = 3;
            double expected = 3341.03;

            double actual = calculator.CalculatePAYE(grossPay, dependents);

            Console.WriteLine($"Gross: R{grossPay}, Dependents: {dependents}, Expected PAYE: R{expected}, Actual: R{actual}");
            Assert.AreEqual(expected, actual, 0.01, "PAYE calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void NetPay_ShouldReturnCorrectAmount_WhenAllDeductionsAreApplied()
        {
            double grossPay = 16150.00;
            double uif = calculator.CalculateUIF(grossPay);
            double membership = calculator.CalculateMembershipFee(grossPay);
            double paye = calculator.CalculatePAYE(grossPay, 3);
            double expected = grossPay - uif - membership - paye;

            double actual = calculator.CalculateNetPay(grossPay, uif, paye, membership);

            Console.WriteLine($"Gross Pay: R{grossPay}");
            Console.WriteLine($"UIF: R{uif}");
            Console.WriteLine($"PAYE: R{paye}");
            Console.WriteLine($"Membership Fee: R{membership}");
            Console.WriteLine($"Expected Net Pay: R{expected}");
            Console.WriteLine($"Actual Net Pay: R{actual}");
            Assert.AreEqual(expected, actual, 0.01, "Net Pay calculation is incorrect.");
        }
    }
}