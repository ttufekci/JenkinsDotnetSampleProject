using Microsoft.AspNetCore.Mvc.Testing;
using SampleWebProject;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RazorPageTests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;

        public UnitTest1(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Test1()
        {
            var response =  await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Contains("Onbirkod", stringResponse);
        }
    }
}
