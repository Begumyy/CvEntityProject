using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class DeleteSkill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities1 db = new DbCvEntityEntities1();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk =db.SKILLS.Find(x);
            db.SKILLS.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("MySkills.aspx");
        }
    }
}