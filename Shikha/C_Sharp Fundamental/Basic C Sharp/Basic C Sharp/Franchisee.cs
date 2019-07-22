
namespace Basic_C_Sharp
{
    #region
    //NAME          :- Franchisee
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain properties
    //CREATED DATE  :- 16/07/2012

  class Franchisee: Entity
  {
      int intFees;
        public int Fees                              //property for get and set value of fees
        {
            get
            {
                return intFees;                        
            }
            set
            {
                intFees = value;
            }
        }
        public override string ToString()
        {
            return "fees is"+ intFees;                             //Return value of fees
        }
  }
    #endregion
} 
