﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Administration.ServiceReference1;
using System.Windows.Forms;

namespace Administration
{
    public partial class NewsEditor : System.Web.UI.Page
    {
        public Administration.ServiceReference1.NewsItem NewsContent { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            bool isAdmin = Session["User"] != null ? ((Administration.ServiceReference1.Person)Session["User"]).IsAdmin : false;
            if (Session["User"] == null)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            if(!isAdmin)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                if (!IsPostBack)
                {
                    using (Service1Client client = new Service1Client())
                    {
                        GetNewsItemByIdResponse response = client.GetNewsItemById(new GetNewsItemByIdRequest()
                        {
                            _id = Request.QueryString["id"]
                        });
                        if (!response.Errored)
                        {
                            NewsContent = response.News;
                            NewsTitle.Text = NewsContent.Title;
                            NewsText.Text = NewsContent.Text;
                            NewsFinal.Text = NewsContent.Text;
                            Author.Text = NewsContent.Author;
                            NewsID.Text = NewsContent._id;
                        }
                        else
                        {
                            ErreurMessage.Text = "Error";
                        }
                    }
                }
            }
        }


        protected void Edit_News(object sender, EventArgs e)
        {
            NewsItem news = new NewsItem()
            {
                _id = NewsID.Text,
                Title = NewsTitle.Text,
                Text = NewsText.Text,
                Author = Author.Text,
                Date_modified = DateTime.Now,
            };
            using (Service1Client client = new Service1Client())
            {
                UpdateNewsItemResponse response = client.UpdateNewsItem(new UpdateNewsItemRequest()
                {
                    NewsItem = news
                });
                if (!response.Errored)
                {
                    Response.Redirect("~/News?id=" + news._id);
                }
                else
                {
                    ErreurMessage.Text = "Error";
                    Response.Redirect("~/");
                }
            }
            
        }
    }
}