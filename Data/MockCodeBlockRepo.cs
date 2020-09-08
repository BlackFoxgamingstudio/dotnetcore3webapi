using System.Collections.Generic;
using CodeBlocks.Models;

namespace CodeBlocks.Data
{
    public class MockCodeBlockRepo : ICodeBlockRepo
    {
        public IEnumerable<Code> GetAppCodes()
        {
          var codes = new List<Code>
          {
              new Code{Id=0, HowTo="win at life", Line="do work", Platform="python1"},
              new Code{Id=1, HowTo="loss dont die then win", Line="do slow work", Platform="python2"},
              new Code{Id=2, HowTo="loss but never give up", Line="do great work", Platform="python3"}
          };

          return codes;
        }

        public Code GetCodeById(int id)
        {
            return new Code{Id=0, HowTo="win at life", Line="do work", Platform="python"};
        }

    }
}
