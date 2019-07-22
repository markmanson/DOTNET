
namespace BASICASPNETProject
{
    public class ConstantMessage
    {
        private string _NameValue=string.Empty;
        private string _ErrorMessage = string.Empty;
        private string _SessionCounter = string.Empty;
        private string _ApplicationCounter = string.Empty;
        public string EnterName
        {
            get{return _NameValue ="Please Enter Name";}
            set{_NameValue = value; }
        }
        public  string ErrorMessage
        {
            get{return _ErrorMessage = "Error Occured.Please contact administrator";}
            set{ _ErrorMessage =value;}

        }
        public string Sessioncounter
        {
            get { return _SessionCounter = "Session Counter"; }
            set { _SessionCounter = value; }

        }
        public string ApplicatioCounter
        {
            get { return _ApplicationCounter = "Application Counter(No.Of User Visited)"; }
            set { _ApplicationCounter = value; }

        }
    }
}
