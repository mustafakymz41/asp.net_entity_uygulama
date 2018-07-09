using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class kategoriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BlogSitesiEntities2 db = new BlogSitesiEntities2();
            try
            {
                var kategoriler = db.Kategori.ToList();
                Repeater1.DataSource = kategoriler;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
            if (Request.QueryString["Id"] != null)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                var silKayit = db.Kategori.Find(id);
                db.Kategori.Remove(silKayit);
                db.SaveChanges();
                Response.Redirect("kategoriler.aspx");
                
            }

        }
    }
}