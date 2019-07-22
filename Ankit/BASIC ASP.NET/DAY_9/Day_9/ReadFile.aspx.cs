using System;
using System.IO;
using System.Text;
namespace Day_9
{
    #region ReadFile
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     ReadFile                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     27/08/2012
     * DESCRIPTION                                  :::                     TO SHOW THE CONTENT OF A TEXT FILE IN WEBPAGE
     * **********************************************************************************************************/
    public partial class ReadFile : System.Web.UI.Page
    {
        public string strError = string.Empty;
        #region Page_Load
     /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Page_Load                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     27/08/2012
     * DESCRIPTION                                  :::                     Page_Load EVENT 
     * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            Show_File();                                                    //CALL THE FUNCTION SHOW_FILE
        }
        #endregion Page_Load
        #region Show_File
     /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Show_File                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     27/08/2012
     * DESCRIPTION                                  :::                     METHOD TO SHOW AN EXISTING FILE INTO A WEB PAGE 
     * **********************************************************************************************************/
        public void Show_File()                                             
        {
            StringBuilder strbuild;
            try
            {
                string path =Server.MapPath(Constant.strPath);                                      //STORE THE PATH OF FILE INTO STRING
                if (!string.IsNullOrEmpty(path))                                    //CHECK IF PATH IS NOT EMPTY
                {
                    string[] readText = File.ReadAllLines(path);                    //INITIALIZE STRING ARRAY
                    strbuild = new StringBuilder();                                 //INITIALIZATION OF STRING BUILDER
                    foreach (string s in readText)
                    {
                        strbuild.Append(s);                                         //APPENDING THE STRINBUILDER
                        strbuild.AppendLine();                                      //APPEND THE STRING BUILDER
                    }
                    txtBoxContents.Text = strbuild.ToString();                      //ASSIGN THE STRINGBUILDER TO TXTBOXCONTENTS.TEXT
                }
            }
            catch (Exception ex)
            {
                txtBoxContents.Text = Constant.strErrOcrd;
                strError=ex.Message;                
            }
        }
        #endregion Show_File
        #region btnError_Click
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     btnError_Click                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     27/08/2012
     * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON SHOW ERROR
     * **********************************************************************************************************/
        protected void btnError_Click(object sender, EventArgs e)
        {
            if (strError != "")
            {
                lblError.Visible = true;
                lblError.Text = strError;
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = Constant.strNoErr;
                lblError.ForeColor = System.Drawing.Color.Green;
            }
        }
        #endregion btnError_Click
    }       
    #endregion ReadFile
}
