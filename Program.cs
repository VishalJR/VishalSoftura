using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Activity

{

    public class Product
    {
        public void Proddisplay()
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5STEVEN; database= tasks ;integrated security=true");
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
            Console.WriteLine("\n\t*******Welcome to McLaren Stores*******");
            SqlConnection con = new SqlConnection("data source = RYZEN5STEVEN; database = tasks; integrated security=true");
            SqlCommand cmd = new SqlCommand("select custId,Name,Gender,ContactNo,EmailID,DoB,City from customer_table where custID = '" + custid + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("CustomerID : " + dr[0] + "||" + " CustomerName : " + dr[1] + "|| " + "Gender : " + dr[2] + " || " + "Mobile no : " + dr[3] + " || " + "EmailID : " + dr[4] + " || " + "DateOfBirth : " + dr[5] + " || " + "City : " + dr[6] + "\n");
            }

            Console.WriteLine("Enter the ProductId you want to purchase:");
            int prod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many times you need to purchase: ");

            switch (prod)
            {
                case 1:

                    Console.WriteLine("Axe Deo ");
                    Console.WriteLine("Enter the Quantity");
                    int q = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                    SqlCommand cmd1 = new SqlCommand("select price* " + q + " from Product where ProductId = " + prod + "", con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int total1 = Convert.ToInt32(dr1[0]);
                        SqlConnection cond1 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                        cond1.Open();
                        string sqlqry = "insert into purchased(CustID,ProductID,Quantity,Total) values(" + custid + "," + prod + "," + q + "," + total1 + ")";
                        SqlCommand cmdd = new SqlCommand(sqlqry, cond1);

                        cmdd.ExecuteNonQuery();
                        cond1.Close();

                        Console.WriteLine(" \n\t$$$Bill for Customer ID:$$$" + custid + " \nProduct Purchased:Axe Deo \n Total Amount " + total1);
                        Console.WriteLine("Payment via Cash or Card or UPI?");
                        string coc = Console.ReadLine();
                        if (coc == "Cash" || coc == "cash")
                        {
                            Console.WriteLine("Give the cash you gonna pay");
                            int cash = Convert.ToInt32(Console.ReadLine());
                            if (cash >= total1)
                            {
                                int change = cash - total1;
                                Console.WriteLine("\nPaid Amount:" + cash);
                                Console.WriteLine("\n Balance after paid:" + change);
                                Console.WriteLine("\nCollect the balance :)\n");
                                Console.WriteLine("Thank you for purchasing with us :)");
                            }
                            else
                            {
                                Console.WriteLine("\nGive the correct amount");
                            }
                        }
                        else if (coc == "Card" || coc == "card")
                        {
                            Console.WriteLine("Enter the pin for authorization");
                            string pin = Console.ReadLine();
                            Console.WriteLine("\n\tAuthorized by Bank");
                            Console.WriteLine("Thank you for purchasing with us :");
                        }
                        else if (coc == "Upi" || coc == "upi")
                        {
                            Console.WriteLine("\tScan the QR Code\t");
                            Console.WriteLine("\n\tEnter the amount to pay");
                            int upic = Convert.ToInt32(Console.ReadLine());
                            if (upic == total1)
                            {
                                Console.WriteLine("\n\tPayment Successfull\t");
                                Console.WriteLine("\n\tCollect the products and Thank you for visiting us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }

                        }
                    }

                    con1.Close();
                    break;
                case 2:
                    Console.WriteLine("Garnier Dye ");
                    Console.WriteLine("Enter the Quantity");
                    int q2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                    SqlCommand cmd2 = new SqlCommand("select price* " + q2 + " from Product where ProductId = " + prod + "", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int total2 = Convert.ToInt32(dr2[0]);
                        SqlConnection cond1 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                        cond1.Open();
                        string sqlqry = "insert into purchased(CustID,ProductID,Quantity,Total) values(" + custid + "," + prod + "," + q2 + "," + total2 + ")";
                        SqlCommand cmdd = new SqlCommand(sqlqry, cond1);

                        cmdd.ExecuteNonQuery();
                        cond1.Close();
                        Console.WriteLine("\n$$$Bill for Customer ID: $$$" + custid + "\nProduct Purchased: Garnier Dye \n  Total Amount " + total2);
                        Console.WriteLine("Payment via Cash or Card or UPI?");
                        string coc = Console.ReadLine();
                        if (coc == "Cash" || coc == "cash")
                        {

                            Console.WriteLine("Give the cash you gonna pay");
                            int cash = Convert.ToInt32(Console.ReadLine());
                            if (cash >= total2)
                            {
                                int change = cash - total2;
                                Console.WriteLine("\nPaid Amount:" + cash);
                                Console.WriteLine("\n Balance after paid:" + change);
                                Console.WriteLine("\nCollect the balance :)\n");
                                Console.WriteLine("Thank you for purchasing with us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }
                        }
                        else if (coc == "Card" || coc == "card")
                        {
                            Console.WriteLine("Enter the pin for authorization");
                            string pin = Console.ReadLine();
                            Console.WriteLine("\n\tAuthorized by Bank");
                            Console.WriteLine("Thank you for purchasing with us :");
                        }
                        else if (coc == "Upi" || coc == "upi")
                        {
                            Console.WriteLine("\tScan the QR Code\t");
                            Console.WriteLine("\n\tEnter the amount to pay");
                            int upic = Convert.ToInt32(Console.ReadLine());
                            if (upic == total2)
                            {
                                Console.WriteLine("\n\tPayment Successfull\t");
                                Console.WriteLine("\n\tCollect the products and Thank you for visiting us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }

                        }

                    }
                    con2.Close();
                    break;
                case 3:
                    Console.WriteLine("Heineken 0.0 Non Alcoholic Beer");
                    Console.WriteLine("Enter the Quantity");
                    int q3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                    SqlCommand cmd3 = new SqlCommand("select price* " + q3 + " from Product where ProductId = " + prod + "", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int total3 = Convert.ToInt32(dr3[0]);
                        SqlConnection cond1 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                        cond1.Open();
                        string sqlqry = "insert into purchased(CustID,ProductID,Quantity,Total) values(" + custid + "," + prod + "," + q3 + "," + total3 + ")";
                        SqlCommand cmdd = new SqlCommand(sqlqry, cond1);

                        cmdd.ExecuteNonQuery();
                        cond1.Close();
                        Console.WriteLine("\n\t$$$Bill for Customer ID: $$$" + custid + " \nProduct Purchased:Heineken 0.0 \n  Total Amount " + total3);
                        Console.WriteLine("Payment via Cash or Card or UPI?");
                        string coc = Console.ReadLine();
                        if (coc == "Cash" || coc == "cash")
                        {
                            Console.WriteLine("Give the cash you gonna pay");
                            int cash = Convert.ToInt32(Console.ReadLine());
                            if (cash >= total3)
                            {
                                int change = cash - total3;
                                Console.WriteLine("\nPaid Amount:" + cash);
                                Console.WriteLine("\n Balance after paid:" + change);
                                Console.WriteLine("\nCollect the balance :)\n");
                                Console.WriteLine("Thank you for purchasing with us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }
                        }
                        else if (coc == "Card" || coc == "card")
                        {
                            Console.WriteLine("Enter the pin for authorization");
                            string pin = Console.ReadLine();
                            Console.WriteLine("\n\tAuthorized by Bank");
                            Console.WriteLine("Thank you for purchasing with us :");
                        }
                        else if (coc == "Upi" || coc == "upi")
                        {
                            Console.WriteLine("\tScan the QR Code\t");
                            Console.WriteLine("\n\tEnter the amount to pay");
                            int upic = Convert.ToInt32(Console.ReadLine());
                            if (upic == total3)
                            {
                                Console.WriteLine("\n\tPayment Successfull\t");
                                Console.WriteLine("\n\tCollect the products and Thank you for visiting us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }

                        }

                    }
                    con3.Close();
                    break;
                case 4:
                    Console.WriteLine("Beer Shampoo");
                    Console.WriteLine("Enter the Quantity");
                    int q4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                    SqlCommand cmd4 = new SqlCommand("select price* " + q4 + " from Product where ProductId = " + prod + "", con4);
                    con4.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int total4 = Convert.ToInt32(dr4[0]);
                        SqlConnection cond1 = new SqlConnection("data source = RYZEN5STEVEN;database=tasks;integrated security=true");
                        cond1.Open();
                        string sqlqry = "insert into purchased(CustID,ProductID,Quantity,Total) values(" + custid + "," + prod + "," + q4 + "," + total4 + ")";
                        SqlCommand cmdd = new SqlCommand(sqlqry, cond1);

                        cmdd.ExecuteNonQuery();
                        cond1.Close();
                        Console.WriteLine("\n\t$$$Bill for Customer ID: $$$" + custid + " \nProduct Purchased:Beer Shampoo \n  Total Amount " + total4);
                        Console.WriteLine("Payment via Cash or Card or UPI?");
                        string coc = Console.ReadLine();
                        if (coc == "Cash" || coc == "cash")
                        {
                            Console.WriteLine("Give the cash you gonna pay");
                            int cash = Convert.ToInt32(Console.ReadLine());
                            if (cash >= total4)
                            {
                                int change = cash - total4;
                                Console.WriteLine("\nPaid Amount:" + cash);
                                Console.WriteLine("\n Balance after paid:" + change);
                                Console.WriteLine("\nCollect the balance :)\n");
                                Console.WriteLine("Thank you for purchasing with us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }
                        }
                        else if (coc == "Card" || coc == "card")
                        {
                            Console.WriteLine("Enter the pin for authorization");
                            string pin = Console.ReadLine();
                            Console.WriteLine("\n\tAuthorized by Bank");
                            Console.WriteLine("Thank you for purchasing with us :)");
                        }
                        else if (coc == "Upi" || coc == "upi")
                        {
                            Console.WriteLine("\tScan the QR Code\t");
                            Console.WriteLine("\n\tEnter the amount to pay");
                            int upic = Convert.ToInt32(Console.ReadLine());
                            if (upic == total4)
                            {
                                Console.WriteLine("\n\tPayment Successfull\t");
                                Console.WriteLine("\n\tCollect the products and Thank you for visiting us :)");
                            }
                            else
                            {
                                Console.WriteLine("\tEnter the correct amount to pay or the product is not yours :/");
                            }

                        }

                    }
                    con4.Close();
                    break;
                default:
                    Console.WriteLine("Product is Unavailable :(");
                    break;
            }

            con.Close();


        }


        public void newCust()
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5STEVEN; database = tasks;integrated security=true");
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
            SqlCommand cmd = new SqlCommand("insert customer_table values ('" + name + "','" + gen + "','" + mobile + "','" + mailid + "','" + dob + "','" + city + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row inserted:");
        }
        public void billinfobyID(int customerid)
        {
            SqlConnection con = new SqlConnection("data source = RYZEN5STEVEN; database = tasks;integrated security=true");

            SqlCommand cmd = new SqlCommand("select BillNo, purc.CustID, ProductName, purc.ProductId, Quantity, Total, ContactNo from[dbo].[Purchased]purc join[dbo].[product]pro on purc.ProductId = pro.ProductID join[dbo].[customer_table]cust on cust.CustID = purc.CustID", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine(" BillNo " + read[0] + "||" + " CustID " + read[1] + "||" + " ProductName " + read[2] + "||" + " ProdID " + read[3] + "||" + " Productname " + read[4] + "||" + " Totalamt " + read[5] + "||" + " MobileNo " + read[6] + "||");

            }
            con.Close();


            SqlConnection conw = new SqlConnection("data source =RYZEN5STEVEN; database = tasks;integrated security=true");
            SqlCommand cmda = new SqlCommand("select * from Purchased where CustID = " + customerid, conw);
            conw.Open();
            SqlDataReader drs = cmda.ExecuteReader();
            while (drs.Read())
            {
                Console.WriteLine("        BillNo :      " + drs[0] + "        Cusid:        " + drs[1] + "       Proid:     " + drs[2] + "     Quantity      " + drs[3] + "        Totalamt     " + drs[4] + "      purchaseDate      " + drs[5]);
            }
            conw.Close();
        }
        public void billinfobyDate()
        {
            Console.WriteLine("Enter Date:");
            var date = Convert.ToString(Console.ReadLine());
            SqlConnection conww = new SqlConnection("data source =RYZEN5STEVEN; database = tasks;integrated security=true");
            SqlCommand cmdq = new SqlCommand("select * from Purchased where prodate = '" + date + "'", conww);
            conww.Open();
            SqlDataReader drss = cmdq.ExecuteReader();
            while (drss.Read())
            {
                Console.WriteLine("   BillNo :   " + drss[0] + "    Cusid:   " + drss[1] + "    Proid:     " + drss[2] + "    Quantity     " + drss[3] + "     Totalamt    " + drss[4] + "    purchaseDate    " + drss[5]);
            }
            conww.Close();
            
        }
    }
    class Program
    {

        public static void Main()
        {
            Customer nobj = new Customer();
            nobj.Proddisplay();
            Console.WriteLine("**********************");

          //  Console.WriteLine("Press the following buttons \n O-If your are and existing customer \n N-If you are a new customer ");
            //string on = Console.ReadLine();

           // switch (on)
           // {
             //   case "O":
               //     {
                 //       Console.WriteLine("Enter your Customer Id:");
                   //     int custid = Convert.ToInt32(Console.ReadLine());
                     //   nobj.ValidateID(custid);
                       // break;

                   // }
                //case "N":
                  //  {
                    //    nobj.newCust();
                       // break;
              //      }
           // }
            //Console.WriteLine("Bill by ID");
           // Console.WriteLine("Enter customerid:");
           // int customerid = Convert.ToInt32(Console.ReadLine());
           // nobj.billinfobyID(customerid);
            Console.WriteLine("Bill by Date");
            nobj.billinfobyDate();



        }
    }
}

