using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using AdoMVC.Models;
using System.Data;

namespace AdoMVC.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listCustomer = new List<Customer>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;

        }
       
            public int Insert(int sno, string cname, string email, string mob) 
            {

                SqlConnection con = new SqlConnection(cnn);
                SqlCommand cmd = new SqlCommand("InsertCustomer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sno;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cname;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = mob;
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            } 
    }








    
}
