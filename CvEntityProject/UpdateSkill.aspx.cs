using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class UpdateSkill : System.Web.UI.Page
    {
        DbCvEntityEntities1 db=new DbCvEntityEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]); //guncelle butonuna tiladiğimiz zaman aldiğimiz ID QueryString oluyor.
            if(Page.IsPostBack==false)
            { 
            var deger =db.SKILLS.Find(x);
            TextBox1.Text = deger.SKILL; //bir yetenek derecesi vardi birde yetenegin kendisi vardi var deger dedik ve deger isminde bir degisken olusturduk, bu deger isimli degisken de o yetenegin satirini bulacak ve daha sonra o satirdaki degeri yazdiracak.
            }
            //bunu yapmak zorundayiz cunku yetenek guncelleme sayfasinda guncelle butonuna tiklayip tablodaki bir veriyi guncelleyip sonra kaydet'e bastigimizda yine eski haliyle kaliyor. yani sayfa post edilirken ilk halini aliyor once mevcut halini ve mevcut halni yeniden guncelliyor. ayni seyi guncellemis oluyor bu yuzden herhangi bir guncelleme olmuyor.

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.SKILLS.Find(x);
            deger.SKILL = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("MySkills.aspx");
        }
    }
}