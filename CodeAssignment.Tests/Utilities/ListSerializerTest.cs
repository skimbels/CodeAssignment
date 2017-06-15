using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeAssignment.Utilities;

namespace CodeAssignment.Tests.Utilities
{
    [TestClass]
    public class ListSerializerTest
    {
        [TestMethod]
        public void Serialize_List()
        {
            // Act            
            string result = ListSerializer.Serialize(new List<int>() { 1, 4, 2, 6, -4 });
            string expected = "[1,4,2,6,-4]";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Serialize_Blank()
        {
            // Act            
            string result = ListSerializer.Serialize(new List<int>() {});
            string expected = "[]";

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Deserialize_List()
        {
            // Act            
            string errorMessage;
            var result = ListSerializer.Deserialize("[1,4,2,6,-4]", out errorMessage);
            var expected = new List<int>() { 1, 4, 2, 6, -4 };

            // Assert
            CollectionAssert.AreEqual(expected, result);
            Assert.IsTrue(string.IsNullOrEmpty(errorMessage));
        }

        [TestMethod]
        public void Deserialize_Blank()
        {
            // Act            
            string errorMessage;
            var result = ListSerializer.Deserialize("[]", out errorMessage);
            var expected = new List<int>() { };

            // Assert
            CollectionAssert.AreEqual(expected, result);
            Assert.IsTrue(string.IsNullOrEmpty(errorMessage));
        }

        [TestMethod]
        public void Deserialize_Bad_Input()
        {
            // Act            
            string errorMessage;
            var result = ListSerializer.Deserialize("[abc, 44.3, 5, 6]", out errorMessage);
            List<int> expected = null;

            // Assert
            CollectionAssert.AreEqual(expected, result);
            Assert.IsFalse(string.IsNullOrEmpty(errorMessage));
        }
    }
}
