using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Program11
{
    class Class3
    {
        public static void Main()
        {
        
                FileStream fs = new FileStream(@"C:\PGM\Employee1.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                BinaryWriter bw1 = new BinaryWriter(fs);
                BinaryWriter bw2 = new BinaryWriter(fs);
                BinaryWriter bw3 = new BinaryWriter(fs);
                bw.Write("Constructor Name:Red Bull Racing");
                bw1.Write("Driver Name:Sebastian Vettel");
                bw2.Write("Age:23");
                bw2.Write("Gender:Male");
                bw.Flush();
                fs.Close();
                FileStream fs1 = new FileStream(@"C:\PGM\Employee1.txt", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs1);
                BinaryReader br1 = new BinaryReader(fs1);
                BinaryReader br2 = new BinaryReader(fs1);
                BinaryReader br3 = new BinaryReader(fs1);
                string str = br.ReadString();
                string str1 = br1.ReadString();
                string str2 = br2.ReadString();
                string str3 = br3.ReadString();
                Console.WriteLine(str);
                Console.WriteLine(str1);
                Console.WriteLine(str2);
                Console.WriteLine(str3);
                fs1.Close();
                Console.Read();
            }


        }
    }




    





