namespace ConsoleApplication3
{
    //Name                      : ExceptionGenerated
    //Auther                    : Ankit Sharma
    //Created Date              : 03/07/2012
    //Description               : To make a class ExceptionGenerated   
    class ExceptionGenerated : System.ApplicationException
    {
        #region ExceptionGenerated
        //METHOD OVERRIDE TOSTRING ********************************************************
        public override  string  ToString()
        {
            return base.ToString();
        }
        //public string strMsg = String.Empty;
        //ExceptionGenerated(string strmsg)
        //    : base(strmsg)
        //{
        //    strMsg = strmsg.ToString();
        //}
    }
        #endregion ExceptionGenerated
}
