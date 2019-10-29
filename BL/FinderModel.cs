using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BL
{
   public class FinderModel : BaseModel
    {
        private string textNameOfVacancy;
        IWebElement serch;
        IWebDriver path;

        public string TextNameOfVacancy
        {
            get { return textNameOfVacancy; }
            set
            {
                textNameOfVacancy = value;
                OnPropertyChanged("TextNameOfVacancy");
            }
        }

       
        private void Find_pos(string FindElement)
        {
            path = new ChromeDriver();
            path.Navigate().GoToUrl("https://hh.ru/");

            serch = path.FindElement(By.ClassName("bloko-input-wrapper"));
            serch.SendKeys(FindElement + Keys.Enter);
        }

        public FinderModel(string textName)
        {
            textNameOfVacancy = textName;
            Find_pos(textName);
        }

    }
}
