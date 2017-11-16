using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMathLibrary;

namespace SimpleLibraryUnitTest
{

    [TestClass]
    public class UnitTest1
    {
        // Plus tests
        [TestMethod]
        public void TestPlusInt()
        {
            // Assemble
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 6;

            // Act
            int actualResult = MathOperation.Plus(2, 4);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestPlusFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 6.0000000F;

            // Act
            float actualResult = MathOperation.Plus(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestPlusDouble()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 3.71;

            // Act
            double actualResult = MathOperation.Plus(1.36,2.35);   

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Plus array tests, arrays equal size
        [TestMethod]
        public void TestPlusIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = {4.2F, 6.2F, 8.2F, 10.2F, 12.2F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Plus array tests, arrays non-equal size
        [TestMethod]
        public void TestPlusIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 6, 7 };
            int[] value1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 8, 9 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestPlusFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 4.2F, 6.2F, 8.2F, 10.2F, 12.2F, 6.1F, 7.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 4.2F, 6.2F, 8.2F, 10.2F, 12.2F, 8.1F, 9.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };

            // Act
            float[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestPlusDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27, 6.12, 7.13 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12, 6.12, 7.13 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27, 6.12, 7.13 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12, 6.12, 7.13 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Plus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }



        // Minus tests
        [TestMethod]
        public void TestMinusInt()
        {
            // Assemble
            MathOperation mathOperation = new MathOperation();
            int expectedResult = -2;

            // Act
            int actualResult = MathOperation.Minus(2, 4);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMinusFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = -2.0000000F;

            // Act
            float actualResult = MathOperation.Minus(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMinusDouble()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 1.36999- 1.35999;

            // Act
            double actualResult = MathOperation.Minus(1.36999, 1.35999);           // Double substract value problem

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Minus array tests, arrays equal size
        [TestMethod]
        public void TestMinusIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { -3, -4, -5, -6, -7 };

            // Act
            int[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinusFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 4.2F, 6.2F, 8.2F, 10.2F, 12.2F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { -3.1F, -4.1F, -5.1F, -6.1F, -7.1F };

            // Act
            float[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPlusMinusArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12 };
            double[] value2 = { -3.11, -4.12, -5.13, -6.14, -7.15 };

            // Act
            double[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Minus array tests, arrays non-equal size
        [TestMethod]
        public void TestMinusIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 6, 7 };
            int[] value1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] value2 = { -3, -4, -5, -6, -7 };

            // Act
            int[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinusIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 8, 9 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { -3, -4, -5, -6, -7, -8, -9 };

            // Act
            int[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMinusFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 4.2F, 6.2F, 8.2F, 10.2F, 12.2F, 6.1F, 7.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };
            float[] value2 = { -3.1F, -4.1F, -5.1F, -6.1F, -7.1F };

            // Act
            float[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinusFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 4.2F, 6.2F, 8.2F, 10.2F, 12.2F, 8.1F, 9.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { -3.1F, -4.1F, -5.1F, -6.1F, -7.1F, -8.1F, -9.1F };

            // Act
            float[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMinusDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27, 6.12, 7.13 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12, 6.12, 7.13 };
            double[] value2 = { -3.11, -4.12, -5.13, -6.14, -7.15 };

            // Act
            double[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinusDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 4.22, 6.23, 8.24, 10.25, 12.27, 6.12, 7.13 };
            double[] value1 = { 1.11, 2.11, 3.11, 4.11, 5.12, 6.12, 7.13 };
            double[] value2 = { -3.11, -4.12, -5.13, -6.14, -7.15 };

            // Act
            double[] actualResult = MathOperation.Minus(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }



        // Multiply tests
        [TestMethod]
        public void TestMultiplyInt()
        {
            // Assemble
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 6;

            // Act
            int actualResult = MathOperation.Multiply(2, 3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMultiplyFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 6.0000000F;

            // Act
            float actualResult = MathOperation.Multiply(1.999999999F, 2.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMultiplyDouble()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 6.25;

            // Act
            double actualResult = MathOperation.Multiply(2.5, 2.5);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Multiply array tests, arrays equal size
        [TestMethod]
        public void TestMultiplyIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 8, 15, 24, 35 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 1.1F * 3.1F, 2.1F * 4.1F, 3.1F * 5.1F, 4.1F * 6.1F, 5.1F * 7.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 1.1 * 3.1, 2.1 * 4.1, 3.1 * 5.1, 4.1 * 6.1, 5.1 * 7.1 };
            double[] value1 = { 1.1, 2.1, 3.1, 4.1, 5.1 };
            double[] value2 = { 3.1, 4.1, 5.1, 6.1, 7.1 };

            // Act
            double[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Multiply array tests, arrays non-equal size
        [TestMethod]
        public void TestMultiplyIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 8, 15, 24, 35, 6, 7 };
            int[] value1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 8, 15, 24, 35, 8, 9 };
            int[] value1 = { 1, 2, 3, 4, 5 };
            int[] value2 = { 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMultiplyFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 1.1F * 3.1F, 2.1F * 4.1F, 3.1F * 5.1F, 4.1F * 6.1F, 5.1F * 7.1F, 6.1F, 7.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 1.1F * 3.1F, 2.1F * 4.1F, 3.1F * 5.1F, 4.1F * 6.1F, 5.1F * 7.1F, 8.1F, 9.1F };
            float[] value1 = { 1.1F, 2.1F, 3.1F, 4.1F, 5.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };            
            

            // Act
            float[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMultiplyDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 1.1 * 3.1, 2.1 * 4.1, 3.1 * 5.1, 4.1 * 6.1, 5.1 * 7.1, 6.1, 7.1 };
            double[] value1 = { 1.1, 2.1, 3.1, 4.1, 5.1, 6.1, 7.1 };
            double[] value2 = { 3.1, 4.1, 5.1, 6.1, 7.1 };

            // Act
            double[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 1.1* 3.1, 2.1* 4.1, 3.1*5.1, 4.1* 6.1, 5.1* 7.1, 8.1, 9.1 };
            double[] value1 = { 1.1, 2.1, 3.1, 4.1, 5.1 };
            double[] value2 = { 3.1, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1 };

            // Act
            double[] actualResult = MathOperation.Multiply(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }



        // Divide tests
        [TestMethod]
        public void TestDivideInt()
        {
            // Assemble
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 4;

            // Act
            int actualResult = MathOperation.Divide(16, 4);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestDivideFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 1.999999999F / 3.99999999F;

            // Act
            float actualResult = MathOperation.Divide(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestDivideDouble()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 1.36 / 2.35;

            // Act
            double actualResult = MathOperation.Divide(1.36, 2.35);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Divide array tests, arrays equal size
        [TestMethod]
        public void TestDivideIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivideFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F / 3.1F, 12.1F / 4.1F, 13.1F / 5.1F, 14.1F / 6.1F, 15.1F / 7.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivideDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11 / 3.11, 20.11 / 4.12, 30.11 / 5.13, 40.11 / 6.14, 50.12 / 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Divide array tests, arrays non-equal size
        [TestMethod]
        public void TestDivideIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 100, 128 };
            int[] value1 = { 12, 24, 40, 60, 84, 100, 128 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivideIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 4, 6, 8, 10, 12, 1/ 8, 1/9 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestDivideFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F / 3.1F, 12.1F / 4.1F, 13.1F / 5.1F, 14.1F / 6.1F, 15.1F / 7.1F, 16.1F, 17.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 16.1F, 17.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivideFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F / 3.1F, 12.1F / 4.1F, 13.1F / 5.1F, 14.1F / 6.1F, 15.1F / 7.1F, 1.0F / 8.1F , 1.0F / 9.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };

            // Act
            float[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestDivideDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11 / 3.11, 20.11 / 4.12, 30.11 / 5.13, 40.11 / 6.14, 50.12 / 7.15, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12, 6.14, 7.15 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivideDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11 / 3.11, 20.11 / 4.12, 30.11 / 5.13, 40.11 / 6.14, 50.12 / 7.15, 1 / 6.14, 1/ 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Divide(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        
        // Minimum tests
        [TestMethod]
        public void TestMinInt()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 6;

            // Act
            int actualResult = MathOperation.Min(6, 8);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 1.999999999F;

            // Act
            float actualResult = MathOperation.Min(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinDouble()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 1.99;

            // Act
            double actualResult = MathOperation.Min(1.99, 3.99);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Minimum array tests, arrays equal size
        [TestMethod]
        public void TestMinIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 4, 5, 6, 7 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 3.11, 4.12, 5.13, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Minimum array tests, arrays non-equal size
        [TestMethod]
        public void TestMinIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 4, 5, 6, 7, 100, 128 };
            int[] value1 = { 12, 24, 40, 60, 84, 100, 128 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 3, 4, 5, 6, 7, 8, 9 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMinFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 16.1F, 17.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 16.1F, 17.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };

            // Act
            float[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMinDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 3.11, 4.12, 5.13, 6.14, 7.15, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12, 6.14, 7.15 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMinDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 3.11, 4.12, 5.13, 6.14, 7.15, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Min(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Maximum tests
        [TestMethod]
        public void TestMaxInt()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 8;

            // Act
            int actualResult = MathOperation.Max(6, 8);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 3.99999999F;

            // Act
            float actualResult = MathOperation.Max(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxDouble()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 3.99;

            // Act
            double actualResult = MathOperation.Max(1.99, 3.99);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Maximum array tests, arrays equal size
        [TestMethod]
        public void TestMaxIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 12, 24, 40, 60, 84 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        // Maximum array tests, arrays non-equal size
        [TestMethod]
        public void TestMaxIntArray_firstArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 12, 24, 40, 60, 84, 100, 128 };
            int[] value1 = { 12, 24, 40, 60, 84, 100, 128 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxIntArray_secondArrayLonger()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 12, 24, 40, 60, 84, 8, 9 };
            int[] value1 = { 12, 24, 40, 60, 84 };
            int[] value2 = { 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMaxFloatArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 16.1F, 17.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 16.1F, 17.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxFloatArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 8.1F, 9.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F, 8.1F, 9.1F };

            // Act
            float[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMaxDoubleArray_firstArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11, 20.11, 30.11, 40.11, 50.12, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12, 6.14, 7.15 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMaxDoubleArray_secondArrayLonger()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 10.11, 20.11, 30.11, 40.11, 50.12, 6.14, 7.15 };
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Max(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }



        // Median tests
        [TestMethod]
        public void TestMedianInt()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 7;

            // Act
            int actualResult = MathOperation.Median(6, 8);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMedianFloat()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            float expectedResult = (3.99999999F + 1.999999999F) / 2;

            // Act
            float actualResult = MathOperation.Median(1.999999999F, 3.99999999F);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMedianDouble()
        {
            // Assemble        
            MathOperation mathOperation = new MathOperation();
            double expectedResult = (3.99 + 1.99) / 2;

            // Act
            double actualResult = MathOperation.Median(1.99, 3.99);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Median of one array tests
        [TestMethod]
        public void TestMedianIntArray()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int expectedResult = 40;
            int[] value1 = { 12, 24, 40, 60, 84 };

            // Act
            int actualResult = MathOperation.Median(value1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMedianFloatArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float expectedResult = 13.1F;
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F };    

            // Act
            float actualResult = MathOperation.Median(value1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMedianDoubleArray()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double expectedResult = 30.11;
            double[] value1 = { 10.11, 20.11, 30.11, 40.11, 50.12 };


            // Act
            double actualResult = MathOperation.Median(value1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        // Median two array tests
        [TestMethod]
        public void TestMedianIntArray_twoArrays()
        {
            // Assemble  
            MathOperation mathOperation = new MathOperation();
            int[] expectedResult = { 60, 5 };
            int[] value1 = { 12, 24, 40, 60, 84, 100, 128 };
            int[] value2 = { 3, 4, 5, 6, 7 };

            // Act
            int[] actualResult = MathOperation.Median(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

 
        [TestMethod]
        public void TestMedianFloatArray_twoArrays()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            float[] expectedResult = { 14.1F, 5.1F };
            float[] value1 = { 10.1F, 12.1F, 13.1F, 14.1F, 15.1F, 16.1F, 17.1F };
            float[] value2 = { 3.1F, 4.1F, 5.1F, 6.1F, 7.1F };

            // Act
            float[] actualResult = MathOperation.Median(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void TestMedianDoubleArray_twoArrays()
        {
            // Assemble           
            MathOperation mathOperation = new MathOperation();
            double[] expectedResult = { 40.11, 5.13 };
            double[] value1 = { 40.11 };
            double[] value2 = { 3.11, 4.12, 5.13, 6.14, 7.15 };

            // Act
            double[] actualResult = MathOperation.Median(value1, value2);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

    }
}
