using System;
using System.Collections;
using System.Collections.Generic;
using Vehicles;
using Users;
namespace ConsoleApplication3
{
    #region Program
    //Name                      : Program
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To call all the classes in 
    class Program
    {
        #region main
        //**********************************   Function main     **************************************************************************
        static void Main(string[] args)
        {
            char ch2;
            string strch1;
            int [] intarr;
            int intchoice;
            List <string> arrDate;
            Boolean boolreturn;
            Constant objconstant;                                                   //Declaring an object for class Constant
            Common objcommon;                                                       //Declaring an object for class Common
            Vowel objvowel;                                                         //Declaring an object for class Vowel
            SwitchVowel objswitchvowel;                                             //Declaring an object for class WwitchVowel
            CaseCheck objcasecheck;                                                 //Declaring an object for class switch CaseCheck           
            Reverse objreverse;                                                     //Declaring an object for class Reverse
            SearchArray objsearcharray;                                             //Declaring an object for class SearchArray
            ReviseArray objrevisearray ;                                            //Declaring an object for class ReviseArray
            SortArray objsortarray;                                                 //Declaring an object for class SortArray
            Power objpower;                                                         //Declaring an object for class Power
            CopyArray objcopyarray;                                                 //Declaring an object for class CopyArray
            OpenNotepad objopennotepad ;                                            //Declaring an object for class OpenNotepad
            Systemdetail objsys ;                                                   //Declaring an object for class SystemDetail
            Customer objcustomer;                                                   //Declaring an object for class Customer
            Franchisee objfranchisee;                                               //Declaring an object for class Franchisee
            Bubble objbubble ;                                                      //Declaring an object for class Bubble
            Transform objtransform;                                                 //Declaring an object for class Transform
            Rounding objrounding;                                                   //Declaring an object for class Rounding
            DateValidate objDateValidate;                                           //Declaring an object for class DateValidate
            Sortdate objsortdate;                                                   //Declaring an object for class Sortdate
            Txtfile objtxtfile;                                                     //Declaring an object for class Txtfile
            Showfile objshowfile;                                                   //Declaring an object for class Showfile
            ShowWords objshowwords;                                                 //Declaring an object for class ShowWords
            Vehicle objVehicle;                                                     //Declaring an object for class Vehicle
            Driver objDriver;                                                       //Declaring an object for class Driver
            Car objCar;                                                             //Declaring an object for class car
            CarMsg objCarMsg;                                                       //Declaring an object for class CarMsg
            CarAllMsg objCarAllMsg;                                                 //Declaring an object for class CarAllMsg
            CarInterface objCarInterface;                                           //Declaring an object for class CarInterface
            CarInterface2 objCarInterface2;                                         //Declaring an object for class CarInterface2
            ArmoredVehicle objArm;                                                  //Declaring an object for class ArmoredVehicle
            CarInterface3 objCarInterface3;                                         //Declaring an object for class CarInterface3
            Armored_Fuel objArmored_Fuel;                                           //Declaring an object of Armored_Fuel
            Car_FuelConsumption objCar_FuelConsumption;                             //Declaring an object of Car_FuelConsumption
            Armored_Fuel objArmor_I1;                                               //Declaring an object of Armored_FuelComsumption
            Car_FuelConsumption objCar_IF1;                                         //Declaring an object of Car_fuelCocsumption
            SortedList MySort;                                                      //Declaring a sorted list
            ArrayList arrlstmylist;                                                 //Declaring an arraylist
            List<object> arrlstobj;                                                 //Declaring a typed array list of objects
            List<object> arrlstStrct;                                               //Declaring an arraylist of object type
            Hashtable HashA;                                                        //Declaring a hashtable
            object[] arr;                                                           //Declaring an array of objects
            int k;                                                                  //Integer variable k
            List<object> lstCar;                                                    //Declaring a typed array list of Car
            ArrayList arrlstVehicle;                                                //Declaring an arraylist 
            //***********************************    Printing Menu    **********************************************************************
            try
            {
                k = 0;
                intarr = new int[5];
                objconstant = new Constant();                                    //Initializing an object for class Constant
                objcommon = new Common();                                        //Initializing an object for class Common 
                arrlstmylist = new ArrayList();                                  //Initializing an arraylist
                arrlstobj=new List<object>();
                //int intLength = 0;
                arrDate = new List<string>();
                arrlstStrct = new List<object>();
                arr = new object[10];
                objDateValidate = new DateValidate();                       //Initializing the object of class DateValidate
                do
                {
                    Console.WriteLine(Constant.strMenu);                //Display the menu 
                    Console.WriteLine(Constant.strMenu1);               //Display first item of the menu
                    Console.WriteLine(Constant.strMenu2);               //Display second item of the menu
                    Console.WriteLine(Constant.strMenu3);               //Display third item of the menu
                    Console.WriteLine(Constant.strMenu4);               //Display fourth item of the menu
                    Console.WriteLine(Constant.strMenu5);               //Display fifth item of the menu
                    Console.WriteLine(Constant.strMenu6);               //Display sixth item of the menu
                    Console.WriteLine(Constant.strMenu7);               //Display seventh item of the menu
                    Console.WriteLine(Constant.strMenu8);               //Display eighth item of the menu
                    Console.WriteLine(Constant.strMenu9);               //Display nineth item of the menu
                    Console.WriteLine(Constant.strMenu10);              //Display tenth item of the menu
                    Console.WriteLine(Constant.strMenu11);              //Display eleventh item of the menu
                    Console.WriteLine(Constant.strMenu14);              //Display the twelefth item of menu
                    Console.WriteLine(Constant.strMenu15);              //Display the thirteenth item of menu
                    Console.WriteLine(Constant.strMenu16);              //Display the fourteenth item of menu
                    Console.WriteLine(Constant.strMenu17);              //Display the fifteenth item of menu
                    Console.WriteLine(Constant.strMenu18);              //Display the sixteenth item of menu
                    Console.WriteLine(Constant.strMenu19);              //Display the seventeenth item of menu
                    Console.WriteLine(Constant.strMenu20);              //Display the eighteenth item of menu
                    Console.WriteLine(Constant.strMenu21);              //Display the ninteenth item of menu
                    Console.WriteLine(Constant.strMenu22);              //Display the twentyth item of menu
                    Console.WriteLine(Constant.strMenu23);              //Display the twenty first item of menu
                    Console.WriteLine(Constant.strMenu24);              //Display the twenty second item of menu                   
                    Console.WriteLine(Constant.strMenu25);              //Display the twenty third item of menu
                    Console.WriteLine(Constant.strMenu26);              //Display the item of menu for namespace test
                    Console.WriteLine(Constant.strMenu27);              //Display the item of menu for car 
                    Console.WriteLine(Constant.strMenu28);              //Display the item of manu carmsg
                    Console.WriteLine(Constant.strMenu29);              //Display item for class CarAllMsg
                    Console.WriteLine(Constant.strMenu30);              //Display item for class CarInterface
                    Console.WriteLine(Constant.strMenu31);              //Display item for class CarAllMsg
                    Console.WriteLine(Constant.strMenu32);              //Display item for adding objects of car and armoredvehicle to array list
                    Console.WriteLine(Constant.strMenu33);              //Display item for throwing an exception can not be destroyed
                    Console.WriteLine(Constant.strMenu34);              //Display item for adding model name of cars
                    Console.WriteLine(Constant.strMenu35);              //Display item for parametrized constructed
                    Console.WriteLine(Constant.strMenu36);
                    Console.WriteLine(Constant.strMenu37);
                  //  Console.WriteLine(Constant.strMenu38);
                    Console.WriteLine(Constant.strMenu12);
                    Console.WriteLine(Constant.strMenu13);              //Display message to enter choice                 
                    strch1 = Console.ReadLine();                                        //Read choice of user
                    switch (strch1)                                                     //Switch case for running code according to choice of user
                    {
                        case "2.1":                                                     // Case 2.1 to call vowel.cs
                            objvowel = new Vowel();                                          //Initializing an object for class Vowel
                            objvowel.check();
                            break;
                        case "2.2":                                                     // Case 2.2 to call switchvowel.cs
                            objswitchvowel = new SwitchVowel();                              //Initializing an object for class WwitchVowel
                            objswitchvowel.checkVowelSwitch();
                            break;
                        case "2.3":                                                     // Case 2.3 to call casecheck.cs
                            objcasecheck = new CaseCheck();                                  //Initializing an object for class switch CaseCheck    
                            objcasecheck.checkcase();
                            break;
                        case "2.4":                                                     // Case 2.4 to call reverse.cs
                            objreverse = new Reverse();                                      //Initializing an object for class Reverse
                            intarr = objreverse.rvrsarray(objreverse.arrRev);
                            Console.WriteLine(Constant.strMsgArrrev);                          
                            objcommon.ShowArray(intarr);
                            break;
                        case "2.5":                                                     // Case 2.5 to call sortarray.cs
                            objsortarray = new SortArray();                                      //Initializing an object for class Reverse
                            intarr = objsortarray.sortarr(objsortarray.arrsort);
                            Console.WriteLine(Constant.strMsgArrasc);                            
                            objcommon.ShowArray(intarr);
                            break;
                        case "2.6":                                                     // Case 2.6 to call SearchArray.cs
                            objsearcharray = new SearchArray();                              //Initializing an object for class SearchArray
                            objsearcharray.search();
                            break;
                        case "2.7":                                                     // Case 2.7 to call ReviseArray.cs 
                            objrevisearray = new ReviseArray();                              //Initializing an object for class ReviseArray
                            objrevisearray.search();
                            break;
                        case "2.8":                                                     // Case 2.8 to call CoppyArray.cs 
                            objcopyarray = new CopyArray();                                  //Initializing an object for class CopyArray
                            //objcopyarray.getarray();
                            objcopyarray.cpyarr();                            
                            break;
                        case "2.9":                                                     // Case 2.9 to call Power.cs
                            objpower = new Power();                                          //Initializing an object for class Power
                            objpower.pwr();
                            break;
                        case "2.10":                                                    // Case 2.10 to call OpenNotepad.cs
                            objopennotepad = new OpenNotepad();                              //Initializing an object for class OpenNotepad
                            objopennotepad.open();
                            break;
                        case "2.11":                                                    // Case 2.11 to call SystemDetails.cs
                            objsys = new Systemdetail();                                    //Initializing an object for class Systemdetail 
                            objsys.getdetails();
                            break;
                        case "4.7":                                                         //To enter the customer and franchisee details                      
                            Console.WriteLine(Constant.strMsgCust);                         //Asking how many customer's detail user wants to enter
                            //arrlstmylist = new ArrayList();
                            int intcust = int.Parse(Console.ReadLine());
                            for (int i = 0; i < intcust; i++)
                            {
                                objcustomer = new Customer();                               //Initializing an object of class Customer
                                Console.WriteLine("Please enter the details for " + (i + 1) + " Customer:-");
                                objcommon.additem(objcustomer);
                                arrlstmylist.Add(objcustomer);                              
                            }
                            Console.WriteLine(Constant.strMsgFra);
                            intcust=int.Parse(Console.ReadLine());
                            for (int i = 0; i < intcust; i++)
                            {
                                objfranchisee = new Franchisee();                           //Initializing an object of class franchisee
                                Console.WriteLine("Please enter "+(i+1)+" fee details:-");
                                objcommon.addfees(objfranchisee);
                                arrlstmylist.Add(objfranchisee); 
                            }
                            break;
                        case "4.8":                                             //Case 4.8 if user wants to traverse the array list                 
                            for (int i = 0; i < arrlstmylist.Count; i++)
                            {
                                Console.WriteLine(arrlstmylist[i].ToString());
                            }                     
                            break;
                        case "4.9":                                             //Case 4.9 if user wants to enter customer and franchisee detail in typped list
                            //List<object> arrlstobj=new List<object>();
                            Console.WriteLine(Constant.strMsgCust);
                            intcust = int.Parse(Console.ReadLine());
                            for (int i = 0; i < intcust; i++)
                            {
                                objcustomer = new Customer();                   //Initializing the object of class Customer
                                Console.WriteLine("Please enter the details for " + (i + 1) + " Customer:-");
                                objcommon.additem(objcustomer);
                                arrlstobj.Add(objcustomer);
                            }
                            Console.WriteLine(Constant.strMsgFra);
                            intcust = int.Parse(Console.ReadLine());
                            for (int i = 0; i < intcust; i++)
                            {
                                objfranchisee = new Franchisee();               //Initializing the object of class Franchisee
                                Console.WriteLine("Please enter " + (i + 1) + " fee details:-");
                                objcommon.addfees(objfranchisee);               //Calling the function to add franchisee detail
                                arrlstobj.Add(objfranchisee);                   //Add franchisee details to an arraylist
                            }
                                break;
                        case "4.10":                                                    //Case 4.10 if user wants to traverse the typped array list
                             foreach (object obj in arrlstobj)
                             {
                               Console.WriteLine(obj.ToString());                       //Show the items of array list
                             }
                                break;
                        case "4.11":                                                    //Case 4.11 if user wants to sort an array by using bubble sort
                            objbubble = new Bubble();                                   //Initializing the object of class Bubble
                            objbubble.bubblesort();                                     //Calling the function bubble sort 
                                break;
                        case "4.12":                                                //Case 4.12 if user wants to transpose a 2-D array
                            objtransform = new Transform();                         // Initializing the object of class Transform
                            objtransform.transform();                               //Calling the function transform
                                break;
                        case "4.13":                                                //Case 4.13 if user wants to see integral part of a double
                            objrounding=new Rounding();                             //Initializing the object of class Rounding
                            objrounding.round();                                    //Calling the function round
                                break;
                        case "4.14":                                                //Case 4.14 if user want to convert an ammount into words
                            objshowwords = new ShowWords();                         //Initializing the object of class ShowWords
                            //string strnum;
                            string strWords;                            
                            Console.WriteLine(Constant.strEntrNum);                 //Display messege to enter a number
                            int intnum=int.Parse(Console.ReadLine());
                            //strnum = Console.ReadLine();                            //Getting number from user
                            //strWords = objshowwords.changeToWords(strnum);          //Call the function changeToWords
                            strWords=objshowwords.NumberToWords(intnum);              //Call the function Number to words
                            Console.WriteLine("You entered :- "+strWords);            //Display the result
                                break;
                        case "4.15":                                                    //Case 4.14 to validate the date
                           // objDateValidate = new DateValidate();                       //Initializing the object of class DateValidate
                            Console.WriteLine(Constant.strMsgHwDate);                   //Messege to enter the date          
                            intchoice = int.Parse(Console.ReadLine());                  //Enter the number of dates      
                            for (int j = 0; j < intchoice; j++)
                            {                                
                                Console.WriteLine("Please enter date " + (j + 1));
                                boolreturn=objDateValidate.valid();                             //call the function valid 
                                if (boolreturn == true)
                                {                                  
                                        arr[k] = objDateValidate;                               //store the date in an array if valid
                                        k++;                                 
                                }
                            }
                            break;
                        case "4.16":                                                            //Case 4.16 to sort the date                            
                            objsortdate = new Sortdate();                                       //Initializing the object of class Sortdate                                              
                            Console.WriteLine(Constant.strDatebyVal);                           //Display the messege for call by value
                            objsortdate.sortroutine(arr,k);                                     //Call function sortroutine call by value                                        
                            Console.WriteLine(Constant.strDatebyRef);                           //Display messege for call by reference
                            objsortdate.sortroutin(ref arr,k);                                  //Call function sortroutine by reference
                            break;
                        case "4.17":                                                            //Case 4.17 if user wants to create a text file and write five lines 
                            objtxtfile = new Txtfile();                                         //Initializing an object of class Txtfile
                            objtxtfile.file();                                                  //Calling the function file 
                            break;
                        case "4.18":                                                            //case 4.18 if user want to see the text file created above
                            objshowfile = new Showfile();                                       //Initializing the object of class Showfile
                            objshowfile.show();                                                 //Calling the function show 
                            break;
                        case "7.1":                                                             //Case 7.1 if user wants to                             
                            objDriver = new Driver();                                           //Initializing the object of class car
                            objDriver.Drive();                                                  //Call the function Drive
                            break;
                        case "7.2":
                            objCar = new Car();                                                 //Initialize the object of class car
                            objCar.ModelName = "Passenger Car";                                 //Set property of class  car
                            objCar.Drive();                                                     //Call the method drive
                            break;
                        case "7.3":
                            objCarMsg=new CarMsg();                                             //Initializing an object for class CarMsg
                            objCarMsg.ModelName = "Passenger Car";                              //Set property of class CarMsg
                            objCarMsg.Drive();                                                  //Call the method Drive from class CarMsg
                            break;
                        case "7.4":                                                             //Case 7.4 
                            objCarAllMsg = new CarAllMsg();                                     //Initializing an object for class CarMsg
                            objCarAllMsg.ModelName = "Passenger Car";
                            objCarAllMsg.Drive();                                               //Call the method Drive
                            break;
                        case "7.5":
                            objCarInterface=new CarInterface();                                 //Initializing the object of class CarInterface
                            objCarInterface.Drive();                                            //Call the method Drive 
                            break;
                        case "7.6":
                            objCarInterface2 = new CarInterface2();                             //Initializing an object of class CarInterface2
                            objArm=new ArmoredVehicle();
                            objCarInterface2.Destruct();                                        //Call the derrived method Destruct
                            objArm.Destruct();
                            break;
                        case "7.7":
                            objCarInterface2 = new CarInterface2();                             //Initializing the object of class CarInterface2
                            objArm = new ArmoredVehicle();                                      //Initializing the object of class ArmoredVehicle
                            arrlstVehicle=new ArrayList ();                                     //Initializing the arraylist 
                            Console.WriteLine(Constant.strCarObj);                              //Display messege to ask how many objects of car does user want to enter
                            int intMax_Car=int.Parse(Console.ReadLine());                       //Getting the maximum number of object of CarInterface as user want to enter
                            for (int i = 0; i < intMax_Car; i++)
                            {
                                arrlstVehicle.Add(objCarInterface2);                            //Add objects of CarInterface2 as much user wants to add
                            }
                            Console.WriteLine(Constant.strArmObj);                              //Display messege to ask how many objects of ArmoredVehicle does user want to enter  
                            int intMax_Arm = int.Parse(Console.ReadLine());                     //Getting the maximum number of object of ArmoredVehicle as user want to enter
                            for (int i = 0; i < intMax_Arm; i++)
                            {
                                arrlstVehicle.Add(objArm);                                      //Add objects of Armored as much user wants to add
                            }
                            foreach (object objA in arrlstVehicle)
                            {
                                if (objA == objCarInterface2)                                   //Check if object is of carinterface2 type
                                {                                   
                                    objCarInterface2.Destruct();                                //Call function Destruct
                                }
                                else if(objA==objArm)                                           //Check if object is of class ArmoredVehicle type
                                {
                                    objArm.Destruct();                                          //Call destruct method
                                }
                            }
                                break;
                       
                        case "7.8":
                                objCarInterface2 = new CarInterface2();                             //Initializing the object of class CarInterface2
                                objArm = new ArmoredVehicle();                                      //Initializing the object of class ArmoredVehicle
                                arrlstVehicle = new ArrayList();                                     //Initializing the arraylist 
                                Console.WriteLine(Constant.strCarObj);                              //Display messege to ask how many objects of car does user want to enter
                                intMax_Car = int.Parse(Console.ReadLine());                       //Getting the maximum number of object of CarInterface as user want to enter
                                for (int i = 0; i < intMax_Car; i++)
                                {
                                    arrlstVehicle.Add(objCarInterface2);                            //Add objects of CarInterface2 as much user wants to add
                                }
                                Console.WriteLine(Constant.strArmObj);                              //Display messege to ask how many objects of ArmoredVehicle does user want to enter  
                                intMax_Arm = int.Parse(Console.ReadLine());                     //Getting the maximum number of object of ArmoredVehicle as user want to enter
                                for (int i = 0; i < intMax_Arm; i++)
                                {
                                    arrlstVehicle.Add(objArm);                                      //Add objects of Armored as much user wants to add
                                }
                                foreach (object objA in arrlstVehicle)
                                {
                                    if (objA == objCarInterface2)                                   //Check if object is of carinterface2 type
                                    {
                                        objCarInterface2.Destruct();                                //Call function Destruct
                                    }
                                    else if (objA == objArm)                                           //Check if object is of class ArmoredVehicle type
                                    {
                                        objArm.Destruct();                                          //Call destruct method
                                    }
                                }
                                break;
                        case "7.9":
                                //Initializing the object of class CarInterface2
                                lstCar = new List<object>();                                          //Initializing the array list of object type
                                Console.WriteLine(Constant.strCarObj);                              //Display messege to ask how many objects of car does user want to enter
                                intMax_Car = int.Parse(Console.ReadLine());                           //Getting the maximum number of object of CarInterface as user want to enter
                                //string strModel;
                                for (int i = 0; i < intMax_Car; i++)
                                {
                                    objCarInterface2 = new CarInterface2();                         //Initialize the object of class CarInterface 2
                                    Console.WriteLine(Constant.strEntrModel);                       //Display to enter the model name
                                    objCarInterface2.ModelName = Console.ReadLine();                //Taking the model name by user
                                    lstCar.Add(objCarInterface2);                                   //Add object of CarInterface into arraylist
                                    //objCarInterface2 = null;
                                }
                                foreach (object obj in lstCar)
                                {
                                    objCarInterface2 = new CarInterface2();                         //Initialize the object of class CarInterface2
                                    Console.WriteLine(obj.ToString());                              //Display the model name entered by user
                                    objCarInterface2.Destruct();                                    //Call the method Destruct
                                }
                                break;
                        case "7.10":
                            string strCar_Model;                                                    
                            lstCar = new List<object>();
                            Console.WriteLine(Constant.strCarObj);                                //Display messege to ask how many objects of car does user want to enter
                            intMax_Car = int.Parse(Console.ReadLine());                           //Getting the maximum number of object of CarInterface as user want to enter
                            for (int i = 0; i < intMax_Car; i++)
                            {
                                Console.WriteLine(Constant.strEntrModel);                           //Display messege to enter model name of car
                                strCar_Model=Console.ReadLine();                                    //Get model name from user
                                objCarInterface3 = new CarInterface3(strCar_Model);                 //Call the constructor of class CarInterface3
                                lstCar.Add(objCarInterface3);                                       //Add objects of class CarInterface3 to arraylist
                            }
                            foreach (object obj in lstCar)
                            {
                                //objCarInterface3 = new CarInterface3(strCar_Model);
                                Console.WriteLine(obj.ToString());                                  //Display the model name of car
                                //objCarInterface3.Destruct();
                            }
                            break;
                        case"7.12":
                            objArmored_Fuel = new Armored_Fuel(25);
                            objCar_FuelConsumption = new Car_FuelConsumption(25);
                            objArmored_Fuel.Drive();
                            objCar_FuelConsumption.Drive();
                            break;
                        case "7.13":
                            Console.WriteLine(Constant.strSizeHash);        //Display the messege to enter the size of hashtable
                            int intM_Hash = int.Parse(Console.ReadLine());  //Read the size of hashtable entered by the user
                            HashA = new Hashtable(intM_Hash);               //Initializing the hashtable
                            Console.WriteLine(Constant.strCarObj);          // "Enter How Many Objects of Car Class You Want To Add In Hash Table : - \n"
                            int intMax_Hash = int.Parse(Console.ReadLine());//Taking input from user
                            // Creating object of Hashtable 
                            objCar_IF1 = new Car_FuelConsumption();         //Initializing the object of class Car_FuelConsumption
                            for (int i = 0; i < intMax_Hash; i++)
                            {
                                HashA.Add(i, objCar_IF1);                   //Add object of class Car_FuelConsumption into hashtable
                            }
                            Console.WriteLine(Constant.strArmObj);          // "Enter How Manay Objects of Armored Vehicle Class You Want To Add In Hash Table : - \n";
                            int intMax_A = int.Parse(Console.ReadLine());   //Taking input from user
                            objArmor_I1 = new Armored_Fuel();               //Initializing the object of class Armored_Fuel
                            for (int i = 0; i < intMax_A; i++)
                            {
                                HashA.Add(intMax_Hash + 1, objArmor_I1);    //Add object of class Armored_Fuel into Hashtable
                                intMax_Hash++;
                            }
                            MySort = new SortedList(HashA);                  // Creating object of SortedList
                            Console.WriteLine("Sorted list:-");              // "Sorted List Items : - \n"
                            foreach (DictionaryEntry myEntry in HashA)
                            {
                                Console.WriteLine(myEntry.Value.ToString());    //Display the elements of sorted list
                            }                                      
                            break;
                        case "0":                                                              // Case 0 if user wants to exit the application
                            Console.WriteLine(Constant.strThanks);
                            Environment.Exit(0);
                            break;
                        default:                                                                //If user entered unrecognize choice
                            Console.WriteLine(Constant.strSorry);
                            break;
                    }
                    Console.WriteLine(Constant.strMsgCont);                         //To get the response does user want to continue this application
                    ch2 = char.Parse(Console.ReadLine());
                }
                while (ch2 == 'y' || ch2 == 'Y');
                if (ch2 == 'n' || ch2 == 'N')
                {
                    Console.WriteLine(Constant.strThanks);                                      //To print msg if user does not want to continue this application
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                objconstant = null;                                      //Destroying an object for class Constant
                objcommon = null;                                        //Destroying an object for class Common
                objvowel =null ;                                         //Destroying an object for class Vowel
                objswitchvowel =null;                                    //Destroying an object for class WwitchVowel
                objcasecheck =null;                                      //Destroying an object for class switch CaseCheck           
                objreverse =null;                                        //Destroying an object for class Reverse
                objsearcharray =null;                                    //Destroying an object for class SearchArray
                objrevisearray = null;                                   //Destroying an object for class ReviseArray
                objsortarray =null;                                      //Destroying an object for class SortArray
                objpower =null;                                          //Destroying an object for class Power
                objcopyarray =null;                                      //Destroying an object for class CopyArray
                objopennotepad = null;                                   //Destroying an object for class OpenNotepad   
                strch1 = null;                                           //Destroying the string named strch1
                arrlstmylist = null;                                     //Destroying arraylist named arrlistmylist
                objsys = null;                                           //Destroying an object for class SystemDetail
                objcustomer = null;                                      //Destroying an object for class Customer
                objfranchisee = null;                                    //Destroying an object for class Franchisee
                objbubble = null;                                        //Destroying an object for class Bubble
                objtransform = null;                                     //Destroying an object for class Transform
                objrounding = null;                                      //Destroying an object for class Rounding
               // objDateValidate = null;                                //Destroying an object for class DateValidate
                objsortdate = null;                                      //Destroying an object for class Sortdate
                objtxtfile = null;                                       //Destroying an object for class Txtfile
                objshowfile = null;                                      //Destroying an object for class Showfile
                objshowwords = null;                                     //Destroying an object for class ShowWords
                objCarInterface2=null;                                   //Destroying an object of class CarInterface2
                objArm=null;                                             //Destroying an object of class ArmoredVehicle
                objArmor_I1 = null;                                      //Destroying an object of class 
                objArmored_Fuel = null;                                  //Destroying an object of class Armored_Fuel
                lstCar = null;                                  
            }
        }
        #endregion main
    }
#endregion Program
}
