using System;
using System.Collections;
using System.Collections.Generic;
using Users;
using Vehicles;
namespace Basic_C_Sharp
{
    #region
    // NAME              :-  PROGRAM
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  MAIN CLASS
    // CREATED DATE      :-  16/07/2012
    class Program
    {
        // NAME              :-  MAIN METHOD
        // AUTHOR NAME       :-  SHIKHA MALIK
        // DECRIPTION        :-  MAIN METHOD
        // CREATED DATE      :-  16/07/2012
        static void Main(string[] args)
        {
            string strS; Vowel objVowel; SwitchVowel objSvowel; CaseCheck objCaseCheck; Reverse objReverse; PowerNum objPowerNum; WindowName objWindowName;                                                     //Declaration of variable
            char chr = 'a'; int n, m; ArrayList arrLstN = new ArrayList(); List<object> arrLstlist = new List<object>();
            StructDate[] objdt; ReverseSort objReverse1; SearchArray objSearchArray; ReviseArray objReviseArray; CopyArray objCopyArray; NotePadApplication objNotePadApplication;
            Franchisee objFranchisee; Customer objCustomer; BubbleSort objBubbleSort; TransformArry objTransformArry; CastValue objCastValue; StringBldr objStringBldr;
            StructDate objStructure; DateArray objDateArray; TextFile objTextFile; ReadTextFile objReadTextFile; ArrayList arrLstCarArmd = new ArrayList();
            List<object> objListCar5 = new List<object>(); Driver objDriver; Car objCar; Car2 objCar2; Car3 objCar3; Car4 objCar4; ArmoredVehicle objArmoredVehicle;
            CarArmoredVcle objCarArmoredVcle; CarArmoredVcle1 objCarArmoredVcle1; Car5 objCar5; List<object> objArryLstD = new List<object>(); List<object> objArryLstD1 = new List<object>();
            try
            {
                System.Console.WriteLine(Constant.strEntrP1);
                System.Console.WriteLine(Constant.strEntrP2);
                System.Console.WriteLine(Constant.strEntrP3);
                System.Console.WriteLine(Constant.strEntrP4);
                System.Console.WriteLine(Constant.strEntrP5);
                System.Console.WriteLine(Constant.strEntrP6);
                System.Console.WriteLine(Constant.strEntrP7);
                System.Console.WriteLine(Constant.strEntrP8);
                System.Console.WriteLine(Constant.strEntrP9);
                System.Console.WriteLine(Constant.strEntrP10);
                System.Console.WriteLine(Constant.strEntrP11);
                System.Console.WriteLine(Constant.strEntrP12);
                System.Console.WriteLine(Constant.strEntrP13);
                System.Console.WriteLine(Constant.strEntrP14);
                System.Console.WriteLine(Constant.strEntrP15);
                System.Console.WriteLine(Constant.strEntrP16);
                System.Console.WriteLine(Constant.strEntrP17);
                System.Console.WriteLine(Constant.strEntrP18);
                System.Console.WriteLine(Constant.strEntrP19);
                System.Console.WriteLine(Constant.strEntrP20);
                System.Console.WriteLine(Constant.strEntrP21);
                System.Console.WriteLine(Constant.strEntrP22);
                System.Console.WriteLine(Constant.strEntrP23);
                System.Console.WriteLine(Constant.strEntrP24);
                System.Console.WriteLine(Constant.strEntrP25);
                System.Console.WriteLine(Constant.strEntrP26);
                System.Console.WriteLine(Constant.strEntrP27);
                System.Console.WriteLine(Constant.strEntrP28);
                System.Console.WriteLine(Constant.strEntrP29);
                System.Console.WriteLine(Constant.strEntrP30);
                System.Console.WriteLine(Constant.strEntrP31);
                System.Console.WriteLine(Constant.strEntrP32);
                System.Console.WriteLine(Constant.strEntrP33);
                System.Console.WriteLine(Constant.strEntrP34);
                System.Console.WriteLine(Constant.strEntrP35);
                System.Console.WriteLine(Constant.strSpace);
                System.Console.WriteLine(Constant.strStar);
                do
                {
                    System.Console.WriteLine(Constant.strEntrCh);                                    //Gather Information regarding choice

                    strS= System.Console.ReadLine();                                                    //Read value of string 

                    switch (strS)
                    {
                        case "2.1":                                                   //case use for 2.1 exercise that is chracter is vowel or not
                           objVowel = new Vowel();                                 //create object for class                                
                           objVowel.vowelc();
                           break;

                        case "2.2":                                                     //case use for 2.2 exercise that is chracter is vowel or not using swith case                                             
                            objSvowel = new SwitchVowel();                       //create object for class   
                            objSvowel.Switchvl();                
                            break;

                        case "2.3":                                                     //case use for 2.3 exercise that is for Enter digit , char in both case and count their times.
                            objCaseCheck = new CaseCheck();                        //create object for class   
                            objCaseCheck.CaseC();
                            break;
  
                        case "2.4":                                                    //case use for 2.4 exercise that is use for reverse array
                             objReverse = new Reverse();                         //create object for class   
                            objReverse.Rev();
                             break;

                        case "2.5":                                                  // case use for 2.5 exercise that is use for reverse array and sort array
                            objReverse1 = new ReverseSort();             //create object for class   
                            objReverse1.RevS();
                            break;
                     
                        case "2.6":                                                  // case use for 2.6 exercise that is use for search element from arry
                             objSearchArray = new SearchArray();          //create object for class   
                            objSearchArray.Sarray();
                            break;
                 
                        case "2.7":                                                   // case use for 2.7 exercise that is use for serch element and print number of times its exists.
                             objReviseArray = new ReviseArray();           //create object for class   
                            objReviseArray.Rarray();
                            break;

                        case "2.8":                                                 // case use for 2.8 exercise that is use for copy array according to condition
                             objCopyArray = new CopyArray();              //create object for class   
                            objCopyArray.Carray();
                            break;

                        case "2.9":                                                 // case use for 2.9 exercise that is use for calculate the power of entered number
                            objPowerNum = new PowerNum();                   //create object for class   
                            objPowerNum.Pwrnum();
                            break;

                        case "2.10":                                                              // case use for 2.10 exercise that is used for open notepad
                            objNotePadApplication = new NotePadApplication();  //create object for class   
                            objNotePadApplication.Notepad();
                            break;

                        case "2.11":                                             // case use for 2.11 exercise that is used for display required system information
                             objWindowName = new WindowName();         //create object for class   
                             objWindowName.WinName();
                             break;

                        case "4.7":                                                             // case use for 4.7 exercise that is for arraylist
                            Console.WriteLine(Constant.strEnumObjArry);                        //message for enter number of object of Customer class
                            n = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= n; i++)                                       // loop for number of times of object of Customer class
                            {   
                                objCustomer = new Customer();
                                Console.WriteLine(Constant.strEntrsalCt + "" + i);
                                objCustomer.Salutation = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrNmCt + "" + i);
                                objCustomer.Name = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrMatCt + "" + i);
                                objCustomer.Maritial_Status = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrGenCt + "" + i);
                                objCustomer.Gender = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrAddCt + "" + i);
                                objCustomer.Address = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrQualCt + "" + i);
                                objCustomer.Qualification = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrLanCt + "" + i);
                                objCustomer.Language = Console.ReadLine();
                                arrLstN.Add(objCustomer);                                            //add into arraylist
                            }
                                
                            Console.WriteLine(Constant.strEntrObjFrch); // message for enter number of object of Franchisee class
                            m = int.Parse(Console.ReadLine());
                           
                            for (int i = 1; i <= m; i++)                                        //  loop for number of times of object of Franchisee class
                            {
                                 objFranchisee = new Franchisee();
                                Console.WriteLine(Constant.strEntrFeesFrch + "" + i);
                                objFranchisee.Fees=int.Parse( Console.ReadLine());
                                arrLstN.Add(objFranchisee);                                            //add into arraylist
                            }
                            Console.ReadLine();
                            break;

                        case "4.8":                                                           // case use for 4.8 exercise that is for show arraylist
                            for(int i=0;i<arrLstN.Count;i++)
                            {
                                Console.WriteLine(arrLstN[i].ToString());
                            }

                            break;
                        case "4.9":                                                                                        // case use for 4.9 exercise that is for Typed Arraylist
                            Console.WriteLine(Constant.strEnumObjList);                                   //message for enter number of object of Customer class
                            n = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= n; i++)                                                                  // loop for number of times of object of Customer class
                            {
                                objCustomer = new Customer();
                                Console.WriteLine(Constant.strEntrsalCt + "" + i);
                                objCustomer.Salutation = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrNmCt + "" + i);
                                objCustomer.Name = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrMatCt + "" + i);
                                objCustomer.Maritial_Status = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrGenCt + "" + i);
                                objCustomer.Gender = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrAddCt + "" + i);
                                objCustomer.Address = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrQualCt + "" + i);
                                objCustomer.Qualification = Console.ReadLine();
                                Console.WriteLine(Constant.strEntrLanCt + "" + i);
                                objCustomer.Language = Console.ReadLine();
                                arrLstlist.Add(objCustomer);                                                             //  add into List
                            }

                            Console.WriteLine(Constant.strEntrObjFrch);
                            m = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= m; i++)
                            {
                                objFranchisee = new Franchisee();
                                Console.WriteLine(Constant.strEntrFeesFrch + "" + i);

                               
                                objFranchisee.Fees = int.Parse(Console.ReadLine());

                                arrLstlist.Add(objFranchisee);                                                           //  add into List                                                  

                            }

                            Console.ReadLine();
                            break;

                        case "4.10":                                                                     // case use for 4.10 exercise that is for show arraylist
                            for (int i = 0; i < arrLstlist.Count; i++)
                            {
                                Console.WriteLine(arrLstlist[i].ToString());
                            }
                            break;

                        case "4.11":                                                                //case use for 4.11 exercise that is use for sorting array 
                            objBubbleSort = new BubbleSort();                         //create object for class   
                            objBubbleSort.BublSrt();
                            break;

                        case"4.12":                                                             //case use for 4.12 exercise that is used for transform matrix
                            objTransformArry = new TransformArry();                //create object for class  
                            objTransformArry.TrnsfrmArr();                                               
                            break;

                        case "4.13":                                                           //case use for 4.13 exercise that is used for casting of double value
                            objCastValue = new CastValue();
                            objCastValue.CastFltMy();                                           //create object for class 
                            break;

                        case "4.14":                                                         //case use for 4.14 exercise that is used for convert input amount into string
                            objStringBldr = new StringBldr();
                            Console.WriteLine(Constant.strEntrAmount);
                            int intN=int.Parse(Console.ReadLine());
                            string strS2;
                           strS2= objStringBldr.NumToWrds(intN);                                           //create object for class 
                           Console.WriteLine(strS2);
                            break;
                        case "4.15":                                                        //case use for 4.15 exercise that is used for create StructDate
                            objStructure = new StructDate();
                            objStructure.dateArray();                                       //  //create object for class 
                            break;
                       
                        case "4.16":                                                    //Case use for 4.16 exercise that is used for sorting date
                 
                            Console.WriteLine(Constant.strEnumDate);
                            int size = Convert.ToInt32(Console.ReadLine());
                            objdt = new StructDate[size];                               //create object of structDate array        
                            for (int i = 0; i < size; i++)
                            {
                                Console.WriteLine(Constant.strEntrdate+ (i + 1));
                                Console.WriteLine(objdt[i].dateArray());              
                            }
                         objDateArray = new DateArray();
                         objDateArray.dateArray(objdt);                                      //Pass by value
                          objDateArray.dateArray(ref objdt);                                 //Pass by Reference break
                            break;

                        case "4.17":                                                   //Case use for 4.17 exercise that is used for Write lines on file
                            objTextFile = new TextFile();                      //create object for class 
                            objTextFile.TextFileM();                                  
                            break;
                        case "4.18":                                                  //Case use for 4.18 exercise that is used for read file content
                            objReadTextFile = new ReadTextFile();        //create object for class 
                            objReadTextFile.ReadText();
                            break;
                        case "7.1":                                               //Case use for 7.1 exercise that is used Driver class 
                            objDriver = new Driver();
                            objDriver.Drive();                                      //create object for class 
                            break;
                        case "7.2":
                            objCar = new Car();                                  //Case use for 7.2 exercise that is used Car class
                            objCar.Drive();
                            break;
                        case "7.3":                                                //Case use for 7.3 exercise that is used Car2 class
                            objCar2 = new Car2();
                            objCar2.Drive();                                       //create object for class
                            break;
                        case "7.4":                                             //Case use for 7.4 exercise that is used Car3 class
                            objCar3 = new Car3();
                            objCar3.Drive();                                       //create object for class
                            break;
                        case "7.5":                                           //Case use for 7.5 exercise that is used Car4 class
                            objCar4 = new Car4();
                            objCar4.Destruct();                              //create object for class
                            break;
                        case "7.6":                                            //Case use for 7.6 exercise that is used  ArmoredVehicle class
                            objArmoredVehicle = new ArmoredVehicle();
                            objArmoredVehicle.Destruct();                       //create object for class
                            break;
                        case "7.7":                                                     //Case use for 7.7 exercise that is used CarArmoredVcle class
                            objCarArmoredVcle = new CarArmoredVcle();
                            ArrayList objarr = objCarArmoredVcle.CarArmored();          //create object for class
                                 foreach (object obj in objarr)
                                  {
                                     Console.WriteLine(obj);
                                  }
                                 break;
                        case "7.8":                                                    //Case use for 7.8 exercise that is used CCarArmoredVcle1 class
                             objCarArmoredVcle1 = new CarArmoredVcle1();
                             ArrayList objarr1 = objCarArmoredVcle1.CarArmored();         //create object for class
                            foreach (object obj in objarr1)
                            {
                                try { Console.WriteLine(obj); }

                                catch (VehicleNtDestydException v)
                                {
                                    Console.WriteLine(v.Message);
                                }
                            }
                                     break;
                        case "7.9":                                              //Case use for 7.9 exercise that is used Arraylist, create dynamically object
                             Console.WriteLine(Constant.strEntrCarobject);
                             int intLst1 = int.Parse(Console.ReadLine());
                             for (int i = 0; i < intLst1; i++)                  //Create object in looping
                             {
                                 Console.WriteLine(Constant.strEntrCarModel);
                                 string strModelnm = Console.ReadLine();
                                 objCar5 = new Car5(strModelnm);
                                 objArryLstD1.Add(objCar5);                     //Add object intito Arraylist
                             }

                             for (int i = 0; i < objArryLstD1.Count; i++)       //looping for traverse list
                            {
                                Console.WriteLine(objArryLstD1[i].ToString());
                            }
                            break;
                             //objListCar5.Add(objCar5 = new Car5("IV-Tec"));
                             //objListCar5.Add(objCar5 = new Car5("City Honda"));
                             //foreach (object obj in objListCar5)
                             //{
                             //    Console.WriteLine(obj.ToString());
                             //}

                             //  break;
                        case "7.10":                                              //Case use for 7.10 exercise that is used Arraylist, create dynamically object and make readonly property

                            Console.WriteLine(Constant.strEntrCarobject);
                            int intLst = int.Parse(Console.ReadLine());
                            for (int i = 0; i < intLst; i++)                          //Create object in looping
                            {
                               
                              Console.WriteLine(Constant.strEntrCarModel);
                             string  strModelnm= Console.ReadLine();
                             CarArmoredVclList objCarArmoredVclList = new CarArmoredVclList(strModelnm);
                             objArryLstD.Add(objCarArmoredVclList);                                    //Add object intito Arraylist                                 
                            }

                            for (int i = 0; i < objArryLstD.Count; i++)                   //looping for traverse list
                            {
                                Console.WriteLine(objArryLstD[i].ToString());
                            }
                            break;
                        case "7.11":                                                   //Case use for 7.11 exercise that is used for fuel calculation
                           
                            Console.WriteLine(Constant.strIniValCar);              //Enter initial value for car
                            int intK = Convert.ToInt16(Console.ReadLine());
                            Car6  objCar6 = new Car6(intK);
                            Console.WriteLine(Constant.strIniValArmored);            //Enter initial value for Armored Vehicle
                            int intC = Convert.ToInt16(Console.ReadLine());
                            CarFuelCmsptn objCarFuelCmsptn = new CarFuelCmsptn(intC);
                            objCarFuelCmsptn.FuelEfficiency = 5;
                            objCar6.FuelEfficiency = 14;
                            Console.WriteLine(Constant.strEntrKiloCar);                   //Enter number of Kilometer Driven by Car by user
                            try { objCar6.Drive(Convert.ToDouble(Console.ReadLine())); }
                            catch (NoFuelLeftException v) { Console.WriteLine(v); }
                            Console.WriteLine(Constant.strEntrKiloArmored);                  // Enter number of Kilometer Driven by ArmoredVehicle by user
                            try { objCar6.Drive(Convert.ToDouble(Console.ReadLine())); }
                            catch (NoFuelLeftException StrFuel) { Console.WriteLine(StrFuel); }
                            break;

                        case "7.12":                                                        //Case use for 7.11 exercise that is used for create hash table, add object in it.
                            HashTblCar objHashTblCar = new HashTblCar();
                            objHashTblCar.HashTblSort();                                      //create object for class
                            break;

                        default:
                            Console.WriteLine(Constant.strEntrNch);             //enter no choice
                            break;

                    }
                    
                    Console.WriteLine(Constant.strEntrCyn);      // Gather information that you want continue or not
                    chr = Char.Parse(Console.ReadLine());                         //  Read value of character
                                                                     
                } while (chr == 'Y' ||chr=='y');


                if (chr == 'N'|| chr=='n')
                {
                    Console.WriteLine(Constant.strMsg);   // Display message if you press N
                    Console.ReadLine();
                }
             
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message.ToString ());                    // throw exception
                Console.Read();
            }
             finally
                  {

                     strS = null; objVowel = null; objSvowel = null; objCaseCheck = null;                                      //REALLOCATE THE MEMORY
                     objdt = null; objReverse = null; objPowerNum = null; objWindowName = null;
                     objReverse1=null;  objSearchArray=null; objReviseArray=null;  objCopyArray=null;
                     objNotePadApplication = null;objDateArray=null;  objTextFile=null;
                     objReadTextFile = null; objDriver = null; objCar = null; objCar2 = null; objCar3 = null; objCar4 = null; objCar5 = null;
                     objArmoredVehicle = null; objCarArmoredVcle = null; objCarArmoredVcle1 = null;
                       
                  }
            
            }
    }
    #endregion
}


