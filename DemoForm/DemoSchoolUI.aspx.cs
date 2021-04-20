using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoForm
{
    [Serializable]
    public class StuDetails
    {
        public string sno;
        public string Name;
        public string RollNo;
        public string Email;
        public string DOB;
        public string GPA;
    }

    public partial class DemoSchoolUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        const string cJobSeekerNameConst = "JobSeeker_cnst";
         public List<StuDetails> sd
        {

            get
            {
                // If not on the viewstate then add it
                if (ViewState[cJobSeekerNameConst] == null)
                    ViewState[cJobSeekerNameConst] = new List<StuDetails>();

                // this code is not exist on release, but I check to be sure that I did not 
                //  overwrite this viewstate with a different object.
                Debug.Assert(ViewState[cJobSeekerNameConst] is List<StuDetails>);

                return (List<StuDetails>)ViewState[cJobSeekerNameConst];
            }
        }
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
        public StuDetails s;
        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            /*s.sno=counter;
             s.Name = txtname.ToString();
             s.RollNo = txtRN.ToString();
             s.Email = txtEmail.ToString();
             s.DOB = txtDOB.ToString();
             s.GPA = TextGpa.ToString();*/
            counter++;
            sd.Add(new StuDetails() {
            sno = counter.ToString(),
            Name = txtname.Text,
            RollNo = txtRN.Text,
            Email = txtEmail.Text,
            DOB = txtDOB.Text,
            GPA = TextGpa.Text
             
            });

            // lblCounter.Text = sd[0].Name;
            txtname.Text = "";
            txtRN.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";
            TextGpa.Text = "";




        }
        public List<StuDetails> Rl()
        {
            
            return sd;
        }
    }
}