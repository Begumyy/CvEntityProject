using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class MessageDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities1 db= new DbCvEntityEntities1();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.CONTACT.Find(x);
            TxtNameSurname.Text = mesaj.NAMESURNAME;
            TxtMail.Text = mesaj.MAIL;
            TxtSubject.Text = mesaj.SUBJECT;
            TxtMessage.Text = mesaj.MESSAGE;
        }
    }
}