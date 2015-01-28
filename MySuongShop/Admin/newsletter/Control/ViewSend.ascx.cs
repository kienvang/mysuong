using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;
using Modules;

public partial class Admin_newsletter_Control_ViewSend : System.Web.UI.UserControl
{
    Guid getId()
    {
        return FGuid.ToGuid(Request["id"]);
    }

    NewsletterEntity nll;

    protected void Page_Load(object sender, EventArgs e)
    {
        nll = NewsletterManager.CreateInstant().SelectOne(getId());
        if (nll != null){
            txtEmailQueue.Text = nll.EmailQueue;
        }

        btnSend.OnClientClick = WebUtility.GetLockButtonJscript(this.Page, btnSend, "", "loading();");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        EmailNewsletter1.Id = getId();
        string html = EmailNewsletter1.Content();
        Literal1.Text = html;

        divTest.Visible = true;
        divEmail.Visible = true;
        btnSendTest.Visible = true;
        btnSend.Visible = true;
    }

    protected void btnSendTest_Click(object sender, EventArgs e)
    {
        EmailNewsletter1.Id = getId();
        string html = EmailNewsletter1.Content();
        HistoryEmail.SendMailHistory(GetEmail.EmailFrom, txtEmail.Text, "Test gửi mail", html);
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        string[] emails = txtEmailQueue.Text.Trim().Split(',');
        if (emails.Length > 0)
        {
            EmailNewsletter1.Id = getId();
            string html = EmailNewsletter1.Content();
            foreach (string email in emails)
            {
                HistoryEmail.SendMailHistory(GetEmail.EmailFrom, email.Trim(), nll.Subject, html);
            }
        }

        CookieManager.setCookie(this.Page, "state", "1");
        WebUtility.Refesh(this.Page);
    }
}