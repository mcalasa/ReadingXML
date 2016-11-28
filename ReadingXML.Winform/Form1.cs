using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadingXML.DbData;
using ReadingXML.MockData;
using ReadingXML.Presenter;
using ReadingXML.Presenter.Infrastructure;

namespace ReadingXML.Winform
{
    public partial class Form1 : Form, IForm1View
    {
        IAuthorsDb authorsDB;
        Form1Presenter presenter;

        public Form1()
        {
            InitializeComponent();

            //Change to either the mock data or production data. 
            //Uncomment for mock data so you can debug
            authorsDB = new MockAuthorsDb();

            //Uncomment for production data
            //authorsDB = new AuthorsDb();

            presenter = new Form1Presenter(this, authorsDB);
        }

        private void ReadXMLButton_Click(object sender, EventArgs e)
        {
            presenter.GetAuthors();
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            presenter.GetSchema();
        }

        public DataSet Authors
        {
            get
            {
                return (DataSet)dataGridView1.DataSource;
            }
            set
            {
                dataGridView1.DataSource = value;
                dataGridView1.DataMember = "authors";
            }
        }

        public string Schema
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;

            }
        }
    }
}
