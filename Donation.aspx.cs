﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userkey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation a = new Donation();
        a.DonationName = DonationTextBox;

        db.Donations.Add(a);
        db.SaveChanges();

        Response.Redirect("DonationList.aspx");


    }
}

