Feature: Google
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	 sessionConfigurationForChromeHeadless = new SessionConfiguration()
                    {
                        Driver = typeof(CustomChromeHeadlessWebDriver),
                        Browser = Coypu.Drivers.Browser.Chrome,
                        AppHost = "https://specflow.org/", // whatever url you want
                        Timeout = TimeSpan.FromSeconds(2)
                    };
                    browser = new BrowserSession(sessionConfigurationForChromeHeadless);
                    browser.ResizeTo(1124, 850);
                    break;


@mytag
Scenario: Acesso a Pagina do Google
	Given que acesso aa pagina do google "https://www.google.com.br/"
	And informo o textoo "Cruzeiro"