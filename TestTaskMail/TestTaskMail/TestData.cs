using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestTaskMail
{
    public class TestData
    {
        public string Recipient { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static IEnumerable<TestCaseData> GetTestCaseData()
        {
            var jsonString = File.ReadAllText(
                $"testData.json");
            var testsData = JsonConvert.DeserializeObject<TestData>(jsonString);
            return new List<TestCaseData> { new TestCaseData(testsData.Login, testsData.Password, testsData.Recipient) };
        }
    }
}
