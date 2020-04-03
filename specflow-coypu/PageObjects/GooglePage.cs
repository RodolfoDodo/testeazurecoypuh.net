using specflow_coypu.WebDrivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace specflow_coypu.PageObjects
{
    public class GooglePage
    {
        private BrowserSessionManager _browserSessionManager;

        public GooglePage(BrowserSessionManager browserSessionManager)
        {
            _browserSessionManager = browserSessionManager;
        }

        string nome = "input[name=q]";

        public void GetUrl(string url)
        {
            _browserSessionManager.Browser().Visit(url);
            Thread.Sleep(5000);
            Assert.AreEqual("Google", _browserSessionManager.Browser().Title);
        }

        public void informarTexto(string texto)
        {
            _browserSessionManager.Browser().FindCss(nome).SendKeys(texto);
        }
    }
}