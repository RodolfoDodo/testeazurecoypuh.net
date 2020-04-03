using specflow_coypu.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace specflow_coypu.Steps
{
    [Binding]
    public class GoogleSteps
    {
        private GooglePage _googlePage;

        public GoogleSteps(GooglePage googlePage)
        {
            _googlePage = googlePage;
        }

        [Given(@"que acesso aa pagina do google ""(.*)""")]
        public void GivenQueAcessoAaPaginaDoGoogle(string url)
        {
            _googlePage.GetUrl(url);
        }
        
        [Given(@"informo o textoo ""(.*)""")]
        public void GivenInformoOTextoo(string galo)
        {
            _googlePage.informarTexto(galo);
        }
    }
}
