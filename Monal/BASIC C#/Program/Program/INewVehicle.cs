
#region INewVehicle
    /// <summary>
    /// Name:INewVehicle
    /// Description:Modify the interface IVehicle and add a numeric property InitialFuel. 
    /// Author:Monal Shah
    /// Created date:2010/09/15
    /// </summary>
    interface INewVehicle
    {
        #region initialFuel
        /// <summary>
        /// Name:FuelEfficiency
        /// Description:numeric property initialFuel
        ///Author:Monal Shah
        /// Created date:2010/09/15
        /// </summary>
        int initialFuel
        {
            get;
            set;
        }
        #endregion
    }
#endregion
