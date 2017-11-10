using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace _1800ContactsInterview
{

    [CodedUITest(CodedUITestType.WindowsStore)]
    public class InterviewTests
    {

        [TestMethod]
        public void InterviewTest()
        {
            pedroWebPageObject test = new pedroWebPageObject();
            int i = 1;
            while(i <= 1000){
                test.NavigateToPage("http://www.pedroliska.com/testengineer");
                test.inputUser("billgates");
                test.inputPass(i.ToString());
                test.clickSubmit();
                if (test.findText() == "Invalid username and password combination")
                {
                    test.NavigateToPage("http://www.pedroliska.com/testengineer");
                    i++;
                }
                else
                {
                    string directory = Directory.GetCurrentDirectory() + "//answer.txt";              
                    File.WriteAllText(directory, i.ToString());
                    break;
                }
            }
        }
    }
}