using System.Threading.Tasks;

namespace OrderManagementConsole
{
    public interface IOrderManager
    {
        public Task<string> Transmit(Order order);
    }
}