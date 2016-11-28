using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReadingXML.DbData;
using ReadingXML.MockData;
using ReadingXML.Presenter;
using ReadingXML.Presenter.Infrastructure;

namespace ReadingXML.Webform
{
    public partial class Default : System.Web.UI.Page, IForm1View
    {
        IAuthorsDb mockDb;
        Form1Presenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            mockDb = new MockAuthorsDb();
            _presenter = new Form1Presenter(this, mockDb);
        }

        protected void btnReadXml_Click(object sender, EventArgs e)
        {
            _presenter.GetAuthors();
        }

        protected void btnReadSchema_Click(object sender, EventArgs e)
        {
            _presenter.GetSchema();
        }

        public System.Data.DataSet Authors
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                GridView1.DataSource = value;
                GridView1.DataBind();
            }
        }

        public string Schema
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                TextBox1.Text = value;
            }
        }
    }
}