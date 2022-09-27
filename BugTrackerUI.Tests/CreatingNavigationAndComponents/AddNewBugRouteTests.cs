﻿using BugTrackerUI.Tests;
using HtmlAgilityPack;
using System.IO;
using Xunit;

namespace M2_BugTrackerUI.Tests.CreatingNavigationAndComponents
{
    public class M2_07_AddNewBugRouteTests
    {
        [Fact(DisplayName = "Add the NewBug Friendly Route @add-newbug-friendly-route")]
        public void AddNewBugRouteTest()
        {
            var filePath = TestHelpers.GetRootString() + "BugTrackerUI"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "NewBug.razor";

            Assert.True(File.Exists(filePath), "`NewBug.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            Assert.True(doc.DocumentNode.InnerText.Contains("@page \"/new-bug\""),
                "The NewBug component should contain the `@page` directive with a value of \"/new-bug\"");
        }
    }
}
