
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using web_api_empresa.Models;
namespace web_api_empresa.Controllers{
[Route("api/[controller]")]
    public class ClientesController : Controller {
        private Conexion dbConexion;
        public ClientesController(){ dbConexion = Conectar.Create();}
       
        [HttpGet]
        public ActionResult Get() {return Ok(dbConexion.Clientes.ToArray());}
        }
        }