using Crud.DTO;
using System;
using System.Collections.Generic;

namespace Crud.IServices
{
    public interface IOutgoingQueryServices
    {
        List<OutgoingDTO> GetAllOutgoings();
        OutgoingDTO GetOutgoingById(int outgoingId);
        //zamienic categoryName na enum i przeniesc do commona
        List<OutgoingDTO> GetCategorizedOutgoing(string categoryName);
        List<OutgoingDTO> GetOutgoingsBeforeTime(TimeSpan when);
    }
}