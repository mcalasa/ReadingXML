using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ReadingXML.Presenter.Infrastructure;
using ReadingXML.DbData;

namespace ReadingXML.Presenter
{
    public class Form1Presenter
    {
        private IForm1View _view;
        private IAuthorsDb _authorsDb;

        public Form1Presenter(IForm1View view, IAuthorsDb authorsDb)
        {
            _view = view;
            _authorsDb = authorsDb;
        }

        public void GetAuthors()
        {
            _view.Authors = _authorsDb.GetAuthors();
        }

        public void GetSchema()
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            _authorsDb.GetAuthors().WriteXmlSchema(swXML);
            _view.Schema = swXML.ToString();
        }
    }
}
