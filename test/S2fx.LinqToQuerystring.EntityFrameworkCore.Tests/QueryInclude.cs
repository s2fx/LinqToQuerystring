
namespace LinqToQuerystring.EntityFrameworkCore.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using LinqToQuerystring;
    using Machine.Specifications;

    public class QueryInclude
    {
        Establish context = () =>
        {
            Value = 1;
        };

        public class Test1
        {
            private Because of = () => Value += 1;
            private It should_return_three_results = () => Value.ShouldBeGreaterThan(1);
        }

        static int Value;
    }
}
