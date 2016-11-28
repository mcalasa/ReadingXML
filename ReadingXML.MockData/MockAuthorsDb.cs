using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ReadingXML.DbData;

namespace ReadingXML.MockData
{
    public class MockAuthorsDb : IAuthors
    {
        private DataSet _authorDataset;
        
        public MockAuthorsDb()
        {
            _authorDataset = new DataSet();
            _authorDataset.ReadXmlSchema(@"C:\Projects\ReadingXML\ReadingXML.MockData\XML\authors.xsd");            
        }

        public DataSet GetAuthors()
        {
            string fileName = @"C:\Projects\ReadingXML\ReadingXML.MockData\XML\authors.xml";
            _authorDataset.ReadXml(fileName);

            //Linq to DataSet example
            //DataTable dt = _authorDataset.Tables["authors"];
            //var query = dt.AsEnumerable().Where(c => c.Field<bool>("contract") == false);

            return _authorDataset;           
        }
    }
}
