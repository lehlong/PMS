using AutoMapper;
using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Commons.Mapping;
using PROJECT.Service.Dtos.AD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PROJECT.Service.Dtos.MD
{
    public class T_MD_VEHICLE_Dto : IMapFrom
    {
        public string CODE { get; set; }
        public string TRANSUNIT_CODE { get; set; }
        public string UNIT { get; set; }
        public bool ACTIVE { get; set; }
        public string OIC_PBATCH { get; set; }
        public string OIC_PTRIP { get; set; }
        public decimal CAPACITY { get; set; }
        public string TRANSMODE_CODE { get; set; }

        [JsonIgnore]
        public virtual ICollection<T_MD_VEHICLE_COMPARTMENT> VehicleCompartment { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<T_MD_VEHICLE, T_MD_VEHICLE_Dto>().ReverseMap();
        }
    }
}
