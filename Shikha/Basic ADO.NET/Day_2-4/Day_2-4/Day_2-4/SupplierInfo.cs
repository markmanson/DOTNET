
namespace Day_2_4
{

    #region SupplierInfo

    // NAME              :-  SupplierInfo
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add supplier information
    // CREATED DATE      :-  31/07/2012
    public class SupplierInfo
    {
        //DECLARATION OF THE VARIABLES
        int intSuppID;
        string strCmpnyNme, strContctNme, strCntctTitle, strAddress, strCity, strRegion, strPstlCd, strCntry, strPhn, strFx, strHmPg;
        #region SuppID

        public int SuppID              //PROPERTY FOR SUPPLIER ID 
        {
            get
            {
                return intSuppID;
            }
            set
            {
                intSuppID = value;
            }
        }
        #endregion SuppID
        #region CmpnyNme

        public string CmpnyNme           //PROPERTY FOR COMPANY NAME 
        {
            get
            {
                return strCmpnyNme;
            }
            set
            {
                strCmpnyNme = value;
            }
        }
        #endregion CmpnyNme
        #region ContctNme

        public string ContctNme         //PROPERTY FOR CONTACT NAME 
        {
            get
            {
                return strContctNme;
            }
            set
            {
                strContctNme = value;
            }
        }
        #endregion ContctNme
        #region CntctTitle
       
        public string CntctTitle         //PROPERTY FOR CONTACT TITLE 
        {
            get
            {
                return strCntctTitle;
            }
            set
            {
                strCntctTitle = value;
            }
        }
        #endregion CntctTitle
        #region Address
         
        public string Address         //PROPERTY FOR ADDRESS
        {
            get
            {
                return strAddress;
            }
            set
            {
                strAddress = value;
            }
        }
        #endregion Address
        #region City
       
        public string City           //PROPERTY FOR CITY
        {
            get
            {
                return strCity;
            }
            set
            {
                strCity = value;
            }
        }
        #endregion City
        #region Region
        
        public string Region          //PROPERTY FOR REGION
        {
            get
            {
                return strRegion;
            }
            set
            {
                strRegion = value;
            }
        }
        #endregion Region
        #region PstlCd
     
        public string PstlCd             //PROPERTY FOR POSTAL CODE
        {
            get
            {
                return strPstlCd;
            }
            set
            {
                strPstlCd = value;
            }
        }
        #endregion PstlCd
        #region Cntry
        
        public string Cntry         //PROPERTY FOR COUNTRY
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
      
        public string Phn               //PROPERTY FOR PHONE 
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
        
        public string Fx              //PROPERTY FOR FAX
        {
            get
            {
                return strFx;
            }
            set
            {
                strFx = value;
            }
        }
        #endregion Fx
        #region HmPg

        public string HmPg            //PROPERTY FOR HOME PAGE 
        {
            get
            {
                return strHmPg;
            }
            set
            {
                strHmPg = value;
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
