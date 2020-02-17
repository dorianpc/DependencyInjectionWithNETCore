using System.Threading.Tasks;

namespace OrderManagementConsole
{
    public interface IOrderSender
    {
        Task<string> Send(Order order);
    }
}