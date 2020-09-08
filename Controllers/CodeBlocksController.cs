using Microsoft.AspNetCore.Mvc;
using CodeBlocks.Data;
using CodeBlocks.Models;
using System.Collections.Generic;

namespace CodeBlocks.Controllers
{
    //api/code
    [Route("api/codes")]
    [ApiController]
    public class CodeBlocksController : ControllerBase
    {
       private readonly ICodeBlockRepo _repository ;
        //       private readonly MockCodeBlockRepo _repository = new MockCodeBlockRepo();

        public CodeBlocksController(ICodeBlockRepo repository)
        {
            _repository = repository;
        }
        //Get api/codes
       [HttpGet]
       public ActionResult <IEnumerable<Code>> GetAllCode()
       {
           var codeItems = _repository.GetAppCodes();

           return Ok(codeItems);

       }
       [HttpGet("{id}")]
       public ActionResult <IEnumerable<Code>> GettCodeById(int id)
       {
            var codeItem = _repository.GetCodeById(id);

           return Ok(codeItem);

       }
    }
}