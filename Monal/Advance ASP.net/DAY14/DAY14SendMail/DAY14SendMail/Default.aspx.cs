using System;
using System.Configuration;
using System.IO;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAY14SendMail
{
    public partial class _Default : System.Web.UI.Page
    {
        string FileName;
        HttpPostedFile ObjPostedFile;
        SmtpClient smtpClient;
        Attachment attchment;
        /// <summary>
        /// Name:Page_Load
        /// Description:Set Focus ans make btnSend as defaultbutton.
        /// Author Name:Monal Shah
        /// Created Date:2010/11/29
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { txtFrom.Focus(); Page.Form.DefaultButton = btnSend.UniqueID; }
        #region btnSend_Click
        /// <summary>
        /// Name:btnSend_Click
        /// Description:Sending Mail and Also Send Attachment
        /// Author Name:Monal Shah
        /// Created Date:2010/11/29
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage mailmsg = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);
            try
            {
                if (txtCC.Text != string.Empty)
                    mailmsg.CC.Add(txtCC.Text);
                if (txtBCC.Text != string.Empty)
                    mailmsg.Bcc.Add(txtBCC.Text);
                smtpClient = new SmtpClient();
                Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
                MailSettingsSectionGroup objMail = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");
                smtpClient.Host = objMail.Smtp.Network.Host;
                smtpClient.Port = objMail.Smtp.Network.Port;
                if (FileUpload.HasFile)
                {   ObjPostedFile = FileUpload.PostedFile;
                    if (ObjPostedFile.ContentLength > 0)
                    {
                        FileName = Path.GetFileName(FileUpload.FileName);
                        FileUpload.SaveAs(Server.MapPath(FileName));
                        attchment = new Attachment(Server.MapPath(FileName));
                        mailmsg.Attachments.Add(attchment);
                    }
                }
                smtpClient.Send(mailmsg);
                LblMsgSent.Visible = true;
                LblMsgSent.Text = ConstantMessage.SendMsg;
                ClearControls();
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                smtpClient = null;
                mailmsg.Dispose();
                ObjPostedFile = null;
                attchment = null;
            }
            if (FileName != null)
                File.Delete(Server.MapPath(FileName));

        }
        #endregion
        #region btnClear_Click
        /// <summary>
        /// Name:btnClear_Click
        /// Description:Clear Controls
        /// Author Name:Monal Shah
        /// Created Date:2010/11/29
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnClear_Click(object sender, EventArgs e)
        { ClearControls(); LblMsgSent.Visible = false; }
        #endregion
        #region btnClear_Click
        /// <summary>
        /// Name:btnClear_Click
        /// Description:Clear Controls
        /// Author Name:Monal Shah
        /// Created Date:2010/11/29
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ClearControls()
        {
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtCC.Text = string.Empty;
            txtBCC.Text = string.Empty;
            txtSubject.Text = string.Empty;
            txtMessage.Text = string.Empty;
        }
        #endregion


    }
}
