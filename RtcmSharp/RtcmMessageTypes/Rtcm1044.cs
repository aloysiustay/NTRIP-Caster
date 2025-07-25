using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1042: QZZZ Satellite Ephemeris Data ==============================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
    DF_001_UINT_12     | UINT | 12 |    0    | Message Type   
    QZSS_002_UINT_4    | UINT |  4 |    1    | QZSS Satellite ID                          
    QZSS_003_UINT_16_S | UINT | 16 |  P2_P4  | QZSS toc                                   
    QZSS_004_INT_8_S   | INT  |  8 |  P2_55  | QZSS af2                                   
    QZSS_005_INT_16_S  | INT  | 16 |  P2_43  | QZSS af1                                   
    QZSS_006_INT_22_S  | INT  | 22 |  P2_31  | QZSS af0                                   
    QZSS_007_UINT_8    | UINT |  8 |    1    | QZSS IODE                                  
    QZSS_008_INT_16_S  | INT  | 16 |  P2_5   | QZSS Crs                                   
    QZSS_009_INT_16_S  | INT  | 16 |  P2_43  | QZSS ∆n                                    
    QZSS_010_INT_32_S  | INT  | 32 |  P2_31  | QZSS M0                                    
    QZSS_011_INT_16_S  | INT  | 16 |  P2_29  | QZSS Cuc                                   
    QZSS_012_UINT_32_S | UINT | 32 |  P2_33  | QZSS e                                     
    QZSS_013_INT_16_S  | INT  | 16 |  P2_29  | QZSS Cus                                   
    QZSS_014_UINT_32_S | UINT | 32 |  P2_19  | QZSS A½                                    
    QZSS_015_UINT_16_S | UINT | 16 |  P2_P4  | QZSS toe                                   
    QZSS_016_INT_16_S  | INT  | 16 |  P2_29  | QZSS Cic                                   
    QZSS_017_INT_32_S  | INT  | 32 |  P2_31  | QZSS Ω0                                    
    QZSS_018_INT_16_S  | INT  | 16 |  P2_29  | QZSS Cis                                   
    QZSS_019_INT_32_S  | INT  | 32 |  P2_31  | QZSS i0                                    
    QZSS_020_INT_16_S  | INT  | 16 |  P2_5   | QZSS Crc                                   
    QZSS_021_INT_32_S  | INT  | 32 |  P2_31  | QZSS ω (Argument of Perigee)               
    QZSS_022_INT_24_S  | INT  | 24 |  P2_43  | QZSS ΩDOT (Rate of Right Ascension)       
    QZSS_023_INT_14_S  | INT  | 14 |  P2_43  | QZSS i0-DOT                                
    QZSS_024_BIT_2     | BIT  |  2 |    1    | QZSS Codes on L2 Channel                   
    QZSS_025_UINT_10   | UINT | 10 |    1    | QZSS Week Number                           
    QZSS_026_UINT_4    | UINT |  4 |    0    | QZSS URA                                   
    QZSS_027_UINT_6    | UINT |  6 |    1    | QZSS SV health                             
    QZSS_028_INT_8_S   | INT  |  8 |  P2_31  | QZSS TGD                                   
    QZSS_029_UINT_10   | UINT | 10 |    1    | QZSS IODC                                  
    QZSS_030_BIT_1     | BIT  |  1 |    1    | QZSS Fit Interval                          
	------------------------------------------------------------------------------*/
    public class Rtcm1044 : BaseMessage
    {
        public QZSS_002_UINT_4 m_SatelliteID { get; }
        public QZSS_003_UINT_16_S m_ClockDataReferenceTimeToc { get; }
        public QZSS_004_INT_8_S m_SVClockDriftRateAf2 { get; }
        public QZSS_005_INT_16_S m_SVClockDriftAf1 { get; }
        public QZSS_006_INT_22_S m_SVClockBiasAf0 { get; }
        public QZSS_007_UINT_8 m_IssueOfDataEphemerisIODE { get; }
        public QZSS_008_INT_16_S m_OrbitRadiusCorrectionCrs { get; }
        public QZSS_009_INT_16_S m_MeanMotionDifferenceDeltaN { get; }
        public QZSS_010_INT_32_S m_MeanAnomalyAtReferenceTimeM0 { get; }
        public QZSS_011_INT_16_S m_ArgumentOfLatitudeCorrectionCuc { get; }
        public QZSS_012_UINT_32_S m_Eccentricity { get; }
        public QZSS_013_INT_16_S m_ArgumentOfLatitudeCorrectionCus { get; }
        public QZSS_014_UINT_32_S m_SquareRootOfSemiMajorAxisSqrtA { get; }
        public QZSS_015_UINT_16_S m_TimeOfEphemerisToe { get; }
        public QZSS_016_INT_16_S m_InclinationAngleCorrectionCic { get; }
        public QZSS_017_INT_32_S m_LongitudeOfAscendingNodeOmega0 { get; }
        public QZSS_018_INT_16_S m_InclinationAngleCorrectionCis { get; }
        public QZSS_019_INT_32_S m_InclinationAngleI0 { get; }
        public QZSS_020_INT_16_S m_OrbitRadiusCorrectionCrc { get; }
        public QZSS_021_INT_32_S m_ArgumentOfPerigeeOmega { get; }
        public QZSS_022_INT_24_S m_RateOfRightAscensionOmegaDot { get; }
        public QZSS_023_INT_14_S m_RateOfInclinationAngleIDot { get; }
        public QZSS_024_BIT_2 m_L2ChannelCodes { get; }
        public QZSS_025_UINT_10 m_WeekNumber { get; }
        public QZSS_026_UINT_4 m_UserRangeAccuracyURA { get; }
        public QZSS_027_UINT_6 m_SatelliteHealthStatus { get; }
        public QZSS_028_INT_8_S m_GroupDelayTGD { get; }
        public QZSS_029_UINT_10 m_IssueOfDataClockIODC { get; }
        public QZSS_030_BIT_1 m_FitIntervalFlag { get; }

        public Rtcm1044(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(4);
            m_ClockDataReferenceTimeToc = _bitStream.ReadBitsUnsigned(16);
            m_SVClockDriftRateAf2 = _bitStream.ReadBitsTwosComplement(8);
            m_SVClockDriftAf1 = _bitStream.ReadBitsTwosComplement(16);
            m_SVClockBiasAf0 = _bitStream.ReadBitsTwosComplement(22);
            m_IssueOfDataEphemerisIODE = _bitStream.ReadBitsUnsigned(8);
            m_OrbitRadiusCorrectionCrs = _bitStream.ReadBitsTwosComplement(16);
            m_MeanMotionDifferenceDeltaN = _bitStream.ReadBitsTwosComplement(16);
            m_MeanAnomalyAtReferenceTimeM0 = _bitStream.ReadBitsTwosComplement(32);
            m_ArgumentOfLatitudeCorrectionCuc = _bitStream.ReadBitsTwosComplement(16);
            m_Eccentricity = _bitStream.ReadBitsUnsigned(32);
            m_ArgumentOfLatitudeCorrectionCus = _bitStream.ReadBitsTwosComplement(16);
            m_SquareRootOfSemiMajorAxisSqrtA = _bitStream.ReadBitsUnsigned(32);
            m_TimeOfEphemerisToe = _bitStream.ReadBitsUnsigned(16);
            m_InclinationAngleCorrectionCic = _bitStream.ReadBitsTwosComplement(16);
            m_LongitudeOfAscendingNodeOmega0 = _bitStream.ReadBitsTwosComplement(32);
            m_InclinationAngleCorrectionCis = _bitStream.ReadBitsTwosComplement(16);
            m_InclinationAngleI0 = _bitStream.ReadBitsTwosComplement(32);
            m_OrbitRadiusCorrectionCrc = _bitStream.ReadBitsTwosComplement(16);
            m_ArgumentOfPerigeeOmega = _bitStream.ReadBitsTwosComplement(32);
            m_RateOfRightAscensionOmegaDot = _bitStream.ReadBitsTwosComplement(24);
            m_RateOfInclinationAngleIDot = _bitStream.ReadBitsTwosComplement(14);
            m_L2ChannelCodes = _bitStream.ReadBitsUnsigned(2);
            m_WeekNumber = _bitStream.ReadBitsUnsigned(10);
            m_UserRangeAccuracyURA = _bitStream.ReadBitsUnsigned(4);
            m_SatelliteHealthStatus = _bitStream.ReadBitsUnsigned(6);
            m_GroupDelayTGD = _bitStream.ReadBitsTwosComplement(8);
            m_IssueOfDataClockIODC = _bitStream.ReadBitsUnsigned(10);
            m_FitIntervalFlag = _bitStream.ReadBitsUnsigned(1);
        }
    }
}
