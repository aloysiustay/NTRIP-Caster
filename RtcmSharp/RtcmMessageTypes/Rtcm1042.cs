using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1042: BDS Satellite Ephemeris Data ===============================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
    DF_001_UINT_12     | UINT | 12 |    0    | Message Type  
    DF488 | UINT |  6 |   0   | BDS Satellite ID
	DF489 | UINT | 13 |   1   | BDS Week Number
	DF490 | BIT  |  4 |   1   | BDS URAI
	DF491 | INT  | 14 | P2_43 | BDS IDOT
	DF492 | UINT |  5 |   1,  | BDS AODE
	DF493 | UINT | 17 |   8,  | BDS Toc
	DF494 | INT  | 11 | P2_66 | BDS a2
	DF495 | INT  | 22 | P2_50 | BDS a1
	DF496 | INT  | 24 | P2_33 | BSD a0
	DF497 | UINT |  5 |   1   | BDS AODC
	DF498 | INT  | 18 | P2_6  | BDS Crs
	DF499 | INT  | 16 | P2_43 | BDS ∆n
	DF500 | INT  | 32 | P2_31 | BDS M0
	DF501 | INT  | 18 | P2_31 | BDS Cuc
	DF502 | UINT | 32 | P2_33 | BDS e (Eccentricity)
	DF503 | INT  | 18 | P2_31 | BDS Cus
	DF504 | UINT | 32 | P2_19 | BDS A½
	DF505 | UINT | 17 |   8   | BDS Toe
	DF506 | INT  | 18 | P2_31 | BDS Cic
	DF507 | INT  | 32 | P2_31 | BDS Ω0
	DF508 | INT  | 18 | P2_31 | BDS Cis
	DF509 | INT  | 32 | P2_31 | BDS i0
	DF510 | INT  | 18 | P2_6  | BDS Crc
	DF511 | INT  | 32 | P2_31 | BDS ω (Argument of Perigee)
	DF512 | INT  | 24 | P2_43 | BDS ΩDOT (Rate of Right Ascension)
	DF513 | INT  | 10 |  0.1  | BDS TGD1
	DF514 | INT  | 10 |  0.1  | BDS TGD2
	DF515 | BIT  |  1 |   1   | BSD SV Health
	------------------------------------------------------------------------------*/
    public class Rtcm1042 : BaseMessage
    {
        public BEIDOU_006_UINT_6 m_SatelliteID { get; }
        public BEIDOU_007_UINT_13 m_WeekNumber { get; }
        public BEIDOU_008_BIT_4 m_UserRangeAccuracyIndex { get; }
        public BEIDOU_009_INT_14_S m_InclinationRate { get; }
        public BEIDOU_010_UINT_5 m_AgeOfDataEphemeris { get; }
        public BEIDOU_011_UINT_17_S m_ClockReferenceTimeToc { get; }
        public BEIDOU_012_INT_11_S m_ClockDriftRateA2 { get; }
        public BEIDOU_013_INT_22_S m_ClockDriftA1 { get; }
        public BEIDOU_014_INT_24_S m_ClockBiasA0 { get; }
        public BEIDOU_015_UINT_5 m_AgeOfDataClock { get; }
        public BEIDOU_016_INT_18_S m_RadiusCorrectionCrs { get; }
        public BEIDOU_017_INT_16_S m_MeanMotionDifferenceDeltaN { get; }
        public BEIDOU_018_INT_32_S m_MeanAnomalyAtReferenceTimeM0 { get; }
        public BEIDOU_019_INT_18_S m_LatitudeCorrectionCuc { get; }
        public BEIDOU_020_UINT_32_S m_Eccentricity { get; }
        public BEIDOU_021_INT_18_S m_LatitudeCorrectionCus { get; }
        public BEIDOU_022_UINT_32_S m_RootSemiMajorAxis { get; }
        public BEIDOU_023_UINT_17_S m_EphemerisReferenceTimeToe { get; }
        public BEIDOU_024_INT_18_S m_InclinationCorrectionCic { get; }
        public BEIDOU_025_INT_32_S m_LongitudeOfAscendingNodeOmega0 { get; }
        public BEIDOU_026_INT_18_S m_InclinationCorrectionCis { get; }
        public BEIDOU_027_INT_32_S m_InclinationAtReferenceTimeI0 { get; }
        public BEIDOU_028_INT_18_S m_RadiusCorrectionCrc { get; }
        public BEIDOU_029_INT_32_S m_ArgumentOfPerigeeOmega { get; }
        public BEIDOU_030_INT_24_S m_RateOfRightAscensionOmegaDot { get; }
        public BEIDOU_031_INT_10_S m_GroupDelayTgd1 { get; }
        public BEIDOU_032_INT_10_S m_GroupDelayTgd2 { get; }
        public BEIDOU_033_BIT_1 m_SatelliteHealthFlag { get; }
        public Rtcm1042(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(6);
            m_WeekNumber = _bitStream.ReadBitsUnsigned(13);
            m_UserRangeAccuracyIndex = _bitStream.ReadBitsUnsigned(4);
            m_InclinationRate = _bitStream.ReadBitsTwosComplement(14);
            m_AgeOfDataEphemeris = _bitStream.ReadBitsUnsigned(5);
            m_ClockReferenceTimeToc = _bitStream.ReadBitsUnsigned(17);
            m_ClockDriftRateA2 = _bitStream.ReadBitsTwosComplement(11);
            m_ClockDriftA1 = _bitStream.ReadBitsTwosComplement(22);
            m_ClockBiasA0 = _bitStream.ReadBitsTwosComplement(24);
            m_AgeOfDataClock = _bitStream.ReadBitsUnsigned(5);
            m_RadiusCorrectionCrs = _bitStream.ReadBitsTwosComplement(18);
            m_MeanMotionDifferenceDeltaN = _bitStream.ReadBitsTwosComplement(16);
            m_MeanAnomalyAtReferenceTimeM0 = _bitStream.ReadBitsTwosComplement(32);
            m_LatitudeCorrectionCuc = _bitStream.ReadBitsTwosComplement(18);
            m_Eccentricity = _bitStream.ReadBitsUnsigned(32);
            m_LatitudeCorrectionCus = _bitStream.ReadBitsTwosComplement(18);
            m_RootSemiMajorAxis = _bitStream.ReadBitsUnsigned(32);
            m_EphemerisReferenceTimeToe = _bitStream.ReadBitsUnsigned(17);
            m_InclinationCorrectionCic = _bitStream.ReadBitsTwosComplement(18);
            m_LongitudeOfAscendingNodeOmega0 = _bitStream.ReadBitsTwosComplement(32);
            m_InclinationCorrectionCis = _bitStream.ReadBitsTwosComplement(18);
            m_InclinationAtReferenceTimeI0 = _bitStream.ReadBitsTwosComplement(32);
            m_RadiusCorrectionCrc = _bitStream.ReadBitsTwosComplement(18);
            m_ArgumentOfPerigeeOmega = _bitStream.ReadBitsTwosComplement(32);
            m_RateOfRightAscensionOmegaDot = _bitStream.ReadBitsTwosComplement(24);
            m_GroupDelayTgd1 = _bitStream.ReadBitsTwosComplement(10);
            m_GroupDelayTgd2 = _bitStream.ReadBitsTwosComplement(10);
            m_SatelliteHealthFlag = _bitStream.ReadBitsUnsigned(1);
        }
    }
}
