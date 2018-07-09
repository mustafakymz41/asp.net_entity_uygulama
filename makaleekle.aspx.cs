using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityBlog
{
    public partial class makaleekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    bindKategoriler();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void DrpKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BlogSitesiEntities2 db = new BlogSitesiEntities2();
                int kategoriId = Convert.ToInt32(DrpKategoriler.SelectedValue);
                var kategories = db.Kategori.Where(x => x.KategoriId == kategoriId).ToList();
                BindDropDownList(DrpKategoriler, kategories, "KategoriAdi");
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static void BindDropDownList(DropDownList DropDown, object obj, string DisplayText)
        {
            try
            {
                DropDown.DataSource = obj;
                DropDown.DataTextField = DisplayText;
                DropDown.DataValueField = "KategoriId";
                DropDown.DataBind();
                DropDown.Items.Insert(0, new ListItem("Seçin", "0"));
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

        }
        public void bindKategoriler()
        {
            BlogSitesiEntities2 db = new BlogSitesiEntities2();
            var Kategori = db.Kategori.ToList();
            BindDropDownList(DrpKategoriler, Kategori, "KategoriAdi");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BlogSitesiEntities2 db = new BlogSitesiEntities2();
            Makale makaleAdd = new Makale();
            makaleAdd.KategoriId = Convert.ToInt32(DrpKategoriler.SelectedValue);
            makaleAdd.MakaleBaslik = txtmakaleAdi.Text;
            makaleAdd.MakaleIcerik = txtArea.Text;
            makaleAdd.MakaleEtiketlemeTarihi = DateTime.Parse(txtEtiketTarihi.Text);
            db.Makale.Add(makaleAdd);
            db.SaveChanges();
            Response.Redirect("makaleler.aspx");

        }
    }
}