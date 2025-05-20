using System.Collections.Generic;
using RussianMultiplication.Models;

namespace RussianMultiplication.Services
{
    public class RussianMultiplication : IRussianMultiplication
    {
        public (int Result, List<StepResult> Steps) Multiply(int a, int b)
        {
            var steps = new List<StepResult>();
            int result = 0;

            while (a > 0)
            {
                bool add = a % 2 != 0;
                steps.Add(new StepResult { Left = a, Right = b, Add = add });

                if (add) result += b;

                a /= 2;
                b *= 2;
            }

            return (result, steps);
        }
    }
}