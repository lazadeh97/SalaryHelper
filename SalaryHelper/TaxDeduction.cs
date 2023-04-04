using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryHelper
{
    internal class TaxDeduction
    {
        public List<double> taxDeductionDegrees = new List<double>();
        public double CalculateTaxDeduction(double grossSalary, bool isInvalid)
        {          
            if (grossSalary <= 1000)
            {
                grossSalary *= ((double)taxDeductionDegree.firstLevel) / 100;
                taxDeductionDegrees.Add((double)taxDeductionDegree.firstLevel);
            }

            else if (grossSalary > 1000 && grossSalary <= 2000)
            {
                grossSalary *= ((double)taxDeductionDegree.secondLevel) / 100;
                taxDeductionDegrees.Add((double)taxDeductionDegree.secondLevel);
            }
               
            else if (grossSalary > 2000 && grossSalary <= 3000)
            {
                grossSalary *= ((double)taxDeductionDegree.thirdLevel) / 100;
                taxDeductionDegrees.Add((double)taxDeductionDegree.thirdLevel);
            }
                
            else if (grossSalary > 3000)
            {
                grossSalary *= ((double)taxDeductionDegree.fourLevel) / 100;
                taxDeductionDegrees.Add((double)taxDeductionDegree.fourLevel);
            }

            if (isInvalid)
            {
                grossSalary += grossSalary * ((double)taxDeductionDegree.fiveLevel) / 100;
                taxDeductionDegrees.Add((double)taxDeductionDegree.fiveLevel);
            }

            return Math.Round(grossSalary,2);
        }      
    }
}
