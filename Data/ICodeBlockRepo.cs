using System.Collections.Generic;
using CodeBlocks.Models;

namespace CodeBlocks.Data 
{
    public interface ICodeBlockRepo
    {
        IEnumerable<Code> GetAppCodes();
        Code GetCodeById(int id);
    }
}