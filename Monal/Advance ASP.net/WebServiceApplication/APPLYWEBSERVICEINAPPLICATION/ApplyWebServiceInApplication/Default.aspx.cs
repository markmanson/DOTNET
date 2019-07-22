using System;
using ApplyWebServiceInApplication.localhost;
using System.Data.SqlClient;
using System.Data;


namespace ApplyWebServiceInApplication
{
    public partial class _Default : System.Web.UI.Page
    {
        Service1 objWebService = new Service1();            
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Set Focus.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtValue1.Focus();
            LblDisplayAnswer.Visible = true;
            if (!IsPostBack)
                BindGrid();
        }
        #endregion
        public void BindGrid()
        {            
            EmployeeGrid.DataSource =objWebService.DispalyTable();
            EmployeeGrid.DataBind();
        }
        #region BtnAdd_Click
        /// <summary>
        /// Name:BtnAdd_Click
        /// Description:Add Two Values And Result Display in Label.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            LblDisplayAnswer.Text = Convert.ToString(objWebService.Add(Convert.ToInt32(TxtValue1.Text), Convert.ToInt32(TxtValue2.Text)));
        }
        #endregion
        #region BtnSubtract_Click
        /// <summary>
        /// Name:BtnSubtract_Click
        /// Description:Subtract Two Values And Result Display in Label.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubtract_Click(object sender, EventArgs e)
        {
            LblDisplayAnswer.Text = Convert.ToString(objWebService.Subtract(Convert.ToSingle(TxtValue1.Text), Convert.ToSingle(TxtValue2.Text)));
        }
        #endregion
        #region BtnMultiply_Click
        /// <summary>
        /// Name:BtnMultiply_Click
        /// Description:Multiply Two Values And Result Display in Label.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnMultiply_Click(object sender, EventArgs e)
        {
            LblDisplayAnswer.Text = Convert.ToString(objWebService.Multiply(Convert.ToSingle(TxtValue1.Text), Convert.ToSingle(TxtValue2.Text)));
        }
        #endregion
        #region BtnDivide_Click
        /// <summary>
        /// Name:BtnDivide_Click
        /// Description:Divide Two Values And Result Display in Label.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDivide_Click(object sender, EventArgs e)
        {
            LblDisplayAnswer.Text = Convert.ToString(objWebService.Divide(Convert.ToSingle(TxtValue1.Text), Convert.ToSingle(TxtValue2.Text)));
        }
        #endregion
        #region BtnClear_Click
        /// <summary>
        /// Name:BtnClear_Click
        /// Description:Clear Controls
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TxtValue1.Text = string.Empty;
            TxtValue2.Text = string.Empty;
            LblDisplayAnswer.Visible = false;
        }
        #endregion
    }
}
