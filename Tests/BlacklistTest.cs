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
            //Create a blacklist
            var blacklist = new Blacklist
            {
                Type = BlacklistType.country,
                Data = "ru",
                Note = "They steal your lands"
            };

            var createBl = sellix.CreateBlacklist(blacklist);
            Assert.Equal(200, createBl.Status);
            Assert.NotNull(createBl.Data.UniqueId);

            //Get all blacklists
            var allBl = sellix.GetBlacklists();
            Assert.Equal(200, allBl.Status);
            Assert.NotNull(allBl.Data.Blacklists[0]);

            //edit blacklist
            blacklist.Data = "us";
            var editBl = sellix.UpdateBlacklist(blacklist, createBl.Data.UniqueId);
            Assert.Equal(200, editBl.Status);

            //get and check for edit
            var checkBl = sellix.GetBlacklist(createBl.Data.UniqueId);
            Assert.Equal(200, checkBl.Status);
            Assert.NotNull(checkBl.Data.Blacklist.UniqueId);
            Assert.Equal("us", checkBl.Data.Blacklist.Data);

            //delete all blacklists
            foreach (var bl in allBl.Data.Blacklists)
            {
               Assert.Equal(200, sellix.DeleteBlacklist(bl.UniqueId).Status);
            }    
        }
    }
}
