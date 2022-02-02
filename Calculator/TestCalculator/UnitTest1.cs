using Xunit;
using System;
using LibCalculator;

namespace CalculatorTest {
    public class UnitTest1 {
        [Fact]
        public void AdditionIsWorking()
        { 
            Assert.Equal<decimal>(24m, Calculate.add(12m, 12m));
        }
        [Fact]
        public void SubtractionIsWorking()
        { 
            Assert.Equal<decimal>(12m, Calculate.sub(24m, 12m));
        }
        [Fact]
        public void MultiplicationIsWorking()
        { 
            Assert.Equal<decimal>(24m, Calculate.mul(12m, 2m));
        }
        [Fact]
        public void DivisionIsWorking()
        { 
            Assert.Equal<decimal>(6.5m, Calculate.div(13m, 2m));
        }
    }
}

