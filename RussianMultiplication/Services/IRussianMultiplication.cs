using System.Collections.Generic;
using RussianMultiplication.Models;

namespace RussianMultiplication.Services
{
    public interface IRussianMultiplication
    {
        (int Result, List<StepResult> Steps) Multiply(int a, int b);
    }
}