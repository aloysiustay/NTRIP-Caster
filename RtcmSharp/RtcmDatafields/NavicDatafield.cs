using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "NAVIC_001", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "NAVIC/IRNSS Satellite ID")] //DF516
    public class NAVIC_001_UINT_6 : DataFieldBase<byte>
    {
        public NAVIC_001_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_001_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_001_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_002", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "NAVIC/IRNSS Week Number (WN)")] //DF517
    public class NAVIC_002_UINT_10 : DataFieldBase<ushort>
    {
        public NAVIC_002_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_002_UINT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_002_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_003", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS Clock Bias (af0)")] //DF518
    public class NAVIC_003_INT_22_S : DataFieldBase<int>
    {
        public NAVIC_003_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_003_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_003_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_004", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "NAVIC/IRNSS Clock Drift (af1)")] //DF519
    public class NAVIC_004_INT_16_S : DataFieldBase<short>
    {
        public NAVIC_004_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_004_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_004_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_005", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_55, description: "NAVIC/IRNSS Clock Drift Rate (af2)")] //DF520
    public class NAVIC_005_INT_8_S : DataFieldBase<sbyte>
    {
        public NAVIC_005_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_005_INT_8_S(sbyte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_005_INT_8_S(long _rawValue) => new((sbyte)_rawValue);
    }

    [DataField(name: "NAVIC_006", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "NAVIC/IRNSS SV Accuracy (URA)")] //DF521
    public class NAVIC_006_UINT_4 : DataFieldBase<byte>
    {
        public NAVIC_006_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_006_UINT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_006_UINT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_007", dataType: "UINT", bitLength: 16, scaleFactor: 16, description: "NAVIC/IRNSS Time of Clock (toc)")] //DF522
    public class NAVIC_007_UINT_16_S : DataFieldBase<ushort>
    {
        public NAVIC_007_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_007_UINT_16_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_007_UINT_16_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_008", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS Total Group Delay (TGD)")] //DF523
    public class NAVIC_008_INT_8_S : DataFieldBase<sbyte>
    {
        public NAVIC_008_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_008_INT_8_S(sbyte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_008_INT_8_S(long _rawValue) => new((sbyte)_rawValue);
    }

    [DataField(name: "NAVIC_009", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_41, description: "NAVIC/IRNSS Mean Motion Difference (∆n)")] //DF524
    public class NAVIC_009_INT_22_S : DataFieldBase<int>
    {
        public NAVIC_009_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_009_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_009_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_010", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "NAVIC/IRNSS Issue of Data Ephemeric & Clock (IODEC)")] //DF525
    public class NAVIC_010_UINT_8 : DataFieldBase<byte>
    {
        public NAVIC_010_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_010_UINT_8(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_010_UINT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_011", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "NAVIC/IRNSS Reserved bits after IODEC")] //DF526
    public class NAVIC_011_UINT_10 : DataFieldBase<ushort>
    {
        public NAVIC_011_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_011_UINT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_011_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_012", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "NAVIC/IRNSS L5 Flag")] //DF527
    public class NAVIC_012_BIT_1: DataFieldBase<byte>
    {
        public NAVIC_012_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_012_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_012_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_013", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "NAVIC/IRNSS S Flag")] //DF528
    public class NAVIC_013_BIT_1 : DataFieldBase<byte>
    {
        public NAVIC_013_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_013_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_013_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_014", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_28, description: "NAVIC/IRNSS Cuc")] //DF529
    public class NAVIC_014_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_014_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_014_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_014_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_015", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_28, description: "NAVIC/IRNSS Cus")] //DF530
    public class NAVIC_015_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_015_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_015_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_015_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_016", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_28, description: "NAVIC/IRNSS Cic")] //DF531
    public class NAVIC_016_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_016_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_016_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_016_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_017", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_28, description: "NAVIC/IRNSS Cis")] //DF532
    public class NAVIC_017_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_017_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_017_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_017_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_018", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_4, description: "NAVIC/IRNSS Crc")] //DF533
    public class NAVIC_018_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_018_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_018_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_018_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_019", dataType: "INT", bitLength: 15, scaleFactor: RtcmConstants.P2_4, description: "NAVIC/IRNSS Crs")] //DF534
    public class NAVIC_019_INT_15_S : DataFieldBase<short>
    {
        public NAVIC_019_INT_15_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_019_INT_15_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_019_INT_15_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_020", dataType: "INT", bitLength: 14, scaleFactor: RtcmConstants.P2_43, description: "NAVIC/IRNSS IDOT")] //DF535
    public class NAVIC_020_INT_14_S : DataFieldBase<short>
    {
        public NAVIC_020_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_020_INT_14_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_020_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_021", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS M0")] //DF536
    public class NAVIC_021_INT_32_S : DataFieldBase<int>
    {
        public NAVIC_021_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_021_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_021_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_022", dataType: "UINT", bitLength: 16, scaleFactor: 16, description: "NAVIC/IRNSS tOE")] //DF537
    public class NAVIC_022_UINT_16_S : DataFieldBase<ushort>
    {
        public NAVIC_022_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_022_UINT_16_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_022_UINT_16_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_023", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_33, description: "NAVIC/IRNSS e (Eccentricity)")] //DF538
    public class NAVIC_023_UINT_32_S : DataFieldBase<uint>
    {
        public NAVIC_023_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_023_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_023_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_024", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_19, description: "NAVIC/IRNSS √A (Square root of semi major axis)")] //DF539
    public class NAVIC_024_UINT_32_S : DataFieldBase<uint>
    {
        public NAVIC_024_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_024_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_024_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_025", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS Ω0 (Long of Ascending Node)")] //DF540
    public class NAVIC_025_UINT_32_S : DataFieldBase<uint>
    {
        public NAVIC_025_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_025_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_025_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_026", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS ω (Argument of perigee)")] //DF541
    public class NAVIC_026_UINT_32_S : DataFieldBase<uint>
    {
        public NAVIC_026_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_026_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_026_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_027", dataType: "UINT", bitLength: 22, scaleFactor: RtcmConstants.P2_41, description: "NAVIC/IRNSS ΩDOT (Rate of Right Ascension)")] //DF542
    public class NAVIC_027_UINT_22_S : DataFieldBase<uint>
    {
        public NAVIC_027_UINT_22_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_027_UINT_22_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_027_UINT_22_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_028", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "NAVIC/IRNSS i0 (Inclination)")] //DF543
    public class NAVIC_028_UINT_32_S : DataFieldBase<uint>
    {
        public NAVIC_028_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_028_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_028_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_029", dataType: "BIT", bitLength: 2, scaleFactor: 1, description: "NAVIC/IRNSS 2 spare bits after IDOT")] //DF544
    public class NAVIC_029_BIT_2 : DataFieldBase<byte>
    {
        public NAVIC_029_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_029_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_029_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_030", dataType: "BIT", bitLength: 2, scaleFactor: 1, description: "NAVIC/IRNSS 2 spare bits after i0")] //DF545
    public class NAVIC_030_BIT_2 : DataFieldBase<byte>
    {
        public NAVIC_030_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_030_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_030_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_031", dataType: "UINT", bitLength: 30, scaleFactor: 1, description: "NAVIC/IRNSS Epoch Time (TOW)")] //DF546
    public class NAVIC_031_UINT_30 : DataFieldBase<uint>
    {
        public NAVIC_031_UINT_30(uint _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_031_UINT_30(uint _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_031_UINT_30(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "NAVIC_032", dataType: "UINT", bitLength: 16, scaleFactor: 1, description: "Reference Epoch t0")] //DF547
    public class NAVIC_032_UINT_16 : DataFieldBase<ushort>
    {
        public NAVIC_032_UINT_16(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_032_UINT_16(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_032_UINT_16(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_033", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dX0 Translation in X for Reference Epoch")] //DF548
    public class NAVIC_033_INT_23_S : DataFieldBase<int>
    {
        public NAVIC_033_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_033_INT_23_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_033_INT_23_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_034", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dY0 Translation in Y for Reference Epoch")] //DF549
    public class NAVIC_034_INT_23_S : DataFieldBase<int>
    {
        public NAVIC_034_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_034_INT_23_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_034_INT_23_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_035", dataType: "INT", bitLength: 23, scaleFactor: 0.001, description: "dZ0 Translation in Z for Reference Epoch")] //DF550
    public class NAVIC_035_INT_23_S : DataFieldBase<int>
    {
        public NAVIC_035_INT_23_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_035_INT_23_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_035_INT_23_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_036", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R01 Rotation about X for Reference Epoch")] //DF551
    public class NAVIC_036_INT_32_S : DataFieldBase<int>
    {
        public NAVIC_036_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_036_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_036_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_037", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R02 Rotation about Y for Reference Epoch")] //DF552
    public class NAVIC_037_INT_32_S : DataFieldBase<int>
    {
        public NAVIC_037_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_037_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_037_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_038", dataType: "INT", bitLength: 32, scaleFactor: 0.00002, description: "R03 Rotation about Z for Reference Epoch")] //DF553
    public class NAVIC_038_INT_32_S : DataFieldBase<int>
    {
        public NAVIC_038_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_038_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_038_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_039", dataType: "INT", bitLength: 25, scaleFactor: 0.00001, description: "dS0 Scale Correction for Reference Epoch")] //DF554
    public class NAVIC_039_INT_25_S : DataFieldBase<int>
    {
        public NAVIC_039_INT_25_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_039_INT_25_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_039_INT_25_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_040", dataType: "INT", bitLength: 17, scaleFactor: 0.00002, description: "dot dX Rate of Change of Translation in X")] //DF555
    public class NAVIC_040_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_040_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_040_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_040_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_041", dataType: "INT", bitLength: 17, scaleFactor: 0.00002, description: "dot dY Rate of Change of Translation in X")] //DF556
    public class NAVIC_041_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_041_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_041_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_041_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_042", dataType: "INT", bitLength: 17, scaleFactor: 0.00002, description: "dot dZ Rate of Change of Translation in X")] //DF557
    public class NAVIC_042_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_042_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_042_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_042_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_043", dataType: "INT", bitLength: 17, scaleFactor: 0.0000004, description: "dot R1 Rate of Change of Rotation about X")] //DF558
    public class NAVIC_043_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_043_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_043_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_043_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_044", dataType: "INT", bitLength: 17, scaleFactor: 0.0000004, description: "dot R2 Rate of Change of Rotation about Y")] //DF559
    public class NAVIC_044_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_044_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_044_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_044_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_045", dataType: "INT", bitLength: 17, scaleFactor: 0.0000004, description: "dot R3 Rate of Change of Rotation about Z")] //DF560
    public class NAVIC_045_INT_17_S : DataFieldBase<int>
    {
        public NAVIC_045_INT_17_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_045_INT_17_S(int _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_045_INT_17_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "NAVIC_046", dataType: "INT", bitLength: 14, scaleFactor: 0.0000002, description: "dot dS Rate of Change of Scale Correction")] //DF561
    public class NAVIC_046_INT_14_S : DataFieldBase<short>
    {
        public NAVIC_046_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_046_INT_14_S(short _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_046_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "NAVIC_047", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Service CRS Name Counter")] //DF562
    public class NAVIC_047_UINT_5 : DataFieldBase<byte>
    {
        public NAVIC_047_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_047_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_047_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_048", dataType: "STR", bitLength: 8, scaleFactor: 0, description: "Service CRS Name")] //DF563
    public class NAVIC_048_STR : DataFieldBase<string>
    {
        public NAVIC_048_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_048_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "NAVIC_049", dataType: "UINT", bitLength: 16, scaleFactor: 0.01, description: "Coordinate Epoch CE")] //DF564
    public class NAVIC_049_UINT_16_S : DataFieldBase<ushort>
    {
        public NAVIC_049_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_049_UINT_16_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_049_UINT_16_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "NAVIC_050", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "RTCM CRS Name Counter")] //DF565
    public class NAVIC_050_UINT_5 : DataFieldBase<byte>
    {
        public NAVIC_050_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_050_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_050_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_051", dataType: "STR", bitLength: 8, scaleFactor: 0, description: "RTCM CRS Name")] //DF566
    public class NAVIC_051_STR : DataFieldBase<string>
    {
        public NAVIC_051_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_051_STR(string _rawValue) => new(_rawValue);
    }

    [DataField(name: "NAVIC_052", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Anchor - Global/Plate Fixed Indicator")] //DF567
    public class NAVIC_052_BIT_1 : DataFieldBase<byte>
    {
        public NAVIC_052_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_052_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_052_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_053", dataType: "UINT", bitLength: 3, scaleFactor: 1, description: "Number of Database Links")] //DF568
    public class NAVIC_053_UINT_3 : DataFieldBase<byte>
    {
        public NAVIC_053_UINT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_053_UINT_3(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_053_UINT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_054", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Database Link Counter")] //DF569
    public class NAVIC_054_UINT_5 : DataFieldBase<byte>
    {
        public NAVIC_054_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_054_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator NAVIC_054_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "NAVIC_055", dataType: "STR", bitLength: 8, scaleFactor: 0, description: "Database Link Name")] //DF570
    public class NAVIC_055_STR : DataFieldBase<string>
    {
        public NAVIC_055_STR(string _rawValue) : base(_rawValue) { }
        public static implicit operator NAVIC_055_STR(string _rawValue) => new(_rawValue);
    }
}
