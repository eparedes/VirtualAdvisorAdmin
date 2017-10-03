﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirtualAdvisorDAL;

namespace VirtualAdvisorDataApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = VirtualAdvisorDB.GetInstance.Students.ToList();
            gvStudents.DataSource = students;
            gvStudents.DataBind();
        }
    }
}