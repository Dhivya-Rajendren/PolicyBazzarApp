using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic; // List in C# 

using PolicyBazzarApp.Models;

namespace PolicyBazzarApp.Pages
{
    public class IndexModel : PageModel
    {

        public Policy policy = new Policy();
   
        // On Get method executes with a get request 
        public void OnGet()
        {
            policy = new Policy();

          policy.  policyId = 123;
        policy.    policyDetail = "Children policy for 10-19 years children";
       policy.     policyName = "Children Care";
       policy.     policyType = "Children Policy";



        }
    }
}
