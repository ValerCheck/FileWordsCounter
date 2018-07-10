using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileWordsCounter.Tests
{
    [TestClass]
    public class FileWordsCounterTest
    {
        [TestMethod]
        public void GetWordsAndCountsFromTextWithTextProcessorAndGetCorrectValues()
        {
            string input = "Go do that thing that you do so well";
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                {"Go", 1 },
                {"do", 2 },
                {"that", 2 },
                {"thing", 1 },
                {"you", 1 },
                {"so", 1 },
                {"well", 1 }
            };

            Dictionary<string, int> actual;

            actual = TextProcessor.GetWordsAndCountsFromText(input);

            Assert.AreEqual(expected["Go"], actual["Go"]);
            Assert.AreEqual(expected["do"], actual["do"]);
            Assert.AreEqual(expected["that"], actual["that"]);
            Assert.AreEqual(expected["thing"], actual["thing"]);
            Assert.AreEqual(expected["you"], actual["you"]);
            Assert.AreEqual(expected["so"], actual["so"]);
            Assert.AreEqual(expected["well"], actual["well"]);
        }

        [TestMethod]
        public void TryOpenFileAndGetContent()
        {
            string fileName = @".\TestFiles\Test.txt";
            string expectedContent = "Go do that thing that you do so well";
            string content = null;

            if (FileProcessor.TryGetFileContent(fileName, out content))
            {
                Assert.IsFalse(String.IsNullOrEmpty(content));
                Assert.AreEqual(expectedContent, content);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
