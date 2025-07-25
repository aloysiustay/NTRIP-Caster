using RtcmSharp.RtcmDataFields;
using System.Collections;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "GNSS_001", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Indicates whether this message is time-synchronous with GNSS")] //DF005
    public class GNSS_001_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_001_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_001_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_001_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_002", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "ITRF Realization Year")] //DF021
    public class GNSS_002_UINT_6 : DataFieldBase<byte>
    {
        public GNSS_002_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_002_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_002_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_003", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GPS Indicator")] //DF022
    public class GNSS_003_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_003_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_003_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_003_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_004", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS Indicator")] //DF023
    public class GNSS_004_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_004_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_004_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_004_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_005", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Galileo Indicator")] //DF024
    public class GNSS_005_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_005_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_005_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_005_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_006", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "Quarter Cycle Indicator")] //DF364
    public class GNSS_006_BIT_2 : DataFieldBase<byte>
    {
        public GNSS_006_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_006_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_006_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_007", dataType: "INT", bitLength: 22, scaleFactor: 0.1, description: "Delta Radial")] //DF365
    public class GNSS_007_INT_22_S : DataFieldBase<int>
    {
        public GNSS_007_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_007_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_007_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_008", dataType: "INT", bitLength: 20, scaleFactor: 0.4, description: "Delta Along-Track")] //DF366
    public class GNSS_008_INT_20_S : DataFieldBase<int>
    {
        public GNSS_008_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_008_INT_20_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_008_INT_20_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_009", dataType: "INT", bitLength: 20, scaleFactor: 0.4, description: "Delta Cross-Track")] //DF367
    public class GNSS_009_INT_20_S : DataFieldBase<int>
    {
        public GNSS_009_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_009_INT_20_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_009_INT_20_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_010", dataType: "INT", bitLength: 21, scaleFactor: 0.001, description: "Dot Delta Radial")] //DF368
    public class GNSS_010_INT_21_S : DataFieldBase<int>
    {
        public GNSS_010_INT_21_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_010_INT_21_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_010_INT_21_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_011", dataType: "INT", bitLength: 19, scaleFactor: 0.004, description: "Dot Delta AlongTrack")] //DF369
    public class GNSS_011_INT_19_S : DataFieldBase<int>
    {
        public GNSS_011_INT_19_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_011_INT_19_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_011_INT_19_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_012", dataType: "INT", bitLength: 19, scaleFactor: 0.004, description: "Dot Delta CrossTrack")] //DF370
    public class GNSS_012_INT_19_S : DataFieldBase<int>
    {
        public GNSS_012_INT_19_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_012_INT_19_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_012_INT_19_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_013", dataType: "INT", bitLength: 27, scaleFactor: 0.00002, description: "RESERVED for Dot Dot Delta Radial")] //DF371
    public class GNSS_013_INT_27_S : DataFieldBase<int>
    {
        public GNSS_013_INT_27_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_013_INT_27_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_013_INT_27_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_014_INT_25_S", dataType: "INT", bitLength: 25, scaleFactor: 0.00008, description: "RESERVED for Dot Dot Delta Along-Track")] //DF372
    public class GNSS_014_INT_25_S : DataFieldBase<int>
    {
        public GNSS_014_INT_25_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_014_INT_25_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_014_INT_25_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_015", dataType: "INT", bitLength: 25, scaleFactor: 0.00008, description: "RESERVED for Dot Dot Delta Cross-Track")] //DF373
    public class GNSS_015_INT_25_S : DataFieldBase<int>
    {
        public GNSS_015_INT_25_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_015_INT_25_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_015_INT_25_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_016", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Satellite Reference Point")] //DF374
    public class GNSS_016_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_016_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_016_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_016_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_017", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Satellite Reference Datum")] //DF375
    public class GNSS_017_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_017_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_017_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_017_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_018", dataType: "INT", bitLength: 22, scaleFactor: 0.1, description: "Delta Clock C0")] //DF376
    public class GNSS_018_INT_22_S : DataFieldBase<int>
    {
        public GNSS_018_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_018_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_018_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_019", dataType: "INT", bitLength: 21, scaleFactor: 0.001, description: "Delta Clock C1")] //DF377
    public class GNSS_019_INT_21_S : DataFieldBase<int>
    {
        public GNSS_019_INT_21_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_019_INT_21_S(int _rawValue) => new GNSS_019_INT_21_S(_rawValue);
        public static implicit operator GNSS_019_INT_21_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_020", dataType: "INT", bitLength: 27, scaleFactor: 0.00002, description: "Delta Clock C2")] //DF378
    public class GNSS_020_INT_27_S : DataFieldBase<int>
    {
        public GNSS_020_INT_27_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_020_INT_27_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_020_INT_27_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_021", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "No. of Code Biases Processed")] //DF379
    public class GNSS_021_UINT_5 : DataFieldBase<byte>
    {
        public GNSS_021_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_021_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_021_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_022", dataType: "INT", bitLength: 14, scaleFactor: 0.01, description: "Code Bias")] //DF383
    public class GNSS_022_INT_14_S : DataFieldBase<short>
    {
        public GNSS_022_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_022_INT_14_S(short _rawValue) => new(_rawValue);
        public static implicit operator GNSS_022_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GNSS_023", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "No. of Satellites")] //DF387
    public class GNSS_023_UINT_6 : DataFieldBase<byte>
    {
        public GNSS_023_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_023_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_023_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_024", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "Multiple Message Indicator")] //DF388
    public class GNSS_024_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_024_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_024_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_024_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_025", dataType: "BIT", bitLength: 6, scaleFactor: 0, description: "SSR URA")] //DF389
    public class GNSS_025_BIT_6 : DataFieldBase<byte>
    {
        public GNSS_025_BIT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_025_BIT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_025_BIT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_026", dataType: "INT", bitLength: 22, scaleFactor: 0.1, description: "High Rate Clock Correction")] //DF390
    public class GNSS_026_INT_22_S : DataFieldBase<int>
    {
        public GNSS_026_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_026_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_026_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_027", dataType: "BIT", bitLength: 4, scaleFactor: 1, description: "SSR Update Interval")] //DF391
    public class GNSS_027_BIT_4 : DataFieldBase<byte>
    {
        public GNSS_027_BIT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_027_BIT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_027_BIT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_028", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "MSM Multiple message bit")] //DF393
    public class GNSS_028_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_028_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_028_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_028_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_029", dataType: "BIT", bitLength: 64, scaleFactor: 0, description: "GNSS Satellite mask")] //DF394
    public class GNSS_029_BIT_64 : DataFieldBase<ulong>
    {
        public GNSS_029_BIT_64(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_029_BIT_64(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "GNSS_030", dataType: "BIT", bitLength: 32, scaleFactor: 0, description: "GNSS Signal mask")] //DF395
    public class GNSS_030_BIT_32 : DataFieldBase<uint>
    {
        public GNSS_030_BIT_32(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_030_BIT_32(uint _rawValue) => new(_rawValue);
        public static implicit operator GNSS_030_BIT_32(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GNSS_031", dataType: "BITX", bitLength: 0, scaleFactor: 0, description: "GNSS Cell mask")] //DF396
    public class GNSS_031_UINT_X : DataFieldBase<ulong>
    {
        public GNSS_031_UINT_X(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_031_UINT_X(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "GNSS_032", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "The number of integer milliseconds in GNSS Satellite rough range")] //DF397
    public class GNSS_032_UINT_8 : DataFieldBase<byte>
    {
        public GNSS_032_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_032_UINT_8(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_032_UINT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_033", dataType: "UINT", bitLength: 10, scaleFactor: RtcmConstants.P2_10, description: "GNSS Satellite rough range modulo 1 millisecond")] //DF398
    public class GNSS_033_UINT_10_S : DataFieldBase<ushort>
    {
        public GNSS_033_UINT_10_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_033_UINT_10_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator GNSS_033_UINT_10_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GNSS_034", dataType: "INT", bitLength: 14, scaleFactor: 1, description: "GNSS Satellite rough Phase Range Rate")] //DF399
    public class GNSS_034_INT_14 : DataFieldBase<short>
    {
        public GNSS_034_INT_14(short _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_034_INT_14(short _rawValue) => new(_rawValue);
        public static implicit operator GNSS_034_INT_14(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GNSS_035", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_24, description: "GNSS signal fine Pseudorange")] //DF400
    public class GNSS_035_INT_15_S : DataFieldBase<short>
    {
        public GNSS_035_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_035_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator GNSS_035_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GNSS_036", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_29, description: "GNSS signal fine PhaseRange data")] //DF401
    public class GNSS_036_INT_22_S : DataFieldBase<int>
    {
        public GNSS_036_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_036_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_036_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_037", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "GNSS PhaseRange Lock Time Indicator")] //DF402
    public class GNSS_037_UINT_4 : DataFieldBase<byte>
    {
        public GNSS_037_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_037_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_037_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_038", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "GNSS signal CNR")] //DF403
    public class GNSS_038_UINT_6 : DataFieldBase<byte>
    {
        public GNSS_038_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_038_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_038_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_039", dataType: "INT", bitLength: 15, scaleFactor: 0.0001, description: "GNSS signal fine Phase Range Rate")] //DF404
    public class GNSS_039_INT_15_S : DataFieldBase<short>
    {
        public GNSS_039_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_039_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator GNSS_039_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GNSS_040", dataType: "INT", bitLength: 20, scaleFactor: RtcmConstants.P2_29, description: "GNSS signal fine Pseudorange with extended resolution")] //DF405
    public class GNSS_040_INT_20_S : DataFieldBase<int>
    {
        public GNSS_040_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_040_INT_20_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_040_INT_20_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_041", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_31, description: "GNSS signal fine PhaseRange data with extended resolution")] //DF406
    public class GNSS_041_INT_24_S : DataFieldBase<int>
    {
        public GNSS_041_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_041_INT_24_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_041_INT_24_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_042", dataType: "UINT", bitLength: 10, scaleFactor: 0, description: "GNSS PhaseRange Lock Time Indicator with extended range and resolution.")] //DF407
    public class GNSS_042_UINT_10 : DataFieldBase<ushort>
    {
        public GNSS_042_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_042_UINT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator GNSS_042_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GNSS_043", dataType: "UINT", bitLength: 10, scaleFactor: RtcmConstants.P2_4, description: "GNSS signal CNR with extended resolution")] //DF408
    public class GNSS_043_UINT_10_S : DataFieldBase<ushort>
    {
        public GNSS_043_UINT_10_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_043_UINT_10_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator GNSS_043_UINT_10_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GNSS_044", dataType: "UINT", bitLength: 3, scaleFactor: 1, description: "IODS - Issue Of Data Station")] //DF409
    public class GNSS_044_UINT_3 : DataFieldBase<byte>
    {
        public GNSS_044_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_044_UINT_3(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_044_UINT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_045", dataType: "UINT", bitLength: 2, scaleFactor: 0, description: "Clock Steering Indicator")] //DF411
    public class GNSS_045_UINT_2 : DataFieldBase<byte>
    {
        public GNSS_045_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_045_UINT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_045_UINT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_046", dataType: "UINT", bitLength: 2, scaleFactor: 0, description: "External Clock Indicator")] //DF412
    public class GNSS_046_UINT_2 : DataFieldBase<byte>
    {
        public GNSS_046_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_046_UINT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_046_UINT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_047", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "IOD SSR")] //DF413
    public class GNSS_047_UINT_4 : DataFieldBase<byte>
    {
        public GNSS_047_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_047_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_047_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_048", dataType: "UINT", bitLength: 16, scaleFactor: 1, description: "SSR Provider ID")] //DF414
    public class GNSS_048_UINT_16 : DataFieldBase<ushort>
    {
        public GNSS_048_UINT_16(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_048_UINT_16(ushort _rawValue) => new(_rawValue);
        public static implicit operator GNSS_048_UINT_16(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GNSS_049", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "SSR Solution ID")] //DF415
    public class GNSS_049_UINT_4 : DataFieldBase<byte>
    {
        public GNSS_049_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_049_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_049_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_050", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GNSS Smoothing Type Indicator")] //DF417
    public class GNSS_050_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_050_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_050_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_050_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_051", dataType: "BIT", bitLength: 3, scaleFactor: 0, description: "GNSS Smoothing Interval")] //DF418
    public class GNSS_051_BIT_3 : DataFieldBase<byte>
    {
        public GNSS_051_BIT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_051_BIT_3(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_051_BIT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_052", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Half-cycle ambiguity indicator")] //DF420
    public class GNSS_052_BIT_1 : DataFieldBase<byte>
    {
        public GNSS_052_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_052_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_052_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_053", dataType: "UINT", bitLength: 2, scaleFactor: 1, description: "Number of Ionospheric Layers")] //DF472
    public class GNSS_053_UINT_2 : DataFieldBase<byte>
    {
        public GNSS_053_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_053_UINT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_053_UINT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_054", dataType: "UINT", bitLength: 8, scaleFactor: 10, description: "Height of Ionospheric Layer")] //DF473
    public class GNSS_054_UINT_8_S : DataFieldBase<byte>
    {
        public GNSS_054_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_054_UINT_8_S(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_054_UINT_8_S(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_055", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "Spherical Harmonics Degree")] //DF474
    public class GNSS_055_UINT_4 : DataFieldBase<byte>
    {
        public GNSS_055_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_055_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_055_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_056", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "Spherical Harmonics Order")] //DF475
    public class GNSS_056_UINT_4 : DataFieldBase<byte>
    {
        public GNSS_056_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_056_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator GNSS_056_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GNSS_057", dataType: "INT", bitLength: 16, scaleFactor: 0.005, description: "Spherical Harmonic Coefficient C")] //DF476
    public class GNSS_057_INT_16_S : DataFieldBase<int>
    {
        public GNSS_057_INT_16_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_057_INT_16_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_057_INT_16_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_058", dataType: "INT", bitLength: 16, scaleFactor: 0.005, description: "Spherical Harmonic Coefficient S")] //DF477
    public class GNSS_058_INT_16_S : DataFieldBase<int>
    {
        public GNSS_058_INT_16_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_058_INT_16_S(int _rawValue) => new(_rawValue);
        public static implicit operator GNSS_058_INT_16_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GNSS_059", dataType: "UINT", bitLength: 9, scaleFactor: 0.05, description: "VTEC Quality Indicator")] //DF478
    public class GNSS_059_UINT_9_S : DataFieldBase<ushort>
    {
        public GNSS_059_UINT_9_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GNSS_059_UINT_9_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator GNSS_059_UINT_9_S(ulong _rawValue) => new((ushort)_rawValue);
    }

}
