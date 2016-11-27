using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingXML.Presenter.Infrastructure;
using System.Data;

namespace ReadingXML.UnitTests.Winform.Mocks
{
    public class MockForm1View : IForm1View
    {

        public DataSet Authors { get; set; }
        public string Schema { get; set; }
       
    }
}
