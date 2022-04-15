using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test1
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccessData dt = new AccessData();
            if (Page.IsPostBack) return;
            string sql;
            if (Session["MaSach"] == null)
                sql = "select * from Sach";
            else
            {
                string maloai = Session["MaSach"].ToString();
                sql = "select * from SACH where MaLoai = '" + maloai + "'";
            }
            try
            {

                DataTable table = dt.DataTable(sql);
                this.DataList1.DataSource = table;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

    }
}