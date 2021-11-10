using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desk.Tests
{
    public class PencilShould
    {
        [Fact]
        public void WriteStrings()
        {
            var paper = new Paper();
            var pencil = new Pencil();

            pencil.Write("Test String", paper);

            paper.Content.ShouldBe("Test String");
        }

        [Fact]
        public void AddNewStringsToExisting()
        {
            var paper = new Paper();
            var pencil = new Pencil();

            pencil.Write("Welcome to", paper);
            paper.Content.ShouldBe("Welcome to");

            pencil.Write(" the jungle!", paper);
            paper.Content.ShouldBe("Welcome to the jungle!");
        }
    }
}
