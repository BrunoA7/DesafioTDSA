using ClienteCrud.web.Data;
using ClienteCrud.web.Models;
using ClienteCrud.web.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClienteCrud.web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public ClientesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Add(AddClienteViewModel viewModel) 
        {
            var cliente = new Cliente
            {
                CLI_NOME = viewModel.CLI_NOME,
                CLI_DATANASCIMENTO = viewModel.CLI_DATANASCIMENTO,
                CLI_ATIVO = viewModel.CLI_ATIVO,
            };

            await dbContext.Clientes.AddAsync(cliente);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Clientes");
        }


        [HttpGet]
        public async Task<IActionResult> List()
        {
            var clientes = await dbContext.Clientes.ToListAsync();

            return View(clientes);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await dbContext.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente viewModel) 
        {
            var cliente = await dbContext.Clientes.FindAsync(viewModel.CLI_ID);

            if (cliente is not null)
            {
                cliente.CLI_NOME = viewModel.CLI_NOME;
                cliente.CLI_DATANASCIMENTO = viewModel.CLI_DATANASCIMENTO;
                cliente.CLI_ATIVO = viewModel.CLI_ATIVO;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Clientes");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Cliente viewModel)
        {
            var cliente = await dbContext.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CLI_ID == viewModel.CLI_ID);

            if (cliente is not null) {
                dbContext.Clientes.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Clientes");
        }
    }
}
