using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:WindowDetails
    /// Description://Print out the currently logged in Windows username, home directory and the OS name.
    /// Author:
    /// Created On:19/5/2015
    /// </summary>
    /// 
    class WindowDetails
    {
        #region Details of User & OS
        ConstantMessage objconst;//object creation                                
        //Print out the currently logged in Windows username, home directory and the OS name.
        ///<summary>
        ///Method Name:GetDetails
        /// Description://Details about Username,home directory & os Name
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void GetDetails()
        {            
            objconst = new ConstantMessage();
            try
            {
                //currently logged in Windows username
                Console.WriteLine("UserName: {0}", Environment.UserName);
                //Home directory
                Console.WriteLine("Home Directory:" + Environment.CurrentDirectory);
                //OS name
                Console.WriteLine("OS name: {0}", Environment.OSVersion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}
