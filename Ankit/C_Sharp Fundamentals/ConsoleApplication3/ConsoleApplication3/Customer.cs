namespace ConsoleApplication3
{
    //Name                      : Customer
    //Auther                    : Ankit Sharma
    //Created Date              : 02/07/2012
    //Description               : Class customer for Customer details 
    #region Customer
    class Customer:Entity
    {
        string strsalut;                                                            //Declaring a string for salutation
        string strname;                                                             //Declaring a string for name
        string strmaritialstate;                                                    //Declaring a string for maritial status
        string strgender ;                                                          //Declaring a string for Gender
        string straddress;                                                          //Declaring a string for Address
        string strqualification;                                                    //Declaring a string for Qualification
        string strlanguage;                                                         //Declaring a string for language    
        public string salute                                                                //Property for salutation
        {
            get 
            {
                return strsalut;
            }
            set 
            {
                strsalut=value;
            }
        }
        public string name                                                                  //Property for name
        {
            get
            {
                return strname;
            }
            set
            {
                strname = value;
            }
        }
        public string maritial                                                              //Property for maritial status
        {
            get 
            {
                return strmaritialstate;
            }
            set 
            {
                strmaritialstate = value;
            }
        }
        public string gender                                                                 //Property for gender
        {
            get 
            {
                return strgender;
            }
            set
            {
                strgender = value;
            }
        }
        public string address                                                               //Property for address
        {
            get 
            {
                return straddress;
            }
            set 
            {
                straddress = value;
            }
        }
        public string qualification                                                         //Property for qualification
        {
            get
            {
                return strqualification;
            }
            set 
            {
                strqualification = value;
            }
        }
        public string language                                                              //Property for language
        {
            get
            {
                return strlanguage;
            }
            set
            {
                strlanguage = value;
            }
        }
        //Override the function ToString **************************************************************************************
        public override string ToString()
        {
            string strdetail = strsalut + " " + strname + " " + strmaritialstate + " " + strgender + " " + straddress + " " + strqualification + " " + strlanguage + " ";
            return "Cust Details -- : "+ strdetail;
        }
        #region Load
        //Function Load **********************************************************************************************************
        public void Load()
        {
        }
        #endregion Load
        #region Save
        //Function Save************************************************************************************************************
        public void Save()
        {
        }
        #endregion Save
        #region Validate
        //Function Validate********************************************************************************************************
        public void Validate()
        {
        }
        #endregion  Validate
    }
    #endregion Customer   
}

