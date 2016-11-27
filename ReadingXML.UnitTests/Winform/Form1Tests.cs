using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ReadingXML.UnitTests.Winform.Mocks;
using ReadingXML.Presenter;
using ReadingXML.MockData;


namespace ReadingXML.UnitTests.Winform
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void GetAuthors_ReturnsCountGreaterThanZero()
        {
            var authorsDb = new MockAuthors();
            var view = new MockForm1View();
            var presenter = new Form1Presenter(view, authorsDb);

            //Notifying the presenter
            presenter.GetAuthors();

            //Verify that the view is updated
            Assert.Greater(view.Authors.Tables.Count, 0);
        }

        [Test]
        public void GetSchema_ReturnsStringGreaterThanZero()
        {
            var authorsDb = new MockAuthors();
            var view = new MockForm1View();
            var presenter = new Form1Presenter(view, authorsDb);

            presenter.GetSchema();

            Assert.Greater(view.Schema.Length, 0);
        }
    }
}
