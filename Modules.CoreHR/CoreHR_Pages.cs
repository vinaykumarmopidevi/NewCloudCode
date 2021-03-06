﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Pages.CoreHR;


namespace Modules.CoreHR
{
    public static class CoreHR_Pages

    {
        
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }

        }

        public static Identification Identification
        {
            get
            {
                var identification = new Identification();
                PageFactory.InitElements(Browser.Driver, identification);
                return identification;
            }

        }

        

        public static PersonInformation PersonInformation
        {
            get
            {
                var personInformation = new PersonInformation();
                PageFactory.InitElements(Browser.Driver, personInformation);
                return personInformation;
            }

        }
        public static EmployementInformation EmployementInformation
        {
            get
            {
                var employementInformation = new EmployementInformation();
                PageFactory.InitElements(Browser.Driver, employementInformation);
                return employementInformation;
            }

        }



        public static SearchPerson SearchPerson
        {
            get
            {
                var searchPerson = new SearchPerson();
                PageFactory.InitElements(Browser.Driver, searchPerson);
                return searchPerson;
            }
        }
        public static void Main(string[] args)
        {

        }
    }
}

