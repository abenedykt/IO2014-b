using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using Xunit;

namespace selenium
{
   public class Program
    {
       public static void Main(string[] args)
    {
     
                
            
        }

       [Fact]
       public void testowy()
       {
           var driver = new ChromeDriver();

           driver.Navigate().GoToUrl("http://webcalculator.apphb.com");
           driver.FindElement(By.Name("A")).SendKeys("3");
           driver.FindElement(By.Name("B")).SendKeys("5");
           driver.FindElement(By.Name("Add")).Click();
           string test = driver.FindElement(By.TagName("h4")).Text;
           driver.Close();
           Assert.Equal("15", test);

       }

    }
}
