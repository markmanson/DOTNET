
namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
   Name:CrateCustomer.cs
   Author:Monal Shah
   Description: 4.1:Create Customer class with properties:
                Salutation, Name, MaritalStatus, Gender, Address, Qualification, Languages
     
                4.2:Add to the Customer class methods:
                Load, Save, Validate
            
                4.4:Make Customer class a child of the Entity class


   CreatedDate: 2010/09/09 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   
      class cratecustomer:Entity means Entity is base class of CrateCustomer.
     */ 
    class CrateCustomer:Entity
    {
        public string _strName,_strMaritalstatus,_strGender,_strAddress,_strSaluat,_strQualifctn,_strLang;
        
        public string Name
        {
            get{ return _strName;}
            set{_strName = value;}
        }
        public string Maritalstatus
        {
            get{return _strMaritalstatus;}
            set{ _strMaritalstatus = value;}
        }
        public string Gender
        {
            get{return _strGender;}
            set{_strGender = value;}
        }
        public string Address
        {
            get{return _strAddress;}
            set { _strAddress = value; }
        }
      
        public string Salut
        {
            get{return _strSaluat;}
            set { _strSaluat = value; }
        }
        public string Qualification
        {
            get { return _strQualifctn; }
            set {_strQualifctn = value; }
        }
        public string Language
        {
            get{return _strLang;}
            set{_strLang = value;}
        }
        /*---------------------------------------------------------------------------------------------------------------
             Name:ToString
             Paramametres:0
             ReturnType:string
             Description:Format the output.
             Author:Monal Shah
             CreatedDate: 2010/09/09 by Monal Shah
        ---------------------------------------------------------------------------------------------------------------
        */
        public override string ToString()
        {

            return string.Format
                
           ("\nSalutation:{0}\nName:{1}\nMaritalStatus:{2}\nGender:{3}\n"+
            "Address:{4}\nQualification:{5}\nLanguages:{6}",
            _strSaluat, _strName, _strMaritalstatus, _strGender, _strAddress, 
            _strQualifctn, _strLang);

        }
        /*---------------------------------------------------------------------------------------------------------------
       Name:CrateCustomer(Constructor is created) 
       Paramametres:string
       Description:4.4:Make Customer class a child of the Entity class
       Author:Monal Shah
       CreatedDate: 2010/09/09 by Monal Shah
   ---------------------------------------------------------------------------------------------------------------
   */
        //public CrateCustomer(string strS, string strN, string strMS, string strG, string strAdres, string strQlfctn, string strLng)
        //    : base(strN, strMS, strG, strAdres)
        //{
        //    _strName = strN;
        //    _strMaritalstatus = strMS;
        //    _strGender = strG;
        //    _strAddress = strAdres;
        //    _strSaluat = strS;
        //    _strQualifctn = strQlfctn;
        //    _strLang = strLng;

        //}
     
         
      /*---------------------------------------------------------------------------------------------------------------
            Name:Save
            Paramametres:0
            Description:4.2:Create a Save Method
            Author:Monal Shah
            CreatedDate: 2010/09/09 by Monal Shah
        ---------------------------------------------------------------------------------------------------------------
        */
            public void Save()
            {
            }
            /*---------------------------------------------------------------------------------------------------------------
                Name:Load
                Paramametres:0
                Description:4.2:Create a Load Method
                Author:Monal Shah
                CreatedDate: 2010/09/09 by Monal Shah
            ---------------------------------------------------------------------------------------------------------------
            */
            public void Load()
            {
            }
            /*---------------------------------------------------------------------------------------------------------------
                Name:vslidate
                Paramametres:0
                Description:4.2:Create a validate Method
                Author:Monal Shah
                CreatedDate: 2010/09/09 by Monal Shah
            ---------------------------------------------------------------------------------------------------------------
            */
            public void Validate()
            {
            }
           
     }
     
    
}

