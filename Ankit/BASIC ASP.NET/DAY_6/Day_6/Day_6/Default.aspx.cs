using System;

namespace Day_6
{
    #region _Default
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     _Default                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     16/08/2012
     * DESCRIPTION                                  :::                     TO SHOW THE OPTION TO SELECTED BY USER
     * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region btnSubmit_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     BtnSubmit_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     16/08/2012
         * DESCRIPTION                                  :::                     FUNCTION BTNSUBMIT_CLICK
         * **********************************************************************************************************/
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strData;                                             //DECLARATION OF THE OBJECT OF STRING TYPE VARIABLE                                                               
            string strComma;                                            //DECLARATION OF THE OBJECT OF STRING TYPE VARIABLE
            try
            {
                strData = String.Empty;                                 //INITIALIZATION OF THE OBJECT OF STRING TYPE VARIABLE
                strComma = String.Empty;                                //INITIALIZATION OF THE OBJECT OF STRING TYPE VARIABLE
                for (int i = 0; i < chklstChoice.Items.Count; i++)
                {
                    if (chklstChoice.Items[i].Selected)                 //CHECK IF CHECKLIST ITEM  IS SELECTED
                    {
                        if (strData != Constant.strEmpty)                               //CHECK IF STRDATA IS EMPTY
                        {
                            strComma = Constant.strCmma;                             //ASSIGN "," TO STRING
                        }
                        strData = strData + strComma + chklstChoice.Items[i].Text + Constant.strCmma + chklstChoice.Items[i].Value; //ASSIGN THE VALUE OF CHECKLIST SELECTED ITEM AND TEXT OF THAT TO STRING
                    }
                }
                if (strData != Constant.strEmpty)
                {
                    Response.Redirect(Constant.strRed + strData, false);      //SEND QUERY STRING TO TOPICS.ASPX AND REDIRECT ALSO
                }
            }
            catch                                                             //CHECK IF EXCEPTION IS  OCCURED
            {
                Response.Redirect(Constant.strError);                         //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                //ASSIGN NULL TO OBJECTS OF STRING INITIALIZED ABOVE
                strComma = null;
                strData = null;
            }
        }
        #endregion btnSubmit_Click
    }
    #endregion _Default
}
