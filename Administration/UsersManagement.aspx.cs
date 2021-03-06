﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Administration.ServiceReference1;
using System.Windows.Forms;
using System.Web.Security;

namespace Administration
{
    public partial class UsersManagement : System.Web.UI.Page
    {
        public bool isAdmin { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            isAdmin = Session["User"] != null ? ((Administration.ServiceReference1.Person)Session["User"]).IsAdmin : false;
            if (Session["User"] == null)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            if (!isAdmin)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void Users_PreRender(object sender, EventArgs e)
        {
            List<Person> users = new List<Person>();
            using (Service1Client client = new Service1Client())
            {
                GetNotApprovedUsersResponse response = client.GetNotApprovedUsers();
                if (!response.Errored)
                {
                    users = response.Users.ToList<Person>();
                }
            }
            NotApprovedUsers.DataSource = users;
            try { NotApprovedUsers.DataBind(); }catch(Exception ex){}
        }

        protected void Admin_PreRender(object sender, EventArgs e)
        {
            List<Person> users = new List<Person>();
            using (Service1Client client = new Service1Client())
            {
                GetApprovedAdminsResponse response = client.GetApprovedAdmins();
                if (!response.Errored)
                {
                    users = response.Users.ToList<Person>();
                }
            }
            AdminUsers.DataSource = users;
            try { AdminUsers.DataBind(); }
            catch (Exception ex) { }
        }


        protected void ApprovedUsers_PreRender(object sender, EventArgs e)
        {
            List<Person> users = new List<Person>();
            using (Service1Client client = new Service1Client())
            {
                GetApprovedUsersResponse response = client.GetApprovedUsers();
                if (!response.Errored)
                {
                    users = response.Users.ToList<Person>();
                }
            }
            ApprovedUsers.DataSource = users;
            try { ApprovedUsers.DataBind(); }
            catch (Exception ex) { }
        }

        protected void Approve_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                ApproveUserResponse response = client.ApproveUser(new ApproveUserRequest() {
                    _id = ((LinkButton)sender).CommandArgument,
                    Approve = true
                });
                if (response.Errored)
                {
                    Response.Redirect("~/UsersManagement");    
                }
            }
        }

        protected void NotApprove_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                ApproveUserResponse response = client.ApproveUser(new ApproveUserRequest()
                {
                    _id = ((LinkButton)sender).CommandArgument,
                    Approve = false
                });
                if (response.Errored)
                {
                    Response.Redirect("~/UsersManagement");
                }
            }
        }

        protected void ApproveAdmin_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                ApproveAdminResponse response = client.ApproveAdmin(new ApproveAdminRequest()
                {
                    _id = ((LinkButton)sender).CommandArgument,
                    Admin = true
                });
                ApproveUserResponse response2 = client.ApproveUser(new ApproveUserRequest()
                {
                    _id = ((LinkButton)sender).CommandArgument,
                    Approve = true
                });
                if (response.Errored)
                {
                    Response.Redirect("~/UsersManagement");
                }
                if (response2.Errored)
                {
                    Response.Redirect("~/UsersManagement");
                }
            }
        }

        protected void NotApproveAdmin_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                ApproveAdminResponse response = client.ApproveAdmin(new ApproveAdminRequest()
                {
                    _id = ((LinkButton)sender).CommandArgument,
                    Admin = false
                });
                if (response.Errored)
                {
                    Response.Redirect("~/UsersManagement");
                }
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                DeleteUserResponse response = client.DeleteUser(new DeleteUserRequest()
                {
                    _id = ((LinkButton)sender).CommandArgument,
                });
                if (response.Errored)
                {
                    Response.Redirect("~/UsersManagement");
                }
                else
                {
                    Response.Redirect("~/UsersManagement");
                }
            }
        }
    }
}