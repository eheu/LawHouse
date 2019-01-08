using AutoFixture.Xunit2;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BusinessLogic.Tests
{
    public class CalculationHelperTests
    {
        //private readonly ITestOutputHelper _output;

        //public CalculationHelperTests(ITestOutputHelper output)
        //{
        //    _output = output;
        //}

        [Theory]
        [AutoFakeItEasyData]
        public void CanCalculateCaseServicePrice(Service service, CaseService caseService, CalculationHelper SUT)
        {
            //Arrange
            double hoursPrice = service.IsHourly ? caseService.Hours * service.Price : service.Price;
            double kilometresPrice = 4 * caseService.Kilometres;
            double expectedValue = hoursPrice + kilometresPrice;

            //Act
            double calculatedValue = SUT.CalculcateCaseServicePrice(service, caseService);

            //Assert
            Assert.Equal(calculatedValue, expectedValue);
        }

        [Theory]
        [InlineAutoFakeItEasyData(null)]
        [InlineAutoFakeItEasyData(null, null)]
        public void CannotCalculateNullCaseServicePrice(Service service, CaseService caseService, CalculationHelper SUT)
        {
            //Act/Assert
            Assert.Throws<NullReferenceException>(() => SUT.CalculcateCaseServicePrice(service, caseService));
        }

        [Theory]
        [AutoFakeItEasyData]
        public void CanCalculateCasePrice(Case @case,
            Dictionary<CaseService, Service> servicesByCaseService,
            [Frozen]ICaseServiceRepository caseServiceRepository,
            CalculationHelper SUT)
        {
            //Arrange
            A.CallTo(() => caseServiceRepository.GetServicesByCaseServiceFromCase(@case)).Returns(servicesByCaseService);
            List<CaseService> caseServicesOnCase = servicesByCaseService.Keys.ToList();
            A.CallTo(() => caseServiceRepository.GetServicesOnCase(@case)).Returns(caseServicesOnCase);

            double expectedValue = 0;
            foreach (CaseService caseService in caseServicesOnCase)
            {
                Service service = servicesByCaseService[caseService];
                double caseServicePrice = SUT.CalculcateCaseServicePrice(service, caseService);
                expectedValue += caseServicePrice;
            }
            //Act
            double calculatedValue = SUT.CalculateCasePrice(@case);

            //Assert
            Assert.Equal(calculatedValue, expectedValue);
        }
    }
}
