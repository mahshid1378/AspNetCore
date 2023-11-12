﻿using Xunit;
using System.IO;

namespace WishListTests
{
    public class AddExceptionHandlingTests
    {
        [Fact(DisplayName = "Configure Exception Handling @configure-exception-handling")]
        public void UseDeveloperExceptionPageTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "WishList" + Path.DirectorySeparatorChar + "Startup.cs";
            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("app.UseDeveloperExceptionPage();"), "`Startup.cs`'s `Configure` did not contain a call to `UseDeveloperExceptionPage`.");
        }

        [Fact(DisplayName = "Configure Exception Handling @configure-exception-handling")]
        public void UseExceptionHandlerTest()
        {
            var filePath = ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + "WishList" + Path.DirectorySeparatorChar + "Startup.cs";
            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains(@"app.UseExceptionHandler(""/Home/Error"")"), "`Startup.cs`'s `Configure` did not contain a call to `UseExceptionHandler` that redirects to the `Home.Error` action.");
        }
    }
}
