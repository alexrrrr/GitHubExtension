using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GitHubExtension.Tests
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(4,4);
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 9);
        }
    }
}
