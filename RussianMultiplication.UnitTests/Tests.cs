using System.Collections.Generic;
using NUnit.Framework;
using RussianMultiplication.Models;
using RussianMultiplication.Services;

namespace RussianMultiplication.UnitTests
{
    [TestFixture]
    public class Tests
    {
        private IRussianMultiplication _russianMultiplication;

        [SetUp]
        public void Setup()
        {
            _russianMultiplication = new Services.RussianMultiplication();
        }

        [Test]
        public void Multiply_PositiveNumbers_ReturnsCorrectResult()
        {
            (int result, _) = _russianMultiplication.Multiply(13, 12);
            Assert.That(156 == result);
        }

        [Test]
        public void Multiply_A_IsZero_ReturnsZero()
        {
            (int result, var steps) = _russianMultiplication.Multiply(0, 10);
            Assert.That(result == 0);
            Assert.That(steps.Count == 0);
        }

        [Test]
        public void Multiply_B_IsZero_ReturnsZero()
        {
            (int result, _) = _russianMultiplication.Multiply(10, 0);
            Assert.That(result == 0);
        }

        [Test]
        public void Multiply_CheckStepDetails()
        {
            (int result, var steps) = _russianMultiplication.Multiply(5, 3);
            var expectedSteps = new List<StepResult>
            {
                new StepResult { Left = 5, Right = 3, Add = true },
                new StepResult { Left = 2, Right = 6, Add = false },
                new StepResult { Left = 1, Right = 12, Add = true }
            };
            Assert.That(steps.Count == expectedSteps.Count);
            for (int i = 0; i < expectedSteps.Count; i++)
            {
                Assert.That(steps[i].Left == expectedSteps[i].Left);
                Assert.That(steps[i].Right == expectedSteps[i].Right);
                Assert.That(steps[i].Add == expectedSteps[i].Add);
            }

            Assert.That(result == 15);
        }

        [Test]
        public void Multiply_NegativeInput_HandledProperly()
        {
            (int result, var steps) = _russianMultiplication.Multiply(-4, 5);
            Assert.That(result == 0);
        }
    }
}