namespace BASICASPNETProject
{
    /// <summary>
    /// Name:CounterDefaultValue.cs
    /// Description:get set the value of username
    /// Author:Monal shah 
    /// Created Date:2010/10/11
    /// </summary>
    public class CounterDefaultValue
    {
        private string _NameValue = string.Empty;
        public string Name
        {
            get { return _NameValue; }
            set { _NameValue = value; }
        }
    }
}
