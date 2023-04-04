using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SalaryHelper.SalaryInputs;

namespace SalaryHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create Class objects 
            SalaryInputs salaryInputs = new SalaryInputs(); 
            TaxDeduction taxDeduction = new TaxDeduction();


            List<int> childBenefits = new List<int>(); 
            double netSalary = 0;
            double taxValue = 0;

        
            //get Inputs
            Console.WriteLine("Iscinin Emek haqqini daxil edin (tam mebleg): ");
            salaryInputs.salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Iscinin Aile veziyyetinizi daxil edin (e/E: evli, b/B: subay, d/D: dul): ");
            salaryInputs.familyStatus = char.Parse(Console.ReadLine());

            Console.WriteLine("Iscinin Usaqlarinin sayini reqemle daxil edin (Subaysinizsa 0 olaraq qeyd edin): ");
            salaryInputs.children = byte.Parse(Console.ReadLine());

            Console.WriteLine("Iscinin elil olub-olmamasini daxil edin (e/E: beli, h/N: yox): ");
            salaryInputs.invalid = char.Parse(Console.ReadLine());

            Console.WriteLine("\n");


            //Add addition money to salary for familyStatus
            if (salaryInputs.familyStatus == 'e' || salaryInputs.familyStatus.Equals('E')) 
            { 
                salaryInputs.salary += salaryInputs.FamilyBenefit; 
            }

            //Add addition money to salary for children
            for (double i = 0; i <= salaryInputs.children; i++)
            {
                if (i==1) {salaryInputs.salary += (int)childBenefit.oneChild; childBenefits.Add((int)childBenefit.oneChild); }
                else if (i==2) {salaryInputs.salary += (int)childBenefit.twoChildren; childBenefits.Add((int)childBenefit.twoChildren); }
                else if (i == 3) {salaryInputs.salary += (int)childBenefit.threeChildren; childBenefits.Add((int)childBenefit.threeChildren); }
                else 
                {
                    if (i!=0) 
                    {
                        salaryInputs.salary += (int)childBenefit.fourOrMoreChildren; 
                        childBenefits.Add((int)childBenefit.fourOrMoreChildren); 
                    }                  
                }
            }

            //check employee is invalid or not
            if (salaryInputs.invalid.Equals('e')|| salaryInputs.invalid.Equals('E'))
            {
                salaryInputs.isInvalid = true;
            }

            //get TaxDeduction Value and Net Salary of employee
            taxValue = taxDeduction.CalculateTaxDeduction(salaryInputs.salary, salaryInputs.isInvalid);
            netSalary = salaryInputs.salary - taxValue;

            #region OutPut
            Console.WriteLine($"Aile muavineti: {salaryInputs.FamilyBenefit}");
            foreach (int childBenefitValues in childBenefits) 
            {
                Console.WriteLine($"Usaq pulu:{childBenefitValues}");
            }
            foreach (var taxDeductionDegrees in taxDeduction.taxDeductionDegrees)
            {
                Console.WriteLine($"Isciden tutulan gelir vergisi derecesi: {taxDeductionDegrees}%");
            }
            
            Console.WriteLine($"Isciden tutulan gelir vergisini goster: {taxValue}");
            Console.WriteLine($"Umumi emek haqqi: {salaryInputs.salary}");
            Console.WriteLine($"Iscinin xalis emek haqqisini goster: {netSalary}");
            #endregion

            Console.ReadKey();  
        }
    }
}
