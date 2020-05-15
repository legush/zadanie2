using System;
using System.Collections.Generic;

namespace zadanie2
{
    class Program
    {
        //2
        static void t(string str)
        {
            Dictionary<string, string> dictionaryChar = new Dictionary<string, string>() {

                {"а","a"},{"б","b"},{"в","v"},{"г","g"},{"д","d"},{"е","e"},{"ё","yo"},{"ж","zh"},{"з","z"},{"и","i"},{"й","i"},{"к","k"},{"л","l"},{"м","m"},{"н","n"},{"о","o"},{"п","p"},
                { "р","r"},{"с","s"},{"т","t"}, {"у","u"},{"ф","f"},{"х","h"},{"ц","ts"},{"ч","ch"},{"ш","sh"},{"щ","shch"},{"ъ","ie"},{"ы","y"},{"ь",""},{"э","e"},{"ю","iu"},{"я","ia"}
            };

            string res = "";

            foreach (var a in str)
            {

                string b = "";

                if (dictionaryChar.TryGetValue(a.ToString(), out b))
                {

                    res += b;
                }
                else res += a;
            }
            Console.WriteLine(res);
        }
        //1
        static void f (string str)
        {
            int a = 0;

            for (int i = 0; i < str.Length; i++) {

                if (str[i] == 'f') a++;

                if (a == 2 && str[i] == 'f') {

                    int ind = str.IndexOf(str[i + 1]);
                    Console.WriteLine(ind - 1);

                    break;
                }
            }

            if (a == 1) Console.WriteLine(1);
            if (a == 0) Console.WriteLine(2);
        }

        //3
        static void h(string str)
        {
            string Str = "";

            for (int i = 0; i < str.Length; i++) {
                int ind = str.IndexOf(str[i]);

                if (str[i] == 'h' && i != 0 && i != str.Length - 1) Str += 'H';
                else Str += str[i];
            }

            Console.WriteLine(Str);
        }

        static void Main(string[] args)
        {
            f("lksjdhfo");
            t("русские буквы для теста");
            h ("hohohohoh");
        }
    }
}
