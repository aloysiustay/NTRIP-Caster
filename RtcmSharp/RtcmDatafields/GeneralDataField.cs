using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "DF_001", dataType: "UINT", bitLength: 12, scaleFactor: 0, description: "Message Number")] //DF002
    public class DF_001_UINT_12 : DataFieldBase<ushort>
    {
        public DF_001_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_001_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_002", dataType: "UINT", bitLength: 12, scaleFactor: 0, description: "Reference Station ID")] //DF003
    public class DF_002_UINT_12 : DataFieldBase<ushort>
    {
        public DF_002_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_002_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_003", dataType: "INT", bitLength: 38, scaleFactor: 0.0001, description: "Antenna Ref. Point, ECEF-X")] //DF025
    public class DF_003_INT_38_S : DataFieldBase<long>
    {
        public DF_003_INT_38_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_003_INT_38_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_004", dataType: "INT", bitLength: 38, scaleFactor: 0.0001, description: "Antenna Ref. Point, ECEF-Y")] //DF026
    public class DF_004_INT_38_S : DataFieldBase<long>
    {
        public DF_004_INT_38_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_004_INT_38_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_005", dataType: "INT", bitLength: 38, scaleFactor: 0.0001, description: "Antenna Ref. Point, ECEF-Z")] //DF027
    public class DF_005_INT_38_S : DataFieldBase<long>
    {
        public DF_005_INT_38_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_005_INT_38_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_006", dataType: "UINT", bitLength: 16, scaleFactor: 0.0001, description: "Antenna Height")] //DF028
    public class DF_006_UINT_16_S : DataFieldBase<ushort>
    {
        public DF_006_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_006_UINT_16_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_007", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Descriptor Counter")] //DF029
    public class DF_007_UINT_8 : DataFieldBase<byte>
    {
        public DF_007_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_007_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_008", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Antenna Descriptor")] //DF030
    public class DF_008_STR : DataFieldBase<string>
    {
        public DF_008_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_008_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_009", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Antenna Setup ID")] //DF031
    public class DF_009_UINT_8 : DataFieldBase<byte>
    {
        public DF_009_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_009_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_010", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Serial Number Counter")] //DF032
    public class DF_010_UINT_8 : DataFieldBase<byte>
    {
        public DF_010_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_010_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_011", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Antenna Serial Number")] //DF033
    public class DF_011_STR : DataFieldBase<string>
    {
        public DF_011_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_011_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_012", dataType: "UINT", bitLength: 16, scaleFactor: 1, description: "Modified Julian Day (MJD) Number")] //DF051
    public class DF_012_UINT_16 : DataFieldBase<ushort>
    {
        public DF_012_UINT_16(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_012_UINT_16(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_013", dataType: "UINT", bitLength: 17, scaleFactor: 1, description: "Seconds of Day (UTC)")] //DF052
    public class DF_013_UINT_17 : DataFieldBase<uint>
    {
        public DF_013_UINT_17(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_013_UINT_17(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_014", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "Number of Message ID Announcements to Follow (Nm)")] //DF053
    public class DF_014_UINT_5 : DataFieldBase<byte>
    {
        public DF_014_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_014_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_015", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "Leap Seconds, GPS-UTC")] //DF054
    public class DF_015_UINT_8 : DataFieldBase<byte>
    {
        public DF_015_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_015_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_016", dataType: "UINT", bitLength: 12, scaleFactor: 1, description: "Message ID")] //DF055
    public class DF_016_UINT_12 : DataFieldBase<ushort>
    {
        public DF_016_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_016_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_017", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Message Sync Flag")] //DF056
    public class DF_017_BIT_1 : DataFieldBase<byte>
    {
        public DF_017_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_017_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_018", dataType: "UINT", bitLength: 16, scaleFactor: 0.1, description: "Message Transmission Interval")] //DF057
    public class DF_018_UINT_16_S : DataFieldBase<ushort>
    {
        public DF_018_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_018_UINT_16_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_019", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "Number of Auxiliary Stations Transmitted")] //DF058
    public class DF_019_UINT_5 : DataFieldBase<byte>
    {
        public DF_019_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_019_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_020", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "Network ID")] //DF059
    public class DF_020_UINT_8 : DataFieldBase<byte>
    {
        public DF_020_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_020_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_021", dataType: "UINT", bitLength: 12, scaleFactor: 1, description: "Master Reference Station ID")] //DF060
    public class DF_021_UINT_12 : DataFieldBase<ushort>
    {
        public DF_021_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_021_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_022", dataType: "UINT", bitLength: 12, scaleFactor: 1, description: "Auxiliary Reference Station ID")] //DF061
    public class DF_022_UINT_12 : DataFieldBase<ushort>
    {
        public DF_022_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_022_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_023", dataType: "INT", bitLength: 20, scaleFactor: 25000000, description: "Aux-Master Delta Latitude")] //DF062
    public class DF_023_INT_20_S : DataFieldBase<int>
    {
        public DF_023_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_023_INT_20_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_024", dataType: "INT", bitLength: 21, scaleFactor: 25000000, description: "Aux-Master Delta Longitude")] //DF063
    public class DF_024_INT_21_S : DataFieldBase<int>
    {
        public DF_024_INT_21_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_024_INT_21_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_025", dataType: "INT", bitLength: 23, scaleFactor: 1, description: "Aux-Master Delta Height")] //DF064
    public class DF_025_INT_23 : DataFieldBase<int>
    {
        public DF_025_INT_23(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_025_INT_23(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_026", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "Subnetwork ID")] //DF072
    public class DF_026_UINT_4 : DataFieldBase<byte>
    {
        public DF_026_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_026_UINT_4(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_027", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "RESERVED for Provider ID")] //DF073
    public class DF_027_UINT_8 : DataFieldBase<byte>
    {
        public DF_027_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_027_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_028", dataType: "UINT", bitLength: 7, scaleFactor: 1, description: "Number of Characters to Follow")] //DF138
    public class DF_028_UINT_7 : DataFieldBase<byte>
    {
        public DF_028_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_028_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_029", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "Number of UTF-8 Code Units")] //DF139
    public class DF_029_UINT_8 : DataFieldBase<byte>
    {
        public DF_029_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_029_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_030", dataType: "STR", bitLength: 8, scaleFactor: 0, description: "UTF-8 Character Code Units")] //DF140
    public class DF_030_STR : DataFieldBase<string>
    {
        public DF_030_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_030_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_031", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Reference-Station Indicator")] //DF141
    public class DF_031_BIT_1 : DataFieldBase<byte>
    {
        public DF_031_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_031_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_032", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Single Receiver Oscillator Indicator")] //DF142
    public class DF_032_BIT_1 : DataFieldBase<byte>
    {
        public DF_032_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_032_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_033", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Source Name Counter")] //DF143
    public class DF_033_UINT_5 : DataFieldBase<byte>
    {
        public DF_033_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_033_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_034", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Source Name")] //DF144
    public class DF_034_STR : DataFieldBase<string>
    {
        public DF_034_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_034_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_035", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Target Name Counter")] //DF145
    public class DF_035_UINT_5 : DataFieldBase<byte>
    {
        public DF_035_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_035_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_036", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Target Name")] //DF146
    public class DF_036_STR : DataFieldBase<string>
    {
        public DF_036_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_036_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_037", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "System Identification Number")] //DF147
    public class DF_037_UINT_8 : DataFieldBase<byte>
    {
        public DF_037_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_037_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_038", dataType: "BIT", bitLength: 10, scaleFactor: 0, description: "Utilized Tranformation Message Indicator")] //DF148
    public class DF_038_BIT_10 : DataFieldBase<ushort>
    {
        public DF_038_BIT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_038_BIT_10(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_039", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Plate Number")] //DF149
    public class DF_039_UINT_5 : DataFieldBase<byte>
    {
        public DF_039_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_039_UINT_5(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_040", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "Computation Indicator")] //DF150
    public class DF_040_UINT_4 : DataFieldBase<byte>
    {
        public DF_040_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_040_UINT_4(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_041", dataType: "UINT", bitLength: 2, scaleFactor: 0, description: "Height Indicator")] //DF151
    public class DF_041_UINT_2 : DataFieldBase<byte>
    {
        public DF_041_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_041_UINT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_042", dataType: "INT", bitLength: 19, scaleFactor: 2, description: "ΦV (Area of validity, lat)")] //DF152
    public class DF_042_INT_19_S : DataFieldBase<int>
    {
        public DF_042_INT_19_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_042_INT_19_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_043", dataType: "INT", bitLength: 20, scaleFactor: 2, description: "ΛV (Area of validity, lon)")] //DF153
    public class DF_043_INT_20_S : DataFieldBase<int>
    {
        public DF_043_INT_20_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_043_INT_20_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_044", dataType: "UINT", bitLength: 14, scaleFactor: 2, description: "∆ΦV (Area of validity, NS extension)")] //DF154
    public class DF_044_UINT_14_S : DataFieldBase<ushort>
    {
        public DF_044_UINT_14_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_044_UINT_14_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_045", dataType: "UINT", bitLength: 14, scaleFactor: 2, description: "∆ΛV (Area of validity, EW extension)")] //DF155
    public class DF_045_UINT_14_S : DataFieldBase<ushort>
    {
        public DF_045_UINT_14_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_045_UINT_14_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_046", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dX (Translation in X)")] //DF156
    public class DF_046_INT_23_S : DataFieldBase<int>
    {
        public DF_046_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_046_INT_23_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_047", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dY (Translation in Y)")] //DF157
    public class DF_047_INT_23_S : DataFieldBase<int>
    {
        public DF_047_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_047_INT_23_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_048", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dZ (Translation in Z)")] //DF158
    public class DF_048_INT_23_S : DataFieldBase<int>
    {
        public DF_048_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_048_INT_23_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_049", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R1 (Rotation around X)")] //DF159
    public class DF_049_INT_32_S : DataFieldBase<int>
    {
        public DF_049_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_049_INT_32_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_050", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R2 (Rotation around Y)")] //DF160
    public class DF_050_INT_32_S : DataFieldBase<int>
    {
        public DF_050_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_050_INT_32_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_051", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R3 (Rotation around Z)")] //DF161
    public class DF_051_INT_32_S : DataFieldBase<int>
    {
        public DF_051_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_051_INT_32_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_052", dataType: "INT", bitLength: 25, scaleFactor: 0.00002, description: "dS (Scale correction)")] //DF162
    public class DF_052_INT_25_S : DataFieldBase<int>
    {
        public DF_052_INT_25_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_052_INT_25_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_053", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "XP (X-coord for Molodenski-Badekas rotation)")] //DF163
    public class DF_053_INT_35_S : DataFieldBase<long>
    {
        public DF_053_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_053_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_054", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "YP (Y-coord for Molodenski-Badekas rotation)")] //DF164
    public class DF_054_INT_35_S : DataFieldBase<long>
    {
        public DF_054_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_054_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_055", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "ZP (Z-coord for Molodenski-Badekas rotation)")] //DF165
    public class DF_055_INT_35_S : DataFieldBase<long>
    {
        public DF_055_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_055_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_056", dataType: "UINT", bitLength: 24, scaleFactor: 0.001, description: "add aS")] //DF166
    public class DF_056_UINT_24_S : DataFieldBase<uint>
    {
        public DF_056_UINT_24_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_056_UINT_24_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_057", dataType: "UINT", bitLength: 25, scaleFactor: 0.001, description: "add bS")] //DF167
    public class DF_057_UINT_25_S : DataFieldBase<uint>
    {
        public DF_057_UINT_25_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_057_UINT_25_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_058", dataType: "UINT", bitLength: 24, scaleFactor: 0.001, description: "add aT")] //DF168
    public class DF_058_UINT_24_S : DataFieldBase<uint>
    {
        public DF_058_UINT_24_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_058_UINT_24_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_059", dataType: "UINT", bitLength: 25, scaleFactor: 0.001, description: "add bT")] //DF169
    public class DF_059_UINT_25_S : DataFieldBase<uint>
    {
        public DF_059_UINT_25_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_059_UINT_25_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_060", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "Projection Type")] //DF170
    public class DF_060_UINT_6 : DataFieldBase<byte>
    {
        public DF_060_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_060_UINT_6(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_061", dataType: "INT", bitLength: 34, scaleFactor: 0.000000011, description: "LaNO [°]")] //DF171
    public class DF_061_INT_34_S : DataFieldBase<long>
    {
        public DF_061_INT_34_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_061_INT_34_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_062", dataType: "INT", bitLength: 35, scaleFactor: 0.000000011, description: "LoNO [°]")] //DF172
    public class DF_062_INT_35_S : DataFieldBase<long>
    {
        public DF_062_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_062_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_063", dataType: "UINT", bitLength: 30, scaleFactor: 0.00001, description: "add SNO")] //DF173
    public class DF_063_UINT_30_S : DataFieldBase<uint>
    {
        public DF_063_UINT_30_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_063_UINT_30_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_064", dataType: "UINT", bitLength: 36, scaleFactor: 0.001, description: "FE")] //DF174
    public class DF_064_UINT_36_S : DataFieldBase<ulong>
    {
        public DF_064_UINT_36_S(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator DF_064_UINT_36_S(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_065", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "FN")] //DF175
    public class DF_065_INT_35_S : DataFieldBase<long>
    {
        public DF_065_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_065_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_066", dataType: "INT", bitLength: 34, scaleFactor: 0.000000011, description: "LaFO [°]")] //DF176
    public class DF_066_INT_34_S : DataFieldBase<long>
    {
        public DF_066_INT_34_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_066_INT_34_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_067", dataType: "INT", bitLength: 35, scaleFactor: 0.000000011, description: "LoFO [°]")] //DF177
    public class DF_067_INT_35_S : DataFieldBase<long>
    {
        public DF_067_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_067_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_068", dataType: "INT", bitLength: 34, scaleFactor: 0.000000011, description: "LaSP1 [°]")] //DF178
    public class DF_068_INT_34_S : DataFieldBase<long>
    {
        public DF_068_INT_34_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_068_INT_34_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_069", dataType: "INT", bitLength: 34, scaleFactor: 0.000000011, description: "LaSP2 [°]")] //DF179
    public class DF_069_INT_34_S : DataFieldBase<long>
    {
        public DF_069_INT_34_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_069_INT_34_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_070", dataType: "UINT", bitLength: 36, scaleFactor: 0.001, description: "EFO")] //DF180
    public class DF_070_UINT_36_S : DataFieldBase<ulong>
    {
        public DF_070_UINT_36_S(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator DF_070_UINT_36_S(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_071", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "NFO")] //DF181
    public class DF_071_INT_35_S : DataFieldBase<long>
    {
        public DF_071_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_071_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_072", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Rectification Flag")] //DF182
    public class DF_072_BIT_1 : DataFieldBase<byte>
    {
        public DF_072_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_072_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_073", dataType: "INT", bitLength: 34, scaleFactor: 0.000000011, description: "LaPC")] //DF183
    public class DF_073_INT_34_S : DataFieldBase<long>
    {
        public DF_073_INT_34_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_073_INT_34_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_074", dataType: "INT", bitLength: 35, scaleFactor: 0.000000011, description: "LoPC")] //DF184
    public class DF_074_INT_35_S : DataFieldBase<long>
    {
        public DF_074_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_074_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_075", dataType: "UINT", bitLength: 35, scaleFactor: 0.000000011, description: "AzIL")] //DF185
    public class DF_075_UINT_35_S : DataFieldBase<ulong>
    {
        public DF_075_UINT_35_S(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator DF_075_UINT_35_S(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_076", dataType: "INT", bitLength: 26, scaleFactor: 0.000000011, description: "Diff ARSG")] //DF186
    public class DF_076_INT_26_S : DataFieldBase<int>
    {
        public DF_076_INT_26_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_076_INT_26_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_077", dataType: "UINT", bitLength: 30, scaleFactor: 0.00001, description: "Add SIL")] //DF187
    public class DF_077_UINT_30_S : DataFieldBase<uint>
    {
        public DF_077_UINT_30_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_077_UINT_30_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_078", dataType: "UINT", bitLength: 36, scaleFactor: 0.001, description: "EPC")] //DF188
    public class DF_078_UINT_36_S : DataFieldBase<ulong>
    {
        public DF_078_UINT_36_S(ulong _rawValue) : base(_rawValue) { }
        public static implicit operator DF_078_UINT_36_S(ulong _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_079", dataType: "INT", bitLength: 35, scaleFactor: 0.001, description: "NPC")] //DF189
    public class DF_079_INT_35_S : DataFieldBase<long>
    {
        public DF_079_INT_35_S(long _rawValue) : base(_rawValue) { }
        public static implicit operator DF_079_INT_35_S(long _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_080", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Horizontal Shift Indicator")] //DF190
    public class DF_080_BIT_1 : DataFieldBase<byte>
    {
        public DF_080_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_080_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_081", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Vertical Shift Indicator")] //DF191
    public class DF_081_BIT_1 : DataFieldBase<byte>
    {
        public DF_081_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_081_BIT_1(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_082", dataType: "INT", bitLength: 21, scaleFactor: 0.5, description: "Φ0")] //DF192
    public class DF_082_INT_21_S : DataFieldBase<int>
    {
        public DF_082_INT_21_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_082_INT_21_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_083", dataType: "INT", bitLength: 22, scaleFactor: 0.5, description: "Λ0")] //DF193
    public class DF_083_INT_22_S : DataFieldBase<int>
    {
        public DF_083_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_083_INT_22_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_084", dataType: "UINT", bitLength: 12, scaleFactor: 0.5, description: "∆φ")] //DF194
    public class DF_084_UINT_12_S : DataFieldBase<ushort>
    {
        public DF_084_UINT_12_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_084_UINT_12_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_085", dataType: "UINT", bitLength: 12, scaleFactor: 0.5, description: "∆λ")] //DF195
    public class DF_085_UINT_12_S : DataFieldBase<ushort>
    {
        public DF_085_UINT_12_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_085_UINT_12_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_086", dataType: "INT", bitLength: 8, scaleFactor: 0.001, description: "Mean ∆φ")] //DF196
    public class DF_086_INT_8_S : DataFieldBase<sbyte>
    {
        public DF_086_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_086_INT_8_S(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_087", dataType: "INT", bitLength: 8, scaleFactor: 0.001, description: "Mean ∆λ")] //DF197
    public class DF_087_INT_8_S : DataFieldBase<sbyte>
    {
        public DF_087_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_087_INT_8_S(sbyte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_088", dataType: "INT", bitLength: 15, scaleFactor: 0.01, description: "Mean ∆H")] //DF198
    public class DF_088_INT_15_S : DataFieldBase<short>
    {
        public DF_088_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_088_INT_15_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_089", dataType: "INT", bitLength: 9, scaleFactor: 0.00003, description: "δφi")] //DF199
    public class DF_089_INT_9_S : DataFieldBase<short>
    {
        public DF_089_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_089_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_090", dataType: "INT", bitLength: 9, scaleFactor: 0.00003, description: "δλi")] //DF200
    public class DF_090_INT_9_S : DataFieldBase<short>
    {
        public DF_090_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_090_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_091", dataType: "INT", bitLength: 9, scaleFactor: 0.001, description: "δhi")] //DF201
    public class DF_091_INT_9_S : DataFieldBase<short>
    {
        public DF_091_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_091_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_092", dataType: "INT", bitLength: 25, scaleFactor: 10, description: "N0")] //DF202
    public class DF_092_INT_25_S : DataFieldBase<int>
    {
        public DF_092_INT_25_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_092_INT_25_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_093", dataType: "UINT", bitLength: 26, scaleFactor: 10, description: "E0")] //DF203
    public class DF_093_UINT_26_S : DataFieldBase<uint>
    {
        public DF_093_UINT_26_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator DF_093_UINT_26_S(uint _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_094", dataType: "UINT", bitLength: 12, scaleFactor: 10, description: "∆N")] //DF204
    public class DF_094_UINT_12_S : DataFieldBase<ushort>
    {
        public DF_094_UINT_12_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_094_UINT_12_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_095", dataType: "UINT", bitLength: 12, scaleFactor: 10, description: "∆E")] //DF205
    public class DF_095_UINT_12_S : DataFieldBase<ushort>
    {
        public DF_095_UINT_12_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_095_UINT_12_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_096", dataType: "INT", bitLength: 10, scaleFactor: 0.01, description: "Mean ∆N")] //DF206
    public class DF_096_INT_10_S : DataFieldBase<short>
    {
        public DF_096_INT_10_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_096_INT_10_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_097", dataType: "INT", bitLength: 10, scaleFactor: 0.01, description: "Mean ∆E")] //DF207
    public class DF_097_INT_10_S : DataFieldBase<short>
    {
        public DF_097_INT_10_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_097_INT_10_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_098", dataType: "INT", bitLength: 15, scaleFactor: 0.01, description: "Mean ∆h")] //DF208
    public class DF_098_INT_15_S : DataFieldBase<int>
    {
        public DF_098_INT_15_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator DF_098_INT_15_S(int _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_099", dataType: "INT", bitLength: 9, scaleFactor: 0.001, description: "δNi")] //DF209
    public class DF_099_INT_9_S : DataFieldBase<short>
    {
        public DF_099_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_099_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_100", dataType: "INT", bitLength: 9, scaleFactor: 0.001, description: "δEi")] //DF210
    public class DF_100_INT_9_S : DataFieldBase<short>
    {
        public DF_100_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_100_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_101", dataType: "INT", bitLength: 9, scaleFactor: 0.001, description: "δhi")] //DF211
    public class DF_101_INT_9_S : DataFieldBase<short>
    {
        public DF_101_INT_9_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_101_INT_9_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_102", dataType: "UINT", bitLength: 2, scaleFactor: 0, description: "Horizontal Interpolation Method Indicator")] //DF212
    public class DF_102_UINT_2 : DataFieldBase<byte>
    {
        public DF_102_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_102_UINT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_103", dataType: "UINT", bitLength: 2, scaleFactor: 0, description: "Vertical Interpolation Method Indicator")] //DF213
    public class DF_103_UINT_2 : DataFieldBase<byte>
    {
        public DF_103_UINT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_103_UINT_2(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_104", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "Horizontal Helmert/Molodenski Quality Indicator")] //DF214
    public class DF_104_UINT_3 : DataFieldBase<byte>
    {
        public DF_104_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_104_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_105", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "Vertical Helmert/Molodenski Quality Indicator")] //DF215
    public class DF_105_UINT_3 : DataFieldBase<byte>
    {
        public DF_105_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_105_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_106", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "Horizontal Grid Quality Indicator")] //DF216
    public class DF_106_UINT_3 : DataFieldBase<byte>
    {
        public DF_106_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_106_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_107", dataType: "UINT", bitLength: 3, scaleFactor: 0, description: "Vertical Grid Quality Indicator")] //DF217
    public class DF_107_UINT_3 : DataFieldBase<byte>
    {
        public DF_107_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_107_UINT_3(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_108", dataType: "UINT", bitLength: 8, scaleFactor: 0.5, description: "soc")] //DF218
    public class DF_108_UINT_8_S : DataFieldBase<byte>
    {
        public DF_108_UINT_8_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_108_UINT_8_S(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_109", dataType: "UINT", bitLength: 9, scaleFactor: 0.01, description: "sod")] //DF219
    public class DF_109_UINT_9_S : DataFieldBase<ushort>
    {
        public DF_109_UINT_9_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_109_UINT_9_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_110", dataType: "UINT", bitLength: 6, scaleFactor: 0.1, description: "soh")] //DF220
    public class DF_110_UINT_6_S : DataFieldBase<byte>
    {
        public DF_110_UINT_6_S(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_110_UINT_6_S(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_111", dataType: "UINT", bitLength: 10, scaleFactor: 0.5, description: "sIc")] //DF221
    public class DF_111_UINT_10_S : DataFieldBase<ushort>
    {
        public DF_111_UINT_10_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_111_UINT_10_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_112", dataType: "UINT", bitLength: 10, scaleFactor: 0.01, description: "sId")] //DF222
    public class DF_112_UINT_10_S : DataFieldBase<ushort>
    {
        public DF_112_UINT_10_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_112_UINT_10_S(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_113", dataType: "UINT", bitLength: 7, scaleFactor: 0, description: "N-Refs")] //DF223
    public class DF_113_UINT_7 : DataFieldBase<byte>
    {
        public DF_113_UINT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_113_UINT_7(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_114", dataType: "UINT", bitLength: 12, scaleFactor: 0, description: "Physical Reference Station ID")] //DF226
    public class DF_114_UINT_12 : DataFieldBase<ushort>
    {
        public DF_114_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator DF_114_UINT_12(ushort _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_115", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Receiver Type Descriptor Counter")] //DF227
    public class DF_115_UINT_8 : DataFieldBase<byte>
    {
        public DF_115_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_115_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_116", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Receiver Type Descriptor")] //DF228
    public class DF_115_STR : DataFieldBase<string>
    {
        public DF_115_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_115_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_117", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Receiver Firmware Version Counter")] //DF229
    public class DF_117_UINT_8 : DataFieldBase<byte>
    {
        public DF_117_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_117_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_118", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Receiver Firmware Version")] //DF230
    public class DF_118_STR : DataFieldBase<string>
    {
        public DF_118_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_118_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_119", dataType: "UINT", bitLength: 8, scaleFactor: 0, description: "Receiver Serial Number Counter")] //DF231
    public class DF_119_UINT_8 : DataFieldBase<byte>
    {
        public DF_119_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator DF_119_UINT_8(byte _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_120", dataType: "CHA", bitLength: 8, scaleFactor: 0, description: "Receiver Serial Number")] //DF232
    public class DF_120_STR : DataFieldBase<string>
    {
        public DF_120_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator DF_120_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_121", dataType: "INT", bitLength: 12, scaleFactor: 0.01, description: "N0: Geometric Gradient in north (ppm)")] //DF242
    public class DF_121_INT_12_S : DataFieldBase<short>
    {
        public DF_121_INT_12_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_121_INT_12_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_122", dataType: "INT", bitLength: 12, scaleFactor: 0.01, description: "E0: Geometric gradient in east (ppm)")] //DF243
    public class DF_122_INT_12_S : DataFieldBase<short>
    {
        public DF_122_INT_12_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_122_INT_12_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_123", dataType: "INT", bitLength: 14, scaleFactor: 0.01, description: "NI: Ionospheric gradient in north  (ppm)")] //DF244
    public class DF_123_INT_14_S : DataFieldBase<short>
    {
        public DF_123_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_123_INT_14_S(short _rawValue) => new(_rawValue);
    }

    [DataField(name: "DF_124", dataType: "INT", bitLength: 14, scaleFactor: 0.01, description: "EI: Ionospheric gradient in east  (ppm)")] //DF245
    public class DF_124_INT_14_S : DataFieldBase<short>
    {
        public DF_124_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator DF_124_INT_14_S(short _rawValue) => new(_rawValue);
    }

}
