﻿using BUPA_Demo.Model;
using BUPA_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUPA_Demo
{
    public partial class PublicProgramDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProgramRepository objProgramRepository = new ProgramRepository();

            if (HttpUtility.UrlDecode(Request.QueryString["id"].ToString()) != null)
            {
                List<Program> program = new List<Program>();
                program.Add(objProgramRepository.GetByProgramID(Convert.ToInt32(HttpUtility.UrlDecode(Request.QueryString["id"].ToString()))));
                RepeaterProgram.DataSource = program;
                RepeaterProgram.DataBind();
            }

        }
    }
}