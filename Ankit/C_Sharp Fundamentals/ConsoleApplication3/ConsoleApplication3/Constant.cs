namespace ConsoleApplication3
{
    #region Constant
    //Name                      : Constant
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To contain all the constant variables required in project   
    class Constant
    {        
            public const string strMenu="*************************     MENU     *************************";
            //DISPLAY THE FIRST ITEM OF MENU********************************************************************************************
            public const string strMenu1 ="2.1 :- To check whether entered character is Vowel  or not ";
            //DISPLAY THE SECOND ITEM OF MENU*******************************************************************************************
            public const string strMenu2 ="2.2 :- To check whether entered character is Vowel or not by switch case  ";
            //DISPLAY THE THIRD ITEM OF MENU********************************************************************************************
            public const string strMenu3 ="2.3 :- To check whether entered character is lower case upper case or digit";
            //DISPLAY THE FOURTH ITEM OF MENU*******************************************************************************************
            public const string strMenu4 ="2.4 :- To reverse an array";
            //DISPLAY THE FIFTH ITEM OF MENU********************************************************************************************
            public const string strMenu5 ="2.5 :- To sort array in ascending order";
            //DISPLAY THE SIXTH ITEM OF MENU********************************************************************************************
            public const string strMenu6 ="2.6 :- To search a number in array";
            //DISPLAY THE SEVENTH ITEM OF MENU******************************************************************************************
            public const string strMenu7 ="2.7 :- To search how many times a number exists in an array";
            //DISPLAY THE EIGHTTH ITEM OF MENU******************************************************************************************
            public const string strMenu8 ="2.8 :- To copy two array in a third array";
            //DISPLAY THE NINTH ITEM OF MENU********************************************************************************************
            public const string strMenu9 ="2.9 :- To find the value of n raise to the power m ";
            //DISPLAY THE TENTH ITEM OF MENU********************************************************************************************
            public const string strMenu10 ="2.10:- To open notepad";
            //DISPLAY THE ELEVENTH ITEM OF MENU*****************************************************************************************
            public const string strMenu11 ="2.11:- To print windows user name , directory and os name";
            //DISPLAY THE TWELEFTH ITEM OF MENU*****************************************************************************************
            public const string strMenu12 ="0   :- To exit";
            //DISPLAY THE MESSEGE TO ENTER CHOICE***************************************************************************************
            public const string strMenu13 = "Enter your choice:-";
            //DISPLAY MESSEGE IF ENTERED WRONG CHOICE***********************************************************************************
            public const string strSorry = "Sorry ! You must enter valid choice......";
            //DISPLAY MESSEGE TO THANKS*************************************************************************************************
            public const string strThanks ="Thanks to use this application";
            //DISPLAY MESSEGE TO ENTER A CHARACTER**************************************************************************************
            public const string strEnterVowel = "Please enter the character:-";
            //DISPLAY MESSEGE TO SHOW THAT THE CHARACTER IS VOWEL***********************************************************************
            public const string strVowel = "Character is Vowel";
            //DISPLAY MESSEGE TO SHOW THAT THE CHARACTER IS CONSONENT*******************************************************************
            public const string strConsonent = "Character is Consonent";
            //DISPLAY MESSEGE IF USER DID NOT ENTER A LETTER****************************************************************************
            public const string strSorryVowel = "Sorry ! You must have enter a letter";
            //DISPLAY MESSEGE TO ENTER THE SIZE OF AN ARRAY*****************************************************************************
            public const string strSizeArray = "Please enter the size of array:-";
            //DISPLAY MESSEGE TO ENTER NUMBERS IN AN ARRAY WHERE SIZE OF ARRAY IS 5*****************************************************          
            public const string strInputArrayInt5 = "Please enter 5 numbers to enter into array:-";
            //DISPLAY MESSEGE TO ENTER A STRING*****************************************************************************************
            public const string strInputStr = "Please enter the string:-";
            //DISPLAY MESSEGE TO SHOW AN ARRAY******************************************************************************************
            public const string strMsgArray = "Your Array is :-";
            //DISPLAY MEESEGE TO ENTER AN ARRAY ****************************************************************************************
            public const string strMsgEnterArr = "please enter the numbers to enter to the array:-";
            //DISPLAY MESSEGE TO SHOW THE RESULTED ARRAY********************************************************************************
            public const string strMsgFinalArray = "Your final array is:-";
            //DISPLAY MESSEGE TO SHOW THE REVERSE OF ARRAY******************************************************************************
            public const string strMsgArrrev = "Reverse of array is :-";
            //DISPLAYING MEESEGE TO SHOW ARRAY IN ASCENDING ORDER***********************************************************************
            public const string strMsgArrasc = "Your array in ascending order is:-";
            //DISPLAY MESSEGE TO ENTER A NUMBER WHICH USER WANTS TO SEARCH IN AN ARRAY**************************************************
            public const string strSearch = "Please enter the number you want to search in:-";
            //DISPLAY MESSEGE IF NUMBER IS NOT EXISTS IN ARRAY**************************************************************************
            public const string strNotSearch="The number you entered is not exist in array";
            //DISPLAY MESSEGE IF NUMBER IS EXISTS IN ARRAY******************************************************************************
            public const string strYesSearch = "The number you entered is exist in array";
            //DISPLAY MESSEGE IF USER ENTERS MORE THAN 5 VALUES*************************************************************************
            public const string strNotSize = "Sorry !You can not enter more than 5 numbers ...";
            //DISPLAY MESSEGE TO ENTER THE BASE NUMBER TO CALCULATE THE POWER***********************************************************
            public const string strEntrBse = "Please enter the base:-";
            //DISPLAY MESSEGE TO ENTER THE EXPONENT TO CALCULATIN THE POWER*************************************************************
            public const string strEntrExp = "Please enter the  exponent:-";
            //DISPLAY MESSEGE IF USER ENTERED MORE THAN ONE CHARACTER ******************************************************************
            public const string strMsgSrr = "You can not enter more than one character";
            //DISPLAY THE FOURTEENTH ITEM OF MENU ************************************************************************************** 
            public const string strMenu14 = "4.7 :- To enter the customer detail and franchisee detail";
            //DISPLAY THE FIFTEENTH ITEM OF MENU  **************************************************************************************
            public const string strMenu15 = "4.8 :- To traverse the arraylist of customer details";
            //DISPLAY THE SIXTEENTH ITEM OF MENU ***************************************************************************************
            public const string strMenu16 = "4.9 :- To enter the customer details and franhisee details by typped  list";
            //DISPLAY THE SEVENTEENTH ITEM OF MENU *************************************************************************************
            public const string strMenu17 = "4.10:- To traverse the typed arraylist";
            //DISPLAY THE MENU ITEM BUBBLE SORT ****************************************************************************************
            public const string strMenu18 = "4.11:- Bubble sort";
            //DISPLAY THE MESSEGE HOW MANY CUSTOMER'S DETAIL DOES USER WANT TO ENTER ***************************************************
            public const string strMsgCust = "How many customer details do you want to enter:-";
            //DISPLAY THE MESSEGE HOW MANY FRANCHISEE DETAIL DOES USER WANT TO ENTER ***************************************************
            public const string strMsgFra = "How many fee details do you want to enter :- ";
            //DISPLAY MESSEGE TO ASK TO ENTER SALUTATION********************************************************************************
            public const string strmsgshowarr1 = "Please Enter Salutation:-";
            //DISPLAY MESSEGE TO ASK TO ENTER NAME**************************************************************************************
            public const string strmsgshowarr2 = "Please Enter Name:-";
            //DISPLAY MESSEGE TO ASK TO ENTER MARIYIAL STATUS***************************************************************************
            public const string strmsgshowarr3 = "Please Enter Maritial status:-";
            //DISPLAY MESSEGE TO ASK TO ENTER GENDER************************************************************************************
            public const string strmsgshowarr4 = "Please Enter Gender:-";
            //DISPLAY MESSEGE TO ASK TO ENTER ADDRESS***********************************************************************************
            public const string strmsgshowarr5 = "Please Enter Address:-";
            //DISPLAY MESSEGE TO ASK TO ENTER QUALIFICATION*****************************************************************************
            public const string strmsgshowarr6 = "Please Enter Qualification:-";
            //DISPLAY MESSEGE TO ASK TO ENTER lANGUAGE**********************************************************************************
            public const string strmsgshowarr7 = "Please Enter Language:-";
            //DISPLAY MESSEGE IF USER ENTERED INVALID DATE ***************************************************************************** 
            public const string strMsgNotDate = "Date is not valid...";
            //DISPLAY MESSEGE IF USER ENTERED VALID DATE *******************************************************************************
            public const string strMsgValidDate = "Date is Valid...";
            //DISPLAY THE MEESEGE TO ENTER THE DAY *************************************************************************************
            public const string strMsgEntrday = "Please enter the day :-";
            //DISPLAY THE MEESEGE TO ENTER THE MONTH ***********************************************************************************
            public const string strMsgEntrMnth = "Please enter the month :-";
            //DISPLAY THE MEESEGE TO ENTER THE YEAR ************************************************************************************
            public const string strMsgEntrYear = "Please enter the year :-";
            //DISPLAY THE MESSEGE TO ASK HOW MANY DATES DOES USER WANT TO ENTER ******************************************************** 
            public const string strMsgHwDate = "How many dates do you want to enter:-";  
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu19="4.12:- To transform an array";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu20 = "4.13:- To Display the intigral part of a double";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu21 = "4.14:- To display a number into words";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu22 = "4.15:- To Validate the DATE";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu23 = "4.16:- To sort the Date  ";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu24 = "4.17:- To Create a text file";
            //DISPLAY THE ITEM OF MENU**************************************************************************************************
            public const string strMenu25 = "4.18:- To Read the text file";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu26 = "7.1 :- To check namespace";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu27 = "7.2 :- Car";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu28 = "7.3 :- CarMsg";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu29 = "7.4 :- CarAllMsg";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu30 = "7.5 :- CarInterface";
            //DISPLAY THE ITEM OF MENU *************************************************************************************************
            public const string strMenu31 = "7.6 :- Destruct";
            //DISPLAY THE ITEM OF THE MENU *********************************************************************************************
            public const string strMenu32 = "7.7 :- Add objects of Car and ArmoredVehicle into an arraylist";
            //DISPLAY THE ITEM OF THE MENU *********************************************************************************************
            public const string strMenu33 = "7.8 :- Throw exception can not be destroyed";
            //DISPLAY THE ITEM OF THE MENU *********************************************************************************************
            public const string strMenu34 = "7.9 :- Typed arraylist for object of car";
            //DISPLAY THE ITEM OF THE MENU *********************************************************************************************
            public const string strMenu35 = "7.10:- Parametrized constructor";
            public const string strMenu36 = "7.12:-Fuel";
            public const string strMenu37 = "7.13:-Hash table";
            //DISPLAY THE MESSEGE TO SHOW THE SORTED DATES******************************************************************************
            public const string strMsgSortDate = "Sorted dates are :-";
            //DISPLAY THE MESSEGE TO ENTER A FLOAT *************************************************************************************
            public const string strMsgEntrFlt = "Please enter a float :-";
            //DISPLAY THE MESSEGE TO SHOW INTEGER PART BY USING CASTING ****************************************************************
            public const string strMsgCast = "Integer part by using casting:-";
            //DISPLAY THE MESSEGE TO SHOW INTEGER PART BY USING ROUNDING****************************************************************
            public const string strMsgRound = "Integer part by using rounding:-";
            //DISPLAY THE MESSEGE TO SHOW INTEGER PART BY USING MANNUALY****************************************************************
            public const string strMsgMan = "Integer part by using mannualy:-";
            //DISPLAY MESSEGE TO ENTER THE NUMBER **************************************************************************************
            public const string strEntrNum = "Please enter the number:-";
            //DISPLAY MESSEGE TO ASK IF USER WANT TO CONTINUE***************************************************************************
            public const string strMsgCont = "Do you want to continue(y/n):-";
            //DISPLAY MESSEGE TO SHOW SORTED DATE BY VALUE *****************************************************************************
            public const string strDatebyVal = "Sorted date call by value:-";
            //DISPLAY MESSEGE TO SHOW SORTED DATE BY REFERENCE**************************************************************************
            public const string strDatebyRef = "Sorted date call by Reference:-";
            //DISPLAY MESSEGE TO DISPLAY THE MATRIX ENTERED BY USER ********************************************************************
            public const string strMsgMat = "The Matrix you entered is :-";
            //DISPLAY MESSEGE TO DISPLAY THE MATRIX ENTERED BY USER ********************************************************************
            public const string strMsgTra = "Transpose of Matrix is :-";
            //DISPLAY MESSEGE TO ASK HOW MANY LINES DOES USER WANT TO ENTER*************************************************************
            public const string strMsgLine = "How many lines do you want to enter :-";
            //DISPLAY MESSEGE VEHICLE IN MOTION ****************************************************************************************
            public const string strVehicle = "Vehicle in motion";
            //DISPLAY MESSEGE CAR IS IN MOTION *****************************************************************************************
            public const string strCar = "Car is in motion";
            //DISPLAY MESSEGE CAR DESTRUCTED *******************************************************************************************
            public const string strDes = "Car Destructed";
            //DISPLAY MESSEGE VEHICLE CAN NOT BE DESTROYED******************************************************************************
            public const string strNotDes = "Vehicle can not be destroyed";
            //DISPLAY MESSEGE TO ASK HOW MANY OBJECTS OF CAR DOES USER WANT TO ENTER ***************************************************
            public const string strCarObj = "How many objects of Car do you want to enter :-";
            //DISPLAY MESSEGE TO ASK HOW MANY OBJECTS OF CAR DOES USER WANT TO ENTER ***************************************************
            public const string strArmObj = "How many objects of ArmoredVehicle do you want to enter :-";
            //DISPLAY MESSEGE TO ENTER THE MODEL NAME **********************************************************************************
            public const string strEntrModel = "Please enter model name:-";
            //DISPLAY A MESSEGE TO ENTER THE SIZE OF HASHTABLE *************************************************************************
            public const string strSizeHash = "Please Enter Size Of Hashtable : - ";
            //DISPLAY THE MESSEGE TO ENTER THE KM **************************************************************************************
            public const string strEntrKm = " Plese Enter Value of Kilometres Driven:-";
            //DISPLAY THE AMMOUNT OF FUEL LEFT *****************************************************************************************
            public const string strLftFuel = "Amount of fuel left in Armored Vehicle = ";
    }
    #endregion Constant
}
