
namespace Basic_C_Sharp
{
    #region
    //NAME          :- Entity
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain properties
    //CREATED DATE  :- 16/07/2012

   public  class Entity
    {
       public string strName, StrMaritialStatus, strGender,strAddress;
       public string Name                                                  //property for get and set value of name,maritialstatus,gender,address
        {
            get
            {
                return strName;
            }
            set
            {
                strName = value;
            }
        }
        public string Maritial_Status
        {
            get
            {
                return StrMaritialStatus;
            }
            set
            {
                StrMaritialStatus = value;
            }
        }

        public string Gender
        {
            get
            {
                return strGender;
            }
            set
            {
                strGender = value;
            }
        }
        public string Address
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

    }
    #endregion
}
