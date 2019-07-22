/// <summary>
/// NamespaceName:ASP_Day1_2
/// Description:Webform controls and their states
/// Author: Bhumi
/// Created On:16/6/2015
/// </summary>    
namespace ASP_Day1_2
{
    /// <summary>
    /// Class Name:Class1_DefaultForm
    /// Description:Set and get the value of property
    /// Author:Bhumi
    /// Created On:16/6/2015
    /// </summary>
    public class Class1_DefaultForm
    {
        private string NameValue;
        public string Name
        {
            get
            {
                return NameValue;
            }
            set
            {
                NameValue = value;
            }
        }
    }
}