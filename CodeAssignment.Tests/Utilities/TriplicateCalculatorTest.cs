using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeAssignment.Utilities;

namespace CodeAssignment.Tests.Utilities
{
    [TestClass]
    public class TriplicateCalculatorTest
    {
        [TestMethod]
        public void Calculate_Triplicates_No_Matches()
        {
            // Act            
            List<int> result = TriplicateCalulator.CalculateTriplicates(new List<int>() { 1, 4, 2, 6, 3, 4, 9, 22, - 6 });
            List<int> expected = new List<int> { };

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Triplicates_Matches()
        {
            // Act            
            List<int> result = TriplicateCalulator.CalculateTriplicates(new List<int>() { 1, 1, 1, 2, 3, 3, 3, -6, -6, -6 });
            List<int> expected = new List<int> { 3, 1, -6 };

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Triplicates_Blank_Input()
        {
            // Act            
            List<int> result = TriplicateCalulator.CalculateTriplicates(new List<int>() { });
            List<int> expected = new List<int> { };

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
