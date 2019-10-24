using System.ComponentModel;
using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BL
{
    class Model : INotifyPropertyChanged
    {
        static void Find_pos(IWebDriver path, IWebElement serch, string FindElement)
        {
            
            path = new ChromeDriver();
            path.Navigate().GoToUrl("https://hh.ru/");

            serch = path.FindElement(By.ClassName("bloko-input-wrapper"));
            serch.SendKeys(FindElement + OpenQA.Selenium.Keys.Enter);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
