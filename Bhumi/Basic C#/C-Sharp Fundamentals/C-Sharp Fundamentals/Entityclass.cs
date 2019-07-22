/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    class Entity:Customer_Entity
    {
        #region Entity class
        //1.Name
        string nam = "bhumi";
        public string Name
        {
            get
            {
                return this.nam;
            }
            set
            {
                this.nam = value;
            }
        }
        //2.MaritalStatus
        private string mst1 = "single";
        public string MaritalStatus
        {
            get
            {
                return mst1;
            }
            set
            {
                mst1 = value;
            }
        }
        //3.Gender
        private string gen1 = "female";
        public string Gender
        {
            get
            {
                return gen1;
            }
            set
            {
                gen1 = value;
            }
        }
        //4.Address 
        private string addrs1 = "keshod";
        public string Address
        {
            get
            {
                return addrs1;
            }
            set
            {
                addrs1 = value;
            }
        }
        public override string ToString()
        {
            //return base.ToString();
            return "Name:" + Name + "\nMarital Status:" + MaritalStatus + "\nGender:" + Gender + "\nAddress:" + Address;
        }
        #endregion
    }
}
