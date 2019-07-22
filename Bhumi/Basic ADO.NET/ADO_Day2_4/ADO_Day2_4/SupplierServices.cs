using System;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_Day2_4
{
    public class SupplierServices
    {
        Supplier objsupplier;
        ArrayList arrylist;
        /// <summary>
        /// Method Name:GetSupplier
        /// Description: Database-->Property of class-->arraylist--->Gridview
        /// Author:bhumi
        /// Created on:2/6/2015
        /// </summary>
        /// <returns> arraylist</returns>
        public ArrayList GetSuppliers()
        {
            //objects
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlDataReader sqlreader;
            sqlconn = new SqlConnection();
            StringBuilder strbuider;
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            sqlconn.Open();//open the connection
            //insert SQLquery in String builder
            strbuider = new StringBuilder("SELECT ");
            strbuider.Append("SupplierID,CompanyName,ContactName,City,Country");
            strbuider.Append(" FROM");
            strbuider.Append(" Suppliers");
            sqlcmd = new SqlCommand(strbuider.ToString(), sqlconn);
            sqladapter = new SqlDataAdapter(sqlcmd);
            sqlreader = sqlcmd.ExecuteReader();//Reading data
            arrylist = new ArrayList();
            while (sqlreader.Read())
            {
                objsupplier = new Supplier();
                objsupplier.SupplierID = Convert.ToInt32(sqlreader[0]);
                objsupplier.CompanyName = sqlreader[1].ToString();
                objsupplier.ContactName = sqlreader[2].ToString();
                objsupplier.City = sqlreader[3].ToString();

                arrylist.Add(objsupplier);
                objsupplier = null;
            }
            return arrylist;
        }        
    }
}