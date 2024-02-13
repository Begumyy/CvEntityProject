using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class statistic : System.Web.UI.Page
    {
        DbCvEntityEntities1 db= new DbCvEntityEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text=db.SKILLS.Count().ToString();
            Label2.Text=db.CONTACT.Count().ToString();
            Label3.Text=db.SKILLS.Average(x=>x.ID).ToString();
            Label4.Text=db.SKILLS.Max(x=>x.ID).ToString();  
        }
    }
}