using System;
namespace ConsoleApplication3
{
    #region Sortdate
    //Name                      : Common
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To store the common functions required in project   
    class Sortdate
    {
        #region sortroutine
        //Function to sort dates for call by value *****************************************************************************************
        public void sortroutine(object[] array,int intsize)
        {
            DateTime[] arrDatetime;                                                                 //Declare an array of datetime      
            try
            {                                                                         
                // Console.WriteLine(dt.intFlag);
              /*  for (int i = 0; i < intsize; i++)
                {
                    Console.WriteLine(array[i].ToString());                                         //Convert the array of object into string
                }*/
                string[] str = new string[intsize];
                for (int i = 0; i < intsize; i++)
                {
                    str[i] = Convert.ToString(array[i]);
                }
                    arrDatetime = new DateTime[intsize];                                           //Initializing array of datetime
                for (int i = 0; i < intsize; i++)
                {
                    arrDatetime[i] =Convert.ToDateTime(str[i]);                                   //convert the array into datetime and store into datetime
                }
                for (int i = 0; i < intsize; i++)
                {
                    for (int j = i + 1; j < intsize; j++)
                    {
                        DateTime temp;
                        if (arrDatetime[i] < arrDatetime[j])                                        //Sorting the dates
                        {
                            temp = arrDatetime[i];
                            arrDatetime[i] = arrDatetime[j];
                            arrDatetime[j] = temp;
                        }
                    }
                }                
                foreach(DateTime d in arrDatetime)                                                  //Display the sorted result 
                {
                    Console.WriteLine(d);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                                       //Display the messege if any exception is occures
            }
        }
        #endregion sortroutine
        #region sortroutine
        //Function to sort dates for call by reference *************************************************************************************
        public void sortroutin(ref object[] array,int intsize)
        {
            DateTime[] arrDatetime;                                                                 //Declare an array of datetime      
            try
            {
                // Console.WriteLine(dt.intFlag);
                string[] str = new string[intsize];
                for (int i = 0; i < intsize; i++)
                {
                    str[i] = Convert.ToString(array[i]);
                }
                arrDatetime = new DateTime[intsize];                                                //Initializing array of datetime
                for (int i = 0; i < intsize; i++)
                {
                    arrDatetime[i] = Convert.ToDateTime(str[i]);                                   //convert the array into datetime and store into datetime
                }
                for (int i = 0; i < arrDatetime.Length; i++)
                {
                    for (int j = i + 1; j < arrDatetime.Length; j++)
                    {
                        DateTime temp;
                        if (arrDatetime[i] < arrDatetime[j])                                       //Sorting the dates
                        {
                            temp = arrDatetime[i];
                            arrDatetime[i] = arrDatetime[j];
                            arrDatetime[j] = temp;
                        }
                    }
                }                
                foreach (DateTime d in arrDatetime)                                                //Display the sorted result
                {
                    Console.WriteLine(d);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                                      //Display messege if any exception is occures
            }
        }
        #endregion sortroutine
    }
    #endregion Sortdate
}
