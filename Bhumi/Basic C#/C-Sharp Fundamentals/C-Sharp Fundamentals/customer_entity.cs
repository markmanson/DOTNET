using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:CustomerDetails
    /// Description://Create the three different classes and their properties & Functions
    /// Author:
    /// Created On:21/5/2015
    /// </summary>     
    class Customer_Entity //Make Customer class a child of the Entity class
    {
        ConstantMessage objconst;
        string slt, nam, MarSt, gendr, adr, qu, ln;
        #region Classes,Properties & Methods
        ///<summary>
        ///Method Name:Property_Method
        /// Description://Method to set the values of property
        /// Author:bhumi
        /// Created On:26/5/2015
        /// </summary>        
        public void Property_Method_Entity()
        {
            try
            {
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strsalutation);
                slt = Console.ReadLine();// set Value of property
                Console.WriteLine(objconst.strname);
                nam = Console.ReadLine();//set Value of property
                Console.WriteLine(objconst.strMaritalstat);
                MarSt = Console.ReadLine();//set Value of property
                Console.WriteLine(objconst.strgender);
                gendr = Console.ReadLine();//set Value of property
                Console.WriteLine(objconst.straddress);
                adr = Console.ReadLine();//set Value of property
                Console.WriteLine(objconst.strQualification);
                qu = Console.ReadLine();//set Value of property
                Console.WriteLine(objconst.strLanguage);
                ln = Console.ReadLine();//set Value of property 
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
        //"Create Customer class with properties:
        //1.Salutation 
        public string Salut1
        {
            get
            {
                return this.slt;
            }
            set
            {
                this.slt = value;
            }
        }
        //2.Name
        public string Name_customer1
        {
            get
            {
                return this.nam;
            }
            set
            {
                this.nam = value;
            }
        }
        //3.MaritalStatus
        public string MaritalStatus_customer1
        {
            get
            {
                return this.MarSt;
            }
            set
            {
                this.MarSt = value;
            }
        }
        //4.Gender
        public string Gender_customer1
        {
            get
            {
                return this.gendr;
            }
            set
            {
                this.gendr = value;
            }
        }
        //5.Address 
        public string Address_customer1
        {
            get
            {
                return this.adr;
            }
            set
            {
                this.adr = value;
            }
        }
        //6.Qualification
        public string Qualification1
        {
            get
            {
                return this.qu;
            }
            set
            {
                this.qu = value;
            }
        }
        //7.Languages
        public string language1
        {
            get
            {
                return this.ln;
            }
            set
            {
                this.ln = value;
            }
        }
        ///<summary>
        ///Method Name:Load
        /// Description://Methods of customer Class
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void Load_entity()
        {
            try
            {
                Console.WriteLine(objconst.strload);
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

        public void Save_entity()
        {
            try
            {
                Console.WriteLine(objconst.strsave);
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
        public void Validate_entity()
        {
            try
            {
                Console.WriteLine(objconst.strvalidate);
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
        public override string ToString()
        {
            //return base.ToString();
            return "Salutation:" + Salut1 + "\nName:" + Name_customer1 + "\nMaritalStatus:" + MaritalStatus_customer1 + "\nGender:" + Gender_customer1 + "\nAddress:" + Address_customer1 + "\nQualification:" + Qualification1 + "\nLanguages:" + language1;
        }
        #endregion
    }
}
