// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetRecurringAmountByRecurringInvoiceIdTests
    {
        public static GetRecurringAmountByRecurringInvoiceIdController Fixture()
        {
            GetRecurringAmountByRecurringInvoiceIdController controller = new GetRecurringAmountByRecurringInvoiceIdController(new GetRecurringAmountByRecurringInvoiceIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetRecurringAmountByRecurringInvoiceIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}