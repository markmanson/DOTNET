using System;
using System.Collections;
namespace ConsoleApplication3
{
    #region Common
    //Name                      : Common
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To store the common functions required in project   
    class Common
    {
        public ArrayList arrlstcmn = new ArrayList(); 
        #region Getarray
        //FUNCTION TO ENTER AN ARRAY WHILE LENGTH IS PASSED AS  PARAMETER ***********************************************************************
        public int[] Getarray(int size)
        {
            int[] array =new int [size];                    // DECLARATION OF AN ARRAY
            try
            {
                for (int i = 0; i < size; i++)              //LOOP FROM 0 TO (LENGTH-1) OF ARRAY
                {
                    array[i] = int.Parse(Console.ReadLine());           //TAKING VALUES OF ARRAY
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                           //DISPLAY ERROR MESSAGE IF ANY EXCEPTION OCCURS
            }
            return array;
        }
        #endregion Getarray
        #region ShowArray
        //FUNCTION TO DISPLAY AN ARRAY **********************************************************************************************
        public void ShowArray(int [] array)
        {            
            try
            {
                foreach (int i in array)
                {
                    Console.WriteLine(i);                                       //Display array
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                   //Display messege if any Exception is occure
            }            
        }
        #endregion ShowArray
        #region additem
        //Function to add details of customer ******************************************************************************************
        public void additem(Customer objcust)
        {
            //objcust=new Customer();
            Console.Write(Constant.strmsgshowarr1);                     //Display messege to enter the salutation of customer
            objcust.salute = Console.ReadLine();                        //Input salutation of customer by user
            Console.Write(Constant.strmsgshowarr2);                     //Display messege to enter the name of customer
            objcust.name = Console.ReadLine();                          //Input name of customer by user
            Console.Write(Constant.strmsgshowarr3);                     //Display messege to enter the maritial status of customer
            objcust.maritial = Console.ReadLine();                      //Input maritial status of customer by user
            Console.Write(Constant.strmsgshowarr4);                     //Display messege to enter the gender of customer
            objcust.gender = Console.ReadLine();                        //Input gender of customer by user
            Console.Write(Constant.strmsgshowarr5);                     //Display messege to enter the address of customer
            objcust.address = Console.ReadLine();                       //Input address of customer by user
            Console.Write(Constant.strmsgshowarr6);                     //Display messege to enter the qualification of customer
            objcust.qualification = Console.ReadLine();                 //Input qualification of customer by user
            Console.Write(Constant.strmsgshowarr7);                     //Display messege to enter the language of customer
            objcust.language = Console.ReadLine();                      //Input qualification of customer by user
        }
        #endregion additem
        #region ShowMat
        //Function  to display the show matrix *******************************************************************************
        public void ShowMat(int [,]Array,int row,int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Array[i, j]);                                  //DISPLAY THE ELEMENTS OF MATRIX
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
        #endregion ShowMat
        #region addfees
        //Function to add fees details in to Franchisee *************************************************************************
        public void addfees(Franchisee objFre)
        {
            Console.WriteLine("Please enter fee:-");
            objFre.fees = Console.ReadLine();
        }
        #endregion addfees
    }
    #endregion Common
}
