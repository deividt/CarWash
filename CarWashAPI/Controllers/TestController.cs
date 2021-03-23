// ----------------------------------------------------------------------
// <copyright file="TestController.cs" company="Deividt Gemeli">
// Copyright (c) Deividt Gemeli.
// </copyright>
// ----------------------------------------------------------------------

namespace CarWashAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Classe <see cref="TestController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Método Gettest
        /// </summary>
        /// <returns>Retorna OK!"</returns>
        [HttpGet]
        public ActionResult GetTest()
        {
            string retorno = "OK!";

            if (string.IsNullOrEmpty(retorno))
            {
                return this.NotFound();
            }

            return this.Ok(retorno);
        }
    }
}