using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities1 db= new DbCvEntityEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.ABOUTME.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.ABOUTME.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.ABOUTME.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.SKILLS.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            contact.NAMESURNAME = TextBox1.Text;
            contact.MAIL = TextBox2.Text;
            contact.SUBJECT = TextBox3.Text;
            contact.MESSAGE = TextBox4.Text;
            db.CONTACT.Add(contact);
            db.SaveChanges();
        }
    }
}