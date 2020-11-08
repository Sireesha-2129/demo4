using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAutoma
{
    class Assertion
    {
        public void ValidateTextwithPath2(object element, String text)
        {
            Assert.IsTrue(element.ToString() != null && element.ToString().Contains(text));
        }
        public void ValidateNotNull(object element)
        {
            Assert.IsNotNull(element);
        }
        public void ValidateNotNullByText(String text)
        {
            Assert.IsNotNull(text);
        }
        public void ValidateNull(object element)
        {
            Assert.IsNull(element);
        }
        public void ValidateNullByText(String text)
        {
            Assert.IsNull(text);
        }

        public void ValidateTextwithPath(object element, String text)
        {
            Assert.AreEqual(element.ToString().ToLower(), text.ToLower());
        }
        public void ValidateByRetrieving(object element1, object element2)
        {
            Assert.AreEqual(element1, element2);
        }
    }
}
