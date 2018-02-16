using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BUPA_Demo.Model;

namespace BUPA_Demo.Repository
{
    public class ProgramRepository : IProgramRepository
    {

        private Context _context;
        public ProgramRepository()
        {
            Context Context = new Context();
            this._context = Context;
        }

        public Program GetByProgramID(int ProId)
        {
            var program = _context.Programs.SingleOrDefault(x => x.ProgramID == ProId);
            return program;
        }

        public IEnumerable<Program> GetPrivateProgram()
        {
            return _context.Programs.ToList().Where(x => x.IsPaidProgram == true);
        }

        public IEnumerable<Program> GetPublicProgram()
        {
            return _context.Programs.ToList().Where(x => x.IsPaidProgram == false);
        }
    }
}