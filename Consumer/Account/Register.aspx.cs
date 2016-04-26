﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Consumer.Models;
using System.Text.RegularExpressions;
using Consumer.ServiceReference1;

namespace Consumer.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            //var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            //IdentityResult result = manager.Create(user, Password.Text);
            /*if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");
                
                //signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }*/
            if (checkMail(Email.Text))
            {
                using (Service1Client client = new Service1Client())
                {
                    //Check mail is not already used

                    //Check password and Hash
                    
                    // Add to database
                    
                }
            }
            else
            {
                ErrorMessage.Text = "Wrong email address format";
            }
            
        }

        private bool check_password(string password)
        {
            string cNumber = @"[\w\.\-]*[0-9]+[\w\.\-]*";
            string cLetter = @"[0-9]*[\w\.\-]+[0-9]*";
            return Regex.IsMatch(cNumber, password) && Regex.IsMatch(cLetter, password) && password.Length>=6;
        }

        private bool checkMail(string mail) {
            string rgmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(mail, rgmail, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

        protected void Email_TextChanged(object sender, EventArgs e)
        {
            Email.BackColor = System.Drawing.Color.Green;
        }
    }
}