//NAME          :- Vehicles
//AUTHOR        :- SHIKHA MALIK
//DESCRIPTION   :- Namespace which contain classes
//CREATED DATE  :- 19/07/2012

namespace Vehicles
{
    #region Car3
    //NAME          :- Car3
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Class that contain Drive method
    //CREATED DATE  :- 19/07/2012
    class Car3 : Car                                                //inherit Car class
    {
        public new void Drive()
        {
            //Car objCar = new Car();
            //objCar.Drive();
            base.Drive();                                           //call method of base class
        }
    }
    #endregion Car3
}
