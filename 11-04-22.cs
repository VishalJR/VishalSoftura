using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class task4
    {
        public class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int Age { get; set; }

            public int BranchId { get; set; }
        }
        public class Specilization
        {
            public int BranchId { get; set; }

            public string BranchName { get; set; }
        }
        public static void Main()
        {
            IList<Doctor> StuData = new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, DoctorName = "Max", Age = 22, BranchId = 1},
                new Doctor() { DoctorID = 2, DoctorName = "George", Age = 23, BranchId = 2},
                new Doctor() { DoctorID = 3, DoctorName = "Jenson", Age = 21, BranchId = 3},
                new Doctor() { DoctorID = 4, DoctorName = "Button", Age = 21, BranchId = 2},
                new Doctor() { DoctorID = 5, DoctorName = "Steven", Age = 23, BranchId = 3},
            };

            IList<Specilization> BranchData = new List<Specilization>()
            {
                new Specilization() {BranchId = 1,BranchName = "Psychology"},
                new Specilization() {BranchId = 2,BranchName = "Therapy"},
                new Specilization() {BranchId = 3,BranchName = "Ortho"},

            };
            var JoinData = StuData.Join(
                BranchData,
                stu => stu.BranchId,
                brd => brd.BranchId,
                (stu, brd) => new
                {
                    DoctorName = stu.DoctorName,
                    BranchName = brd.BranchName
                }
                    );
            foreach (var v in JoinData)
            {
                Console.WriteLine(v.DoctorName + "  " + v.BranchName);
            }

        }
    }
}
