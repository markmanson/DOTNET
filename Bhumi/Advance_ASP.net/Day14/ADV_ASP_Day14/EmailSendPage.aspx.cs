using System;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
/// <summary>
/// Namespace Name:ADV_ASP_Day14
/// Description: Send Email 
/// Author:Bhumi
/// Created On:23/7/2015
/// </summary>  
namespace ADV_ASP_Day14
{
    /// <summary>
    /// Class Name:EmailSendPage
    /// Description:Send Email with attachment in ASP.NET
    /// Author:bhumi
    /// Created on:21/7/2015
    /// </summary>    
    public partial class EmailSendPage : System.Web.UI.Page
    {
        ConstantMessages objconst;
        MailMessage ObjMsg;
        Attachment attachFile;
        ContentType mimeType;
        AlternateView alternate;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            LblSendMailAlert.Visible = false;            
        }
        #endregion
        #region Send Button Click Event
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ObjMsg = new MailMessage();//Object Of MailMessage
                ObjMsg.To.Add(TxtTo.Text.Trim());//Email To Contact
                if (TxtCc.Text != "")
                {
                    ObjMsg.CC.Add(TxtCc.Text.Trim());//CC Contact            
                }
                if (TxtBcc.Text != "")
                {
                    ObjMsg.Bcc.Add(TxtBcc.Text.Trim());//Bcc Contact
                }                                
                ObjMsg.From = new MailAddress(TxtFrom.Text.Trim());//From Contact
                ObjMsg.Subject = TxtSubject.Text;//Subject Of Mail
                // Add the alternate body to the message.
                mimeType = new ContentType("text/Html");                
                alternate = AlternateView.CreateAlternateViewFromString(TxtBody.Content, mimeType);
                ObjMsg.AlternateViews.Add(alternate);//Message Body
                if (fileUpload1.HasFile)
                {
                    string strFileName = Path.GetFileName(fileUpload1.PostedFile.FileName);
                    attachFile = new Attachment(fileUpload1.PostedFile.InputStream, strFileName);
                    ObjMsg.Attachments.Add(attachFile);//Attachement                    
                }
                objconst = new ConstantMessages();                
                SmtpClient objsmtp = new SmtpClient(objconst.strIPAddress);
                ObjMsg.IsBodyHtml = false;
                objsmtp.Send(ObjMsg);//Email With All Content Send using Specific IP Address
                LblSendMailAlert.Visible = true;
                //ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconst.strMailSend + "');", true);//Alert for Mail Sent
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage, false);//Error Page
            }
            finally
            {
                ObjMsg = null;
                objconst = null;
                attachFile = null;
                mimeType = null;
                alternate = null;
                TxtBcc.Text = "";
                TxtBody.Content = "";
                TxtCc.Text = "";
                TxtFrom.Text = "";
                TxtSubject.Text = "";
                TxtTo.Text = "";
            }
        }
        #endregion
        #region Clear Button Click Event
        //Clear all field of web Form
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            LblSendMailAlert.Visible = false;
            TxtBcc.Text = "";
            TxtBody.Content = "";
            TxtCc.Text = "";
            TxtFrom.Text = "";
            TxtSubject.Text = "";
            TxtTo.Text = "";
            fileUpload1.Attributes.Clear();
        }
        #endregion
    }
}