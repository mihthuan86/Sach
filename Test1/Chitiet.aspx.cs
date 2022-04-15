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
    public partial class Chitiet : System.Web.UI.Page
    {
        public string masp;
        public AccessData data = new AccessData();
        protected void Page_Load(object sender, EventArgs e)
        {
            masp = Request.QueryString["masp"];                     
            if (Page.IsPostBack) return;
            string q;
            if (Request.QueryString["id"] == null)
                q = "select * from Hoa";
            else
            {
                string masach = Request.QueryString["id"];
                q = "select * from SACH where MaHoa = '" + masach + "'";
            }
            try
            {
                DataTable dt = data.DataTable(q);
                this.DataList2.DataSource = dt;
                this.DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["customer"]==null)
            {
                Response.Write("<script>alert('Vui long dang nhap')</script>");
            }
            else
            {
                string TenDN = Session["customer"].ToString();
                string sql_check = "select * from DONHANG where TenDN= " + TenDN + "and MaSach=" + masp;
                var dong = data.ExcuteReader(sql_check);
                if (dong.HasRows)
                {
                    sql_update = update
                }
            }
        }
    }
}