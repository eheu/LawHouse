using AutoFixture;
using AutoFixture.AutoFakeItEasy;
using AutoFixture.Xunit2;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tests
{
    public class AutoFakeItEasyDataAttribute : AutoDataAttribute
    {
        public AutoFakeItEasyDataAttribute()
            : base(() => new Fixture().Customize(new AutoFakeItEasyCustomization()))
        { 
        }
    }
}
