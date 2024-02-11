using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities1 db = new DbCvEntityEntities1();
            Repeater1.DataSource = db.SKILLS.ToList();
            Repeater1.DataBind();
        }
    }
}