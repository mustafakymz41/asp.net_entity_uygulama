using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class kategoriguncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BlogSitesiEntities2 db = new BlogSitesiEntities2();

            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                var veri = db.Kategori.Find(id);
                txtKategoriAdi.Text = veri.KategoriAdi;
                txtArea.Text = veri.KategoriAciklama;

            }
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BlogSitesiEntities2 db = new BlogSitesiEntities2();
            int id = int.Parse(Request.QueryString["Id"]);
            var guncelkayit = db.Kategori.Find(id);
            guncelkayit.KategoriAdi = txtKategoriAdi.Text;
            guncelkayit.KategoriAciklama = txtArea.Text;
            db.SaveChanges();
        }
    }
}