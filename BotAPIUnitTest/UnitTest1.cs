using BotAPI.Requests;
using BotAPI.Responses;
using BotAPI.Types;
using System;
using Xunit;

namespace BotAPIUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedUser = new User
            {
                Id = 1866937452,
                IsBot = true,
                FirstName = "Test Bot",
                Username = "sulpak_test_bot",
                CanJoinGroups = true,
                CanReadAllGroupMessages = false,
                SupportsInlineQueries = false
            };

            var exptectedResponse = new Response<User> { Ok = true, Result = expectedUser };

            var actualResponse = RequestHandler.MakeRequest<User>(new GetMeRequest());

            Assert.Equal(exptectedResponse.Result.Id, actualResponse.Result.Id);
            Assert.Equal(exptectedResponse.Result.IsBot, actualResponse.Result.IsBot);
            Assert.Equal(exptectedResponse.Result.FirstName, actualResponse.Result.FirstName);
            Assert.Equal(exptectedResponse.Result.LastName, actualResponse.Result.LastName);
            Assert.Equal(exptectedResponse.Result.Username, actualResponse.Result.Username);
            Assert.Equal(exptectedResponse.Result.LanguageCode, actualResponse.Result.LanguageCode);
            Assert.Equal(exptectedResponse.Result.CanJoinGroups, actualResponse.Result.CanJoinGroups);
            Assert.Equal(exptectedResponse.Result.CanReadAllGroupMessages, actualResponse.Result.CanReadAllGroupMessages);
            Assert.Equal(exptectedResponse.Result.SupportsInlineQueries, actualResponse.Result.SupportsInlineQueries);

            Assert.Equal(exptectedResponse.Ok, actualResponse.Ok);
        }
    }
}
