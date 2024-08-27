using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Ana Geremias", "anageremiias@gmail.com", 3492);

            Aluno a2 = new Aluno(2, "Ana Clara", "anaclara@gmail.com", 3489);

            Aluno a3 = new Aluno(3, "Livia Solla", "liviasolla@gmail.com", 3689);

            Aluno a4 = new Aluno(4, "Beatriz Nascimento", "beanascimento@gmail.com", 4503);

            Aluno a5 = new Aluno(5, "Mariano Dias", "marianodias@gmail.com", 5478);


            List<Aluno> listaAluno = new List<Aluno>();
            listaAluno.Add(a1);
            listaAluno.Add(a2);
            listaAluno.Add(a3);
            listaAluno.Add(a4);
            listaAluno.Add(a5);



            return View(listaAluno);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }


    }
}
