using System.Security.Cryptography.X509Certificates;
using Crud.Data.Models;

namespace IData.Interfaces.Command
{
    public interface IOutgoingCommandRepository
    {
        void AddEditOutgoing(Outgoing outgoing );
        void DeleteOutgoing(int id);
    }
}