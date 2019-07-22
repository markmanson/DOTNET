using System;
using System.Web.UI.WebControls;
using System.Web;

namespace ASP.NET_DAY1
{
    #region _Default
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     _Default                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A CLASS TO FIND THE TOTAL NUMBERS OF VISITOR
     * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {        
        #region Page_Load
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Page_Load                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     PAGE LOAD EVENT
     * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txtName.Focus();                                    //TO FOCUS ON TEXTBOX TXTNAME
                if (!IsPostBack)
                {
                    Application[Constant.strCurrentUser] = 0;      //INITIALIZATION OF COUNTER FOR CLICKING THE SUBMIT BUTTON
                }
                lblVisitor.Text = Constant.strOnUser + (int)Application[Constant.strOnlineUser];     //DISPLAY THE NUMBER OF TOTAL VISITOR
            }
            catch (Exception)                                            //IF EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                    //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
            }
        }
        #endregion Page_Load
        #region btnSubmit_Click
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     btnSubmit_Click                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     SUBMIT BUTTON CLICK EVENT
     * **********************************************************************************************************/
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Property objclass1;
            try
            {                
                objclass1 = new Property();
                objclass1.Name = txtName.Text;
                Session[Constant.strName] = objclass1.Name;                                     //ASSIGN THE VALUE OF TXTNAME TO SESSION 
                txtSession.Text = Convert.ToString(Session[Constant.strName]);                  //ASSIGN THE VALUE OF SESSION TO TXTSESSION 
                txtName.Text = "";
                if (Session[Constant.strName].ToString() != "")
                {
                    Application[Constant.strCurrentUser] = Convert.ToInt32(Application[Constant.strCurrentUser]) + 1;                                                            //INCREMENT THE COUNTER
                    lblClick.Text = Constant.strCrntClck + Convert.ToInt32(Application[Constant.strCurrentUser]);                            //DISPLAY THE TOTAL HITS
                }                
            }
            catch (Exception)
            {
                Response.Redirect(Constant.strError);                                //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
            }
            finally
            {
                objclass1 = null;                                                    //ASSIGN NULL TO THE OBJECT OF CLASS PROPERTY
            }
        }
        #endregion btnSubmit_Click
    }
    #endregion _Default
}

