using FeriadoApi.Context;
using FeriadoApi.Entities;
using FeriadoApi.Helpers;
using FeriadoApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace FeriadoApi.Controllers
{
    [ApiController]
    [Route("api/v1/feriado")]
    public class FeriadoController : ControllerBase
    {
        private readonly ILogger<FeriadoController> _logger;
        private FeriadoContext _context;
        private readonly IFeriadoRepository _feriadoRepository;
        private IMapper _mapper;


        public FeriadoController(ILogger<FeriadoController> logger, IFeriadoRepository feriadoRepository, FeriadoContext context, IMapper mapper)
        {
            _logger = logger;
            _feriadoRepository = feriadoRepository;
            _context = context;
            _mapper = mapper;

        }
        [DisableCors]
        [HttpGet("buscar-todos-feriados")]
        public async Task<IActionResult> GetBuscarTodosFeriados()
        {


            var resposta = await HttpHelper.SendRequestRaw("http://dadosbr.github.io/feriados/nacionais.json", HttpMethod.Get);
            var conteudo = await resposta.Content.ReadAsStringAsync();
            var feriado = JsonConvert.DeserializeObject<List<Feriado>>(conteudo);

            foreach (var item in feriado)
            {
                var novaEntidade = new Feriado(item.Date, item.Title, item.Description, item.Legislation, item.Type, item.StartTime, item.EndTime);
                var retorno = await _feriadoRepository.Salvar(novaEntidade);
            }


            return Ok();
        }
        [HttpGet]
        public IEnumerable<Feriado> GetAllFeriados()
        {
             var feriados =  _context.Feriados.ToList();
             return feriados;
        }
        [HttpGet("{id}")]
        public IActionResult  GetFeriadoById(int id)
        {
            Feriado feriado = _context.Feriados.FirstOrDefault(f => f.Id == id);

            if (feriado != null) {
                Feriado feriadoDto = _mapper.Map<Feriado>(feriado);
                return Ok(feriadoDto);
            }

            return NotFound();

            
        }
        [HttpPut("{id}")]
        public IActionResult UpdateFeriado(int id, [FromBody] FeriadoDto dto)
        {
            
            var feriado = _context.Feriados.FirstOrDefault(
                f => f.Id == id);
            if(feriado == null) return NotFound();
            _mapper.Map(dto, feriado);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeriado(int id)
        {
            var feriado = _context.Feriados.FirstOrDefault(
               f => f.Id == id);
            if (feriado == null) return NotFound();
            _context.Remove(feriado);
            _context.SaveChanges(); 
            return NoContent();
        }

    }

}
