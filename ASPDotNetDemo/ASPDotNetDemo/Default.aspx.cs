using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNetDemo
{
    public partial class _Default : Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string data = TextBox1.Text;

        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            string data = TextBox1.Text;

        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            string data = TextBox1.Text;

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            if (!IsCrossPagePostBack)
            {

            }
        }



        /*   protected void Page_LoadComplete(object sender, EventArgs e)
           {
               string data = TextBox1.Text;

           }*/

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.BorderColor = System.Drawing.Color.Purple;
            TextBox1.BorderWidth = 3;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }


    }
}