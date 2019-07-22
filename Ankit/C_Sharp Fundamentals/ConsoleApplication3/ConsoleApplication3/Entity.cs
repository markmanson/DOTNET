namespace ConsoleApplication3
{
    #region Entity
    //Name                      : Customer
    //Auther                    : Ankit Sharma
    //Created Date              : 02/07/2012
    //Description               : Base class named Entity
    class Entity
    {      
        string strEname;
        string strEmaritial;
        string strEgender;
        string strEaddress;
        public string Ename                                              //Property for name
        {
            get
            {

                return strEname;
            }
            set
            {
                strEname = value;
            }
        }
        public string Emaritial                                             //Property for maritial status
        {
            get
            { 
                return strEmaritial;
            }
            set
            {
                strEmaritial = value;
            }
        }
        public string Egender                                               //Property for Gender
        {
            get
            {
                return strEgender;
            }
            set
            {
                strEgender = value;
            }
        }
        public string Eaddress                                              //Property for Address
        {
            get
            {
                return strEaddress;
            }
            set
            {
                strEaddress = value;
            }
        }
    }
    #endregion Entity
}
