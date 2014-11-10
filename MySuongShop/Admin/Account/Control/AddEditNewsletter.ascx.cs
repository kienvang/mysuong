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

public partial class Admin_Account_Control_AddEditNewsletter : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    Guid getId()
    {
        return FGuid.ToGuid(Request["id"]);
    }

    void LoadData()
    {
        NewsletterEntity nll = NewsletterManager.CreateInstant().SelectOne(getId());
        if (nll != null)
        {
            txtSubject.Text = nll.Subject;
            txtBody.Value = nll.Body;
            txtSendDate.Text = nll.SendDate.ToString("dd/MM/yyy");
            chkIsEnable.Checked = nll.IsEnable;
            hidId.Value = nll.Id.ToString();
            btnUpdate.Text = "Cập nhật";
            rdoSendAll.Checked = nll.IsSendAll;
        }

        DataTable group = CustomerGroupManager.CreateInstant().GetInNewsletter(getId());
        foreach (DataRow r in group.Rows)
        {
            ListItem item = new ListItem(r["Name"].ToString(), r["Id"].ToString());
            item.Selected = (int)r["Selected"] == 1 ? true : false;
            item.Attributes.Add("select", r["Selected"].ToString());
            chklGroup.Items.Add(item);
        }
    }

    NewsletterEntity GetNewsletter()
    {
        NewsletterEntity nll = new NewsletterEntity();
        nll.Subject = txtSubject.Text.Trim();
        nll.Body = txtBody.Value.Trim();
        nll.IsEnable = chkIsEnable.Checked;
        nll.SendDate = FDateTime.ConvertDate(txtSendDate.Text.Trim());
        nll.UpdatedBy = Util.CurrentUserName;
        nll.UpdatedDate = DateTime.Now;
        nll.IsSendAll = rdoSendAll.Checked;
        return nll;
    }

    void UpdateGroup(Guid newsletterId)
    {
        if (rdoSendAll.Checked)
        {
            NewsletterInGroupManager.CreateInstant().DeleteByNewsletterId(newsletterId);
        }
        else
        {
            foreach (ListItem item in chklGroup.Items)
            {
                if (item.Selected)
                {
                    if (item.Attributes["select"] == "0")
                    {
                        NewsletterInGroupEntity g = new NewsletterInGroupEntity();
                        g.GroupId = FGuid.ToGuid(item.Value);
                        g.NewsletterId = newsletterId;
                        NewsletterInGroupManager.CreateInstant().Insert(g);
                    }
                }
                else
                {
                    if (item.Attributes["select"] == "1")
                    {
                        NewsletterInGroupManager.CreateInstant().DeleteGroup(newsletterId, FGuid.ToGuid(item.Value));
                    }
                }
            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            NewsletterEntity nll = GetNewsletter();
            if (hidId.Value == string.Empty)
            {
                nll.CreatedBy = Util.CurrentUserName;
                nll.CreatedDate = DateTime.Now;
                nll.State = NewsletterManager.NEW;
                nll.Id = Guid.NewGuid();
                NewsletterManager.CreateInstant().Insert(nll);
                UpdateGroup(nll.Id);
                Response.Redirect("/Admin/Account/NewsletterEdit.aspx?id" + nll.Id.ToString());
            }
            else
            {
                NewsletterEntity tmp = NewsletterManager.CreateInstant().SelectOne(getId());
                tmp.Subject = nll.Subject;
                tmp.Body = nll.Body;
                tmp.IsEnable = nll.IsEnable;
                tmp.SendDate = nll.SendDate;
                tmp.UpdatedDate = nll.UpdatedDate;
                tmp.UpdatedBy = nll.UpdatedBy;
                tmp.IsSendAll = nll.IsSendAll;
                NewsletterManager.CreateInstant().Update(tmp);
                UpdateGroup(tmp.Id);
                WebUtility.Refesh(Page);
            }
        }
    }
}
