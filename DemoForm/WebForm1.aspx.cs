using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public int counter
        {
            get
            {
                if (ViewState["counter"] is null)
                {
                    return 0;
                }
                return (int)ViewState["counter"];
            }
            set
            {
                ViewState["counter"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblCounter.Text = counter.ToString();
            counter++;

        }

        public struct StuDetails
        {
            public int sno;
            public string Name;
            public string RollNo;
            public string Email;
            public string DOB;
            public string GPA;
        }
      
      //   public  DemoSchoolUI obj = new DemoSchoolUI();
          //  obj.Rl();
           
       
        
       
   }
}