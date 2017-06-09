using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;
using Crud.DTO;
using Crud.IServices;
using IData.Interfaces.Query;

namespace Services.Query
{
    public class OutgoingQueryServices : IOutgoingQueryServices
    {
        private readonly IOutgoingQueryRepository _outgoingQueryRepository;
        public OutgoingQueryServices(IOutgoingQueryRepository outgoingQueryRepository)
        {
            _outgoingQueryRepository = outgoingQueryRepository;
        }

        public List<OutgoingDTO> GetAllOutgoings()
        {
            var result = _outgoingQueryRepository.GetAll();
            return result;
        }

        public List<OutgoingDTO> GetCategorizedOutgoing(string categoryName)
        {
            throw new NotImplementedException();
        }

        public OutgoingDTO GetOutgoingById(int outgoingId)
        {
            var result = _outgoingQueryRepository.GetOutgoingById(outgoingId);
            return result;
        }

        public List<OutgoingDTO> GetOutgoingsBeforeTime(TimeSpan when)
        {
            throw new NotImplementedException();
        }
    }
}
