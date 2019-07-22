using System;
using System.Configuration;
using System.IO;

namespace Day_12_13
{
    #region UploadFile
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- UploadFile
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to Upload file on the server
    //      CREATED DATE    :- 2012/10/31
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class UploadFile : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ------------
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #endregion Page_Load
        #region UploadFile
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnUpload_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Function Used for Upload data on the server
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
    protected void btnUpload_Click(object sender, EventArgs e)
        {
            string strMess1;                                   //DECLARATION OBJECT OF VARIABLES
            string strFleUpload;
            string strFolderPath;                                                                           //Declaration of String type strfolderpath
            string strFilePath;
            bool uplod = true;                                 //SET BOOL VARIABLE TRUE
            try
            {
                if (FileUpOfEmp.HasFile)                        //IF FILE IS SELECT FOR UPLOAD THEN
                {
                    strFleUpload = Path.GetExtension(FileUpOfEmp.FileName.ToString());                  //STRFOLDER STORE EXTENSION OF FILE
                    //strFolderPath = AppDomain.CurrentDomain.BaseDirectory + "ServerPath";
                    strFolderPath = ConfigurationManager.AppSettings[Constant.strSERVERPATH];                 //USING CONFIGRATION FROM WEB CONFIG FILE ASSIGN VALUE OF PATH
                    strFilePath = (strFolderPath + FileUpOfEmp.FileName.ToString());                          //STRORE FILE PATH WITH FILE NAME IN A STRING
                    if (strFleUpload.Trim().ToLower() == Constant.strXLS |
                    strFleUpload.Trim().ToLower() == Constant.strXLSX)                                  //CHECK CONDITION FOR EXTENSION OF FILE
                    {
                        // Save excel file into Server sub dir
                        FileUpOfEmp.SaveAs(strFilePath);
                    }
                    if (uplod)                                                      //IF FILE UPLOAD THEN DISPLAY MESSAGE FILE UPLOADED SUCESSFULLY
                    {
                        strMess1 = Constant.strFILEUPLOADED;
                        lblMessage.Visible = true;
                        this.lblMessage.Text = strMess1;
                    }
                }
                else                                                                 //IF NOT THEN MESSAGE IS PLEASE SELECT FILE
                {
                    lblMessage.Visible = true;
                    this.lblMessage.Text = Constant.strPLSSELECTFILE;
                }
            }
            catch
            {
                uplod = false;                                                //IF ANY EXCEPTION THEN BOOL VARIABLE SET FALSE
                lblMessage.Visible = true;
                this.lblMessage.Text = Constant.strUPLOADINGERR;              //DISPLAY ERROR MESSAGE
            }
            finally
            {                                                              //FREE MEMORY OF VARIABLES
                strMess1 = null;
                strFilePath = null;
                strFolderPath = null;
                strFleUpload = null;
            }
        }
        #endregion UploadFile
    }
    #endregion UploadFile
}
