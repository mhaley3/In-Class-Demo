﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageSpecialEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ProcessExceptions(object sender, ObjectDataSourceStatusEventArgs e)
    {
        if (e.Exception != null)
        {
            //display a message
            MessageLabel.Text = "Unable to process the request.";
            //prevent the error from being handled by the objectdatasource control itself
            e.ExceptionHandled = true; //Problem solved
        }
    }
}