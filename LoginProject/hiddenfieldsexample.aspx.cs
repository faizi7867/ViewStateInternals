using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class hiddenfieldsexample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if (tbtemp.Value!=string.Empty)
            {
                tbtemp.Value = (Convert.ToInt64(tbtemp.Value)  + Convert.ToInt64(tbnum.Text)).ToString();
                tbnum.Text = tbtemp.Value;
            }
            tbtemp.Value = tbnum.Text;


        }
    }
}