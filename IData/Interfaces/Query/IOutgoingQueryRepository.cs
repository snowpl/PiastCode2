using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Interfaces.Query
{
    public interface IOutgoingQueryRepository
    {
        List<OutgoingDTO> GetAll();
        OutgoingDTO GetOutgoingById(int id);
        List<OutgoingDTO> GetCategorizedOutgoing(string categoryName);
        List<OutgoingDTO> GetOutgoingsBeforeTime(TimeSpan when);
    }
}
