using System.Net.Http;
using System.Threading.Tasks;
using Thenewboston.Bank.Api.Models;
using Thenewboston.Bank.Models;
using Thenewboston.Common.Api.Models;

namespace Thenewboston.Bank.Api
{
    public interface IBlocksService
    {
        public Task<PaginatedResponseModel<BankBlock>> GetBlocksAsync();
        
        public Task<HttpResponseMessage> PostBlocksAsync(Thenewboston.Common.Models.Block block);
    }
}