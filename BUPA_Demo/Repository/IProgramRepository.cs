using BUPA_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUPA_Demo.Repository
{
    interface IProgramRepository
    {
        IEnumerable<Program> GetPublicProgram();

        IEnumerable<Program> GetPrivateProgram();

        Program GetByProgramID(int ProId);
             
    }
}
