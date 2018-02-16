using BUPA_Demo.Model;
using BUPA_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUPA_Demo.Private
{
    public partial class Privateprogram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRepeator();
            }
        }

        public void BindRepeator()
        {
            ProgramRepository objProgramRepository = new ProgramRepository();
            List<Program> program = new List<Program>();
            program = objProgramRepository.GetPrivateProgram().ToList();
            PublicRepeator.DataSource = program;
            PublicRepeator.DataBind();

        }
    }
}