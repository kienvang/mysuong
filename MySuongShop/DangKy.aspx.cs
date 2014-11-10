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
using LayerHelper.ShopCake.DAL.HelperClasses;
using Library.Tools;

public partial class DangKy : System.Web.UI.Page
{
    protected void Page_PreRender(object sender, EventArgs e)
    {
        // setup client-side input processing
        SampleCaptcha.UserInputClientID = txtCaptcha.ClientID;

        if (IsPostBack)
        {
            // clear previous user input
            txtCaptcha.Text = null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Library.Tools.Util.CurrentUserName))
        {
            Response.Redirect("/");
        }

        if (!IsPostBack)
        {
            txtUserName.Attributes.Add("autocomplete", "off");
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            MembershipUser user = Membership.CreateUser(txtUserName.Text.Trim(), txtPassword.Text);

            CustomersEntity customer = new CustomersEntity();

            customer.Id = new Guid(user.ProviderUserKey.ToString());
            customer.UserName = user.UserName;
            customer.FullName = Filter.GetStringNoHtml(txtFullname.Text.Trim(), CustomersFields.FullName.MaxLength);
            customer.Email = Filter.GetMaxString(txtEmail.Text.Trim(), CustomersFields.Email.MaxLength);
            customer.Address = Filter.GetStringNoHtml(txtAddress.Text.Trim(), CustomersFields.Address.MaxLength);
            customer.IsAccount = true;

            CustomersManager.CreateInstant().Insert(customer);

            user.Email = txtEmail.Text.Trim();
            Membership.UpdateUser(user);
            Roles.AddUserToRole(user.UserName, Modules.Role.EnumsRoles.UserMember);

            FormsAuthentication.SetAuthCookie(user.UserName, true);
            
            Response.Redirect("/", true);
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        MembershipUser user = Membership.GetUser(txtUserName.Text.Trim());
        if (user != null)
        {
            args.IsValid = false;
            CustomValidator1.ErrorMessage = "Tên đăng nhập " + txtUserName.Text.Trim() + " đã tồn tại";
            return;
        }

        string username = Membership.GetUserNameByEmail(txtEmail.Text.Trim());
        if (!string.IsNullOrEmpty(username))
        {
            args.IsValid = false;
            CustomValidator1.ErrorMessage = "Email " + txtEmail.Text.Trim() + " đã tồn tại";
            return;
        }
    }
}
