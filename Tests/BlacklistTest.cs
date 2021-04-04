using System.Net.Http;
using Sellix.Net;
using Sellix.Net.Models.Blacklist;
using Xunit;

namespace Tests
{
    public class BlacklistTest
    {
        private readonly Sellix.Net.Sellix sellix  = new Sellix.Net.Sellix(Token.Get, new HttpClient());
        [Fact]
        public void Test()
        {
            //Create a blacklist.
            var blacklist = new Blacklist
            {
                Type = BlacklistType.country,
                Data = "ru",
                Note = "They steal your lands"
            };

            var createBl = sellix.Blacklist.CreateBlacklist(blacklist);
            Assert.Equal(200, createBl.Status);
            Assert.NotNull(createBl.Data.UniqueId);

            //Get all blacklists.
            var allBl = sellix.Blacklist.GetBlacklists();
            Assert.Equal(200, allBl.Status);
            Assert.NotNull(allBl.Data.Blacklists[0]);

            //Edit blacklist.
            blacklist.Data = "us";
            var editBl = sellix.Blacklist.UpdateBlacklist(blacklist, createBl.Data.UniqueId);
            Assert.Equal(200, editBl.Status);

            //Get and check for edit.
            var checkBl = sellix.Blacklist.GetBlacklist(createBl.Data.UniqueId);
            Assert.Equal(200, checkBl.Status);
            Assert.NotNull(checkBl.Data.Blacklist.UniqueId);
            Assert.Equal("us", checkBl.Data.Blacklist.Data);

            //Delete all blacklists.
            foreach (var bl in allBl.Data.Blacklists)
            {
               Assert.Equal(200, sellix.Blacklist.DeleteBlacklist(bl.UniqueId).Status);
            }    
        }
    }
}
