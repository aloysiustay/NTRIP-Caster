using Caster.Parser;
using RtcmSharp.RtcmDatafields;

namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1005: Stationary RTK Reference Station ARP =======================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
    DF_001_UINT_12    | UINT | 12 |    0   | Message Type      
	DF_002_UINT_12    | UINT | 12 |    0   | Reference Station ID
	GNSS_002_UINT_6   | UINT |  6 |    0   | ITRF Realization Year
	GNSS_003_BIT_1    | BIT  |  1 |    0   | GPS Indicator
	GNSS_004_BIT_1    | BIT  |  1 |    0   | GLONASS Indicator
	GNSS_005_BIT_1    | BIT  |  1 |    0   | Galileo Indicator
	DF_031_BIT_1      | BIT  |  1 |    0   | Reference-Station Indicator
    DF_003_INT_38_S   | INT  | 38 | 0.0001 | Antenna Ref. Point, ECEF-X
	DF_032_BIT_1      | BIT  |  1 |    0   | Single Receiver Oscillator Indicator
	RESERVED_BIT_1    | BIT  |  1 |    0   | Reserved 1 BIT
	DF_004_INT_38_S   | INT  | 38 | 0.0001 | Antenna Ref. Point, ECEF-Y
	GNSS_006_BIT_2    | BIT  |  2 |    0   | Quarter Cycle Indicator
	DF_005_INT_38_S   | INT  | 38 | 0.0001 | Antenna Ref. Point, ECEF-Z
	------------------------------------------------------------------------------*/
    internal class Rtcm1005 : BaseMessage
    {
        public DF_002_UINT_12 m_StationID { get; }
        public GNSS_002_UINT_6 m_ItrfYear { get; }
        public GNSS_003_BIT_1 m_GpsIndicator { get; }
        public GNSS_004_BIT_1 m_GlonassIndicator { get; }
        public GNSS_005_BIT_1 m_GalileoIndicator { get; }
        public DF_031_BIT_1 m_ReferenceStationIndicator { get; }
        public DF_003_INT_38_S m_AntennaECEF_X { get; }
        public DF_032_BIT_1 m_SingleReceiverOscillatorIndicator { get; }
        public RESERVED_BIT_1 m_ReservedBit { get; }
        public DF_004_INT_38_S m_AntennaECEF_Y { get; }
        public GNSS_006_BIT_2 m_QuarterCycleIndicator { get; }
        public DF_005_INT_38_S m_AntennaECEF_Z { get; }
        public Rtcm1005(Bitstream _bitStream)
        {
            m_MessageType = (ushort)_bitStream.ReadBitsUnsigned(12);
            m_StationID = (ushort)_bitStream.ReadBitsUnsigned(12);
            m_ItrfYear = (byte)_bitStream.ReadBitsUnsigned(6);
            m_GpsIndicator = (byte)_bitStream.ReadBitsUnsigned(1);
            m_GlonassIndicator = (byte)_bitStream.ReadBitsUnsigned(1);
            m_GalileoIndicator = (byte)_bitStream.ReadBitsUnsigned(1);
            m_ReferenceStationIndicator = (byte)_bitStream.ReadBitsUnsigned(1);
            m_AntennaECEF_X = _bitStream.ReadBitsTwosComplement(38);
            m_SingleReceiverOscillatorIndicator = (byte)_bitStream.ReadBitsUnsigned(1);
            m_ReservedBit = (byte)_bitStream.ReadBitsUnsigned(1);
            m_AntennaECEF_Y = _bitStream.ReadBitsTwosComplement(38);
            m_QuarterCycleIndicator = (byte)_bitStream.ReadBitsUnsigned(2);
            m_AntennaECEF_Z = _bitStream.ReadBitsTwosComplement(38);
        }
    }
}
