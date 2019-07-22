using System;
using System.Collections.Generic;
using System.Collections;
using Vehicles;
using Users;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    class Program
    {       
        /// <summary>
        /// Class Name:Program
        /// Description:Class which containts Main Method.
        /// Author:
        /// Created On:18/5/2015
        /// </summary>
        ///
        #region Main method Class

        static void Main(string[] args)
        {
            List<object> arrylist;
            List<object> objarrylist;
            ArrayList arraylist_objects;
            arrylist = new List<object>();
            objarrylist = new List<object>();
            arraylist_objects = new ArrayList();
            try
            {
                #region Define objects
                //object creation
                ConstantMessage objconst;
                Program objprogram;
                Vowel objvowel;
                SwichVowel objswitchvowel;
                CaseCheck objcscheck;
                Reverse objreverse;
                Sort objsort;
                SearchArray search_arra;
                ReviseArray revise_arra;
                CopyArray objcopyarr;
                Power objpower;
                NotepadFile objfile;
                WindowDetails objwindetails;
                Customer objcustomer;
                Entity objentity;
                Franchisee objfranch;
                Bubble_Sort objbubblesort;
                Array_Transformation objarrtransform;
                DoubleToInt objdbint;
                Structure objstrct;
                Structure_Datesort objstructdatesort;
                objstructdatesort = new Structure_Datesort();                     
                FileWrite objfilewrite;
                FileRead_Exception objfileread;
                objconst = new ConstantMessage();
                StringBuilder_Str objstringbuilder;
                child objchild;
                Driver objdriver;
                Vehicle objvehicle;
                Car objcar;
                //Arraylist_objects objarylistobj;
                ArmoredVehicle objarmoredvehicle;
                IVehicle objinterfaceIvehicle;
                vehicle objinterfacevehicle;
                Car7_10 objcar7_10;
                IFuelConsumption objfuelinterfaceCar;
                IFuelConsumption objfuelinterfacearmored;
                Fuel7_11 objfuel;
                Hashtable_Sortedlist objhash;
                #endregion
                while (true)
                {
                    //object 
                    #region Objects Initialization
                    objprogram = new Program();
                    objvowel = new Vowel();
                    objswitchvowel = new SwichVowel();
                    objcscheck = new CaseCheck();
                    objreverse = new Reverse();
                    objsort = new Sort();
                    search_arra = new SearchArray();
                    revise_arra = new ReviseArray();
                    objcopyarr = new CopyArray();
                    objpower = new Power();
                    objfile = new NotepadFile();
                    objwindetails = new WindowDetails();
                    objcustomer = new Customer();
                    objentity = new Entity();
                    objfranch = new Franchisee();
                    objbubblesort = new Bubble_Sort();
                    objarrtransform = new Array_Transformation();
                    objdbint = new DoubleToInt();
                    objstrct = new Structure();
                    objfilewrite = new FileWrite();
                    objfileread = new FileRead_Exception();
                    objstringbuilder=new StringBuilder_Str();
                    objchild = new child();
                    objdriver = new Driver();
                    objvehicle = new Vehicle();
                    objcar = new Car();
                    objinterfaceIvehicle = new Car();
                    objinterfacevehicle = new ArmoredVehicle();
                    objarmoredvehicle = new ArmoredVehicle();
                    objfuelinterfaceCar = new Car();
                    objfuelinterfacearmored = new ArmoredVehicle();
                    objfuel = new Fuel7_11();
                    objhash = new Hashtable_Sortedlist();
                    #endregion
                    //objarylistobj = new Arraylist_objects();
                    //Get the input from user AS Day.Exercise No.
                    string a;
                    Console.WriteLine(objconst.strExer);
                    a = Console.ReadLine();
                    //Display the No. of Day
                    string dy = a.Substring(0, 1);
                    Console.WriteLine("Day=" + dy);
                    int intDy = Convert.ToInt32(dy);

                    //Display the No. of Exercise
                    string ex = a.Substring(2);
                    Console.WriteLine("Exercise No.=" + ex);
                    int intEx = Convert.ToInt32(ex);
                    if (intDy > 9 || intDy < 0)
                    {
                        Console.WriteLine(objconst.strday);
                    }
                    else if (intEx > 18)
                    {
                        Console.WriteLine(objconst.strExercise);
                    }
                    else
                    {
                        Console.WriteLine("Code for " + intDy + "." + intEx);
                        Console.WriteLine("*************************************************");
                        //code for Day1 
                        if (intDy == 1)
                        {
                            Console.WriteLine(objconst.ShowMessage1);
                            objprogram.Exit();
                        }                        
                        else
                        {
                            switch (a)
                            {
                                case "2.1":
                                case "3.1":
                                    objvowel.FindVowel();
                                    objprogram.Exit();
                                    break;
                                case "2.2":
                                case "3.2":
                                    objswitchvowel.FindSwitchVowel();
                                    objprogram.Exit();
                                    break;
                                case "2.3":
                                case "3.3":
                                    objcscheck.CountChar();
                                    objprogram.Exit();
                                    break;
                                case "2.4":
                                case "3.4":
                                    objreverse.ArrayReverse();
                                    objprogram.Exit();
                                    break;
                                case "2.5":
                                case "3.5":
                                    objsort.ArraySort();
                                    objprogram.Exit();
                                    break;
                                case "2.6":
                                case "3.6":
                                    search_arra.SearchFunction();
                                    objprogram.Exit();
                                    break;
                                case "2.7":
                                case "3.7":
                                    revise_arra.CountFunction();
                                    objprogram.Exit();
                                    break;
                                case "2.8":
                                case "3.8":
                                    objcopyarr.ThreeArray();
                                    objprogram.Exit();
                                    break;
                                case "2.9":
                                case "3.9":
                                    objpower.FindPowerNum();
                                    objprogram.Exit();
                                    break;
                                case "2.10":
                                case "3.10":
                                    objfile.OpenFile();
                                    objprogram.Exit();
                                    break;
                                case "2.11":
                                case "3.11":
                                    objwindetails.GetDetails();
                                    objprogram.Exit();
                                    break;                                                                                                                       
                                case "4.1":
                                case "5.1":
                                case "6.1":                                    
                                case "4.2":
                                case "5.2":
                                case "6.2":
                                    Console.WriteLine(objconst.strCustomerMethod);
                                    objcustomer.Load();
                                    objcustomer.Save();
                                    objcustomer.Validate();
                                    objprogram.Exit();
                                    break;
                                case "4.3":
                                case "5.3":
                                case "6.3":
                                    Console.WriteLine(objconst.strEntityProp);
                                    Console.WriteLine(objentity);
                                    objprogram.Exit();                                    
                                    break;
                                case "4.4":
                                case "5.4":
                                case "6.4":
                                    Console.WriteLine(objconst.strchildclass);
                                    objprogram.Exit();                                                                        
                                    break;
                                case "4.5":
                                case "5.5":
                                case "6.5":
                                case "4.6":
                                case "5.6":
                                case "6.6":
                                    objfranch.GetFees();
                                    Console.WriteLine(objfranch);
                                    objprogram.Exit();
                                    break;
                                case "4.7":
                                case "5.7":
                                case "6.7":
                                case "4.8":
                                case "5.8":
                                case "6.8":
                                    Console.WriteLine(objconst.strcustomernum);
                                    int num_customer1 = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < num_customer1; i++)
                                    {
                                        Console.WriteLine(objconst.strcustomerno);
                                        objentity.Property_Method_Entity();
                                        arraylist_objects.Add(objentity);
                                    }
                                        Console.WriteLine(objconst.strfranchcount);
                                        int num_franch1 = Convert.ToInt32(Console.ReadLine());
                                        for (int i = 0; i < num_franch1; i++)
                                        {
                                            objfranch.GetFees();
                                            arraylist_objects.Add(objfranch);                                            
                                        }
                                        foreach (object obj in arraylist_objects)
                                        {
                                            Console.WriteLine(obj);
                                        }                                        
                                    objprogram.Exit();
                                    break;
                                case "4.9":
                                case "5.9":
                                case "6.9":
                                    Console.WriteLine(objconst.strcustomernum);
                                    int num_customer = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < num_customer; i++)
                                    {
                                        Console.WriteLine(objconst.strcustomerno);
                                        objcustomer.Property_Method();
                                        arrylist.Add(objcustomer);
                                    }
                                        Console.WriteLine(objconst.strfranchcount);
                                        int num_franch = Convert.ToInt32(Console.ReadLine());
                                        for (int i = 0; i < num_franch; i++)
                                        {
                                            objfranch.GetFees();
                                            arrylist.Add(objfranch);                                            
                                        }                                                                            
                                    objprogram.Exit();                                    
                                    break;
                                case "4.10":
                                case "5.10":
                                case "6.10":
                                    foreach (object obj in arrylist)
                                    {
                                        Console.WriteLine(obj);
                                    }
                                    objprogram.Exit();
                                    break;
                                case "4.11":
                                case "5.11":
                                case "6.11":
                                    objbubblesort.BubbleSort();
                                    objprogram.Exit();
                                    break;
                                case "4.12":
                                case "5.12":
                                case "6.12":
                                    objarrtransform.Trasform();
                                    objprogram.Exit();
                                    break;
                                case "4.13":
                                case "5.13":
                                case "6.13":
                                    objdbint.DataTypeConv();
                                    objprogram.Exit();
                                    break;
                                case "4.14":
                                case "5.14":
                                case "6.14":
                                    Console.WriteLine(objconst.strstringbuilder);
                                    Console.WriteLine(objconst.strintnum);            
                                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(objstringbuilder.NumbersToWords(inputNumber));
                                    objprogram.Exit();                                    
                                    break;
                                case "4.15":
                                case "5.15":
                                case "6.15":
                                    Console.WriteLine(objconst.strdatecount);
                                    int datecount = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < datecount; i++)
                                    {
                                        objstrct.GetDate();                                        
                                    }                                        
                                    objprogram.Exit();
                                    break;
                                case "4.16":
                                case "5.16":
                                case "6.16":
                                    Console.WriteLine(objconst.strdatecount);
                                    int datecount_sort = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < datecount_sort; i++)
                                    {
                                        objstructdatesort.Getdate_Struct();
                                     }
                                    Console.WriteLine(objconst.stractualdate);
                                    objstructdatesort.Print();
                                    objprogram.Exit();
                                    break;
                                case "4.17":
                                case "5.17":
                                case "6.17":
                                    objfilewrite.WriteToFile();
                                    objprogram.Exit();
                                    break;
                                case "4.18":
                                case "5.18":
                                case "6.18":
                                    objfileread.FileReadException();
                                    objprogram.Exit();
                                    break;
                                    //day 7,8 & 9
                                case "7.1":
                                case "8.1":
                                case "9.1":
                                    objdriver.Drive();
                                    objprogram.Exit();
                                    break;
                                case "7.2":
                                case "8.2":
                                case "9.2":
                                    objchild.GetCarClass();
                                    objprogram.Exit();
                                    break;
                                case "7.3":
                                case "8.3":
                                case "9.3":
                                    objcar.Drive72();
                                    objprogram.Exit();
                                    break;
                                case "7.4":
                                case "8.4":
                                case "9.4":
                                    objvehicle.Drive();//method of Vehicle class which contains in Vehicles namespace            
                                    objcar.Drive72();
                                    objprogram.Exit();
                                    break;
                                case "7.5":
                                case "8.5":
                                case "9.5":                                    
                                case "7.6":
                                case "8.6":
                                case "9.6":
                                    objinterfaceIvehicle.Destruct();
                                    objinterfacevehicle.Destruct();
                                    objprogram.Exit();
                                    break;
                                case "7.7":
                                case "8.7":
                                case "9.7":
                                    Console.WriteLine(objconst.strcountcarobj);
                                    int countcar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(objconst.strcountarmoredobj);
                                    int countarmored = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < countcar; i++)
                                    {
                                        objinterfaceIvehicle.Destruct();
                                        arrylist.Add(objinterfaceIvehicle);                                                                        
                                    }
                                    for (int i = 0; i < countarmored; i++)
                                    {
                                        objinterfacevehicle.Destruct();
                                        arrylist.Add(objinterfacevehicle);
                                    }
                                    foreach (object s in arrylist)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    objprogram.Exit();
                                    break;
                                case "7.8":
                                case "8.8":
                                case "9.8":
                                    ArrayList arrylist1 = new ArrayList();
                                    objinterfacevehicle.Destruct();
                                    arrylist1.Add(objinterfacevehicle);
                                    foreach (object s in arrylist1)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    objprogram.Exit();
                                    break;
                                case "7.9":
                                case "8.9":
                                case "9.9":
                                    Console.WriteLine(objconst.strcountcarobj);
                                    int countcarobj = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < countcarobj; i++)
                                    {
                                        arrylist = new List<object>();
                                        objinterfaceIvehicle.Destruct();                                        
                                    }
                                    for (int i = 0; i < countcarobj; i++)
                                    {
                                        string strmodelname = objcar.ModelName;                                        
                                        arrylist.Add(strmodelname);
                                    }
                                        foreach (object s in arrylist)
                                        {
                                            Console.WriteLine(s);
                                        }
                                    objprogram.Exit();
                                    break;
                                case "7.10":
                                case "8.10":
                                case "9.10":
                                    Console.WriteLine(objconst.strcountcarobj);
                                    int countcar7_10obj = Convert.ToInt32(Console.ReadLine());
                                    string strcarmodelnm;
                                    arrylist = new List<object>();                                                                                
                                    for (int i = 0; i < countcar7_10obj; i++)
                                    {
                                        Console.WriteLine(objconst.strmodelnm);
                                        strcarmodelnm = Console.ReadLine();
                                        objcar7_10=new Car7_10(strcarmodelnm);
                                        string s1 = objcar7_10.ModelName;
                                        arrylist.Add(s1);                                    
                                    }
                                    Console.WriteLine("******************");
                                    foreach (object s in arrylist)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    objprogram.Exit();
                                    break;                                
                                case "7.11":
                                case "8.11":
                                case "9.11":                                                                        
                                case "7.12":
                                case "8.12":
                                case "9.12":
                                    int kmcar, initfuelcar, effcar;//variasbles for car
                                    int kmarmored,effarmored,initfuelarmored;//variables for armored vehicle
                                    //For Car
                                    Console.WriteLine(objconst.strinitialfuelcar);
                                    initfuelcar = Convert.ToInt32(Console.ReadLine());
                                    objcar = new Car(initfuelcar);
                                    Console.WriteLine(objconst.strincar+ initfuelcar);
                                    kmcar = objfuelinterfaceCar.Drive7_11();
                                    //For Armored Vehicle
                                    Console.WriteLine(objconst.strinitialfuelarmored);
                                    initfuelarmored = Convert.ToInt32(Console.ReadLine());
                                    objarmoredvehicle = new ArmoredVehicle(initfuelarmored);
                                    Console.WriteLine(objconst.strinArm+objarmoredvehicle.InitialFuel);
                                    kmarmored = objfuelinterfacearmored.Drive7_11();
                                    //Fuel Efficiency for car
                                    Console.WriteLine(objconst.strfueleffcar);
                                    effcar = Convert.ToInt32(Console.ReadLine());
                                    objcar.FuelEfficiency = effcar;
                                    Console.WriteLine( objconst.streffcar+ objcar.FuelEfficiency);
                                    //Fuel efficiency for armored
                                    Console.WriteLine(objconst.strfueleffarmored);
                                    effarmored = Convert.ToInt32(Console.ReadLine());
                                    objarmoredvehicle.FuelEfficiency = effarmored;
                                    Console.WriteLine(objconst.streffArm + objarmoredvehicle.FuelEfficiency);
                                    int leftfuel_car = ((kmcar * initfuelcar) - (effcar));
                                    if (leftfuel_car <= 0)
                                    {
                                        objfuel.NoFuelExe();
                                    }
                                    else
                                    {
                                        Console.WriteLine(objconst.strleftcar + leftfuel_car);
                                    }
                                    int leftfuel_armored = ((kmarmored * initfuelarmored) - (effarmored));
                                    if (leftfuel_armored <= 0)
                                    {
                                        objfuel.NoFuelExe();
                                    }
                                    else
                                    {
                                        Console.WriteLine(objconst.strleftArm + leftfuel_armored);
                                    }
                                    objprogram.Exit();
                                    break;
                                case "7.13":
                                case "8.13":
                                case "9.13":
                                    objhash.GetobjectHashTable();
                                    objprogram.Exit();
                                    break;
                                default:
                                    Console.WriteLine(objconst.ShowMessage1);
                                    objprogram.Exit();
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Program objpr = new Program();
                objpr.Exit();
            }        
        }                              
        ///<summary>
        ///Method Name:Exit
        /// Description://User want to terminate console application
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void Exit()
        {
            ConstantMessage objconst = new ConstantMessage();//object creation                                                            
            Console.WriteLine(objconst.strContinue);
            string end = Console.ReadLine();
            if (end == "Y" || end == "y")
            {
            }
            else
            {
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
