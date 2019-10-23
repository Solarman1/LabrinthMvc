using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Labrinth;


namespace BL
{
    class Finder 
    {
        public void Find_pos(IWebDriver path, IWebElement serch, string FindElement)
        {
            Labrinth.MainWindow T;
            

            path = new ChromeDriver();
            path.Navigate().GoToUrl("https://hh.ru/");

            serch = path.FindElement(By.ClassName("bloko-input-wrapper"));
            serch.SendKeys(FindElement + OpenQA.Selenium.Keys.Enter);
        }
    }
}
