using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormat_ValidContent_ReturnsBoldHtml()
        {
            var helper = new HtmlFormatHelper();
            var content = "Hello";
            var result = helper.GetBoldFormat(content);
            Assert.AreEqual("<b>Hello</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ValidContent_ReturnsItalicHtml()
        {
            var helper = new HtmlFormatHelper();
            var content = "World";
            var result = helper.GetItalicFormat(content);
            Assert.AreEqual("<i>World</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithEmptyList_ReturnsEmptyUl()
        {
            var helper = new HtmlFormatHelper();
            var contents = new List<string>();

            var result = helper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithOneElement_ReturnsSingleLi()
        {
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item1" };

            var result = helper.GetFormattedListElements(contents);

            Assert.AreEqual("<ul><li>Item1</li></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_WithMultipleElements_ReturnsHtmlList()
        {
            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item1", "Item2", "Item3" };

            var result = helper.GetFormattedListElements(contents);

            Assert.AreEqual(
                "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>",
                result
            );
        }
    }
}
