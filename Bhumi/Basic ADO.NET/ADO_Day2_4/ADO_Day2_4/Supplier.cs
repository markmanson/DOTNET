
namespace ADO_Day2_4
{
    public class Supplier
    {
        //Properties of Supplier Class
        private int id;
        public int SupplierID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private string contactnm;
        public string ContactName
        {
            get
            {
                return contactnm;
            }
            set
            {
                contactnm = value;
            }
        }
        private string companynm;
        public string CompanyName
        {
            get
            {
                return companynm;
            }
            set
            {
                companynm = value;
            }
        }
        private string citynm;
        public string City
        {
            get
            {
                return citynm;
            }
            set
            {
                citynm = value;
            }
        }
        //Override Method
        public override string ToString()
        {
            
            return base.ToString();
        }
    }
}