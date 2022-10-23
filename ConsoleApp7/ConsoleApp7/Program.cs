using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a- kwadrat \r\nb- prostokąt\r\nc- trójkąt\r\nd- równoległobok\r\ne- romb (bok, wysokość)\r\nf- deltoida\r\ng- romb (przekątne)\r\nh- trapez prostokątny\r\ni- trójkąt prostokątny\r\nj- trapez\r\nk- (V)ostrosłup czworokątny");
            Console.WriteLine("l- wysokość trójkąta(Pp,a) \r\nm- czworościan foremny(a,h,H) \r\nn- (V)sześcian\r\no- (V)prostopadłościan\r\np-  wysokość rombu (bok, Pp)\r\nr- bok kwadratu\r\ns- bok prostokąta\r\nt- podstawa trójkąta\r\nu- wysokość równoległoboku\r\nv- podstawy (a+b) równoległoboku\r\nw- wysokość trapezu");
            Console.WriteLine("x- bok trapezu \r\ny- przekątna rombu \r\nz- Pp sześcianu");
            string inp = Console.ReadLine().ToLower();
            if (inp == "a")
            {
                Console.WriteLine("pole kwadrata: " + xxxx.add1());
                
            }
            else if (inp == "b")
            {

                Console.WriteLine("pole prostokonta: " + xxxx.add2());

            }
            else if (inp == "c")
            {
                
                Console.WriteLine("pole trójkąta: " + xxxx.add3());
            }
            else if (inp == "d")
            {

                Console.WriteLine("pole równoległoboku: " + xxxx.add4());
            }
            else if (inp == "e")
            {
                Console.WriteLine("pole rombu: " + xxxx.add5());
            }
            else if (inp == "f")
            {
                Console.WriteLine("pole deltoidu: " + xxxx.add6());
            }
            else if (inp == "g")
            {
                Console.WriteLine("pole rombu: " + xxxx.add7());
            }
            
            
            else if (inp == "h")
            {
                Console.WriteLine("pole trapezu: " + xxxx.add9());
            }
            else if (inp == "i")
            {
                Console.WriteLine("pole trójkąta prostokątnego: " + xxxx.add10());
            }
            else if (inp == "j")
            {
                Console.WriteLine("pole trapezu: " + xxxx.add11());
            }
            else if (inp == "k")
            {
                Console.WriteLine("pole ostrosłupa czworokątnego: " + xxxx.add12());
            }
            else if (inp == "l")
            {
                Console.WriteLine("wysokość trójkąta: " + xxxx.add13());
            }
            else if (inp == "m")
            {
                Console.WriteLine("pole czworościanu foremnego: " + xxxx.add14());
            }
            else if (inp == "n")
            {
                Console.WriteLine(" pole sześcianu: " + xxxx.add15());
            }
            else if (inp == "o")
            {
                Console.WriteLine("pole prostopadłościanu: " + xxxx.add16());
            }
            else if (inp == "p")
            {
                Console.WriteLine("pole rombu: " + xxxx.add17());
            }
            else if (inp == "r")
            {
                Console.WriteLine("bok kwadratu: " + xxxx.add18());
            }
            else if (inp == "s")
            {
                Console.WriteLine("bok prostokąta: " + xxxx.add19());
            }
            else if (inp == "t")
            {
                Console.WriteLine("podstawa trójkąta: " + xxxx.add20());
            }
            else if (inp == "u")
            {
                Console.WriteLine("wysokość równoległoboku: " + xxxx.add21());
            }
            else if (inp == "v")
            {
                Console.WriteLine("podstawy trapezu (a+b): " + xxxx.add22());
            }
            else if (inp == "w")
            {
                Console.WriteLine("wysokość trapezu: " + xxxx.add23());
            }
            else if (inp == "x")
            {
                Console.WriteLine("bok trapezu: " + xxxx.add24());
            }
            else if (inp == "y")
            {
                Console.WriteLine("przekątna rombu: " + xxxx.add25());
            }
            else if (inp == "z")
            {
                Console.WriteLine("pole powierzchni sześcianu: " + xxxx.add26());
            }
            Console.ReadKey();

        }
    }
}
