using FBTarjetaCreedito.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBTarjetaCreedito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    {
        // Creamos una variable de lectura

        private readonly ApplicationDbContext _context;


        // Creamos un constructor

        public TarjetaController(ApplicationDbContext context)
        {

            _context = context;



        }



        // GET: api/<TarjetaController>
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            try
            {

                var listTarjetas = await _context.TarjetaCredito.ToListAsync();
                return Ok(listTarjetas);

            }
            catch (Exception ex)
            {

               return BadRequest(ex.Message);       
            }
        }



        /*********************************************************/




      
        // POST api/<TarjetaController>
        [HttpPost]
        public async Task<IActionResult>  Post([FromBody] TarjetaCredito tarjeta)
        {

            try
            {
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(tarjeta);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }




        }


        /**************************************************************/



        // PUT api/<TarjetaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarjetaCredito tarjeta)
        {


            try
            {

                if (id != tarjeta.Id)
                {

                    return NotFound();
                }

                _context.Update(tarjeta);
                await _context.SaveChangesAsync();
                return Ok( new { message = "Tarjeta editada Correctamente!"});


              
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }






        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                // Esta variablebusca la coincidencia
                var tarjeta = await _context.TarjetaCredito.FindAsync(id);

                
                if(tarjeta == null)
                {
                    return NotFound();

                }

                _context.TarjetaCredito.Remove(tarjeta);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Tarjeta Eliminada Correctamente" + tarjeta });


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }
    }
}
