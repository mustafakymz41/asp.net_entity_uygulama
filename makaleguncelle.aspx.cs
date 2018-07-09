using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class makaleduzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BlogSitesiEntities2 db = new BlogSitesiEntities2();

            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                var veri = from m in db.Makale
                           join k in db.Kategori
                           on m.KategoriId equals k.KategoriId
                           select new
                           {
                               k.KategoriAdi
                           };
                DrpKategoriler.SelectedValue = veri.ToString();


            }
        }
    }
}