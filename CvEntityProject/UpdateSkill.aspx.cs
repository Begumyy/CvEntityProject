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
            var deger =db.SKILLS.Find(x);
            TextBox1.Text = deger.SKILL; //bir yetenek derecesi vardi birde yetenegin kendisi vardi var deger dedik ve deger isminde bir degisken olusturduk, bu deger isimli degisken de o yetenegin satirini bulacak ve daha sonra o satirdaki degeri yazdiracak.

        }
    }
}