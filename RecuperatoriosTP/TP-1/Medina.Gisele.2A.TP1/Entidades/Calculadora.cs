using System;

namespace Entidades
{
    public static class Calculadora
    {
        static char ValidarOperador(char operador )
        {
            char operadorValidado = '+';

            if(operador== '+' || operador=='-' || operador=='/' || operador=='*')
            {
                operadorValidado = operador;
            }
            return operadorValidado;
        }
       public  static double Operar(Operando num, Operando num2, char operador)
        {
            double resultado = 0;
            char operacion;
            if( num is not null && num2 is not null)
            {
                operacion=ValidarOperador(operador);
                switch (operacion)
                {
                    case '+':
                        resultado = num + num2;
                        break;
                    case '-':
                        resultado = num - num2;
                        break;
                    case '/':
                        resultado = num / num2;
                        break;
                    case '*':
                        resultado = num * num2;
                        break;
                                     
                }
            }
            return resultado;
        }
    }
}
