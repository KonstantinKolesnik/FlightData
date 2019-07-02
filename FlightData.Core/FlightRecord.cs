using System.Collections.Generic;
using System.IO;

namespace FlightData.Core
{
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
