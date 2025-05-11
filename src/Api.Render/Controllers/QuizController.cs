using Api.Render.Data;
using Api.Render.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Render.Controllers
{
    [ApiController]
    [Route("quiz")]
    public class QuizController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quiz>>> GetQuizzes()
        {
            return await _context.Quizzes.ToListAsync();
        }

        [HttpGet("{id}/perguntas")]
        public async Task<ActionResult<IEnumerable<Pergunta>>> GetPerguntasDoQuiz(int id)
        {
            var perguntas = await _context.Perguntas
                .Where(p => p.QuizId == id)
                .Include(p => p.Opcoes)
                .ToListAsync();

            if (perguntas == null || perguntas.Count == 0)
                return NotFound("Quiz não encontrado ou sem perguntas.");

            return perguntas;
        }
    }
}
