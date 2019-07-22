using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ADV_ASP_Day1_2
{    
      
    public partial class Frame2 : System.Web.UI.Page
    {
        private int flag;  // the name field 
        public int FlagValue    // the Name property
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
            }
        }   
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BtnEmployee_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        public void BtnDepartment_Click(object sender, EventArgs e)
        {
            flag = 2;    
        }
    }
}