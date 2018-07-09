using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class makaleler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                BlogSitesiEntities2 db = new BlogSitesiEntities2();
                var makaleler = db.Makale.ToList();
                Repeater1.DataSource = makaleler;
                Repeater1.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
            if (Request.QueryString["Id"] != null)
            {
                BlogSitesiEntities2 db = new BlogSitesiEntities2();
                int id = int.Parse(Request.QueryString["Id"]);
                var makaleSil = db.Makale.Find(id);
                db.Makale.Remove(makaleSil);
                db.SaveChanges();
                Response.Redirect("makaleler.aspx");
            }
        }
    }
}