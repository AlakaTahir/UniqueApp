using System;
using System.Collections.Generic;
using System.Text;
using Unique.Model;

namespace Unique.Logic
{
    public class MultiplicationLogic
    {
        public double Multiplication(MultiplicationModel model)
        {
            return model.NumA * model.NumB;
        }
    }
}
