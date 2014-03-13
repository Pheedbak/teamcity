using System;
using System.Collections.Generic;
using FluentAssertions;
using Machine.Specifications;
using Machine.Specifications.Model;
using Rhino.Mocks.Impl.InvocationSpecifications;

namespace ClassLibrary1
{
    [Subject("Testd")]
    public class SomeTests
    {
        Establish context = () =>
        {

            testything = new SomeWork();
        };

        private Because of = () => result = testything.MakeMeTrue();
        private static SomeWork testything;
        private static bool result;

        It should_run_me = () => result.Should().BeTrue();

    }
}
