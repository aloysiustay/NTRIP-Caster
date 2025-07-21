using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "GLONASS_001", dataType: "UINT", bitLength: 27, scaleFactor: 1, description: "GLONASS Epoch Time (tk - number of seconds since the start of the current day in GLONASS time)")] //DF034
    public class GLONASS_001_UINT_27 : DataFieldBase<uint>
    {
        public GLONASS_001_UINT_27(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_001_UINT_27(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_002", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "No. of GLONASS Satellite Signals Processed")] //DF035
    public class GLONASS_002_UINT_5 : DataFieldBase<uint>
    {
        public GLONASS_002_UINT_5(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_002_UINT_5(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_003", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS Divergence-free Smoothing Indicator")] //DF036
    public class GLONASS_003_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_003_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_003_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_004", dataType: "BIT", bitLength: 3, scaleFactor: 0, description: "GLONASS Smoothing Interval")] //DF037
    public class GLONASS_004_BIT_3 : DataFieldBase<byte>
    {
        public GLONASS_004_BIT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_004_BIT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_005", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "GLONASS Satellite ID (Satellite Slot Number)")] //DF038
    public class GLONASS_005_UINT_6 : DataFieldBase<byte>
    {
        public GLONASS_005_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_005_UINT_6(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_006", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS L1 Code Indicator")] //DF039
    public class GLONASS_006_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_006_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_006_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_007", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "GLONASS Satellite Frequency Channel Number")] //DF040
    public class GLONASS_007_UINT_5 : DataFieldBase<byte>
    {
        public GLONASS_007_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_007_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_008", dataType: "UINT", bitLength: 25, scaleFactor: 0.02, description: "GLONASS L1 Pseudorange")] //DF041
    public class GLONASS_008_UINT_25_S : DataFieldBase<uint>
    {
        public GLONASS_008_UINT_25_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_008_UINT_25_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_009", dataType: "INT", bitLength: 20, scaleFactor: 0.0005, description: "GLONASS L1 PhaseRange - L1 Pseudorange")] //DF042
    public class GLONASS_009_INT_20_S : DataFieldBase<int>
    {
        public GLONASS_009_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_009_INT_20_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_010", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "GLONASS L1 Lock Time Indicator")] //DF043
    public class GLONASS_010_UINT_7 : DataFieldBase<byte>
    {
        public GLONASS_010_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_010_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_011", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "GLONASS Integer L1 Pseudorange Modulus Ambiguity")] //DF044
    public class GLONASS_011_UINT_7 : DataFieldBase<byte>
    {
        public GLONASS_011_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_011_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_012", dataType: "UINT", bitLength: 8, scaleFactor: 0.25, description: "GLONASS L1 CNR")] //DF045
    public class GLONASS_012_UINT_8_S : DataFieldBase<byte>
    {
        public GLONASS_012_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_012_UINT_8_S(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_013", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GLONASS L2 Code Indicator")] //DF046
    public class GLONASS_013_BIT_2 : DataFieldBase<byte>
    {
        public GLONASS_013_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_013_BIT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_014", dataType: "INT", bitLength: 14, scaleFactor: 0.02, description: "GLONASS L2-L1 Pseudorange Difference")] //DF047
    public class GLONASS_014_INT_14_S : DataFieldBase<short>
    {
        public GLONASS_014_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_014_INT_14_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_015", dataType: "INT", bitLength: 20, scaleFactor: 0.0005, description: "GLONASS L2 PhaseRange - L1 Pseudorange")] //DF048
    public class GLONASS_015_INT_20_S : DataFieldBase<int>
    {
        public GLONASS_015_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_015_INT_20_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_016", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "GLONASS L2 Lock Time Indicator")] //DF049
    public class GLONASS_016_UINT_7 : DataFieldBase<byte>
    {
        public GLONASS_016_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_016_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_017", dataType: "UINT", bitLength: 8, scaleFactor: 0.25, description: "GLONASS L2 CNR")] //DF050
    public class GLONASS_017_UINT_8_S : DataFieldBase<byte>
    {
        public GLONASS_017_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_017_UINT_8_S(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_018", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS almanac health")] //DF104
    public class GLONASS_018_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_018_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_018_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_019", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS almanac health availability indicator")] //DF105
    public class GLONASS_019_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_019_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_019_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_020", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GLONASS P1")] //DF106
    public class GLONASS_020_BIT_2 : DataFieldBase<byte>
    {
        public GLONASS_020_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_020_BIT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_021", dataType: "BIT", bitLength: 12, scaleFactor: 0, description: "GLONASS tk")] //DF107
    public class GLONASS_021_BIT_12 : DataFieldBase<ushort>
    {
        public GLONASS_021_BIT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_021_BIT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_022", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS MSB of Bn word")] //DF108
    public class GLONASS_022_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_022_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_022_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_023", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS P2")] //DF109
    public class GLONASS_023_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_023_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_023_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_024", dataType: "UINT", bitLength: 7, scaleFactor: 1, description: "GLONASS tb")] //DF110
    public class GLONASS_024_UINT_7 : DataFieldBase<byte>
    {
        public GLONASS_024_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_024_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_025", dataType: "INTS", bitLength: 24, scaleFactor: RtcmConstants.P2_20, description: "GLONASS xn(tb), first derivative")] //DF111
    public class GLONASS_025_SINT_24_S : DataFieldBase<int>
    {
        public GLONASS_025_SINT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_025_SINT_24_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_026", dataType: "INTS", bitLength: 27, scaleFactor: RtcmConstants.P2_11, description: "GLONASS xn(tb)")] //DF112
    public class GLONASS_026_SINT_27_S : DataFieldBase<int>
    {
        public GLONASS_026_SINT_27_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_026_SINT_27_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_027", dataType: "INTS", bitLength: 5, scaleFactor: RtcmConstants.P2_30, description: "GLONASS xn(tb), second derivative")] //DF113
    public class GLONASS_027_SINT_5_S : DataFieldBase<sbyte>
    {
        public GLONASS_027_SINT_5_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_027_SINT_5_S(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_028", dataType: "INTS", bitLength: 24, scaleFactor: RtcmConstants.P2_20, description: "GLONASS yn(tb), first derivative")] //DF114
    public class GLONASS_028_SINT_24_S : DataFieldBase<int>
    {
        public GLONASS_028_SINT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_028_SINT_24_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_029", dataType: "INTS", bitLength: 27, scaleFactor: RtcmConstants.P2_11, description: "GLONASS yn(tb)")] //DF115
    public class GLONASS_029_SINT_27_S : DataFieldBase<int>
    {
        public GLONASS_029_SINT_27_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_029_SINT_27_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_030", dataType: "INTS", bitLength: 5, scaleFactor: RtcmConstants.P2_30, description: "GLONASS yn(tb), second derivative")] //DF116
    public class GLONASS_030_SINT_5_S : DataFieldBase<sbyte>
    {
        public GLONASS_030_SINT_5_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_030_SINT_5_S(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_031", dataType: "INTS", bitLength: 24, scaleFactor: RtcmConstants.P2_20, description: "GLONASS zn(tb), first derivative")] //DF117
    public class GLONASS_031_SINT_24_S : DataFieldBase<int>
    {
        public GLONASS_031_SINT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_031_SINT_24_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_032", dataType: "INTS", bitLength: 27, scaleFactor: RtcmConstants.P2_11, description: "GLONASS zn(tb)")] //DF118
    public class GLONASS_032_SINT_27_S : DataFieldBase<int>
    {
        public GLONASS_032_SINT_27_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_032_SINT_27_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_033", dataType: "INTS", bitLength: 5, scaleFactor: RtcmConstants.P2_30, description: "GLONASS zn(tb), second derivative")] //DF119
    public class GLONASS_033_SINT_5_S : DataFieldBase<sbyte>
    {
        public GLONASS_033_SINT_5_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_033_SINT_5_S(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_034", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS P3")] //DF120
    public class GLONASS_034_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_034_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_034_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_035", dataType: "INTS", bitLength: 11, scaleFactor: 0, description: "GLONASS γn(tb) (Relative deviation)")] //DF121
    public class GLONASS_035_SINTS_11 : DataFieldBase<short>
    {
        public GLONASS_035_SINTS_11(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_035_SINTS_11(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_036", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GLONASS-M P")] //DF122
    public class GLONASS_036_BIT_2 : DataFieldBase<byte>
    {
        public GLONASS_036_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_036_BIT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_037", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS-M ln (third string)")] //DF123
    public class GLONASS_037_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_037_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_037_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_038", dataType: "INTS", bitLength: 22, scaleFactor: 0, description: "GLONASS τn (tb)")] //DF124
    public class GLONASS_038_SINT_22 : DataFieldBase<int>
    {
        public GLONASS_038_SINT_22(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_038_SINT_22(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_039", dataType: "INTS", bitLength: 5, scaleFactor: 0, description: "GLONASS-M Δτn")] //DF125
    public class GLONASS_039_SINT_5 : DataFieldBase<sbyte>
    {
        public GLONASS_039_SINT_5(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_039_SINT_5(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_040", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "GLONASS En")] //DF126
    public class GLONASS_040_UINT_5 : DataFieldBase<byte>
    {
        public GLONASS_040_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_040_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_041", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS-M P4")] //DF127
    public class GLONASS_041_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_041_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_041_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_042", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "GLONASS-M FT")] //DF128
    public class GLONASS_042_UINT_4 : DataFieldBase<byte>
    {
        public GLONASS_042_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_042_UINT_4(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_043", dataType: "UINT", bitLength: 11, scaleFactor: 1, description: "GLONASS-M NT")] //DF129
    public class GLONASS_043_UINT_11 : DataFieldBase<ushort>
    {
        public GLONASS_043_UINT_11(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_043_UINT_11(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_044", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GLONASS-M M")] //DF130
    public class GLONASS_044_BIT_2 : DataFieldBase<byte>
    {
        public GLONASS_044_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_044_BIT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_045", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS The Availability of Additional Data")] //DF131
    public class GLONASS_045_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_045_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_045_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_046", dataType: "UINT", bitLength: 11, scaleFactor: 1, description: "GLONASS NA")] //DF132
    public class GLONASS_046_UINT_11 : DataFieldBase<ushort>
    {
        public GLONASS_046_UINT_11(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_046_UINT_11(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_047", dataType: "INTS", bitLength: 32, scaleFactor: 0, description: "GLONASS τc")] //DF133
    public class GLONASS_047_SINT_32 : DataFieldBase<int>
    {
        public GLONASS_047_SINT_32(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_047_SINT_32(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_048", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "GLONASS-M N4")] //DF134
    public class GLONASS_048_UINT_5 : DataFieldBase<byte>
    {
        public GLONASS_048_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_048_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_049", dataType: "INTS", bitLength: 22, scaleFactor: 0, description: "GLONASS-M τGPS")] //DF135
    public class GLONASS_049_SINT : DataFieldBase<int>
    {
        public GLONASS_049_SINT(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_049_SINT(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_050", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS-M ln (fifth string)")] //DF136
    public class GLONASS_050_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_050_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_050_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_051", dataType: "UINT", bitLength: 17, scaleFactor: 1, description: "GLONASS Residuals Epoch Time (tk)")] //DF225
    public class GLONASS_051_UINT_17 : DataFieldBase<uint>
    {
        public GLONASS_051_UINT_17(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_051_UINT_17(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_052", dataType: "UINT", bitLength: 20, scaleFactor: 0.1, description: "GLONASS NW Epoch Time")] //DF233
    public class GLONASS_052_UINT_20_S : DataFieldBase<uint>
    {
        public GLONASS_052_UINT_20_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_052_UINT_20_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_053", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "Number of GLONASS Data Entries")] //DF234
    public class GLONASS_053_UINT_4 : DataFieldBase<byte>
    {
        public GLONASS_053_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_053_UINT_4(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_054", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "GLONASS Ambiguity Status Flag")] //DF235
    public class GLONASS_054_BIT_2 : DataFieldBase<byte>
    {
        public GLONASS_054_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_054_BIT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_055", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "GLONASS Non Sync Count")] //DF236
    public class GLONASS_055_UINT_3 : DataFieldBase<byte>
    {
        public GLONASS_055_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_055_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_056", dataType: "INT", bitLength: 17, scaleFactor: 0.5, description: "GLONASS Ionospheric Carrier Phase Correction Difference")] //DF237
    public class GLONASS_056_INT_17_S : DataFieldBase<int>
    {
        public GLONASS_056_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_056_INT_17_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_057", dataType: "INT", bitLength: 17, scaleFactor: 0.5, description: "GLONASS Geometric Carrier Phase Correction Difference")] //DF238
    public class GLONASS_057_INT_17_S : DataFieldBase<int>
    {
        public GLONASS_057_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_057_INT_17_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_058", dataType: "BIT", bitLength: 8, scaleFactor: 0, description: "GLONASS IOD")] //DF239
    public class GLONASS_058_BIT_8 : DataFieldBase<byte>
    {
        public GLONASS_058_BIT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_058_BIT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_059", dataType: "UINT", bitLength: 17, scaleFactor: 1, description: "GLONASS FKP Epoch Time")] //DF241
    public class GLONASS_059_UINT_17 : DataFieldBase<uint>
    {
        public GLONASS_059_UINT_17(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_059_UINT_17(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_060", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "GLONASS Signal and Tracking Mode Identifier")] //DF381
    public class GLONASS_060_UINT_5 : DataFieldBase<byte>
    {
        public GLONASS_060_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_060_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_061", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "GLONASS Satellite ID")] //DF384
    public class GLONASS_061_UINT_5 : DataFieldBase<byte>
    {
        public GLONASS_061_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_061_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_062", dataType: "UINT", bitLength: 17, scaleFactor: 1, description: "GLONASS Epoch Time 1s")] //DF386
    public class GLONASS_062_UINT_17 : DataFieldBase<uint>
    {
        public GLONASS_062_UINT_17(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_062_UINT_17(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_063", dataType: "BIT", bitLength: 8, scaleFactor: 0, description: "GLONASS Issue Of Data (IOD)")] //DF392
    public class GLONASS_063_BIT_8 : DataFieldBase<byte>
    {
        public GLONASS_063_BIT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_063_BIT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_064", dataType: "UINT", bitLength: 3, scaleFactor: 1, description: "GLONASS Day Of Week")] //DF416
    public class GLONASS_064_UINT_3 : DataFieldBase<byte>
    {
        public GLONASS_064_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_064_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_065", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "GLONASS Satellite Frequency Channel Number")] //DF419
    public class GLONASS_065_UINT_4 : DataFieldBase<byte>
    {
        public GLONASS_065_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_065_UINT_4(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_066", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS Code-Phase Bias Indicator")] //DF421
    public class GLONASS_066_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_066_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_066_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_067", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS FDMA Signals Mask L1 C/A")] //DF422_1
    public class GLONASS_067_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_067_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_067_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_068", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS FDMA Signals Mask L1 P")] //DF422_2
    public class GLONASS_068_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_068_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_068_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_069", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS FDMA Signals Mask L2 C/A")] //DF422_3
    public class GLONASS_069_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_069_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_069_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_070", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "GLONASS FDMA Signals Mask L2 P")] //DF422_4
    public class GLONASS_070_BIT_1 : DataFieldBase<byte>
    {
        public GLONASS_070_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_070_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_071", dataType: "INT", bitLength: 16, scaleFactor: 0.02, description: "GLONASS L1 C/A Code-Phase Bias")] //DF423
    public class GLONASS_071_INT_16_S : DataFieldBase<short>
    {
        public GLONASS_071_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_071_INT_16_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_072", dataType: "INT", bitLength: 16, scaleFactor: 0.02, description: "GLONASS L1 P Code-Phase Bias")] //DF424
    public class GLONASS_072_INT_16_S : DataFieldBase<short>
    {
        public GLONASS_072_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_072_INT_16_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_073", dataType: "INT", bitLength: 16, scaleFactor: 0.02, description: "GLONASS L2 C/A Code-Phase Bias")] //DF425
    public class GLONASS_073_INT_16_S : DataFieldBase<short>
    {
        public GLONASS_073_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_073_INT_16_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "GLONASS_075", dataType: "INT", bitLength: 16, scaleFactor: 0.02, description: "GLONASS L2 P Code-Phase Bias")] //DF426
    public class GLONASS_075_INT_16_S : DataFieldBase<short>
    {
        public GLONASS_075_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GLONASS_075_INT_16_S(short _rawValue) => new(_rawValue);
    }
}
