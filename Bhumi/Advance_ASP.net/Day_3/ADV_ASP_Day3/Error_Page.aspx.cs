﻿using System;

namespace ADV_ASP_Day3
{
    public partial class Error_Page : System.Web.UI.Page
    {
        ConstantMessages objconst;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            Response.Write(objconst.strErrorMessage);
        }
    }
}