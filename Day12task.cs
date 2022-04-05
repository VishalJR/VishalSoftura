using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KoreConsole

{
    class go1
    {
        public static void Main()
        {

            FileStream fs = new FileStream(@"C:\PGM\Desert.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter bw = new StreamWriter(fs);
            List<string> str = new List<String>();
            str.Add("Khunafah");
            str.Add("Soufflet Au Chocolat");
            str.Add("Pancake");
            str.Add("Bread Halwa");
            str.Add("Whisky");
            foreach (string d in str)
            {
                bw.Write("\n" + d);
            }
            bw.Flush();
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\PGM\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            String s = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(s);
            FileInfo fi = new FileInfo(@"C:\PGM\Dessert.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.Read();
        }
    }
}