//using BusinessLogic.Interfaces;
//using BusinessLogic.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLogic
//{
//    public class CalculationHelper
//    {
//        private readonly ICaseRepository _caseRepository;

//        private readonly ICaseServiceRepository _caseServiceRepository;

//        public CalculationHelper(ICaseRepository caseRepository, ICaseServiceRepository caseServiceRepository)
//        {
//            _caseRepository = caseRepository;
//            _caseServiceRepository = caseServiceRepository;
//        }

//        public double CalculateClientPriceSum(Client client)
//        {
//            List<Case> cases = _caseRepository.GetCasesFromClient(client.ID);
//            double clientSum = 0;
//            foreach (Case @case in cases)
//            {
//                double caseSum = CalculateCasePriceSum(@case);
//                clientSum += caseSum;
//            }
//            return clientSum;
//        }

//        public double CalculateCasePriceSum(Case @case)
//        {
//            List<CaseService> caseServices = _caseServiceRepository.GetServicesOnCase(@case);
//            Dictionary<CaseService, Service> servicesByCaseService = _caseServiceRepository.GetServicesByCaseServiceFromCase(@case);
//            double caseSum = 0;
//            foreach (CaseService caseService in caseServices)
//            {
//                Service service = servicesByCaseService[caseService];
//                double caseServicePrice = CalculcateCaseServicePrice(service, caseService);
//                caseSum += caseServicePrice;
//            }
//            return caseSum;
//        }

//        public double CalculcateCaseServicePrice(Service service, CaseService caseService)
//        {
//            double hoursPrice = service.IsHourly ? caseService.Hours * service.Price : service.Price;
//            double kilometresPrice = 4 * caseService.Kilometres;
//            return hoursPrice + kilometresPrice;
//        }
//    }
//}

//public class CalculationHelperTests
//{
//    private readonly ITestOutputHelper _output;

//    public CalculationHelperTests(ITestOutputHelper output)
//    {
//        _output = output;
//    }

//    [Theory]
//    [AutoFakeItEasyData]
//    [InlineAutoFakeItEasyData(1, 2, 1)]
//    public void Name(int amountCases, int amountServicesOnCase, int servicePrice,
//        [Frozen]ICaseRepository caseRepository,
//        [Frozen]ICaseServiceRepository caseServiceRepository,
//        CalculationHelper SUT)
//    {
//        //Arrange
//        Client client = A.Fake<Client>();
//        List<Case> casesOnClient = new List<Case>();
//        for (int i = 0; i < amountCases; i++) //param1
//        {
//            casesOnClient.Add(A.Fake<Case>());
//        }
//        A.CallTo(() => caseRepository.GetCasesFromClient(client.ID)).Returns(casesOnClient);

//        List<Service> servicesOnCase = new List<Service>();
//        var fixture = new Fixture();
//        foreach (Case @case in casesOnClient)
//        {
//            for (int i = 0; i < amountServicesOnCase; i++)
//            {
//                Service service = A.Fake<Service>();
//                service.ID = fixture.
//                service.Price = fixture.Create<int>();
//                servicesOnCase.Add(service);
//            }
//            servicesOnCase.ForEach(s => _output.WriteLine("ID: " + s.ID + ", Price: " + s.Price.ToString()));
//            A.CallTo(() => caseServiceRepository.GetServicesOnCase(@case)).Returns(servicesOnCase); ;
//        }


//        public double CalculcateCaseServicePrice(Service service, CaseService caseService)
//        {
//            double hoursPrice = service.IsHourly ? caseService.Hours * service.Price : service.Price;
//            double kilometresPrice = 4 * caseService.Kilometres;
//            return hoursPrice + kilometresPrice;
//        }

//        [Theory]
//    [AutoFakeItEasyData]
//    //[InlineAutoFakeItEasyData(1, 2, 1)]
//    public void Name(Service service, CaseService caseService,
//            [Frozen]ICaseRepository caseRepository,
//            [Frozen]ICaseServiceRepository caseServiceRepository,
//            CalculationHelper SUT)
//    {
//        double hoursPrice = service.IsHourly ? caseService.Hours * service.Price : service.Price;
//        double kilometresPrice = 4 * caseService.Kilometres;
//        double expectedValue = hoursPrice + kilometresPrice;

//        Assert.Equal(SUT.CalculcateCaseServicePrice(service, caseService), expectedValue);
//    }