using RtcmSharp.RtcmDataFields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1019: GPS Ephemerides ============================================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
	DF009: UINT	|  6 |   0   | GPS Satellite ID
	DF076: UINT | 10 |   0   | GPS Week number
	DF077: BIT  |  4 |   0   | GPS SV Acc. (URA)
	DF078: BIT  |  2 |   1   | GPS CODE ON L2
	DF079: INT  | 14 | P2_43 | GPS IDOT (Issue of Data, Time) 
	- (These values are provided in semicircles, multiply by π to use in orbit computations)
	DF071: UINT |  8 |   1	 | GPS IODE
	DF081: UINT | 16 | P2_P4 | GPS toc (Reference Time, Clock)
	DF082: INT	|  8 | P2_55 | GPS af2 (Clock correction drift rate)
	DF083: INT  | 16 | P2_43 | GPS af1 (Clock correction drift)
	DF084: INT  | 22 | P2_31 | GPS af0 (Clock correction bias)
	DF085: UINT | 10 |	 1   | GPS IODC (Issue of Data, Clock)
	DF086: INT  | 16 | P2_5  | GPS Crs (Amplitude of sine harmonic correction term to the orbit, radius)
	DF087: INT  | 16 | P2_43 | GPS ∆n (Mean motion difference from computed value)
	- (These values are provided in semicircles, multiply by π to use in orbit computations)
	DF088: INT  | 32 | P2_31 | GPS M0 (Mean Anomaly)
	- (These values are provided in semicircles, multiply by π to use in orbit computations)
	DF089: INT  | 16 | P2_29 | GPS Cuc (Amplitude of cosine harmonic correction term to argument oflatitude)
	DF090: UINT | 32 | P2_33 | GPS e (Eccentricity)
	DF091: INT	| 16 | P2_29 | GPS Cus (Amplitude of sine harmonic correction term to argument oflatitude)
	DF092: UINT | 32 | P2_19 | GPS A½ (Square root of Semi-major Axis)
	DF093: UINT | 16 | P2_P4 | GPS toe (Reference Time, Ephemeris)
	DF094: INT  | 16 | P2_29 | GPS Cic (Amplitude of cosine harmonic correction term to angle addField(ofinclination)
	DF095: INT  | 32 | P2_31 | "GPS Ω0 (Longitude of Ascending Node)
	- These values are provided in semicircles, multiply by π to use in orbit, computations
	DF096: INT  | 16 | P2_29 | GPS Cis (Amplitude of sine harmonic correction term to angle ofinclination)
	DF097: INT  | 32 | P2_31 | GPS i0 (Inclination)
	- These values are provided in semicircles, multiply by π to use in orbit, computations
	DF098: INT  | 16 | P2_5  | GPS Crc (Amplitude of cosine harmonic correction term to orbit,  radius)
	DF099: INT  | 32 | P2_31 | GPS ω (Argument of Perigee)
	-These values are provided in semicircles, multiply by π to use in orbit, computations
	DF100: INT  | 24 | P2_43 | GPS ΩDOT (Rate of Change of Right Ascension)
	- These values are provided in semicircles, multiply by π to use in orbit, computations
	DF101: INT  |  8 | P2_31 | GPS tGD
	DF102: UINT |  6 |   1   | GPS SV HEALTH
	DF103: BIT  |  1 |   1   | GPS L2 P data flag
	DF137: BIT  |  1 |   1   | GPS Fit Interval
	------------------------------------------------------------------------------*/
    public class Rtcm1019 : BaseMessage
    {
        public GPS_005_UINT_6 m_SatelliteID { get; }
        public GPS_026_UINT_10 m_WeekNumber { get; }
        public GPS_027_BIT_4 m_SatelliteUserRangeAccuracyIndex { get; }
        public GPS_028_BIT_2 m_CodeOnL2 { get; }
        public GPS_029_INT_14_S m_RateOfInclinationAngleChange { get; }
        public GPS_023_UINT_8 m_IssueOfDataEphemeris { get; }
        public GPS_031_UINT_16_S m_ClockDataReferenceTimeSeconds { get; }
        public GPS_032_INT_8_S m_ClockCorrectionDriftRate_af2 { get; }
        public GPS_033_INT_16_S m_ClockCorrectionDrift_af1 { get; }
        public GPS_034_INT_22_S m_ClockCorrectionBias_af0 { get; }
        public GPS_035_UINT_10 m_IssueOfDataClock { get; }
        public GPS_036_INT_16_S m_AmplitudeSineHarmonicCorrectionRadius { get; }
        public GPS_037_INT_16_S m_MeanMotionDifferenceFromComputedValue { get; }
        public GPS_038_INT_32_S m_MeanAnomalyAtReferenceTime { get; }
        public GPS_039_INT_16_S m_AmplitudeCosineHarmonicCorrectionLatitude { get; }
        public GPS_040_UINT_32_S m_OrbitEccentricity { get; }
        public GPS_041_INT_16_S m_AmplitudeSineHarmonicCorrectionLatitude { get; }
        public GPS_042_UINT_32_S m_SquareRootOfSemiMajorAxis { get; }
        public GPS_043_UINT_16_S m_EphemerisReferenceTimeSeconds { get; }
        public GPS_044_INT_16_S m_AmplitudeCosineHarmonicCorrectionInclination { get; }
        public GPS_045_INT_32_S m_LongitudeOfAscendingNodeOfOrbitPlane { get; }
        public GPS_046_INT_16_S m_AmplitudeSineHarmonicCorrectionInclination { get; }
        public GPS_047_INT_32_S m_OrbitalInclinationAngleAtReferenceTime { get; }
        public GPS_048_INT_16_S m_AmplitudeCosineHarmonicCorrectionRadius { get; }
        public GPS_049_INT_32_S m_ArgumentOfPerigee { get; }
        public GPS_050_INT_24_S m_RateOfRightAscension { get; }
        public GPS_051_INT_8_S m_GroupDelayDifferential { get; }
        public GPS_052_UINT_6 m_SatelliteHealthStatus { get; }
        public GPS_053_BIT_1 m_L2PDataFlag { get; }
        public GPS_054_BIT_1 m_EphemerisFitIntervalFlag { get; }
        public Rtcm1019(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_SatelliteID = _bitStream.ReadBitsUnsigned(6);
            m_WeekNumber = _bitStream.ReadBitsUnsigned(10);
            m_SatelliteUserRangeAccuracyIndex = _bitStream.ReadBitsUnsigned(4);
            m_CodeOnL2 = _bitStream.ReadBitsUnsigned(2);
            m_RateOfInclinationAngleChange = _bitStream.ReadBitsTwosComplement(14);
            m_IssueOfDataEphemeris = _bitStream.ReadBitsUnsigned(8);
            m_ClockDataReferenceTimeSeconds = _bitStream.ReadBitsUnsigned(16);
            m_ClockCorrectionDriftRate_af2 = _bitStream.ReadBitsTwosComplement(8);
            m_ClockCorrectionDrift_af1 = _bitStream.ReadBitsTwosComplement(16);
            m_ClockCorrectionBias_af0 = _bitStream.ReadBitsTwosComplement(22);
            m_IssueOfDataClock = _bitStream.ReadBitsUnsigned(10);
            m_AmplitudeSineHarmonicCorrectionRadius = _bitStream.ReadBitsTwosComplement(16);
            m_MeanMotionDifferenceFromComputedValue = _bitStream.ReadBitsTwosComplement(16);
            m_MeanAnomalyAtReferenceTime = _bitStream.ReadBitsTwosComplement(32);
            m_AmplitudeCosineHarmonicCorrectionLatitude = _bitStream.ReadBitsTwosComplement(16);
            m_OrbitEccentricity = _bitStream.ReadBitsUnsigned(32);
            m_AmplitudeSineHarmonicCorrectionLatitude = _bitStream.ReadBitsTwosComplement(16);
            m_SquareRootOfSemiMajorAxis = _bitStream.ReadBitsUnsigned(32);
            m_EphemerisReferenceTimeSeconds = _bitStream.ReadBitsUnsigned(16);
            m_AmplitudeCosineHarmonicCorrectionInclination = _bitStream.ReadBitsTwosComplement(16);
            m_LongitudeOfAscendingNodeOfOrbitPlane = _bitStream.ReadBitsTwosComplement(32);
            m_AmplitudeSineHarmonicCorrectionInclination = _bitStream.ReadBitsTwosComplement(16);
            m_OrbitalInclinationAngleAtReferenceTime = _bitStream.ReadBitsTwosComplement(32);
            m_AmplitudeCosineHarmonicCorrectionRadius = _bitStream.ReadBitsTwosComplement(16);
            m_ArgumentOfPerigee = _bitStream.ReadBitsTwosComplement(32);
            m_RateOfRightAscension = _bitStream.ReadBitsTwosComplement(24);
            m_GroupDelayDifferential = _bitStream.ReadBitsTwosComplement(8);
            m_SatelliteHealthStatus = _bitStream.ReadBitsUnsigned(6);
            m_L2PDataFlag = _bitStream.ReadBitsUnsigned(1);
            m_EphemerisFitIntervalFlag = _bitStream.ReadBitsUnsigned(1);
        }
    }
}
