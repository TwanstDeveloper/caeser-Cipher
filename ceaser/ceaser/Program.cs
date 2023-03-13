using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceaser
{
    internal class Program
    {

        //caesar cipher
        //-------------//
        // 0-25 pitakan 
        //key = 1-26 //
        //modal = 1-26
        //----------------//
        //E(x)=(x+key)%26
        //e(a)=(0+5)%26
        //----------------//
        //D(x)=(x-key)%26
        //e(a)=(0-5)%26

        static void Main(string[] args)
        {
            string txt = "hawraman";
            int k = 3;
            Program obj=new Program();
            Console.WriteLine("cipher text");
            string x=  obj.enc(txt,k);//argument
            Console.WriteLine(x);
            Console.WriteLine("normall text");
            string y = obj.dec(x,k);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        // 1-mothod yan function / karkrdn lagal //lagar methode  parametaraize
        // 2-loop for loop
        // 3-control flow  if- -else if- -else
        string enc(string msg,int key)
        {
            string c = "";
            for (int i = 0; i < msg.Length; i++)
            {
                //65-90
                if (char.IsUpper(msg[i]))
                {
                    c = c + (char)((int)(msg[i]+key-65)%26+65);
                }
                //97-122
                else
                {
                    c = c + (char)((int)(msg[i]+key-97)%26+97);
                }
            }
            return c;
        }
        string dec(string msg,int key)
        {
            string c = "";
            for (int i = 0; i < msg.Length; i++)
            {
                //65-90
                if (char.IsUpper(msg[i]))
                {
                    c = c + (char)((int)(msg[i]-key-65)%26+65);
                }
                //97-122
                else
                {
                    c = c + (char)((int)(msg[i]-key-97)%26+97);
                }
            }
            return c;
        }

    }
}
