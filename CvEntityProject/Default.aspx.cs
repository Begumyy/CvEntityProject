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
        DbCvEntityEntities db= new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.ABOUTME.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.ABOUTME.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.ABOUTME.ToList();
            Repeater3.DataBind();
        }
    }
}