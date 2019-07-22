
namespace Vehicles
{
    #region IFuelConsumption
    //NAME          :- IFuelConsumption
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Interface which contain property
    //CREATED DATE  :- 20/07/2012
  public interface IFuelConsumption
    {
      int FuelEfficiency                           //declaration of property
        {
            get;
            set;
        }
      double Drive(double dblkilometresDriven);                //declare method
       
    }
#endregion IFuelConsumption
}
