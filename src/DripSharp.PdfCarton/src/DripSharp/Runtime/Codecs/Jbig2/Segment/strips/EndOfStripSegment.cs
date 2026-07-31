#nullable disable
#pragma warning disable
﻿namespace JBig2Decoder.NETStandard
{
    internal class EndOfStripeSegment : Segment
    {

        public EndOfStripeSegment(JBIG2StreamDecoder streamDecoder) : base(streamDecoder) { }

        public override void ReadSegment()
        {
            for (int i = 0; i < this.GetSegmentHeader().GetSegmentDataLength(); i++)
            {
                decoder.Readbyte();
            }
        }
    }
}
