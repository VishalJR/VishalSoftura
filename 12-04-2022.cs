using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Dataa
{
    class task
    {
       // public void InsData()
      //  {
          // SqlConnection con = new SqlConnection("Data source =RYZEN5; database =task; user id = sa;password = P@ssw0rd");
         //   string sqlqry = "insert Enroll values(3,'Checo ','Perez','Male','Mexico',31)";
            
          //  SqlCommand cmd = new SqlCommand(sqlqry, con);
           // con.Open();
           // cmd.ExecuteNonQuery();
          //  con.Close();
           // Console.WriteLine("Row Inserted");
      //  }
        public void DelData(  )
        {
            SqlConnection con = new SqlConnection("Data source =RYZEN5; database =task; user id = sa;password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("delete from Enroll where sno=3", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
        }

        public void UpdData()
        {
            SqlConnection con = new SqlConnection("Data source =RYZEN5; database = task;user id =sa; password = P@ssw0rd");
            string sqlqry = "update Enroll set Lname = 'Lzalo' where Fname = 'Albert' ";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row updated Successfully!!!");


        }
             
        public void insertmeth(int sno, string FName,string Lname,string gender,string Country,int age)
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5;database = task;user id = sa ;password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("ins_sp_proc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = FName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = Lname;
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age;
            Console.WriteLine("SP Inserted");
            con.Open();
            
            con.Close();
        }
        public void Updatemeth(int sno, string LName)
        {

            SqlConnection con = new SqlConnection("data source = RYZEN5;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("upd_sp_proc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = LName;
            Console.WriteLine("SP Updated");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deletemeth(int sno)
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5;database = Newdatabase;user id = sa ;password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("del_sp_proc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            Console.WriteLine("SP deleted");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


        static void Main(string[] args)
        {
           // SqlConnection con = new SqlConnection("data source =RYZEN5;database = task;user id=sa; password=P@ssw0rd");
            //con.Open();
           // SqlCommand cmd = new SqlCommand("create table Enroll(sno int,Fname varchar(20),Lname varchar(20),Gender varchar(20),Country varchar(20),Age int)", con);
           // cmd.ExecuteNonQuery();
           // Console.WriteLine("Completed");
           // con.Close();
            task dobj = new task();
            Console.WriteLine("Enter sno:");
            int sno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fname:");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter Lname:");
            string Lname = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Country:");
            string Country = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            dobj.insertmeth(sno, Fname, Lname, gender, Country, age);
            dobj.deletemeth(sno);
            dobj.Updatemeth(sno, Lname);




           // dobj.UpdData();

        }
    }
}
