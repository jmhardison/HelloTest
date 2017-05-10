using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloTest.Controllers
{
	[Route("api/[controller]")]
	public class HelloController : Controller
	{
		// GET api/values
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				string envTest = Environment.GetEnvironmentVariable("INPUTVAL1");

				if (envTest != null)
				{
					return new JsonResult(("Sorry, you failed."));
				}
				else
				{
					return new JsonResult(("Hello World" + " " + envTest));
				}
			}
			catch (Exception e)
			{
				return new JsonResult(("Sorry, you crashed. " + e.Message.ToString()));
			}
		}
	}
}
