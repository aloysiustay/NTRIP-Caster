using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1020: GLONASS Ephemerides ========================================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
	DF038:   UINT |  6 |   0   | GLONASS Satellite ID (Satellite Slot Number)
	DF040:   UINT |  5 |   1   | GLONASS Satellite Frequency Channel Number
	DF104:   BIT  |  1 |   0   | GLONASS almanac health
	DF105:   BIT  |  1 |   0   | GLONASS almanac health availability indicator
	DF106:   BIT  |  2 |   0   | GLONASS P1
	DF107:   BIT  | 12 |   0   | GLONASS tk
	DF108:   BIT  |  1 |   0   | GLONASS MSB of Bn word
	DF109:   BIT  |  1 |   0   | GLONASS P2
	DF110:   UINT |  7 |   1   | GLONASS tb
	DF111:   INTS | 24 | P2_20 | GLONASS xn(tb], first derivative
	DF112:   INTS | 27 | P2_11 | GLONASS xn(tb)
	DF113:   INTS |  5 | P2_30 | GLONASS xn(tb), second derivative
	DF114:   INTS | 24 | P2_20 | GLONASS yn(tb), first derivative
	DF115:   INTS | 27 | P2_11 | GLONASS yn(tb)
	DF116:   INTS |  5 | P2_30 | GLONASS yn(tb), second derivative
	DF117:   INTS | 24 | P2_20 | GLONASS zn(tb), first derivative
	DF118:   INTS | 27 | P2_11 | GLONASS zn(tb)
	DF119:   INTS |  5 | P2_30 | GLONASS zn(tb), second derivative
	DF120:   BIT  |  1 |   0   | GLONASS P3");
	DF121:   INTS | 11 |   0   | GLONASS γn(tb) (Relative deviation)
	DF122:   BIT  |  2 |   0   | GLONASS-M P");
	DF123:   BIT  |  1 |   0   | GLONASS-M ln (third string)
	DF124:   INTS | 22 |   0   | GLONASS τn (tb)
	DF125:   INTS |  5 |   0   | GLONASS-M Δτn
	DF126:   UINT |  5 |   1   | GLONASS En
	DF127:   BIT  |  1 |   0   | GLONASS-M P4
	DF128:   UINT |  4 |   0   | GLONASS-M FT
	DF129:   UINT | 11 |   1   | GLONASS-M NT
	DF130:   BIT  |  2 |   0   | GLONASS-M M
	DF131:   BIT  |  1 |   0   | GLONASS The Availability of Additional Data
	DF132:   UINT | 11 |   1   | GLONASS NA
	DF133:   INTS | 32 |   0   | GLONASS τc
	DF134:   UINT |  5 |   0   | GLONASS-M N4
	DF135:   INTS | 22 |   0   | GLONASS-M τGPS
	DF136:   BIT  |  1 |   0   | GLONASS-M ln (fifth string)
	DF001_7: BIT  |  7 |   0   | Reserved 7 BIT, s
	------------------------------------------------------------------------------*/
    public class Rtcm1020 : BaseMessage
    {
        public GLONASS_005_UINT_6 m_SatelliteID { get; }
        public GLONASS_007_UINT_5 m_FrequencyChannelNumber { get; }
        public GLONASS_018_BIT_1 m_AlmanacHealthFlag { get; }
        public GLONASS_019_BIT_1 m_HealthAvailabilityIndicator { get; }
        public GLONASS_020_BIT_2 m_P1Flag { get; }
        public GLONASS_021_BIT_12 m_EpochTime_tk { get; }
        public GLONASS_022_BIT_1 m_BnWordMSB { get; }
        public GLONASS_023_BIT_1 m_P2Flag { get; }
        public GLONASS_024_UINT_7 m_Epoch_tb { get; }
        public GLONASS_025_SINT_24_S m_VelocityX { get; }
        public GLONASS_026_SINT_27_S m_PositionX { get; }
        public GLONASS_027_SINT_5_S m_AccelerationX { get; }
        public GLONASS_028_SINT_24_S m_VelocityY { get; }
        public GLONASS_029_SINT_27_S m_PositionY { get; }
        public GLONASS_030_SINT_5_S m_AccelerationY { get; }
        public GLONASS_031_SINT_24_S m_VelocityZ { get; }
        public GLONASS_032_SINT_27_S m_PositionZ { get; }
        public GLONASS_033_SINT_5_S m_AccelerationZ { get; }
        public GLONASS_034_BIT_1 m_P3Flag { get; }
        public GLONASS_035_SINTS_11 m_FrequencyBiasGamma { get; }
        public GLONASS_036_BIT_2 m_P_MFlag { get; }
        public GLONASS_037_BIT_1 m_LnThirdStringFlag { get; }
        public GLONASS_038_SINT_22 m_SatelliteTimeOffsetTauN { get; }
        public GLONASS_039_SINT_5 m_DeltaTauN { get; }
        public GLONASS_040_UINT_5 m_AgeOfOperationEn { get; }
        public GLONASS_041_BIT_1 m_P4Flag { get; }
        public GLONASS_042_UINT_4 m_FTType { get; }
        public GLONASS_043_UINT_11 m_NavigationMessageFrameNumber_NT { get; }
        public GLONASS_044_BIT_2 m_MIndicator { get; }
        public GLONASS_045_BIT_1 m_AdditionalDataAvailabilityFlag { get; }
        public GLONASS_046_UINT_11 m_AlmanacReferenceNumber_NA { get; }
        public GLONASS_047_SINT_32 m_SystemTimeOffsetTauC { get; }
        public GLONASS_048_UINT_5 m_N4Value { get; }
        public GLONASS_049_SINT m_DeltaTauGPS { get; }
        public GLONASS_050_BIT_1 m_LnFifthStringFlag { get; }
        public RESERVED_BIT_7 m_ReservedBits_7 { get; }
        public Rtcm1020(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(6);
            m_FrequencyChannelNumber = _bitStream.ReadBitsUnsigned(5);
            m_AlmanacHealthFlag = _bitStream.ReadBitsUnsigned(1);
            m_HealthAvailabilityIndicator = _bitStream.ReadBitsUnsigned(1);
            m_P1Flag = _bitStream.ReadBitsUnsigned(2);
            m_EpochTime_tk = _bitStream.ReadBitsUnsigned(12);
            m_BnWordMSB = _bitStream.ReadBitsUnsigned(1);
            m_P2Flag = _bitStream.ReadBitsUnsigned(1);
            m_Epoch_tb = _bitStream.ReadBitsUnsigned(7);

            m_VelocityX = _bitStream.ReadBitsSignMagnitude(24);
            m_PositionX = _bitStream.ReadBitsSignMagnitude(27);
            m_AccelerationX = _bitStream.ReadBitsSignMagnitude(5);
            m_VelocityY = _bitStream.ReadBitsSignMagnitude(24);
            m_PositionY = _bitStream.ReadBitsSignMagnitude(27);
            m_AccelerationY = _bitStream.ReadBitsSignMagnitude(5);
            m_VelocityZ = _bitStream.ReadBitsSignMagnitude(24);
            m_PositionZ = _bitStream.ReadBitsSignMagnitude(27);
            m_AccelerationZ = _bitStream.ReadBitsSignMagnitude(5);

            m_P3Flag = _bitStream.ReadBitsUnsigned(1);
            m_FrequencyBiasGamma = _bitStream.ReadBitsSignMagnitude(11);
            m_P_MFlag = _bitStream.ReadBitsUnsigned(2);
            m_LnThirdStringFlag = _bitStream.ReadBitsUnsigned(1);
            m_SatelliteTimeOffsetTauN = _bitStream.ReadBitsSignMagnitude(22);
            m_DeltaTauN = _bitStream.ReadBitsSignMagnitude(5);
            m_AgeOfOperationEn = _bitStream.ReadBitsUnsigned(5);
            m_P4Flag = _bitStream.ReadBitsUnsigned(1);
            m_FTType = _bitStream.ReadBitsUnsigned(4);
            m_NavigationMessageFrameNumber_NT = _bitStream.ReadBitsUnsigned(11);
            m_MIndicator = _bitStream.ReadBitsUnsigned(2);
            m_AdditionalDataAvailabilityFlag = _bitStream.ReadBitsUnsigned(1);
            m_AlmanacReferenceNumber_NA = _bitStream.ReadBitsUnsigned(11);
            m_SystemTimeOffsetTauC = _bitStream.ReadBitsSignMagnitude(32);
            m_N4Value = _bitStream.ReadBitsUnsigned(5);
            m_DeltaTauGPS = _bitStream.ReadBitsSignMagnitude(22);
            m_LnFifthStringFlag = _bitStream.ReadBitsUnsigned(1);
            m_ReservedBits_7 = _bitStream.ReadBitsUnsigned(7);
        }
    }
}
