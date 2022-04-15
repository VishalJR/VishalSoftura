﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace task

{

    public class Product
    {
        public void Proddisplay()
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5; database= tasks ;user id= sa; password =P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select ProductId,ProductName,Price,DoM,Expiry from product", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProductID : " + dr[0] + "|" + " ProductName : " + dr[1] + "| " + "Price: " + dr[2] + " | " + "DateOfManufacture : " + dr[3] + " | " + "Expirydate: " + dr[4]);
            }
            con.Close();
        }
    }

    public class Customer : Product
    {
        public void ValidateID(int custid)
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5; database = tasks; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select custId,Name,Gender,ContactNo,EmailID,DoB,City from customer_table where custID = '" + custid + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CustomerID : " + dr[0] + "|" + " CustomerName : " + dr[1] + "| " + "Gender : " + dr[2] + " | " + "Mobile no : " + dr[3] + " | " + "EmailID : " + dr[4] + " | " + "DateOfBirth : " + dr[5] + " | " + "City : " + dr[6] + "\n");
            }
            Console.WriteLine("Enter the ProductId you want to purchase:");
            int prod = Convert.ToInt32(Console.ReadLine());
            switch (prod)
            {
                case 1:

                    Console.WriteLine("Axe Deo ");
                    Console.WriteLine("Enter the Quantity");
                    int q = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("data source = RYZEN5;database=tasks;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd1 = new SqlCommand("select price* " + q + " from Product where ProductId = " + prod + "", con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int total1 = Convert.ToInt32(dr1[0]);
                        Console.WriteLine(" \nBill \nProduct Purchased:Axe Deo \n Total Amount " +total1);
                    }
                    con1.Close();
                    break;
                case 2:
                    Console.WriteLine("Garnier Dye ");
                    Console.WriteLine("Enter the Quantity");
                    int q2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("data source = RYZEN5;database=tasks;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd2 = new SqlCommand("select price* " + q2 + " from Product where ProductId = " + prod + "", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int total2 = Convert.ToInt32(dr2[0]);
                        Console.WriteLine("\nBill \nProduct Purchased: Garnier Dye \n  Total Amount " + total2);
                    }
                    con2.Close();
                    break;
                case 3:
                    Console.WriteLine("Heineken 0.0");
                    Console.WriteLine("Enter the Quantity");
                    int q3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("data source = RYZEN5;database=tasks;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd3 = new SqlCommand("select price* " + q3 + " from Product where ProductId = " + prod + "", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int total3 = Convert.ToInt32(dr3[0]);
                        Console.WriteLine("\nBill \nProduct Purchased:Heineken 0.0 \n  Total Amount " + total3);
                    }
                    con3.Close();
                    break;
                case 4:
                    Console.WriteLine("Beer Shampoo");
                    Console.WriteLine("Enter the Quantity");
                    int q4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source = RYZEN5;database=tasks;user id=sa;password=P@ssw0rd");
                    SqlCommand cmd4 = new SqlCommand("select price* " + q4 + " from Product where ProductId = " + prod + "", con4);
                    con4.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int Total4 = Convert.ToInt32(dr4[0]);
                        Console.WriteLine("\nBill \nProduct Purchased:Beer Shampoo \n  Total Amount " + Total4);
                    }
                    con4.Close();
                    break;
                default:
                    Console.WriteLine("Invalid Details");
                    break;
            }
            con.Close();
        }


        public void newCust()
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5; database = tasks; user id = sa; password = P@ssw0rd");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Gender :M or F");
            string gen = Console.ReadLine();
            Console.WriteLine("Please Enter your Contact.No:");
            string mobile = Console.ReadLine();
            Console.WriteLine("Enter your mailid");
            string mailid = Console.ReadLine();
            Console.WriteLine("Date of birth");
            string dob = Console.ReadLine();
            Console.WriteLine("Choose from the cities Below:\n 1.Chennai.\n 2.Mumbai. \n 3.Delhi.\n 4.Kolkata .....");
            string city = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert Customer values ('" + name + "','" + gen + "','" + mobile + "','" + mailid + "','" + dob + "','" + city + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row inserted:");
        }
    }
    class Program
    {

        public static void Main()
        {
            Customer nobj = new Customer();
            nobj.Proddisplay();
            Console.WriteLine("Press O (if your are and existing customer) \n Press N (if you are a new customer) ");
            string n = Console.ReadLine();
            switch (n)
            {
                case "O":
                    {
                        Console.WriteLine("Enter your Id:");
                        int custid = Convert.ToInt32(Console.ReadLine());
                        nobj.ValidateID(custid);
                        break;

                    }
                case "N":
                    {
                        nobj.newCust();
                        break;
                    }
            }


        }
    }
}