
namespace ConsoleApplication3
{
    #region Franchisee
    //Name                      : Franchisee
    //Auther                    : Ankit Sharma
    //Created Date              : 03/07/2012
    //Description               : Class franchisee   
    class Franchisee : Entity
    {
        private string strfees;                                                     //Declaring a string 
        public string fees                                                          //Property for fees
        {
            get
            {
                return strfees;
            }
            set
            {
                strfees = value;
            }
        }
        #region ToString
        //Overriding the function ToString
        public override string ToString()                                           //Override function ToString
        {
            string strdetail = strfees+" ";
            return "Fee Details -- : " +strfees;
        }
        #endregion ToString
    }
    #endregion Franchisee
}
