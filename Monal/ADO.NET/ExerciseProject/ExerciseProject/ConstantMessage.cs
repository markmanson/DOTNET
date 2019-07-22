
namespace ExerciseProject
{
    public class ConstantMessage
    {
        private string _NoTableRecordFound=string.Empty;
        private string _NoIdValueFound = string.Empty;
        private string _ErrorMessage = string.Empty;
        public string NoTableRecordFound
        {
            get
            {
                return _NoTableRecordFound = "Datatable Does Not Contain Any Row"; 
            }
            set
            {
                _NoTableRecordFound = value; 
            }

        }
        public  string NoIdValueFoundInControl
        {
            get
            {
                return _NoIdValueFound = "There is No Id value Found";
            }
            set
            {
                _NoIdValueFound =value;
            }

        }

        public  string ErrorMessage
        {
            get
            {
                return _ErrorMessage = "Error Occured.Please contact administrator";
            }
            set
            {
                _ErrorMessage =value;
            }

        }
    }
}
