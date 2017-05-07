using System;
using System.IO;
using System.Text;

namespace sample
{
    class anagram
    {
        static void Main(string[] args)
        {
            //ストップウォッチを開始する
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            StreamReader sr = new StreamReader(
                "small.txt", Encoding.GetEncoding("Shift_JIS"));

            String str = sr.ReadToEnd();


            // \n区切りで分割して配列に格納する
            string[] strArrayData = str.Split('\n');

            for(int i = 0 ; i < strArrayData.Length ; i++)
            {

                for(int j = i + 1; j < strArrayData.Length; j++)
                {

                    if(is_match_anagram(strArrayData[i], strArrayData[j]))
                    {
                        Console.Write(strArrayData[i]);
                        Console.Write("\n");
                        Console.Write(strArrayData[j]);
                        Console.Write("\n");
                        Console.Write("\n");
                    }
                }
            }

            //ストップウォッチを止める
            sw.Stop();

            //結果を表示する
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }




        static bool is_match_anagram(string str1,string str2)
        {

            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {

                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if(str1[i] == str2[j])
                        {                   
                            str2 = str2.Replace(str2[j],'0');
                            break;
                        }

                        if (j == str2.Length - 1)
                            return false;
                    }
                }

                return true;
                
            }
        }


    }
}
