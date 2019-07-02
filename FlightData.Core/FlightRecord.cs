using System.Collections.Generic;
using System.IO;

namespace FlightData.Core
{
    // https://github.com/daviesian/phantom-decoder
    // https://github.com/mikeemoo/dji-log-parser
    // http://djilogs.live555.com/


    public class FlightRecord
    {
        // some properties here;

        public List<FlightFrame> FlightFrames
        {
            get;
        } = new List<FlightFrame>();

        public FlightRecord(byte[] data)
        {
            var ms = new MemoryStream(data);
            ms.Position = 0;

            //ms.r
        }
    }
}
