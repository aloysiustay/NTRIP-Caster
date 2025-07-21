using Caster.Parser;
using RtcmSharp.RtcmDatafields;

namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1006: Stationary RTK Reference Station ARP =======================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
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
	DF_006_UINT_16_S  | UINT | 16 | 0.0001 | Antenna Height
	------------------------------------------------------------------------------*/
    internal class Rtcm1006 : Rtcm1005 
    {
        public DF_006_UINT_16_S m_AntennaHeight { get; }
        public Rtcm1006(Bitstream _bitStream) : base(_bitStream)
        {
            m_AntennaHeight = (ushort)_bitStream.ReadBitsUnsigned(16);
        }
    }
}
