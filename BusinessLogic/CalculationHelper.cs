using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CalculationHelper
    {
        private readonly ICaseRepository _caseRepository;

        private readonly ICaseServiceRepository _caseServiceRepository;

        public CalculationHelper(ICaseRepository caseRepository, ICaseServiceRepository caseServiceRepository)
        {
            _caseRepository = caseRepository;
            _caseServiceRepository = caseServiceRepository;
        }

        public double CalculateClientPriceSum(Client client)
        {
            List<Case> cases = _caseRepository.GetCasesFromClient(client.ID);
            double clientSum = 0;
            foreach (Case @case in cases)
            {
                double caseSum = CalculateCasePriceSum(@case);
                clientSum += caseSum;
            }
            return clientSum;
        }

        public double CalculateCasePriceSum(Case @case)
        {
            List<CaseService> caseServices = _caseServiceRepository.GetServicesOnCase(@case);
            Dictionary<CaseService,Service> servicesByCaseService = _caseServiceRepository.GetServicesByCaseServiceFromCase(@case);
            double caseSum = 0;
            foreach (CaseService caseService in caseServices)
            {
                Service service = servicesByCaseService[caseService];
                double caseServicePrice = CalculcateCaseServicePrice(service, caseService);
                caseSum += caseServicePrice;
            }
            return caseSum;
        }

        public double CalculcateCaseServicePrice(Service service, CaseService caseService)
        {
            double hoursPrice = service.IsHourly ? caseService.Hours * service.Price : service.Price;
            double kilometresPrice = 4 * caseService.Kilometres;
            return hoursPrice + kilometresPrice;
        }
    }
}
