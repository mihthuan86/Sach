using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    AccessData dt = new AccessData();
                    string sql = "select * from LOAISACH";
                    DataTable table = dt.DataTable(sql);
                    this.DataList1.DataSource = table;
                    this.DataList1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void LinkButton_Click(object sender, EventArgs e)
        {
            string mamd = ((LinkButton)sender).CommandArgument;
            Session["maloai"] = mamd;
            Response.Redirect("SanPham.aspx");
        }
    }
}