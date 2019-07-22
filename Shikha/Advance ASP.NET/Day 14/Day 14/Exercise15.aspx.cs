using System;
using System.Configuration;
using System.IO;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;

namespace Day_14
{
    #region _Default
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to sendmail
    //      CREATED DATE    :- 2012/11/02
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- --------------
        //      CREATED DATE    :- 2012/11/02
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        { }
        #endregion Page_Load
        #region SendMail
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnSend_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Method used for sending mail
        //      CREATED DATE    :- 2012/11/02
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient objSmtpClient;
            MailMessage objMessage; 
            MailAddress objFromAddress, objToAddress;
            string strFileName, strBcc1, strval, strval2,strCc;
            string[] strWords, strBcc;
            try
            {
                Configuration configurationFile = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
                MailSettingsSectionGroup mailSettings = (MailSettingsSectionGroup)configurationFile.GetSectionGroup("system.net/mailSettings");
                objSmtpClient = new SmtpClient();
                objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("shikha", "Shikha");//Gmail username and password
                objMessage = new MailMessage();
                objSmtpClient.EnableSsl = false;
                objSmtpClient.UseDefaultCredentials = false;
                objSmtpClient.Credentials = basicAuthenticationInfo;
                objFromAddress = new MailAddress(txtFrom.Text);
                objToAddress = new MailAddress(txtTo.Text);
                // You can specify the host name or ipaddress of your server
                objSmtpClient.Host = Constant.strHOST;
                //Default port will be 25
                objSmtpClient.Port = 25;
                //From address will be given as a MailAddress Object
                objMessage.From = objFromAddress;
                // To address collection of MailAddress
                objMessage.To.Add(objToAddress);
                // objMessage.To.Add(txtTo.Text);
                objMessage.Subject = txtSubject.Text;
                // CC and BCC optional
                // MailAddressCollection class is used to send the email to various users
                if (txtCc.Text != Constant.strBLANK)
                {
                    strCc = txtCc.Text;
                    strWords = strCc.Split(';');
                    
                    for (int i = 0; i <strWords.Length; i++)
                    {
                        strval = strWords[i];
                        objMessage.CC.Add(new MailAddress(strval));
                    }
                }
                if (txtBcc.Text != Constant.strBLANK)
                {
                    strBcc1 = txtBcc.Text;
                    strBcc = strBcc1.Split(';');

                    for (int i = 0; i < strBcc.Length; i++)
                    {
                        strval2 = strBcc[i];
                        objMessage.Bcc.Add(new MailAddress(strval2));
                    }
                }

                //***************************************************************************
                if (inpAttachment1.PostedFile != null)
                {
                    /* Get a reference to PostedFile object */
                    HttpPostedFile attFile = inpAttachment1.PostedFile;
                    /* Get size of the file */
                    int attachFileLength = attFile.ContentLength;
                    /* Make sure the size of the file is > 0  */
                    if (attachFileLength > 0)
                    {
                        /* Get the file name */
                        strFileName = Path.GetFileName(inpAttachment1.PostedFile.FileName);
                        /* Save the file on the server */
                        inpAttachment1.PostedFile.SaveAs(Server.MapPath(strFileName));
                        /* Create the email attachment with the uploaded file */
                        Attachment attach = new Attachment(Server.MapPath(strFileName));
                        /* Attach the newly created email attachment */
                        objMessage.Attachments.Add(attach);
                        /* Store the attach filename so we can delete it later */
                        //attach = strFileName;
                    }
                }
                //**************************************************************************
                objMessage.Priority = MailPriority.High;
                //Body can be Html or text format
                //Specify true if it  is html objMessage
                objMessage.IsBodyHtml = true;
                // Message body content
                objMessage.Body = txtMsg.Text;
                // Send SMTP mail
                objSmtpClient.Send(objMessage);
                lblStatus.Text = Constant.strMSGSENT;
            }
            catch
            {
                Response.Redirect(Constant.strERRPAGE);          //throw exception on error page
            }
            finally
            {
                strFileName = null; strBcc1 = null; strval = null; 
                strval2 = null; strCc=null;
                strWords = null; strBcc=null;
                objFromAddress = null; objToAddress=null;
                objSmtpClient = null;
                objMessage = null;
            }
        }
        #endregion SendMail
       #region ClearTextBox
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- btnClear_Click
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- The Method used for reset the textboxes
       //      CREATED DATE    :- 2012/11/02
       //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFrom.Text = Constant.strBLANK;
            txtTo.Text = Constant.strBLANK;
            txtSubject.Text = Constant.strBLANK;
            txtCc.Text = Constant.strBLANK;
            txtBcc.Text = Constant.strBLANK;
            txtMsg.Text = Constant.strBLANK;
        }
       #endregion ClearTextBox
    }
    #endregion _Default
}
