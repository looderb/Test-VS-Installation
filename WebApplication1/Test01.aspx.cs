﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eteach.Toolkit.BaseClasses;

namespace WebApplication1
{
    public partial class Test01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			//Commentaire 1
        }

        protected void DataBaseButton_Click(object sender, EventArgs e)
        {
            Context context = new eteach.Toolkit.BaseClasses.Context();
            DataSet dataSet = new DataSet();

            _BusniessObjects personne = new _BusniessObjects(context);
            personne.Detail(ref dataSet, 87);
            personne.Dispose();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {

                ResultLabel.Text = row["Nom"].ToString();
            }
        }
    }
}