using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    //Create a class Franchisee as child of the Entity class.
    class Franchisee : Entity
    {
        #region franchisee class
        ConstantMessage objconst;
        ///<summary>
        ///Method Name:GetFees
        /// Description://Method to set the values of property        
        /// </summary>                
        double fees;
        public void GetFees()
        {
             objconst= new ConstantMessage();
             try
             {
                 Console.WriteLine("Enter " + objconst.strfees);
                 fees = Convert.ToDouble(Console.ReadLine());
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 objconst = null;
             }
        }
        //Add property Fees to Franchisee class
        //Fees
        public double Fees
        {
            get
            {
                return this.fees;
            }
            set
            {
                this.fees = value;
            }
        }
        public override string ToString()
        {
            //return base.ToString();
            return "Fees:" + Fees;
        }
        #endregion
    }
}
