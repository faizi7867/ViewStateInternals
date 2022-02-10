using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class Iindex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["userRegDetails"];
            string name = c.Values["username"];
            Response.Output.Write($"welcome {name}");
        }
    }
}