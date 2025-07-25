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
    GALILEO_008_BIT_8       | BIT  |  8  |     0   | Galileo SV SISA   
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
    GALILEO_031_BIT_2       | BIT  |  2  |     0   | Galileo E5a Signal Health Status        
    GALILEO_032_BIT_1      | BIT  |  1  |     0   | Galileo E5a Data Validity Status        
    RESERVED_BIT_7             
	------------------------------------------------------------------------------*/
    public class Rtcm1045 : BaseMessage
    {
        public GALILEO_002_UINT_6 m_SatelliteID { get; }
        public GALILEO_006_UINT_12 m_WeekNumber { get; }
        public GALILEO_007_UINT_10 m_IssueOfDataNavigationIODnav { get; }
        public GALILEO_008_BIT_8 m_SignalInSpaceAccuracySISA { get; }
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
        public GALILEO_029_INT_10_S m_BroadcastGroupDelayE1E5a { get; }
        public GALILEO_031_BIT_2 m_E5aSignalHealthStatus { get; }
        public GALILEO_032_BIT_1 m_E5aDataValidityStatus { get; }
        public RESERVED_BIT_7 m_ReservedBits { get; }
        public Rtcm1045(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(6);
            m_WeekNumber = _bitStream.ReadBitsUnsigned(12);
            m_IssueOfDataNavigationIODnav = _bitStream.ReadBitsUnsigned(10);
            m_SignalInSpaceAccuracySISA = _bitStream.ReadBitsUnsigned(8);
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
            m_BroadcastGroupDelayE1E5a = _bitStream.ReadBitsTwosComplement(10);
            m_E5aSignalHealthStatus = _bitStream.ReadBitsUnsigned(2);
            m_E5aDataValidityStatus = _bitStream.ReadBitsUnsigned(1);
            m_ReservedBits = _bitStream.ReadBitsUnsigned(7);
        }
    }
}
