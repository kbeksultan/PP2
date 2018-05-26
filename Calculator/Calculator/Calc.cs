using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum CalcStates
    {
        FirstNumber,
        SecondNumber
    }

    enum OperationsState
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }

    class Calc
    {
        public double firstNumber;
        public double secondNumber;
        public double resultNumber;
        public List<string> memory = new List<string>();
        public bool flag = false;
        public CalcStates currentState;
        public OperationsState currentOperation;

        public Calc()
        {
            currentState = CalcStates.FirstNumber;
            firstNumber = 0;
            secondNumber = 0;
            resultNumber = 0;
        }
    }
}
