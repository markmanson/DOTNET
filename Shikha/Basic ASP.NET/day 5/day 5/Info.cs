
namespace day_5
{
    public class Info
    {
        //DECLARATION OF THE VARIABLES
       
        #region Name
        string strName, strDob, strSex, strEmail, strPassword, strFaxNumber, strMarried, strLanguage;
        public string Name
        {
            get { return strName; }
            set { strName  = value; }
        }
        #endregion Name
        #region Sex

        public string Sex           //PROPERTY FOR Information
        {
            get
            {
                return strSex;
            }
            set
            {
                strSex = value;
            }
        }
        #endregion Sex

        #region Email
        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        #endregion Email

        #region Dob
        public string Dob
        {
            get { return strDob; }
            set { strDob = value; }
        }
        #endregion Dob
        #region Password
        public string Password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }

        #endregion Password
        #region FaxNumber
        public string FaxNumber
        {
            get { return strFaxNumber; }
            set { strFaxNumber = value; }
        }
        #endregion FaxNaumber

        #region Married
        public string Married
        {
            get { return strMarried; }
            set { strMarried = value; }
        }
        #endregion Married

        #region Language
        public string Language
        {
            get { return strLanguage; }
            set { strLanguage = value; }
        }
        #endregion Language
    }
}
