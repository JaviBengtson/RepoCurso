using BengtsonMVC2023.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BengtsonMVC2023.Controllers
{
	public class UserController1 : Controller
	{
		[Route("Users")]

		public async Task<IActionResult> Index()
		{
			var service = new Service1Client();
			var user = await service.GetUserAsync(int.MaxValue);
			
			return View("Index",user);	
		}
		//public IActionResult GetUser()
		//{
		//	var user = new UserClase
		//	{
		//		Nombre="Javier",
		//		Apellido = "Bengtson"			    
		//	 
		//	};
		//   return View("Index",user);
		//}
	}
}
