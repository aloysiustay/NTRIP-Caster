using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
using RtcmSharp.RtcmDataFields;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1075: ==============================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	-------------------------------------------------------------------------------- 
    DF_001_UINT_12         | UINT | 12 |    0    | Message Type
    DF_002_UINT_12         | UINT | 12 |    0   | Reference Station ID
    GPS_001_UINT_30        | UINT | 30 |    1    | GPS Epoch Time (TOW - the number of seconds since the start of the current GPS week)
    GNSS_028_BIT_1         | BIT  |  1 |    0    | MSM Multiple message bit
    GNSS_044_UINT_3        | UINT |  3 |    1    | IODS - Issue Of Data Station
    RESERVED_BIT_7         | BIT  |  7 |    0    | Reserved 7 BIT, s
    GNSS_045_UINT_2        | UINT |  2 |    0    | Clock Steering Indicator
    GNSS_046_UINT_2        | UINT |  2 |    0    | External Clock Indicator
    GNSS_050_BIT_1         | BIT  |  1 |    0    | GNSS Smoothing Type Indicator
    GNSS_051_BIT_3         | BIT  |  3 |    0    | GNSS Smoothing Interval
    GNSS_029_BIT_64        | BIT  | 64 |    0    | GNSS Satellite mask

	------------------------------------------------------------------------------*/
    public class Rtcm1075 : BaseMessage
    {
        public DF_002_UINT_12 m_StationID { get; }
        public GPS_001_UINT_30 m_EpochTimeTOW { get; }
        public GNSS_028_BIT_1 m_MsnMultipleMessageFlag { get; }
        public GNSS_044_UINT_3 m_IssueOfDataStation { get; }
        public RESERVED_BIT_7 m_ReservedBits { get; }
        public GNSS_045_UINT_2 m_ClockSteeringIndicator { get; }
        public GNSS_046_UINT_2 m_ExternalClockIndicator { get; }
        public GNSS_050_BIT_1 m_GnssSmoothingTypeIndicator { get; }
        public GNSS_051_BIT_3 m_GnssSmoothingInterval {  get; }
        public GNSS_029_BIT_64 m_GnssSatelliteMask { get; }
        public int m_NumberOfSatellites { get; }
        public GNSS_030_BIT_32 m_GnssSignalMask { get; }
        public int m_NumberOfSignals { get; }
        public GNSS_031_UINT_X m_GnssCellMask { get; }
        public int m_NumberOfCells { get; }
        public List<RtcmPRN> m_PRNs { get; }
        public List<RtcmCell> m_Cells { get; }
        public Rtcm1075(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_StationID = _bitStream.ReadBitsUnsigned(12);
            m_EpochTimeTOW = _bitStream.ReadBitsUnsigned(30);
            m_MsnMultipleMessageFlag = _bitStream.ReadBitsUnsigned(1);
            m_IssueOfDataStation = _bitStream.ReadBitsUnsigned(3);
            m_ReservedBits = _bitStream.ReadBitsUnsigned(7);
            m_ClockSteeringIndicator = _bitStream.ReadBitsUnsigned(2);
            m_ExternalClockIndicator = _bitStream.ReadBitsUnsigned(2);
            m_GnssSmoothingTypeIndicator = _bitStream.ReadBitsUnsigned(1);
            m_GnssSmoothingInterval = _bitStream.ReadBitsUnsigned(3);

            m_GnssSatelliteMask = _bitStream.ReadBitsUnsigned(64);
            m_NumberOfSatellites = BitstreamUtils.CountBits(m_GnssSatelliteMask.m_RawValue);

            m_GnssSignalMask = _bitStream.ReadBitsUnsigned(32);
            m_NumberOfSignals = BitstreamUtils.CountBits(m_GnssSignalMask.m_RawValue);

            m_GnssCellMask = _bitStream.ReadBitsUnsigned(m_NumberOfSatellites * m_NumberOfSignals);
            m_NumberOfCells = BitstreamUtils.CountBits(m_GnssCellMask.m_RawValue);

            m_PRNs = new List<RtcmPRN>();
            for (byte i = 0; i < 64; ++i)
            {
                if(!BitstreamUtils.CheckBit64MSB(m_GnssSatelliteMask.GetRawValue(), i))
                    continue;
                m_PRNs.Add(new RtcmPRN(_bitStream, (byte)(i + 1), m_PRNs.Count, m_NumberOfSatellites));
            }
            _bitStream.SeekAndSet(m_NumberOfSatellites * (36));

            List<CELLSIG> signalID = new List<CELLSIG>();
            for(byte i = 0; i < 32; ++i)
            {
                if (BitstreamUtils.CheckBit32MSB(m_GnssSignalMask.GetRawValue(), i))
                {
                    signalID.Add(MsmSignalMaps.GPS[i]);
                }
            }
            int m_CellNumber = 0;
            m_Cells = new List<RtcmCell> ();
            for (int i = 0; i < m_PRNs.Count; ++i)
            {
                for(int j = 0; j < signalID.Count; ++j)
                {
                    int index = 64 - m_NumberOfSatellites * m_NumberOfSignals + (i * signalID.Count + j);
                    if (BitstreamUtils.CheckBit64MSB(m_GnssCellMask.GetRawValue(), index))
                        m_Cells.Add(new RtcmCell(_bitStream, m_PRNs[i].m_PseudorandomNoiseNumber.GetRawValue(), signalID[j], m_CellNumber++, m_NumberOfCells));
                }
            }
        }
    }
}
