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

        public List<OutgoingDTO> GetOutgoingsFromDistance(double lan, double lon, double maxDistance)
        {
            var allCordinatesAndIds = _outgoingQueryRepository.GetAllIdAndCoords();

            var idList = new List<int>();
            foreach(var id in allCordinatesAndIds)
            {
                if (distance(id.OutgoingLocalization.Latitude, id.OutgoingLocalization.longitude, lan, lon) < maxDistance)
                    idList.Add(id.Id);
            }

            var result = new List<OutgoingDTO>();

            foreach(int someid in idList) { 
                var item = _outgoingQueryRepository.GetOutgoingById(someid);
                if(item!=null)
                result.Add(item);
            }

            return result;
        }

        private double distance(double lat1, double lon1, double lat2, double lon2)
        {
            //distance in KM
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            dist = dist * 1.609344;
            return (dist);
        }

        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
    }
}
