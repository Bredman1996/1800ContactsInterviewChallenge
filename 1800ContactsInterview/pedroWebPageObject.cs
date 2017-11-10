using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _1800ContactsInterview
{

    class pedroWebPageObject : PageObject
    {
        public PedroWebPageMap map => new PedroWebPageMap();


        public pedroWebPageObject()
        {

        }

        public void inputUser(string username)
        {
            IWebElement userBox =  _driver.FindElement(map.usernameBox);
            userBox.Clear();
            userBox.SendKeys(username);
        }

        public void inputPass(string password)
        {
            IWebElement passBox = _driver.FindElement(map.passwordBox);
            passBox.Clear();
            passBox.SendKeys(password);
        }

        public void clickSubmit()
        {
            IWebElement submitBtn = _driver.FindElement(map.submitBtn);
            submitBtn.Click();
        }

        public string findText()
        {
            IWebElement bodyText = _driver.FindElement(map.body);
            String Text = bodyText.Text;
            return Text;
        }
    }


}
