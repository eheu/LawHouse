using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace UI
{
    class Program
    {
    }

    class Test
    {
        private readonly ICaseRepository _caseRepository;
        public Test(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
            foreach (var @case in _caseRepository.GetAll())
            {
                Console.WriteLine(@case.ClientID);
            }
        }
    }
}
