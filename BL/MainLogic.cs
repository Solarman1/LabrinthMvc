using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Labrinth;
using System.Windows;




namespace BL
{
   
    public class MainLog
    {   
        

        
        string textForFind;
        void StartPars()
        {
            IWebDriver driverOne = new ChromeDriver();
            driverOne.Url = "https://hh.ru/";
        }
        
    }
}
