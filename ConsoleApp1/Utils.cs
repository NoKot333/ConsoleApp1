using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NOpshin.AIT22_01.Uitl
{
    public class Utils
    {
        public static void echo(string message, string S, int N)
        {
            string str = "";
            int i = 0;
            for (; i < ((N-message.Length)/(2*S.Length)); i++)
            {
                str += S;
            }
            str += message;
            i += message.Length;
            for (; i < N; i+=S.Length)
            {
                str += S;
            }
            WriteLine(str);
        }
        public static void echo1(string message, char S, int N)
        {
            if (message.Length >= N)
            {
                WriteLine(message);
            }
            WriteLine($"{new string(S, (N - message.Length) / 2)} {message} {new string(S, N-((N + message.Length)/2))}");
        }
    }
}
