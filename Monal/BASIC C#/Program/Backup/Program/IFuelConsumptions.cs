#region IFuelConsumption
/// <summary>
/// Name:IFuelConsumption
/// Description:Create an interface IFuelConsumption with a numeric property FuelEfficiency and a method Drive.
///             The method Drive should take a numeric value as the number of kilometres driven.
///             Implement this interface on the Car and ArmoredVehicle classes.
///             Modify the interface IVehicle and add a numeric property InitialFuel. 
/// Author:Monal Shah
/// Created date:2010/09/15
/// </summary>

interface IFuelConsumption
{
    #region FuelEfficiency
    /// <summary>
    /// Name:FuelEfficiency
    /// Description:numeric property FuelEfficiency
    ///Author:Monal Shah
    /// Created date:2010/09/15
    /// </summary>
    int FuelEfficiency
    {
        get;
        set;
    }
    #endregion
    #region Drive
    /// <summary>
    /// Name:Drive
    /// Description:Create method Drive.
    ///Author:Monal Shah
    /// Created date:2010/09/15
    /// </summary>
    /// <param name="fltNumInKM"></param>
    void Drive(float fltNumInKM);
    #endregion
}
#endregion


