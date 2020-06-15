using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test2class
{
    class Tests : Base

    {
        const string selectorsButtonCss =    "#menu-item-106 > a";
        const string introductionButtonCss = "#menu-item-25 > a";
        const string introductionTextCss =   "#page-17 > header > h1";
        const string searchTextBoxCss =      "#search-2 > form > label > input";
        const string imageAlertCss =         "#main-content > article > div.mh-loop-thumb > a > img";
        const string imageNameXpath =        "/html/body/div/div[2]/div/article[1]/div[1]/a/img";
        const string categoryId =            "cat";
        const string categoryTestCaseXpath = "/html/body/div/div[2]/aside/div[3]/select/option[6]";
        const string titleTestCaseCss =      "#main-content > header > h1";
        const string testScenarionButtonCss = "#menu-item-58 > a";
        const string loginFormXpath =        "/html/body/div/div[2]/div/article[1]/div[2]/header/h3/a";
        const string userIdCss = "#post-72 > div > form > ul > li:nth-child(2) > input[type=text]";
        const string USERNAME = "Username001";
        public void Test1()
        {
            IWebElement selectorsButton = FindElementByCss(selectorsButtonCss, "Selectors Button");
            VerifyElementDisplayed(selectorsButton, "Selectors Button");
            VerifyElementValue(selectorsButton, "SELECTORS");
            selectorsButton.Click();
            Thread.Sleep(200);

            IWebElement imageName = FindElementByXpath(imageNameXpath, "imageName");
            VerifyElementDisplayed(imageName, "ImageName");

            IWebElement introductionButton = FindElementByCss(introductionButtonCss, "Introduction Button");
            VerifyElementDisplayed(introductionButton, "Introduction Button");
            VerifyElementValue(introductionButton, "INTRODUCTION");
            introductionButton.Click();
            Thread.Sleep(200);

            IWebElement introductionText = FindElementByCss(introductionTextCss, "Introduction Text");
            VerifyElementDisplayed(introductionText, "Introduction Text");
            VerifyElementValue(introductionText, "Introduction");

            IWebElement searchTextBox = FindElementByCss(searchTextBoxCss, "Search Text Box");
            VerifyElementDisplayed(searchTextBox, "Search Text Box");
            searchTextBox.SendKeys("alert");
            searchTextBox.SendKeys(Keys.Enter);
            Thread.Sleep(200);

            IWebElement imageAlert = FindElementByCss(imageAlertCss, "Image Alert");
            VerifyElementDisplayed(imageAlert, "Image Alert");
        }

        public void Test2()
        {
            IWebElement category = FindElementById(categoryId, "category list");
            VerifyElementDisplayed(category, "category list");
            IWebElement categoryTestCase = FindElementByXpath(categoryTestCaseXpath, "category Test Case");
            categoryTestCase.Click();
            Thread.Sleep(1000);
            IWebElement titleTestCase = FindElementByCss(titleTestCaseCss, "title Test Case");
            VerifyElementDisplayed(titleTestCase, "title Test Case");
            VerifyElementValue(titleTestCase, "Test Cases");

            IWebElement testScenario = FindElementByCss(testScenarionButtonCss, "Test Scenario Button");
            testScenario.Click();
            IWebElement loginForm = FindElementByXpath(loginFormXpath, "Login Form");
            loginForm.Click();
            IWebElement userIdbox = FindElementByCss(userIdCss, "userID text box");
            VerifyElementDisplayed(userIdbox, "userID text box");
            userIdbox.SendKeys(USERNAME);
            Thread.Sleep(2000);
        }
    }
}
