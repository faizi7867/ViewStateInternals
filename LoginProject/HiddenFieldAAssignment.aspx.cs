using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class HiddenFieldAAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> BG = new List<string>();
                BG.Add("o+");
                BG.Add("o-");
                BG.Add("a+");
                BG.Add("a-");
                BG.Add("b+");
                BG.Add("b-");
                BG.Add("ab+");
                BG.Add("ab-");
                ddlbg.DataSource = BG;
                ddlbg.DataBind();
            }

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (hdnName.Value!=string.Empty)
            {
                Response.Output.Write($"Last Patient Details : <br/>");
                Response.Output.Write($"Name = {hdnName.Value}<br/> age = {hdnAge.Value}<br/> Blood Group = {hdnBG.Value}<br/>");
            }
            Response.Output.Write($"Current Patient Details : <br/>");
            Response.Output.Write($"Name = {tbname.Text}<br/> age = {tbage.Text}<br/> Blood Group = {ddlbg.SelectedValue}<br/>");
            hdnName.Value = tbname.Text;
            hdnAge.Value = tbage.Text;
            hdnBG.Value = ddlbg.SelectedValue;

        }
    }
}