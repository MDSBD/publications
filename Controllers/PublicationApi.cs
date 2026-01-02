using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using publications.Models;
using publications.Repositories;
using publications.Services.Remote;

namespace publications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationApi : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IChercheur _chercheurService;
        public PublicationApi(IUnitOfWork unitOfWork, IChercheur chercheurService)
        {
            _unitOfWork = unitOfWork;
            _chercheurService = chercheurService;
        }

        [HttpGet("all")]
        public IActionResult GetAllPublications()
        {
            var publications = _unitOfWork.buprepo.findAll();
            foreach (var pub in publications)
            {
                foreach (var id in pub.Idchercheurs)
                {
                    pub.Chercheurs.Add(_chercheurService.GetChercheurById(id));

                }
            }
            

            return Ok(publications);
        }

        [HttpPost("add/articles")]
        public IActionResult AddArticle([FromBody] Article article)
        {
            var savedPublication = _unitOfWork.articlerepo.save(article);
            _unitOfWork.Commit();
            return CreatedAtAction(nameof(GetAllPublications), new { id = savedPublication.Id }, savedPublication);
        }

        [HttpPost("add/communication")]
        public IActionResult AddCommunication([FromBody] Communication com)
        {
            var savedPublication = _unitOfWork.communicationrepo.save(com);
            _unitOfWork.Commit();
            return CreatedAtAction(nameof(GetAllPublications), new { id = savedPublication.Id }, savedPublication);
        }


        [HttpGet("all/idcs")]
        public IActionResult getIdchercheurs()
        {
            List<long> ids = new List<long>();
            var publications = _unitOfWork.buprepo.findAll();
            foreach (var pub in publications)
            {
                ids.AddRange(pub.Idchercheurs);
            }
            return Ok(ids.Distinct());
        }
    }
}
