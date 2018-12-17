using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BusinessLogic.Tests
{
    public class InlineAutoFakeItEasyDataAttribute : CompositeDataAttribute
    {
        public InlineAutoFakeItEasyDataAttribute(params object[] values) 
            : base(new InlineDataAttribute(values), new AutoFakeItEasyDataAttribute())
        {
        }
    }
}
