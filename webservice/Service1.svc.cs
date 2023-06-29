using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WordCountServices.src;

namespace WordCountServices
{
    public class MapReduceServices : IMapReduceServices
    {
        public ResponseData Map(RequestData requestData) { return new ResponseData { data = Mapper.Map(requestData.data) }; }

        public ResponseData Reduce(RequestData requestData) { return new ResponseData { data = Reducer.Reduce(requestData.data) }; }

        public ResponseData Combine(RequestData requestData) { return new ResponseData { data = Combiner.Combine(requestData.data) };  }

    }
}
