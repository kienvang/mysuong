using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;
using Modules;

public partial class Admin_Feedback_Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadFeedback();
            LoadData();
        }
    }

    void LoadFeedback()
    {
        FeedBackEntity fb = FeedBackManager.CreateInstant().SelectOne(FGuid.ToGuid(Request.QueryString["id"]));
        if (fb != null)
        {
            lblContent.Text = fb.Message.Replace("\n", "<br>");
            txtReceiver.Text = fb.SenderEmail;
        }
    }

    public void LoadData()
    {
        CGridView1.CDataBind(FeedbackDetailManager.CreateInstant().GetAll(FGuid.ToGuid(Request.QueryString["id"])));
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetFormatEmail(txtDetail.Value.Trim());
            if (template != null)
            {
                string subject = txtSubject.Text.Trim();
                string body = template.Body;
                string from = GetEmail.EmailFrom;
                string to = txtReceiver.Text.Trim();
                string bcc = GetEmail.EmailTo;

                HistoryEmail.SendMailHistory(from, to, subject, body);

                FeedBackEntity fb = FeedBackManager.CreateInstant().SelectOne(FGuid.ToGuid(Request.QueryString["id"]));
                fb.Approved = true;
                FeedBackManager.CreateInstant().Update(fb);

                FeedbackDetailEntity fd = new FeedbackDetailEntity();
                fd.FeedbackId = fb.Id;
                fd.Receiver = txtReceiver.Text.Trim();
                fd.Subject = txtSubject.Text.Trim();
                fd.Body = txtDetail.Value.Trim();
                fd.CreatedBy = Util.CurrentUserName;
                FeedbackDetailManager.CreateInstant().Insert(fd);
            }
        }

        Response.Redirect("/Admin/Feedback/Detail.aspx?id=" + Request.QueryString["id"]);
    }
}
