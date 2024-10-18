using System;
using System.Security.Cryptography.X509Certificates;
namespace tabuleiro
{
    class TabuleiroException:Exception
    {
        public TabuleiroException(string msg):base(msg) {
               
        }
    }
}
