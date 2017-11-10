using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace _1800ContactsInterview
{
    class PedroWebPageMap
    {
        public By usernameBox = By.CssSelector("input[name='username']");
        public By passwordBox = By.CssSelector("input[name='password']");
        public By submitBtn = By.CssSelector("input[type='submit']");
        public By body = By.TagName("body");
        
        public PedroWebPageMap() { }
    }


}
