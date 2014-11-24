using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webs.Provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Webs.Provider.Tests
{
    [TestClass()]
    public class SecurityProviderTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            var r = SecurityProvider.Instance.Login("wind", "123456");
            Assert.IsTrue(r.Result);
            Assert.IsNotNull(r.Data);
        }
    }
}
