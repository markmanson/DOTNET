using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
        Name:CarModelName.cs
        Author:Monal Shah
        Description:"Change the Car class so the property ModelName is read-only. 
                     Create a parameterized constructor which will accept the value of the ModelName property.
                     e-execute the code for typed arraylist and assign different model names to the car objects."


                      In this program the our own Exception is created
        CreatedDate: 2010/09/15 by Monal Shah
-------------------------------------------------------------------------------------------------------------------
*/
    class CarModelName
    {
        private readonly string _strModelName;
        #region MobelName
        /// <summary>
        /// Name:ModelNme
        /// Description:Create propertyName ModelName
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        /// </summary>
        public string ModelNme
        {
            get { return _strModelName; }

        }
        #endregion
        #region CarModelName
        /// <summary>
        /// Name:CarModelName(Constructor)
        /// argument returnType:string
        /// Description:Create a parameterized constructor which will accept the value of the ModelName property.
        /// Author:Monal shah
        /// CreatedDate: 2010/09/14
        /// </summary>
        /// <param name="strModelName"></param>
        public CarModelName(string strModelName)
        {
            _strModelName = strModelName;
            Console.WriteLine(_strModelName);
        }
        #endregion

    }
}
