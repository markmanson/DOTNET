
namespace Day2_4
{
    #region SupplierInfo
    /************************************************************************************************************************
        NAME                               ::::                    SUPPLIERINFO
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    16-07-2012
        DESCRIPTION                        ::::                    TO MAKE A CLASS WITH ALL THE PROPERTIES OF SUPPLIER TABLE
       **********************************************************************************************************************/
    public class SupplierInfo
    {
        //DECLARATION OF THE VARIABLES
        int intSuppID;
        string strCmpnyNme,strContctNme,strCntctTitle,strAddress,strCity,strRegion,strPstlCd,strCntry,strPhn,strFx,strHmPg;
        #region SuppID
        //PROPERTY FOR SUPPLIER ID ******************************************************************************************
        public int SuppID
        {
            get
            {
                return intSuppID;
            }
            set
            {
                intSuppID=value;
            }
        }
        #endregion SuppID
        #region CmpnyNme
        //PROPERTY FOR COMPANY NAME ******************************************************************************************
        public string CmpnyNme
        {
            get
            {
                return strCmpnyNme;
            }
            set
            {
                strCmpnyNme=value ;
            }
        }
        #endregion CmpnyNme
        #region ContctNme
        //PROPERTY FOR CONTACT NAME ******************************************************************************************
        public string ContctNme
        {
            get
            {
                return strContctNme;
            }
            set
            {
                strContctNme=value;
            }
        }
        #endregion ContctNme
        #region CntctTitle
        //PROPERTY FOR CONTACT TITLE ******************************************************************************************
        public string CntctTitle
        {
            get
            {
                return strCntctTitle;
            }
            set
            {
                strCntctTitle=value;
            }
        }
        #endregion CntctTitle
        #region Address
        //PROPERTY FOR ADDRESS ************************************************************************************************
        public string Address
        {
            get
            {
                return strAddress;
            }
            set
            {
                strAddress=value;
            }
        }
        #endregion Address
        #region City
        //PROPERTY FOR CITY **************************************************************************************************
        public string City
        {
            get
            {
                return strCity;
            }
            set
            {
                strCity=value;
            }
        }
        #endregion City
        #region Region
        //PROPERTY FOR REGION ************************************************************************************************
        public string Region
        {
            get
            {
                return strRegion;
            }
            set
            {
                strRegion=value;
            }
        }
        #endregion Region
        #region PstlCd
        //PROPERTY FOR POSTAL CODE *******************************************************************************************
        public string PstlCd
        {
            get
            {
                return strPstlCd;
            }
            set
            {
                strPstlCd=value;
            }
        }
        #endregion PstlCd
        #region Cntry
        //PROPERTY FOR COUNTRY ***********************************************************************************************
        public string Cntry
        {
            get
            {
                return strCntry;
            }
            set
            {
                strCntry = value;
            }
        }
        #endregion Cntry
        #region Phn
        //PROPERTY FOR PHONE *************************************************************************************************
        public string Phn
        {
            get
            {
                return strPhn;
            }
            set
            {
                strPhn = value;
            }
        }
        #endregion Phn
        #region Fx
        //PROPERTY FOR FAX ****/***********************************************************************************************
        public string Fx
        {
            get
            {
                return strFx;
            }
            set
            {
                strFx=value;
            }
        }
        #endregion Fx
        #region HmPg
        //PROPERTY FOR HOME PAGE **********************************************************************************************
        public string HmPg
        {
            get
            {
                return strHmPg;
            }
            set
            {
                strHmPg=value;
            }
        }
        #endregion HmPg
        public override string ToString()
        {
            return intSuppID + strCmpnyNme + strContctNme + strCntctTitle + strAddress + strCity + strRegion + strPstlCd + strCntry + strPhn + strFx + strHmPg;
        }
    }
    #endregion SupplierInfo
}
