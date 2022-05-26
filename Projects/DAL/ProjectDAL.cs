using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using Project2.Models;
using System.Data;

namespace Project2.DAL
{
    public class ProjectDAL
    {
        public string cnn = "";
        public ProjectDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public int DoctorAdd1(string fname, string lname, string gen, string special, string visith)
        {

            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Doctorproc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = gen;
            cmd.Parameters.Add("@spec", SqlDbType.VarChar).Value = special;
            cmd.Parameters.Add("@vhour", SqlDbType.VarChar).Value = visith;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int Patient1( string FirstName, string LastName, string Sex,string Dateof)
        {

            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Patientproc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = FirstName;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = LastName;
            cmd.Parameters.Add("@sex", SqlDbType.VarChar).Value = Sex;
            //cmd.Parameters.Add("@age", SqlDbType.Int).Value = years;
            cmd.Parameters.Add("@dob", SqlDbType.VarChar).Value = Dateof;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public int Usercheck(User usr)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("userlogin", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Userid", usr.Fname);
            cmd.Parameters.AddWithValue("@Pass", usr.Password);
            con.Open();
            IDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return (1);

            con.Close();
            return (0);
        }
        //    public int AppointN(int ID, string Spec, string Doctor, string VisitD, string VisitH)
        //    {

        //        SqlConnection con = new SqlConnection(cnn);
        //    SqlCommand cmd = new SqlCommand("Appointproc", con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
        //        cmd.Parameters.Add("@spec", SqlDbType.VarChar).Value = Spec;
        //        cmd.Parameters.Add("@doctor", SqlDbType.VarChar).Value = Doctor;
        //        cmd.Parameters.Add("@visit", SqlDbType.VarChar).Value = VisitD;
        //        cmd.Parameters.Add("@atime", SqlDbType.VarChar).Value = VisitH;
        //        con.Open();
        //        int result = cmd.ExecuteNonQuery();
        //    con.Close();
        //        return result;

        //}
        public int AppointN(Appoint A)
        {
            int result;
            SqlConnection conn = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Appointproc", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", A.Pid);
            cmd.Parameters.AddWithValue("@spec", A.Special);
            cmd.Parameters.AddWithValue("@doctor", A.Doc);
            cmd.Parameters.AddWithValue("@visit", A.Vdate);
            cmd.Parameters.AddWithValue("@atime", A.AppoinTime);
            conn.Open();
            result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public List<Appoint> Schlist()
        {
            List<Appoint> App = new List<Appoint>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("ShowDetails", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        App.Add(new Appoint()
                        {
                            AppID = int.Parse(reader["AppID"].ToString()),
                            Pid = int.Parse(reader["Pid"].ToString()),
                            Special = reader["Special"].ToString(),
                            Doc = reader["Doc"].ToString(),
                            AppoinTime = reader["AppoinTime"].ToString(),
                            Vdate = reader["Vdate"].ToString()
                        }) ; ;
                    }

                }
            }
            return App;
        }
        public int Cancel(int id)
        {

            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("DelAppoint", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
   
       public int Creator(User au)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Userproc", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", au.Username);
            cmd.Parameters.AddWithValue("@fname", au.Fname);
            cmd.Parameters.AddWithValue("@lname", au.Fname);
            cmd.Parameters.AddWithValue("@password", au.Password);
            con.Open();
            IDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return (1);

            con.Close();
            return (0);
        }

        public List<AddDoctor> Displaydoc()
        {
            List<AddDoctor> listSchedules = new List<AddDoctor>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("Displaydoctor", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listSchedules.Add(new AddDoctor()
                        {
                            DoctorId = int.Parse(reader["DoctorId"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Sex = reader["Sex"].ToString(),
                            Specialization = reader["Specialization"].ToString(),
                            VistingHours = reader["VisitingHours"].ToString(),

                        });
                    }

                }
            }
            return listSchedules;
        }
        public List<AddPatient> Displaypatient()
        {
            List<AddPatient> listschedules = new List<AddPatient>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("Displaypatient", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listschedules.Add(new AddPatient()
                        {
                            Pid = int.Parse(reader["Pid"].ToString()),
                            Fname = reader["Fname"].ToString(),
                            Lname = reader["Lname"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DoB = reader["DoB"].ToString()

                        }) ;
                    }

                }
            }
            return listschedules;
        }

    }
}
