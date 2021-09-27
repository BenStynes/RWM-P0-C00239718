using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;


namespace Tests
{
    public class DecrimentIfLessThanFirstTest
    {
        [Test]
        public void DecrimentIfLessThanFirstSimple()
        {
            int[] input = {4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = DecrementIfLessThanFirst.decrementIfLessS(input);
            int[] expected = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
