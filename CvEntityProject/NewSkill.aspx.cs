using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class NewSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DbCvEntityEntities1 db = new DbCvEntityEntities1();
        protected void Button1_Click(object sender, EventArgs e)
        {
            SKILLS skills = new SKILLS();
            skills.SKILL = TextBox1.Text;
            db.SKILLS.Add(skills);
            db.SaveChanges();
            Response.Redirect("MySkills.aspx");

        }
    }
}