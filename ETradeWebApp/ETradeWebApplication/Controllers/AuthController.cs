using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETradeWebApplication.Api_Service;
using ETradeWebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETradeWebApplication.Controllers
{
    public class AuthController : Controller
    {
        private AuthApiService _authApiService;
        public AuthController(AuthApiService authApiService)
        {
            _authApiService = authApiService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(AuthListViewModel authListViewModel)
        {
            var accessToken = await _authApiService.LoginAsync(authListViewModel.UserForLoginDto);
            if (accessToken.Success)
            {
                HttpContext.Session.SetString("JWToken", accessToken.Data.Token);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View("Login",accessToken.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(AuthListViewModel authListViewModel)
        {
            var accessToken = await _authApiService.RegisterAsync(authListViewModel.UserForRegisterDto);
            if (accessToken.Success)
            {
                HttpContext.Session.SetString("JWToken", accessToken.Data.Token);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View("Register",accessToken.Message);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
