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
            List<Outgoing> tempList = new List<Outgoing>();
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 2,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 52.2296760,
                    longitude = 21.0122290
                },
                Id = 1
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6829932,
                    longitude = 17.8717630
                },
                Id = 2
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6817152,
                    longitude = 17.8773205
                },
                Id = 3
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6813617,
                    longitude = 17.8838865
                },
                Id = 4
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 2,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6766028,
                    longitude = 17.9055159
                },
                Id = 5
            });
            var entity = tempList.Select(x => x);
            var result = new List<OutgoingDTO>();
            foreach (var outgoing in entity)
            {
                result.Add(outgoing.Map());
            }
            return result;
        }

        public OutgoingDTO GetOutgoingById(int id)
        {
            List<Outgoing> tempList = new List<Outgoing>();
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 2,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 52.2296760,
                    longitude = 21.0122290
                },
                Id = 1
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6829932,
                    longitude = 17.8717630
                },
                Id = 2
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6817152,
                    longitude = 17.8773205
                },
                Id = 3
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6813617,
                    longitude = 17.8838865
                },
                Id = 4
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 2,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6766028,
                    longitude = 17.9055159
                },
                Id = 5
            });
            var entity = tempList.Select(x => x).Where(x => x.Id == id).FirstOrDefault();
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
            List<Outgoing> tempList = new List<Outgoing>();
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 2,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 52.2296760,
                    longitude = 21.0122290
                },
                Id = 1
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6829932,
                    longitude = 17.8717630
                },
                Id = 2
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 3,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6817152,
                    longitude = 17.8773205
                },
                Id = 3
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 5,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6813617,
                    longitude = 17.8838865
                },
                Id = 4
            });
            tempList.Add(new Outgoing()
            {
                CreateDate = DateTime.Now,
                MaxPeople = 2,
                MinPeople = 1,
                OutgoingLocalization = new Localization()
                {
                    Latitude = 50.6766028,
                    longitude = 17.9055159
                },
                Id = 5
            });
            var entity = tempList.Select(x => x);
            var result = new List<OutgoingDTO>();
            foreach (var outgoing in entity)
            {
                var item = new OutgoingDTO();
                item.OutgoingLocalization = new LocalizationDTO();
                item.OutgoingLocalization.Latitude = outgoing.OutgoingLocalization.Latitude;
                item.OutgoingLocalization.longitude = outgoing.OutgoingLocalization.longitude;
                item.Id = outgoing.Id;
                result.Add(item);
            }
            return result;
        }
    }
}
