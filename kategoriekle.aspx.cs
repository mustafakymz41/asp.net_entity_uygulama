using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class kategoriekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                BlogSitesiEntities2 db = new BlogSitesiEntities2();
                Kategori kategori = new Kategori();
                kategori.KategoriAdi = txtKategoriAdi.Text;
                kategori.KategoriAciklama = txtArea.Text;
                db.Kategori.Add(kategori);
                db.SaveChanges();
                Response.Redirect("kategoriler.aspx");


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}