using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalaryHelper
{
    internal class SalaryInputs
    {
        public double salary { get; set; }
        public char familyStatus { get; set; }
        public byte children { get; set; }
        public char invalid { get; set; }
        public bool isInvalid { get; set; }

        private static byte familyBenefit = 50;
        public byte FamilyBenefit
        {
            get { return familyBenefit; }
            set { familyBenefit = value; }
        }
        //private List<double> taxDeductionDegrees;

        //public List<double> TaxDeductionDegrees
        //{
        //    get { return taxDeductionDegrees; } 
        //    set { taxDeductionDegrees = value; }
        //}
    }
    public enum childBenefit
    {
        oneChild = 30,
        twoChildren = 25,
        threeChildren = 20,
        fourOrMoreChildren = 15
    }

    public enum taxDeductionDegree
    {
        firstLevel = 15,
        secondLevel = 20,
        thirdLevel = 25,
        fourLevel = 30,
        fiveLevel = -50,
    }
}
