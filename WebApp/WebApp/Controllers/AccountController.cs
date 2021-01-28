using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : BaseController
	{
		private readonly ApplicationDbContext _context;

		public AccountController(ApplicationDbContext context):base(context)
		{
			_context = context;
		}


		[HttpGet]
		public ActionResult Registro()
		{
			return View();
		}
		[HttpPost]
		public async Task<ActionResult> Registro(string email,
												 string password,
												 int RolID,
												 string primer_nombre,
												 string segundo_nombre,
												 string primer_apellido,
												 string segundo_apellido,
												 string tipo_identificacion,
												 string identificacion,
												 string sexo,
												 string EstadoId)
		{

			var usuario = await _context.usuarios.FirstOrDefaultAsync(x => x.Email == email);
			if (usuario == null)
			{

				var estadoId = "A";

				usuario = new Usuario()
				{
					Email = email,
					contrasena = password,
					primer_nombre = primer_nombre,
					segundo_nombre = segundo_nombre,
					primer_apellido = primer_apellido,
					segundo_apellido = segundo_apellido,
					tipo_identificacion = tipo_identificacion,
					identificacion = identificacion,
					sexo = sexo,
					EstadoId = estadoId
				};

				_context.Add(usuario);
				_context.SaveChanges();

				EnviarCorreo(email, primer_nombre);// para enviar correo

			}
			else
			{
				if (usuario.Email.Equals(email))
				{

					ViewBag.Message = "Ya existe un usuario con este correo, Por favor vuelva a intentarlo.";
					return View();
				}
			}

			return RedirectToAction("Login");
		}
		// GET: AccountController
		[HttpGet]
		public async Task<ActionResult> Login()
		{
			await LogOff();

			return View();
		}
		[HttpPost]
		public async Task<ActionResult> Login(string email, string password)
		{
			var usr = await _context.usuarios
				.Where(u => u.Email == email && u.EstadoId != "E")
				.FirstOrDefaultAsync();

			if (usr == null)
			{
				ViewBag.Login = "El usuario indicado no existe";
				return View();
			}
			
			if (usr.contrasena.Equals(password))
			{
				var claims = new[] {
					new Claim(ClaimTypes.NameIdentifier,email),
					new Claim(ClaimTypes.Name, usr.primer_nombre),
				};

				var identity = new ClaimsIdentity(claims, "CookieAuth");
				var principal = new ClaimsPrincipal(identity);
				await HttpContext.SignInAsync("CookieAuth", principal);

				return RedirectToAction("Index", "Books");
			}


			ViewBag.Login = "Contraseña incorrecta";
			return View();
		}

		[Microsoft.AspNetCore.Authorization.Authorize]
		public async Task<ActionResult> LogOff()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		public string EnviarCorreo(string correo, string nombre)
		{
			var mensaje = "Cumplido";


			MailMessage Correo = new MailMessage();
			Correo.From = new MailAddress("Library@gmail.com");
			Correo.To.Add(correo);
			Correo.Subject = ("Bienvenido a  Library");
			Correo.Body = "Saludos, Te damos la Bienvenida a Library:" + "     " + nombre;
			Correo.Priority = MailPriority.Normal;

			SmtpClient ServerEmail = new SmtpClient();
			ServerEmail.Credentials = new NetworkCredential("Library@gmail.com", "Library1538");
			ServerEmail.Host = "smtp.gmail.com";
			ServerEmail.Port = 587;
			ServerEmail.EnableSsl = true;
			try
			{
				ServerEmail.Send(Correo);
			}
			catch (Exception e)
			{
				Console.Write(e);
			}
			Correo.Dispose();
			return mensaje;
		}

		public static Usuario GetCurrentUser(IPrincipal user, ApplicationDbContext context)
		{
			var usr = user as ClaimsPrincipal;
			var email = usr.FindFirst(ClaimTypes.NameIdentifier)?.Value;

			var currentUser = context.usuarios
				.Where(u => u.EstadoId != "I")
				.FirstOrDefault(u => u.Email == email);

			return currentUser;
		}
	}
}
