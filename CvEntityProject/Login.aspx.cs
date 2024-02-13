using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DbCvEntityEntities1 db = new DbCvEntityEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu= from x in db.ADMIN where x.USERNAME==TextBox1.Text && x.SIFRE==TextBox2.Text select x;
            if(sorgu.Any())
            {
                Response.Redirect("Contact.aspx");
            }
            //sorgu.Any anlamı: eger sorgunun icerisinde birsey varsa yani x isminde bir degisken olusturduk ama eger bu x degiskeni username ve sifreye textbox'lardan gelen degerlerle eslestirebiliyorsam o zaman sorgunun sonucunda bana Any methodu birsey dondurecektir yani icerisinde birsey olacaktir.
            else
            {
                Response.Write("Wrong Username or Password. Please try again!!");
            }
        }
    }
}