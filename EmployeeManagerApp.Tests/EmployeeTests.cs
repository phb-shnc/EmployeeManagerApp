using NUnit.Framework;
using EmployeeManagerApp.Models;
using System;

namespace EmployeeManagerApp.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CalcullateAnnualBonus_ValidSalary_ReturnsTenPercent()
        {
            // 1. ARRANGE: Set up the initial state
            var employee = new Employee { Salary = 60000m };
            decimal expectedBonus = 6000m;

            // 2. ACT: Execute the method being tested
            decimal actualBonus = employee.CalculateAnnualBonus();

            // 3. ASSERT: Verify the result matches our expectation
            Assert.AreEqual(expectedBonus, actualBonus);
        }

        [Test]
        public void CalculateAnnualBonus_NegativeSalary_ThrowsArgumentException()
        {
            // 1. ARRANGE
            var employee = new Employee { Salary = -5000m };

            // 2. ACT & 3. ASSERT
            // We assert that calling this method with bad data throws an exception
            Assert.Throws<ArgumentException>(() => employee.CalculateAnnualBonus());
        }
    }
}