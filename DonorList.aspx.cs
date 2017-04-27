using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonorList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        var donate = (from a in db.Donations
                      select a).ToList();
        GridView1.DataSource = donate;
        GridView1.DataBind();

            
    }
}