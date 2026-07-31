#nullable disable
#pragma warning disable
﻿namespace JBig2Decoder.NETStandard
{
    internal class ExtensionSegment : Segment
    {

        public ExtensionSegment(JBIG2StreamDecoder streamDecoder) : base(streamDecoder) { }

        public override void ReadSegment()
        {
            for (int i = 0; i < GetSegmentHeader().GetSegmentDataLength(); i++)
            {
                decoder.Readbyte();
            }
        }
    }
}
