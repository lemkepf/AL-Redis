﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace TestWebSite
{
    public partial class Frame1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			  Thread.Sleep(2000); 

			  Session["LastPage"] = "Frame1";
            Session["UtcNow"] = DateTime.UtcNow;
            //Session["BigObject"] = new ExponentiallyChunkyThing(3);

				
        }
    }
}