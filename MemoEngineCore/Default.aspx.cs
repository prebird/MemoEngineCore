using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngineCore
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) //첫 로드 할때만 색 변경
            {
                txtDisplay.BorderColor = System.Drawing.Color.Red;
                txtDisplay.BorderStyle = System.Web.UI.WebControls.BorderStyle.Solid;
                txtDisplay.BorderWidth = 2;
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "안녕하세요";
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "반갑습니다";
        }

        protected void btnOutput_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "종료합니다";
        }
    }
}