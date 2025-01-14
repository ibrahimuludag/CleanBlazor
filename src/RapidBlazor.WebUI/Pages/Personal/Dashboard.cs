﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using RapidBlazor.WebUI.Shared;
using System.Collections.Generic;

namespace RapidBlazor.WebUI.Pages.Personal
{
    public partial class Dashboard
    {
        [CascadingParameter]
        public MainLayout Layout { get; set; }

        protected override void OnInitialized()
        {
            Layout.BreadcrumbItems = new List<BreadcrumbItem>
            {
                new BreadcrumbItem("Personal", href: "#"),
                new BreadcrumbItem("Dashboard", href: "#"),
            };
        }

        EarningReport[] earningReports = new EarningReport[]
        {
            new EarningReport { Name = "Lunees", Title = "Reactor Engineer", Avatar = "https://avatars2.githubusercontent.com/u/71094850?s=460&u=66c16f5bb7d27dc751f6759a82a3a070c8c7fe4b&v=4", Salary = "$0.99", Severity = Color.Success, SeverityTitle = "Low"},
            new EarningReport { Name = "Mikes-gh", Title = "Developer", Avatar = "https://avatars.githubusercontent.com/u/16208742?s=120&v=4", Salary = "$19.12K", Severity = Color.Secondary, SeverityTitle = "Medium"},
            new EarningReport { Name = "Garderoben", Title = "CSS Magician", Avatar = "https://avatars2.githubusercontent.com/u/10367109?s=460&amp;u=2abf95f9e01132e8e2915def42895ffe99c5d2c6&amp;v=4", Salary = "$1337", Severity = Color.Primary, SeverityTitle = "High"},
         };

        class EarningReport
        {
            public string Avatar;
            public string Name;
            public string Title;
            public Color Severity;
            public string SeverityTitle;
            public string Salary;
        }
    }
}
