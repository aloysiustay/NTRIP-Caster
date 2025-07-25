using RtcmSharp.RtcmDatafields;
using System.Collections;

namespace RtcmSharp.RtcmDataFields
{
    [DataField(name: "GPS_001", dataType: "UINT", bitLength: 30, scaleFactor: 1, description: "GPS Epoch Time (TOW - the number of seconds since the start of the current GPS week)")] //DF004
    public class GPS_001_UINT_30 : DataFieldBase<uint>
    {
        public GPS_001_UINT_30(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_001_UINT_30(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_001_UINT_30(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_002", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "No. of GPS Satellite Signals Processed")] //DF006
    public class GPS_002_UINT_5 : DataFieldBase<byte>
    {
        public GPS_002_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_002_UINT_5(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_002_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_003", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GPS Divergence-free Smoothing Indicator")] //DF007
    public class GPS_003_BIT_1 : DataFieldBase<byte>
    {
        public GPS_003_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_003_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_003_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_004", dataType: "BIT", bitLength: 3, scaleFactor: 0, description: "GPS Smoothing Interval")] //DF008
    public class GPS_004_BIT_3 : DataFieldBase<byte>
    {
        public GPS_004_BIT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_004_BIT_3(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_004_BIT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_005", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "GPS Satellite ID")] //DF009
    public class GPS_005_UINT_6 : DataFieldBase<byte>
    {
        public GPS_005_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_005_UINT_6(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_005_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_006", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GPS L1 Code Indicator")] //DF010
    public class GPS_006_BIT_1 : DataFieldBase<byte>
    {
        public GPS_006_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_006_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_006_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_007", dataType: "UINT", bitLength: 24, scaleFactor: 0.02, description: "GPS L1 Pseudorange")] //DF011
    public class GPS_007_UINT_24_S : DataFieldBase<uint>
    {
        public GPS_007_UINT_24_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_007_UINT_24_S(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_007_UINT_24_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_008", dataType: "INT", bitLength: 20, scaleFactor: 0.0005, description: "GPS L1 PhaseRange - L1 Pseudorange")] //DF012
    public class GPS_008_INT_20_S : DataFieldBase<int>
    {
        public GPS_008_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_008_INT_20_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_008_INT_20_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_009", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "GPS L1 Lock Time Indicator")] //DF013
    public class GPS_009_UINT_7 : DataFieldBase<byte>
    {
        public GPS_009_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_009_UINT_7(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_009_UINT_7(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_010", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "GPS Integer L1 Pseudorange Modulus Ambiguity")] //DF014
    public class GPS_010_UINT_8 : DataFieldBase<byte>
    {
        public GPS_010_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_010_UINT_8(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_010_UINT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_011", dataType: "UINT", bitLength: 8, scaleFactor: 0.25, description: "GPS L1 CNR")] //DF015
    public class GPS_011_UINT_8_S : DataFieldBase<byte>
    {
        public GPS_011_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_011_UINT_8_S(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_011_UINT_8_S(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_012", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GPS L2 Code Indicator")] //DF016
    public class GPS_012_BIT_2 : DataFieldBase<byte>
    {
        public GPS_012_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_012_BIT_2(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_012_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_013", dataType: "INT", bitLength: 14, scaleFactor: 0.02, description: "GPS L2-L1 Pseudorange Difference")] //DF017
    public class GPS_013_INT_14_S : DataFieldBase<short>
    {
        public GPS_013_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_013_INT_14_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_013_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_014", dataType: "INT", bitLength: 20, scaleFactor: 0.0005, description: "GPS L2 PhaseRange - L1 Pseudorange")] //DF018
    public class GPS_014_INT_20_S : DataFieldBase<int>
    {
        public GPS_014_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_014_INT_20_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_014_INT_20_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_015", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "GPS L2 Lock Time Indicator")] //DF019
    public class GPS_015_UINT_7 : DataFieldBase<byte>
    {
        public GPS_015_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_015_UINT_7(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_015_UINT_7(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_016", dataType: "UINT", bitLength: 8, scaleFactor: 0.25, description: "GPS L2 CNR")] //DF020
    public class GPS_016_UINT_8_S : DataFieldBase<byte>
    {
        public GPS_016_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_016_UINT_8_S(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_016_UINT_8_S(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_017", dataType: "UINT", bitLength: 23, scaleFactor: 0.1, description: "GPS Epoch Time (GPS TOW)")] //DF065
    public class GPS_017_UINT_23_S : DataFieldBase<uint>
    {
        public GPS_017_UINT_23_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_017_UINT_23_S(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_017_UINT_23_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_018", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "GPS Multiple Message Indicator")] //DF066
    public class GPS_018_BIT_1 : DataFieldBase<byte>
    {
        public GPS_018_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_018_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_018_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_019", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "Number of GPS Satellites")] //DF067
    public class GPS_019_UINT_4 : DataFieldBase<byte>
    {
        public GPS_019_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_019_UINT_4(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_019_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_020", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "GPS Satellite ID")] //DF068
    public class GPS_020_UINT_6 : DataFieldBase<byte>
    {
        public GPS_020_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_020_UINT_6(byte _rawValue) => new GPS_020_UINT_6(_rawValue);
        public static implicit operator GPS_020_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_021", dataType: "INT", bitLength: 17, scaleFactor: 0.5, description: "GPS Ionospheric Carrier Phase Correction Difference")] //DF069
    public class GPS_021_INT_17_S : DataFieldBase<int>
    {
        public GPS_021_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_021_INT_17_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_021_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_022", dataType: "INT", bitLength: 17, scaleFactor: 0.5, description: "GPS Geometric Carrier Phase Correction Difference")] //DF070
    public class GPS_022_INT_17_S : DataFieldBase<int>
    {
        public GPS_022_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_022_INT_17_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_022_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_023", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "GPS IODE")] //DF071
    public class GPS_023_UINT_8 : DataFieldBase<byte>
    {
        public GPS_023_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_023_UINT_8(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_023_UINT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_024", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GPS Ambiguity Status Flag")] //DF074
    public class GPS_024_BIT_2 : DataFieldBase<byte>
    {
        public GPS_024_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_024_BIT_2(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_024_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_025", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "GPS Non Sync Count")] //DF075
    public class GPS_025_UINT_3 : DataFieldBase<byte>
    {
        public GPS_025_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_025_UINT_3(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_025_UINT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_026", dataType: "UINT", bitLength: 10, scaleFactor: 0, description: "GPS Week number")] //DF076
    public class GPS_026_UINT_10 : DataFieldBase<ushort>
    {
        public GPS_026_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_026_UINT_10(ushort _rawValue) => new (_rawValue);
        public static implicit operator GPS_026_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GPS_027", dataType: "BIT", bitLength: 4, scaleFactor: 0, description: "GPS SV Acc. (URA)")] //DF077
    public class GPS_027_BIT_4 : DataFieldBase<byte>
    {
        public GPS_027_BIT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_027_BIT_4(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_027_BIT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_028", dataType: "BIT", bitLength: 2, scaleFactor: 1, description: "GPS CODE ON L2")] //DF078
    public class GPS_028_BIT_2 : DataFieldBase<byte>
    {
        public GPS_028_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_028_BIT_2(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_028_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_029", dataType: "INT", bitLength: 14, scaleFactor: RtcmConstants.P2_43, description: "GPS IDOT (Issue of Data, Time) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF079
    public class GPS_029_INT_14_S : DataFieldBase<short>
    {
        public GPS_029_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_029_INT_14_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_029_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_030", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "GPS IODE (Issue of Data, Ephemeris)")] //DF080
    public class GPS_030_UINT_8 : DataFieldBase<byte>
    {
        public GPS_030_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_030_UINT_8(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_030_UINT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_031", dataType: "UINT", bitLength: 16, scaleFactor: RtcmConstants.P2_P4, description: "GPS toc (Reference Time, Clock)")] //DF081
    public class GPS_031_UINT_16_S : DataFieldBase<ushort>
    {
        public GPS_031_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_031_UINT_16_S(ushort _rawValue) => new (_rawValue);
        public static implicit operator GPS_031_UINT_16_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GPS_032", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_55, description: "GPS af2 (Clock correction drift rate)")] //DF082
    public class GPS_032_INT_8_S : DataFieldBase<sbyte>
    {
        public GPS_032_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_032_INT_8_S(sbyte _rawValue) => new (_rawValue);
        public static implicit operator GPS_032_INT_8_S(long _rawValue) => new((sbyte)_rawValue);
    }

    [DataField(name: "GPS_033", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "GPS af1 (Clock correction drift)")] //DF083
    public class GPS_033_INT_16_S : DataFieldBase<short>
    {
        public GPS_033_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_033_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_033_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_034", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_31, description: "GPS af0 (Clock correction bias)")] //DF084
    public class GPS_034_INT_22_S : DataFieldBase<int>
    {
        public GPS_034_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_034_INT_22_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_034_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_035", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "GPS IODC (Issue of Data, Clock)")] //DF085
    public class GPS_035_UINT_10 : DataFieldBase<ushort>
    {
        public GPS_035_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_035_UINT_10(ushort _rawValue) => new (_rawValue);
        public static implicit operator GPS_035_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GPS_036", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "GPS Crs (Amplitude of sine harmonic correction term to the orbit, radius)")] //DF086
    public class GPS_036_INT_16_S : DataFieldBase<short>
    {
        public GPS_036_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_036_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_036_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_037", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "GPS ∆n (Mean motion difference from computed value) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF087
    public class GPS_037_INT_16_S : DataFieldBase<short>
    {
        public GPS_037_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_037_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_037_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_038", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "GPS M0 (Mean Anomaly) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF088
    public class GPS_038_INT_32_S : DataFieldBase<int>
    {
        public GPS_038_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_038_INT_32_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_038_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_039", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "GPS Cuc (Amplitude of cosine harmonic correction term to argument of latitude)")] //DF089
    public class GPS_039_INT_16_S : DataFieldBase<short>
    {
        public GPS_039_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_039_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_039_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_040", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_33, description: "GPS e (Eccentricity)")] //DF090
    public class GPS_040_UINT_32_S : DataFieldBase<uint>
    {
        public GPS_040_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_040_UINT_32_S(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_040_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_041", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "GPS Cus (Amplitude of sine harmonic correction term to argument of latitude)")] //DF091
    public class GPS_041_INT_16_S : DataFieldBase<short>
    {
        public GPS_041_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_041_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_041_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_042", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_19, description: "GPS A½ (Square root of Semi-major Axis)")] //DF092
    public class GPS_042_UINT_32_S : DataFieldBase<uint>
    {
        public GPS_042_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_042_UINT_32_S(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_042_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_043", dataType: "UINT", bitLength: 16, scaleFactor: RtcmConstants.P2_P4, description: "GPS toe (Reference Time, Ephemeris)")] //DF093
    public class GPS_043_UINT_16_S : DataFieldBase<ushort>
    {
        public GPS_043_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_043_UINT_16_S(ushort _rawValue) => new (_rawValue);
        public static implicit operator GPS_043_UINT_16_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GPS_044", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "GPS Cic (Amplitude of cosine harmonic correction term to angle of inclination)")] //DF094
    public class GPS_044_INT_16_S : DataFieldBase<short>
    {
        public GPS_044_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_044_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_044_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_045", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "GPS Ω0 (Longitude of Ascending Node) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF095
    public class GPS_045_INT_32_S : DataFieldBase<int>
    {
        public GPS_045_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_045_INT_32_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_045_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_046", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "GPS Cis (Amplitude of sine harmonic correction term to angle of inclination)")] //DF096
    public class GPS_046_INT_16_S : DataFieldBase<short>
    {
        public GPS_046_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_046_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_046_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_047", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "GPS i0 (Inclination) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF097
    public class GPS_047_INT_32_S : DataFieldBase<int>
    {
        public GPS_047_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_047_INT_32_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_047_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_048", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "GPS Crc (Amplitude of cosine harmonic correction term to orbit, radius)")] //DF098
    public class GPS_048_INT_16_S : DataFieldBase<short>
    {
        public GPS_048_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_048_INT_16_S(short _rawValue) => new (_rawValue);
        public static implicit operator GPS_048_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GPS_049", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "GPS ω (Argument of Perigee) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF099
    public class GPS_049_INT_32_S : DataFieldBase<int>
    {
        public GPS_049_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_049_INT_32_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_049_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_050", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_43, description: "GPS ΩDOT (Rate of Change of Right Ascension) - These values are provided in semicircles, multiply by π to use in orbit, computations")] //DF100
    public class GPS_050_INT_24_S : DataFieldBase<int>
    {
        public GPS_050_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_050_INT_24_S(int _rawValue) => new (_rawValue);
        public static implicit operator GPS_050_INT_24_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GPS_051", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_31, description: "GPS tGD")] //DF101
    public class GPS_051_INT_8_S : DataFieldBase<sbyte>
    {
        public GPS_051_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_051_INT_8_S(sbyte _rawValue) => new (_rawValue);
        public static implicit operator GPS_051_INT_8_S(long _rawValue) => new((sbyte)_rawValue);
    }

    [DataField(name: "GPS_052", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "GPS SV HEALTH")] //DF102
    public class GPS_052_UINT_6 : DataFieldBase<byte>
    {
        public GPS_052_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_052_UINT_6(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_052_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_053", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "GPS L2 P data flag")] //DF103
    public class GPS_053_BIT_1 : DataFieldBase<byte>
    {
        public GPS_053_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_053_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_053_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_054", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "GPS Fit Interval")] //DF137
    public class GPS_054_BIT_1 : DataFieldBase<byte>
    {
        public GPS_054_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_054_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_054_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_055", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "GPS Residuals Epoch Time (TOW)")] //DF224
    public class GPS_055_UINT_20 : DataFieldBase<uint>
    {
        public GPS_055_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_055_UINT_20(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_055_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_056", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "GPS FKP Epoch Time")] //DF240
    public class GPS_056_UINT_20 : DataFieldBase<uint>
    {
        public GPS_056_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_056_UINT_20(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_056_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GPS_057", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "GPS Signal and Tracking Mode Identifier")] //DF380
    public class GPS_057_UINT_5 : DataFieldBase<byte>
    {
        public GPS_057_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_057_UINT_5(byte _rawValue) => new (_rawValue);
        public static implicit operator GPS_057_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GPS_058", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "GPS Epoch Time 1s")] //DF385
    public class GPS_058_UINT_20 : DataFieldBase<uint>
    {
        public GPS_058_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GPS_058_UINT_20(uint _rawValue) => new (_rawValue);
        public static implicit operator GPS_058_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

}
