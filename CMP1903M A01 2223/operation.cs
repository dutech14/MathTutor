﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
   
    class operation : Ioperands
    {
        public double _num1;
        public double _num2;
        public int _operand;

        public  operation(double num1, double num2, int operand)
        {
            _num1 = num1;
            _num2 = num2;
            _operand = operand;

        }

        public virtual double performance()
        {
            if (_operand == 1)
            {
                return _num1 + _num2;
            }
            else if (_operand == 2)
            {
                return _num1 - _num2;
            }
            else if (_operand == 3)
            {
                return _num1 / _num2;
            }
            else if (_operand == 4)
            {
                return _num1 * _num2;
            }
            return 0;
        }

        public override string ToString()
        {
            char operatorTocharacter(float op)
            {
                char operatorCharacter = '0';
                if (op == 1) operatorCharacter = '+';
                else if (op == 2) { operatorCharacter = '-'; }
                else if (op == 3) { operatorCharacter = '/'; }
                else if (op == 4) { operatorCharacter = 'X'; }
                return operatorCharacter;
            }
            char operator1Character = operatorTocharacter(_operand);


            return $"{_num1} {operator1Character} {_num2} = ? ";

        }
    }
}
