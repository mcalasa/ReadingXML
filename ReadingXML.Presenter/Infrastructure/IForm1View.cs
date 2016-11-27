using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ReadingXML.Presenter.Infrastructure
{
    public interface IForm1View
    {
        DataSet Authors { get; set; }
        string Schema { get; set; }
    }
}
