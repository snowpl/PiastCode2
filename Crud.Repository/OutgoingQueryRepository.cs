using IData.Interfaces.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.DTO;
using Crud.Data.Models;
using Crud.Data.Mappings;

namespace Crud.Repository
{
    public class OutgoingQueryRepository : IOutgoingQueryRepository
    {
        private readonly CrudDBContext _dbContext;
        public OutgoingQueryRepository(CrudDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public List<OutgoingDTO> GetAll()
        {
            var entity = _dbContext.Outgoing.Select(x => x);
            var result = new List<OutgoingDTO>();
            foreach (var outgoing in entity)
            {
                result.Add(outgoing.Map());
            }
            return result;
        }

        public OutgoingDTO GetOutgoingById(int id)
        {
            var entity = _dbContext.Outgoing.Select(x => x).Where(x => x.Id == id).FirstOrDefault();
            var result = entity.Map();
            return result;
        }

        public List<OutgoingDTO> GetOutgoingsBeforeTime(TimeSpan when)
        {
            throw new NotImplementedException();
        }

        public List<OutgoingDTO> GetCategorizedOutgoing(string categoryName)
        {
            throw new NotImplementedException();
        }

        public List<OutgoingDTO> GetAllIdAndCoords()
        {
            var entity = _dbContext.Outgoing.Select(x => x);
            var result = new List<OutgoingDTO>();
            foreach (var outgoing in entity)
            {
                var item = new OutgoingDTO();

                item.OutgoingLocalization.Latitude = outgoing.OutgoingLocalization.Latitude;
                item.OutgoingLocalization.longitude = outgoing.OutgoingLocalization.longitude;
                item.Id = outgoing.Id;
                result.Add(item);
            }
            return result;
        }
    }
}
