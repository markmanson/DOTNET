using System;
using System.Collections;
using System.Collections.Generic;
using Users;


namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
    Name:Program.cs
    Author:Monal Shah
    Description:Create a console application that asks the user to enter the exercise/example number.
                Use the numbering system to indicate day followed by a dot followed by the exercise number.
    For e.g. exercise 2 of day 3 would be 3.2  When the user enters 3.2 the code for exercise 2 of day 3 should run.    
    CreatedDate: 2010/09/06 by Monal Shah
    -------------------------------------------------------------------------------------------------------------------
     */
    class Program
    {
        /*---------------------------------------------------------------------------------------------------------------
            Name:Main 
            Paramametres:args
            Return: String
            Description:This method is used for getting the argument value 
                          from the console and call the appropriate case accroding to entered value.
            Author:Monal Shah
            CreatedDate: 2010/09/06 by Monal Shah
        ---------------------------------------------------------------------------------------------------------------
        */
       public static void Main(string[] args)
        {
            /*
              [Date]:2010/09/09 
              [Author Name]:Monal Shah
              [number of lines added]:11
            */
            Vowel objVw;//objVw is object of class Vowel
            SwichVowel objSwc; //objSwc is object of class SwitchVowel
            CaseCheck objCh;  //objCh is object of class CaseCheck 
            Reverse objRev; //objRev is object of class Reverse 
            Sorting objSortAsc; //objSortAsc is object of class Sorting 
            SearchArray objSearch;//objSearch is object of class SearchArray
            ReviseArray objRevise;//objRevise is object of class ReviseArray
            CopyArray objCopyAry; //objCopyAry is object of class CopyArray
            Power objPw; //objPw is object of class Power 
            NotepadWindow objNpw; //objNpw is object of class  NotepadWindow
            WindowsUser objWindowUser;//objWindowUser is object of class  WindowsUser
            bool bolFlag = true;
            ArrayList aryList = new ArrayList();
            List<object> lsCustomerFrnchisee = new List<object>();
            BubbleSort objBubbleSort;//objBubbleSort is object of class  BubbleSort
            TransformMatrix objTransform;//objTransformis object of class  TransformMatrix
            CastingFunction objCasting;//objCasting is object of class  CastingFunction
            StructureDate objDate;//objDate is object of class StructureDate
            TextFile objTxtWrite;//objTxtWrite is object of class TextFile
            ReadTextfile objTxtRead;//objTxtRead is object of class ReadTextfile
            StringBuilderNumToText objNumToText;//objNumToText is object of class  StringBuilderNumToText
            StructureDateSort objDateSort;//objDateSort is object of class  StructureDateSort
            string strValue = "";
            Driver objDrive;//objDrive is object of class Driver
            Car objCar;//objCar object of class Car
            CarMsg objCarMsg;//objCarMsg is object of class CarMsg
            CarAllMsg objCarAllMsg;//objCarAllMsg is object of class CarAllMsg
            CarInterface objVehicle, objCarInterFace, objCar1;//objVehicle,objCarInterFace,objCar1 are objects of class CarInterface
            DestructMsgCar objDestructCar, objDestructCar1;//objDestructCar,objDestructCar1 are objects of class DestructMsgCar
            ArmoredVehicle objArm, objArm1;//objArm,objArm1 are objects of class ArmoredVehicle
            ArrayList aryListDestruct = new ArrayList();
            ExceptionArmodVehicle objExceptionArm;//objExceptionArm is object of class ExceptionArmodVehicle
            ArrayList aryListException=new ArrayList();
            List<object> lsModelName = new List<object>();
            CrateCustomer objCust;//objcust is object Cratecustomer
            Frenchisee objFrnchisee;//objFrenchisee is object Frenchisee
            
            List<object> lsConstructModelName = new List<object>();
            CarNewInterface objCarNInterface;//objCarNInterface is object CarNewInterface
            ArmodVehicleNew objArmodNew;//objArmodNew is object ArmodVehicleNew
            Hashtable hashTable=new Hashtable();
            SortedList slSort;//slSort is object of sortedList 


            /*
              [Date]:2010/09/09 
              [Author Name]:Monal Shah
              Description:Add try catch and finally Block in code
             */
            try
            {
              do
                {
                    Console.WriteLine("Enter value:");
                    string entervalue = Console.ReadLine(); //entervalue is the variable of string datatype 
                    switch (entervalue)
                    {
                        case "2.1":
                            objVw = new Vowel();              //objVw is object of class Vowel
                            objVw.VowelCharacter();                 //vowelcharacter is method of class Vowel so this method is accessed by objVw object. 
                            break;
                        case "2.2":
                            objSwc = new SwichVowel();   //objSwc is object of class SwitchVowel
                            objSwc.SwitchCase();                    //SwitchCase is method of class SwitchVowel so this method is accessed by objSwc object.
                            break;
                        case "2.3":
                            objCh = new CaseCheck();     //objCh is object of class CaseCheck 
                            objCh.CaseCheckLettersDigit();         //CaseCheckLettersDigit is method of class CaseCheck so this method is accessed by objCh object.
                            break;
                        case "2.4":
                            objRev = new Reverse();        //objRev is object of class Reverse 
                            objRev.ReverseNumber();                //ReverseNumber is method of class Reverse so this method is accessed by objRev object.
                            break;
                        case "2.5":
                            objSortAsc = new Sorting();    //objSortAsc is object of class Sorting 
                            objSortAsc.SortValue();                //SortValue is method of class Sorting  so this method is accessed by objSortAsc object.
                            break;
                        case "3.1":
                            objSearch = new SearchArray(); //objSearch is object of class SearchArray
                            objSearch.SearchingArrayValue();           //SearchingArrayValue is method of class SearchArray so this method is accessed by objSearch object.
                            break;
                        case "3.2":
                            objRevise = new ReviseArray(); //objRevise is object of class ReviseArray
                            objRevise.ReviseArrayValue();              //ReviseArrayValue is method of class ReviseArray so this method is accessed by objRevise object.
                            break;
                        case "3.3":
                            objCopyAry = new CopyArray();   //objCopyAry is object of class CopyArray
                            objCopyAry.CopyAryElement();               //CopyAryElement is method of class  CopyArray so this method is accessed by objCopyAry object.
                            break;
                        case "3.4":
                            objPw = new Power();         //objPw is object of class Power 
                            objPw.PowerValue();                //PowerValue is method of class Power so this method is accessed by objPw object.
                            break;
                        case "3.5":
                            objNpw = new NotepadWindow();    //objNpw is object of class  NotepadWindow
                            objNpw.NpWindow();                             //NpWindow is method of class  NotepadWindow so this method is accessed by objNpw object.
                            break;
                        case "3.6":
                            objWindowUser = new WindowsUser(); //objWindowUser is object of class  WindowsUser
                            objWindowUser.WinUser();                       //WinUser is method of class  WindowsUser so this method is accessed by objWindowUser object.
                            break;
                        case "4.7":
                            Console.WriteLine("Customer Details");
                            Console.WriteLine("How Many Customer You"+
                                +"want to add?:");
                            int intCustomer= System.Convert.ToInt32(Console.ReadLine());
                            for (int intI = 0; intI < intCustomer; intI++)
                            {
                                objCust=new CrateCustomer();
                                Console.WriteLine("Please Eneter Customer" +
                                    +"Details For customer " + intI);//here user enter the array value till the intArrnum length
                                Console.WriteLine("Salutation:");
                                objCust.Salut = Console.ReadLine();
                                Console.WriteLine("Name:");
                                objCust.Name = Console.ReadLine();
                                Console.WriteLine("MaritalStatus:");
                                objCust.Maritalstatus = Console.ReadLine();
                                Console.WriteLine("Gender:");
                                objCust.Gender = Console.ReadLine();
                                Console.WriteLine("Address:");
                                objCust.Address = Console.ReadLine();
                                Console.WriteLine("Qualification:");
                                objCust.Qualification = Console.ReadLine();
                                Console.WriteLine("Language:");
                                objCust.Language = Console.ReadLine();
                                aryList.Add(objCust);
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Frenchisee Details");
                            Console.WriteLine("How Many Frenchisee"+
                                +"You want to add?:");
                            int intFrnchisee = System.Convert.ToInt32(Console.ReadLine()); 
                            for (int intJ = 0; intJ < intFrnchisee; intJ++)
                            {
                                objFrnchisee= new Frenchisee();
                                Console.WriteLine("Please Eneter Customer"+
                                   +"Details For customer " + intJ);//here user enter the array value till the intArrnum length
                                Console.WriteLine("Name:");
                                objFrnchisee._strName = Console.ReadLine();
                                Console.WriteLine("MaritalStatus:");
                                objFrnchisee._strMaritalstatus = Console.ReadLine();
                                Console.WriteLine("Gender:");
                                objFrnchisee._strGender = Console.ReadLine();
                                Console.WriteLine("Address:");
                                objFrnchisee._strAddress = Console.ReadLine();
                                Console.WriteLine("Fees:");
                                objFrnchisee.Fees = System.Convert.ToInt32
                                                (Console.ReadLine());
                                aryList.Add(objFrnchisee);

                            }
                                Console.ReadLine();
                            break;
                        case "4.8":
                            Console.WriteLine("Created Customer Details");
                            if (bolFlag)
                            {
                                for (int i = 0; i < aryList.Count; i++)
                                {
                                   Console.WriteLine("******************"+
                                       +"**************************************");
                                   Console.WriteLine(aryList[i]);
                                   Console.WriteLine("********************"+
                                       +"************************************");
                                }
                                Console.ReadLine();
                            }
                            break;
                        case "4.9":
                            Console.WriteLine("Typed Arraylist");
                            Console.WriteLine("How Many Customer You want to add?:");
                            int intCustomerList = System.Convert.ToInt32(Console.ReadLine());
                            for (int intI = 0; intI < intCustomerList; intI++)
                            {
                                objCust = new CrateCustomer();
                                Console.WriteLine("Please Eneter Customer Details"+
                                    +"For customer " + intI);//here user enter the array value till the intArrnum length
                                Console.WriteLine("Salutation:");
                                objCust.Salut = Console.ReadLine();
                                Console.WriteLine("Name:");
                                objCust.Name = Console.ReadLine();
                                Console.WriteLine("MaritalStatus:");
                                objCust.Maritalstatus = Console.ReadLine();
                                Console.WriteLine("Gender:");
                                objCust.Gender = Console.ReadLine();
                                Console.WriteLine("Address:");
                                objCust.Address = Console.ReadLine();
                                Console.WriteLine("Qualification:");
                                objCust.Qualification = Console.ReadLine();
                                Console.WriteLine("Language:");
                                objCust.Language = Console.ReadLine();
                                lsCustomerFrnchisee.Add(objCust);
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Frenchisee Details");
                            Console.WriteLine("How Many Frenchisee You want to add?:");
                            int intFrnchiseeList =Convert.ToInt32
                                                (Console.ReadLine());
                            for (int intJ = 0; intJ < intFrnchiseeList; intJ++)
                            {
                                objFrnchisee = new Frenchisee();
                                Console.WriteLine("Please Eneter Customer Details"+
                                    +"For customer " + intJ);//here user enter the array value till the intArrnum length
                                Console.WriteLine("Name:");
                                objFrnchisee._strName = Console.ReadLine();
                                Console.WriteLine("MaritalStatus:");
                                objFrnchisee._strMaritalstatus = Console.ReadLine();
                                Console.WriteLine("Gender:");
                                objFrnchisee._strGender = Console.ReadLine();
                                Console.WriteLine("Address:");
                                objFrnchisee._strAddress = Console.ReadLine();
                                Console.WriteLine("Fees:");
                                objFrnchisee.Fees = System.Convert.ToInt32
                                                (Console.ReadLine());
                                lsCustomerFrnchisee.Add(objFrnchisee);

                            }
                            Console.ReadLine();
                            break;
                        case "4.10":
                            Console.WriteLine("Typed arraylist details");
                            if (bolFlag)
                            {
                                for (int i = 0; i < lsCustomerFrnchisee.Count; i++)
                                {
                                    Console.WriteLine("********************************************************");
                                    Console.WriteLine(lsCustomerFrnchisee[i]);
                                    Console.WriteLine("********************************************************");
                                }
                                Console.ReadLine();
                            }
                            break;
                        case "5.1":
                            Console.WriteLine("Bubble Sort");
                            objBubbleSort = new BubbleSort();//objBubbleSort is object of class  BubbleSort
                            objBubbleSort.BubbleSorting();//BubbleSorting is method of BubbleSort
                            break;
                        case "5.2":
                            Console.WriteLine("Matrix Program");
                            objTransform = new TransformMatrix();//objTransformis object of class  TransformMatrix
                            objTransform.TransformRowToColumn();//BubbleSorting is method of TransformMatrix
                            break;
                        case "5.3":
                            objCasting = new CastingFunction();//objCasting is object of class  CastingFunction
                            objCasting.CastingValue();//CastingValue is method of CastingFunction
                            break;
                        case "5.4":
                            Console.WriteLine("Plaese Enter the amount:");
                            int intNum = System.Convert.ToInt32
                                        (Console.ReadLine());
                            objNumToText = new StringBuilderNumToText();//objNumToText is object of class  StringBuilderNumToText
                            strValue = objNumToText.StrngBuilderNumtoText(intNum);//StrngBuilderNumtoText is method of StringBuilderNumToText
                            Console.WriteLine(strValue);
                            break;
                        case "6.1":
                            objDate = new StructureDate();//objDate is object of class StructureDate
                            objDate.StructDates();//StructDates is method of StructureDate
                            break;
                        case "6.2":
                            objDateSort = new StructureDateSort();//objDateSort is object of class StructureDateSort
                            objDateSort.StructDateSort();//StructDateSort is method of StructureDateSort
                            break;
                        case "6.3":
                            objTxtWrite = new TextFile();//objTxtWrite is object of class TextFile
                            objTxtWrite.TxtFile();//TxtFile is method of TextFile
                            break;
                        case "6.4":
                            objTxtRead = new ReadTextfile();//objTxtReadis object of class ReadTextfile
                            objTxtRead.ReadFile();//ReadFile is method of ReadTextfile
                            break;
                         case "7.1":
                            objDrive=new Driver();//objDrive object of class driver
                            objDrive.Drive();//Drive is method of Driver Class
                            break;
                         case "7.2":
                            objCar = new Car();//objCar object of class Car
                            objCar.Drive();//Drive is method of Car Class
                            objCar.ShowMessage();//ShowMessage is method of Car Class
                            break;
                         case "7.3":
                            objCarMsg = new CarMsg();//objCarMsg object of class CarMsg
                            objCarMsg.Drive();//Drive is method of Car Class
                            break;
                         case "7.4":
                            objCarAllMsg = new CarAllMsg();//objCarAllMsg object of class CarAllMsg
                            objCarAllMsg.Drive();//Drive is method of CarAllMsg Class
                            break;
                         case "7.5":
                            objVehicle = new CarInterface();//objVehicle object of class CarInterface
                            objVehicle.Drive();//Drive is method of CarInterface Class
                            objVehicle.ShowMessage();//ShowMessage is method of CarInterface Class
                            break;
                         case "8.1":
                            objDestructCar = new DestructMsgCar();//objDestructCar object of class DestructMsgCar
                            objDestructCar.Destruct();//Destruct is method of DestructMsgCar Class
                            objArm = new ArmoredVehicle();//objArm object of class ArmoredVehicle
                            objArm.Destruct();//Destruct is method of ArmoredVehicle  Class
                            break;
                        case "8.2":
                            Console.WriteLine("Cars Details");
                            objDestructCar = new DestructMsgCar();//objDestructCar object of class DestructMsgCar
                            objArm = new ArmoredVehicle();//objArm object of class ArmoredVehicle
                            //Create an arraylist of 5 elements.  Add 3 Car objects and 2 ArmoredVehicle objects to the arraylist.
                            aryListDestruct.Add(objDestructCar);
                            aryListDestruct.Add(objDestructCar);
                            aryListDestruct.Add(objDestructCar);
                            aryListDestruct.Add(objArm);
                            aryListDestruct.Add(objArm);
                            
                            foreach(object obj in aryListDestruct)
                            {
                              //if object's gettype is same as class's object according to that Destruct Method is called
                                if (obj.GetType()==objDestructCar.GetType())
                                {
                                    objDestructCar.Destruct();//Destruct is method of DestructMsgCar Class
                                    Console.ReadLine();
                                 
                                }
                                else if (obj.GetType()==objArm.GetType())
                                {
                                    objArm.Destruct();//Destruct is method of ArmoredVehicle  Class
                                    Console.ReadLine();
                                    
                                }
                               
                            }
                            break;
                        case "8.3":

                            objExceptionArm = new ExceptionArmodVehicle();//objExceptionArm object of class ExceptionArmodVehicle
                            //add obect into aryListException
                            aryListException.Add(objExceptionArm);
                            aryListException.Add(objExceptionArm);
                            aryListException.Add(objExceptionArm);
                            aryListException.Add(objExceptionArm);
                            aryListException.Add(objExceptionArm);
                            foreach (object obj in aryListException)
                            {
                                try
                                {
                                    //if object's gettype is same as class's object according to that Destruct Method is called
                                    if (obj.GetType() == objExceptionArm.GetType())
                                    {
                                        objExceptionArm.Destruct();
                                    }
                                }
                                catch (ExceptionGenerate exException)
                                {
                                    Console.WriteLine("ERROR:"+exException.strM);
                                }
                             }
                          
                            break;
                        case "8.4":
                            objCarInterFace = new CarInterface();// objCarInterFace object of class CarInterface
                            objDestructCar1 = new DestructMsgCar();//objDestructCar1 object of class DestructMsgCar1
                            //add 5 car objects into typed arraylist
                            lsModelName.Add(objCarInterFace);
                            lsModelName.Add(objCarInterFace);
                            lsModelName.Add(objCarInterFace);
                            lsModelName.Add(objCarInterFace);
                            lsModelName.Add(objCarInterFace);
                            foreach (object obj in lsModelName)
                            {
                                //if object's gettype is same as class's object according to  Method is called
                                if (obj.GetType() == objCarInterFace.GetType())
                                {
                                    objCarInterFace.ShowMessage();
                                    objDestructCar1.Destruct();
                                    Console.ReadLine();

                                }
                               
                            }

                            break;
                        case "9.1":
                            //add 5 car model name into typed arraylist
                            lsConstructModelName.Add
                                (new CarModelName("Maruti").ModelNme);
                            lsConstructModelName.Add
                                (new CarModelName("HondaCity").ModelNme);
                            lsConstructModelName.Add
                                (new CarModelName("wagnor").ModelNme);
                            lsConstructModelName.Add
                                (new CarModelName("BMW").ModelNme);
                            lsConstructModelName.Add
                                (new CarModelName("Corola").ModelNme);
                            break;
                        case "9.3":
                            Console.WriteLine("Enter Initial Fuel Value:");
                            int intInitialValue = System.Convert.ToInt32
                                            (Console.ReadLine());
                            Console.WriteLine("Enter Total Kilometer value");
                            float floatNumberKM = System.Convert.ToSingle
                                            (Console.ReadLine());
                            try
                            {
                                objCarNInterface = new CarNewInterface
                                                    (intInitialValue);// objCarNInterface object of class CarINewnterface
                                objCarNInterface.FuelEfficiency = 14;
                                objCarNInterface.Drive(floatNumberKM);
                                objArmodNew = new ArmodVehicleNew
                                                    (intInitialValue);//  objArmodNew object of class ArmodVehicleNew
                                objArmodNew.FuelEfficiency = 5;
                                objArmodNew.Drive(floatNumberKM);
                                Console.ReadLine();
                            }
                            catch (NoFuelLeftException exNoFuel)
                            {
                              Console.WriteLine("ERROR:"+exNoFuel.strM);
                            }
                            break;
                        case "9.4":
                            Console.WriteLine("HashTable Values");
                            objCar1 = new CarInterface();//   objCar1 object of class CarInterface
                            objArm1 = new ArmoredVehicle();//objArm1 object of class ArmoredVehicle
                            //add 3 Car objects and 2 ArmoredVehicle objects to the hashtable. 
                            hashTable.Add("First",new CarInterface());
                            hashTable.Add("Second", new CarInterface());
                            hashTable.Add("Third",new CarInterface());
                            hashTable.Add("Fourth",new ArmoredVehicle());
                            hashTable.Add("Fifth",new ArmoredVehicle());
                            slSort = new SortedList(hashTable);//slsort is object ofSortedList                      
                            try
                            {
                                Console.WriteLine("sort");
                                foreach (object obj in slSort.GetValueList())
                                {
                                    //if object's gettype is same as class 
                                   if (obj.GetType() == typeof(CarInterface))
                                        {
                                            objCar1=(CarInterface)obj;//Casting is done
                                            objCar1.Drive();
                                        }
                                  else if (obj.GetType() == typeof(ArmoredVehicle))
                                        {
                                            objArm1=(ArmoredVehicle)obj;//casting is done
                                            objArm1.Destruct();
                                        }

                                    }                                                                 
                                
                            }
                            catch (Exception exException)
                            {
                                Console.WriteLine("ERROR:" 
                                    + exException.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Please Enter"+
                                +"the value properly");
                            break;
                    }
                } while (true);
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:"+ExException.Message);//throw exeption
            }
            finally
            {
                /*
                 Realese the memory space from the all the objects
                    [Date]:2010/09/09 
                    [Author Name]:Monal Shah
                    [number of lines added]:11
                 */
                objVw = null;
                objSwc = null;
                objSortAsc = null;
                objSearch = null;
                objRevise = null;
                objRev = null;
                objPw = null;
                objNpw = null;
                objCopyAry = null;
                objCh = null;
                objWindowUser = null;
                aryList = null;
                lsCustomerFrnchisee = null;
                objBubbleSort = null;
                objCasting = null;
                objDate = null;
                objTxtRead = null;
                objTxtWrite = null;
                objTransform = null;
                objNumToText = null;
                objCust = null;
                objFrnchisee = null;
                strValue = null;
                objDrive = null;
                objCar = null;
                objCarMsg = null;
                objCarAllMsg = null;
                objVehicle = null;
                objDestructCar = null;
                objArm = null;
                aryListDestruct = null;
                objExceptionArm = null;
                aryListException = null;
                objCarInterFace = null;
                objDestructCar1 = null;
                lsModelName = null;
                lsConstructModelName = null;
                objCarNInterface = null;
                objArmodNew = null;
                objCar1 = null;
                objArm1 = null;
                hashTable = null;
                slSort = null;
                
            }
        }
    }
}
