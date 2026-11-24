using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName {  get; set; }

        [Required]
        public string Department { get; set; }

        [Range(1, 1000000)]
        public decimal Salary { get; set; }

        // --- NEW BUSINESS LOGIC FOR TESTING ---
        public decimal CalculateAnnualBonus()
        {
            if (Salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            // Bonus is 10% of the salary
            return Salary * 0.10m;
        }
    }
}
