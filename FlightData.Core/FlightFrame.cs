using System;
using System.Collections.Generic;
using System.Text;

namespace FlightData.Core
{
    public class FlightFrame
    {
        public FlightFrameType Type { get; set; }
        public byte PayloadLength { get; set; }

        public byte[] Payload { get; set; }
        //0xFF - Frame delimiter. This isn't really necessary, but it's there anyway.



    }
}
