using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)     {         string user = UserTextBox.Text; 
       string first = FirstNameTextBox.Text; 
         string last = LastNameTextBox.Text; 
        string email = EmailTextBox.Text; 
         string password = ConfirmTextBox.Text; 
 
 
         Community_AssistEntities db = new Community_AssistEntities(); 
         int result = db.usp_Login(user, first, last, email, password); 
         if (result != -1) 
         { 
             Response.Redirect("Default.aspx"); 
         } 
         else 
         { 
             ErrorLabel.Text = "Something went terribly wrong"; 
         } 
    }
}