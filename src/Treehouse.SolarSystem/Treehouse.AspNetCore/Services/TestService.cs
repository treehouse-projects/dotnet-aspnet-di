using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treehouse.AspNetCore.Services
{
    public class TestService : ITestService
    {
        public string GetAboutContent()
        {
            return "Here's the About view content from the TestService service!";
        }
    }
}
