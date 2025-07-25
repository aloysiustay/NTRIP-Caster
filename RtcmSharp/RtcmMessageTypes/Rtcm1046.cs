using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1042: QZZZ Satellite Ephemeris Data ==============================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	-------------------------------------------------------------------------------- 
    DF_001_UINT_12         | UINT | 12 |    0    | Message Type
    GALILEO_002_UINT_6     |UINT  | 6 |0 |  Galileo Satellite ID 
    GALILEO_006_UINT_12    | UINT | 12  |     1   | Galileo Week Number  
    GALILEO_007_UINT_10     | UINT | 10  |     1   | Galileo IODnav    
    GALILEO_003_BIT_8       | BIT  |  8  |
    GALILEO_009_INT_14_S    | INT  | 14  | P2_43   | Galileo Rate of Inclination (IDOT)   
    GALILEO_010_UINT_14_S   | UINT | 14  |    60   | Galileo toc       
    GALILEO_011_INT_6_S   | INT  |  6  | P2_59   | Galileo af2         
    GALILEO_012_INT_21_S    | INT  | 21  | P2_46   | Galileo af1        
    GALILEO_013_INT_31_S     | INT  | 31  | P2_34   | Galileo af0 
    GALILEO_014_INT_16_S    | INT  | 16  |  P2_5   | Galileo Crs    
    GALILEO_015_INT_16_S    | INT  | 16  | P2_43   | Galileo ∆n    
    GALILEO_016_INT_32_S    | INT  | 32  | P2_31   | Galileo M0     
    GALILEO_017_INT_16_S    | INT  | 16  | P2_29   | Galileo Cuc      
    GALILEO_018_UINT_32_S   | UINT | 32  | P2_33   | Galileo Eccentricity (e)   
    GALILEO_019_INT_16_S    | INT  | 16  | P2_29   | Galileo Cus       
    GALILEO_020_UINT_32_S   | UINT | 32  | P2_19   | Galileo A½          
    GALILEO_021_UINT_14_S   | UINT | 14  |    60   | Galileo toe         
    GALILEO_022_UINT_16_S    | INT  | 16  | P2_29   | Galileo Cic          
    GALILEO_023_UINT_32_S   | INT  | 32  | P2_31   | Galileo Ω0             
    GALILEO_024_UINT_16_S   | INT  | 16  | P2_29   | Galileo Cis           
    GALILEO_025_UINT_32_S   | INT  | 32  | P2_31   | Galileo i0        
    GALILEO_026_UINT_16_S   | INT  | 16  |  P2_5   | Galileo Crc     
    GALILEO_027_UINT_32_S   | INT  | 32  | P2_31   | Galileo ω (Argument of Perigee)          
    GALILEO_028_UINT_24_S   | INT  | 24  | P2_43   | Galileo ΩDOT          
    GALILEO_029_UINT_10_S   | INT  | 10  | P2_32   | Galileo BGD (E1/E5a)              
    GALILEO_030_UINT_10_S   | UNIT | 10
    GALILEO_033_BIT_2       | BIT  |  2
    GALILEO_034_BIT_1       | BIT  |  1
    GALILEO_004_BIT_2       | BIT  |  2
    GALILEO_005_BIT_1       | BIT  |  1
    RESERVED_BIT_2          | BIT  |  2   

    <RTCM(1046, DF002=1046, DF252=11, DF289=1350, DF290=9, DF286=107, DF292=5.206857167650014e-11, DF293=462600, DF294=0.0, DF295=2.8335023216641275e-10, DF296=-1.4121993444859982e-05, DF297=188.25, DF298=8.698179954080842e-10, DF299=0.65404521394521, DF300=8.73766839504242e-06, DF301=0.0004554599290713668, DF302=1.3969838619232178e-06, DF303=5440.610055923462, DF304=462600, DF305=-3.166496753692627e-08, DF306=0.3712812219746411, DF307=-1.210719347000122e-07, DF308=0.3171015940606594, DF309=321.3125, DF310=0.40829852828755975, DF311=-1.8061427908833139e-09, DF312=-1.4668330550193787e-08, DF313=-1.6065314412117004e-08, DF316=0, DF317=0, DF287=0, DF288=0, DF001_2=0)>
	------------------------------------------------------------------------------*/
    public class Rtcm1046 : BaseMessage
    {
        public GALILEO_002_UINT_6 m_SatelliteID { get; }
        public GALILEO_006_UINT_12 m_WeekNumber { get; }
        public GALILEO_007_UINT_10 m_IssueOfDataNavigationIODnav { get; }
        public GALILEO_003_BIT_8 m_SignalInSpaceAccuracySISA_E1E5b { get; }
        public GALILEO_009_INT_14_S m_RateOfInclinationIDOT { get; }
        public GALILEO_010_UINT_14_S m_ClockDataReferenceTimeToc { get; }
        public GALILEO_011_INT_6_S m_SVClockDriftRateAf2 { get; }
        public GALILEO_012_INT_21_S m_SVClockDriftAf1 { get; }
        public GALILEO_013_INT_31_S m_SVClockBiasAf0 { get; }
        public GALILEO_014_INT_16_S m_RadiusCorrectionCrs { get; }
        public GALILEO_015_INT_16_S m_MeanMotionDifferenceDeltaN { get; }
        public GALILEO_016_INT_32_S m_MeanAnomalyAtReferenceTimeM0 { get; }
        public GALILEO_017_INT_16_S m_ArgumentOfLatitudeCorrectionCuc { get; }
        public GALILEO_018_UINT_32_S m_Eccentricity { get; }
        public GALILEO_019_INT_16_S m_ArgumentOfLatitudeCorrectionCus { get; }
        public GALILEO_020_UINT_32_S m_SqrtOfSemiMajorAxis { get; }
        public GALILEO_021_UINT_14_S m_TimeOfEphemerisToe { get; }
        public GALILEO_022_INT_16_S m_InclinationAngleCorrectionCic { get; }
        public GALILEO_023_INT_32_S m_LongitudeOfAscendingNodeOmega0 { get; }
        public GALILEO_024_INT_16_S m_InclinationAngleCorrectionCis { get; }
        public GALILEO_025_INT_32_S m_InclinationAngleI0 { get; }
        public GALILEO_026_INT_16_S m_RadiusCorrectionCrc { get; }
        public GALILEO_027_INT_32_S m_ArgumentOfPerigeeOmega { get; }
        public GALILEO_028_INT_24_S m_RateOfRightAscensionOmegaDot { get; }
        public GALILEO_029_INT_10_S m_BroadcastGroupDelay_E1E5a { get; }
        public GALILEO_030_INT_10_S m_BroadcastGroupDelay_E5bE1 { get; }
        public GALILEO_033_BIT_2 m_SOLNAVSignalHealthStatus { get; }
        public GALILEO_034_BIT_1 m_SOLNAVDataValidityStatus { get; }
        public GALILEO_004_BIT_2 m_E1BSignalHeaBthStatus { get; }
        public GALILEO_005_BIT_1 m_E1BDataValidityStatus { get; }
        public RESERVED_BIT_2 m_ReservedBits { get; }
        public Rtcm1046(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(6);
            m_WeekNumber = _bitStream.ReadBitsUnsigned(12);
            m_IssueOfDataNavigationIODnav = _bitStream.ReadBitsUnsigned(10);
            m_SignalInSpaceAccuracySISA_E1E5b = _bitStream.ReadBitsUnsigned(8);
            m_RateOfInclinationIDOT = _bitStream.ReadBitsTwosComplement(14);
            m_ClockDataReferenceTimeToc = _bitStream.ReadBitsUnsigned(14);
            m_SVClockDriftRateAf2 = _bitStream.ReadBitsTwosComplement(6);
            m_SVClockDriftAf1 = _bitStream.ReadBitsTwosComplement(21);
            m_SVClockBiasAf0 = _bitStream.ReadBitsTwosComplement(31);
            m_RadiusCorrectionCrs = _bitStream.ReadBitsTwosComplement(16);
            m_MeanMotionDifferenceDeltaN = _bitStream.ReadBitsTwosComplement(16);
            m_MeanAnomalyAtReferenceTimeM0 = _bitStream.ReadBitsTwosComplement(32);
            m_ArgumentOfLatitudeCorrectionCuc = _bitStream.ReadBitsTwosComplement(16);
            m_Eccentricity = _bitStream.ReadBitsUnsigned(32);
            m_ArgumentOfLatitudeCorrectionCus = _bitStream.ReadBitsTwosComplement(16);
            m_SqrtOfSemiMajorAxis = _bitStream.ReadBitsUnsigned(32);
            m_TimeOfEphemerisToe = _bitStream.ReadBitsUnsigned(14);
            m_InclinationAngleCorrectionCic = _bitStream.ReadBitsTwosComplement(16);
            m_LongitudeOfAscendingNodeOmega0 = _bitStream.ReadBitsTwosComplement(32);
            m_InclinationAngleCorrectionCis = _bitStream.ReadBitsTwosComplement(16);
            m_InclinationAngleI0 = _bitStream.ReadBitsTwosComplement(32);
            m_RadiusCorrectionCrc = _bitStream.ReadBitsTwosComplement(16);
            m_ArgumentOfPerigeeOmega = _bitStream.ReadBitsTwosComplement(32);
            m_RateOfRightAscensionOmegaDot = _bitStream.ReadBitsTwosComplement(24);
            m_BroadcastGroupDelay_E1E5a = _bitStream.ReadBitsTwosComplement(10);
            m_BroadcastGroupDelay_E5bE1 = _bitStream.ReadBitsTwosComplement(10);

            m_SOLNAVSignalHealthStatus = _bitStream.ReadBitsUnsigned(2);
            m_SOLNAVDataValidityStatus = _bitStream.ReadBitsUnsigned(1);
            m_E1BSignalHeaBthStatus = _bitStream.ReadBitsUnsigned(2);
            m_E1BDataValidityStatus = _bitStream.ReadBitsUnsigned(1);

            m_ReservedBits = _bitStream.ReadBitsUnsigned(2);
        }
    }
}
