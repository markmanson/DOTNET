using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    #region SupplierServices
    /// <summary>
    /// Name:SupplierServices.cs
    /// Description:"Add a class SupplierService with a method GetSuppliers. 
    ///             This method should return an arraylist of Supplier type.
    ///             Add code to this method to open database connection and 
    ///             fetch the supplier data into an array list using the Supplier class.
    ///             Use a datareader to read the info.  Return this array list."
    /// Author:Monal shah
    /// created date:2010/09/23
    /// </summary>
    public class SupplierServices
    {
        ArrayList _objAryList;       
        Suppliers _objSupplier;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        Commonlogic _objCl = new Commonlogic();
        SqlCommand _objCmd;
        SqlDataReader _objReader;
        #region GetSuppliers
        /// <summary>
        /// Name:Getsuppliers
        /// Description:"Add a class SupplierService with a method GetSuppliers. 
        ///             This method should return an arraylist of Supplier type.
        ///             Add code to this method to open database connection and 
        ///             fetch the supplier data into an array list using the Supplier class.
        ///             Use a datareader to read the info.  Return this array list."
        /// Author:Monal shah
        /// created date:2010/09/23
        /// </summary>
        /// <returns>ArrayList</returns>
        public ArrayList Getsuppliers()
        {
            _objCon.ConnectionString = Commonlogic.GetConnectionString;//get the connectionstring value
            _objCmd = new SqlCommand();//create command object
            //if connection state is close then connection will be open
            if (_objCon.State == ConnectionState.Closed)
            {
                _objCon.Open();
            }
            _objCmd.Connection = _objCon;//set connection value 
            _objCmd.CommandType = CommandType.Text;
            string strQuery = "Select * From Suppliers";
            _objCmd.CommandText = strQuery;
            _objReader =_objCmd.ExecuteReader(CommandBehavior.CloseConnection);
            _objAryList = new ArrayList();
            //while  _objReader.Read() the data till it get the table row empty data
            while (_objReader.Read())
            {
                    _objSupplier=new Suppliers();
                    _objSupplier.SupplierID = Convert.ToInt32(_objReader["SupplierID"]);
                    _objSupplier.CompanyName = _objReader["CompanyName"].ToString();
                    _objSupplier.ContactName = _objReader["ContactName"].ToString();
                    _objSupplier.ContactTitle = _objReader["ContactTitle"].ToString();
                    _objSupplier.Address = _objReader["Address"].ToString();
                    _objSupplier.City = _objReader["City"].ToString();
                    _objSupplier.Region = _objReader["Region"].ToString();
                    _objSupplier.PostalCode = _objReader["PostalCode"].ToString();
                    _objSupplier.Country = _objReader["Country"].ToString();
                    _objSupplier.phone = _objReader["Phone"].ToString();
                    _objSupplier.Fax = _objReader["Fax"].ToString();
                    _objSupplier.HomePage = _objReader["HomePage"].ToString();
                    _objAryList.Add(_objSupplier);//add _objSupplier to arraylist
             }
         
            return _objAryList;
          
        }
        #endregion
    }
    #endregion
}
