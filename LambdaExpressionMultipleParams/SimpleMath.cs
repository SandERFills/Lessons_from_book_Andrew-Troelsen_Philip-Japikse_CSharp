using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionMultipleParams
{
    class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mathMessage;
        public void SetMathHandler(MathMessage message)
        {
            mathMessage = message;
        }
        public void Add(int a, int b)
        {
            mathMessage?.Invoke("Adding has complete!", a + b);
        }
    }
}
