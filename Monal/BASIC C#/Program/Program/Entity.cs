using System;

namespace Program
{
     /*-------------------------------------------------------------------------------------------------------------------
   Name:Entity.cs
   Author:Monal Shah
   Description: 4.3:"Create base class Entity with properties:
                        Name, MaritalStatus, Gender, Address"

   CreatedDate: 2010/09/09 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
    */
    class Entity
    {
        public string _strName,_strMaritalstatus,_strGender,_strAddress;//strName, strMaritalstatus, strGender, strAddress are variable of string datatype

        public string Name
        {
            get { return _strName; }
            set { _strName = value; }
        }
        public string Maritalstatus
        {
            get { return _strMaritalstatus; }
            set { _strMaritalstatus = value; }
        }
        public string Gender
        {
            get { return _strGender; }
            set { _strGender = value; }
        }
        public string Address
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }
        /*-------------------------------------------------------------------------------------------------------------------
           Name:Entity(Constructor is created)
           Parameter:string
           Author:Monal Shah
           Description: 4.3:"Properties get the value"
            CreatedDate: 2010/09/09 by Monal Shah
       -------------------------------------------------------------------------------------------------------------------
        */
        //public Entity(string strNme, string strMaritalstus, string strGendr, string strAdres)
        //{
        //    _strName = strNme;
        //    _strMaritalstatus = strMaritalstus;
        //    _strGender = strGendr;
        //    _strAddress = strAdres;
        //}
    }
}
