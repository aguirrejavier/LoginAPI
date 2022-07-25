using AutenticacionAPI.Data;
using AutenticacionAPI.Dtos;
using AutenticacionAPI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutenticacionAPI.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class LoginController : Controller
    {

        private readonly AutenticacionDb autenticacionDb;
        private readonly IMapper mapper;
        public LoginController(AutenticacionDb autenticacionDb, IMapper mapper)
        {
            this.autenticacionDb = autenticacionDb;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<UsuarioDto>>> Get()
        {
            var usuarios = await autenticacionDb.Usuarios.ToListAsync();

            return mapper.Map<List<UsuarioDto>>(usuarios);
        }
    }
}
