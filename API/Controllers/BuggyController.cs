using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound();

        }

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ProblemDetails { Title = "Acesta este un request gresit" });

        }

        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized()
        {
            return Unauthorized();

        }

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "Prima eroare");
            ModelState.AddModelError("Problem2", "A doua eroara");
            return ValidationProblem();

        }

        [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("Eroare de server");

        }
    }
}