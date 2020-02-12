using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void formValidation(object sender, EventArgs e)
        {
            //Validate FirstName
            if (string.IsNullOrEmpty(firstname.Text))
            {
                firstnameErrorMsg.Text = "Enter your FirstName.";
            }
            //Validate Second Name
            if (string.IsNullOrEmpty(lastname.Text))
            {
                lastnameErrorMsg.Text = "Enter your LastName.";
            }
            //Validate MoobileNumber
            if (string.IsNullOrEmpty(mobile.Text))
            {
                mobileNoErrorMsg.Text = "Mobile No is required.";
            }
            else { 
                if (mobile.Text.Length != 10)
                {
                    mobileNoErrorMsg.Text = "Check your entered mobile number.";
                }
            }
            //Validate Mail id
            if (string.IsNullOrEmpty(mail.Text))
            {
                emailErrorMsg.Text = "Invalid email id or email id required";
            }
            // Validate stream
            if (!(NetCheckBox.Checked)&& !(JavaCheckBox.Checked)&& !(SdetCheckBox.Checked))
            {
                streamErrorMsg.Text = "Please select atleast one stream. ";
            }
            //Validate Gender
            bool isValid = false;
            foreach(ListItem item in genderList.Items)
            {
                if (item.Selected)
                {
                    isValid = true;
                    break;
                }
                else
                {
                    isValid = false;
                }
            }
            if (isValid == false)
            {
                genderErrorMsg.Text = "Select gender.";
            }
           
        }
    }
}