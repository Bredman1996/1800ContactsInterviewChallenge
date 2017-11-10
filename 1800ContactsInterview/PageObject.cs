using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace _1800ContactsInterview
{
    class PageObject
    {
        protected ChromeDriver _driver;

        public PageObject()
        {
            string path = Directory.GetCurrentDirectory();
            string newpath = "..//..//..//";
            Directory.SetCurrentDirectory(newpath);
            path = Directory.GetCurrentDirectory();
            _driver = new ChromeDriver(path);
        }
        
        public void NavigateToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
