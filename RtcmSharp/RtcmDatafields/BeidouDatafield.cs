using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "BEIDOU_001", dataType: "UINT", bitLength: 30, scaleFactor: 1, description: "BeiDou Epoch Time (TOW)")] //DF427
    public class BEIDOU_001_UINT_30 : DataFieldBase<uint>
    {
        public BEIDOU_001_UINT_30(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_001_UINT_30(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_001_UINT_30(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_002", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "BDS Epoch Time 1s")] //DF465
    public class BEIDOU_002_UINT_20 : DataFieldBase<uint>
    {
        public BEIDOU_002_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_002_UINT_20(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_002_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_003", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "BDS Signal and Tracking Mode Identifier")] //DF467
    public class BEIDOU_003_UINT_5 : DataFieldBase<byte>
    {
        public BEIDOU_003_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_003_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_003_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_004", dataType: "BIT", bitLength: 10, scaleFactor: 8, description: "BDS toe Modulo")] //DF470
    public class BEIDOU_004_BIT_10 : DataFieldBase<ushort>
    {
        public BEIDOU_004_BIT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_004_BIT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_004_BIT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "BEIDOU_005", dataType: "BIT", bitLength: 8, scaleFactor: 0, description: "BDS IOD")] //DF471
    public class BEIDOU_005_BIT_8 : DataFieldBase<byte>
    {
        public BEIDOU_005_BIT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_005_BIT_8(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_005_BIT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_006", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "BDS Satellite ID")] //DF488
    public class BEIDOU_006_UINT_6 : DataFieldBase<byte>
    {
        public BEIDOU_006_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_006_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_006_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_007", dataType: "UINT", bitLength: 13, scaleFactor: 1, description: "BDS Week Number")] //DF489
    public class BEIDOU_007_UINT_13 : DataFieldBase<ushort>
    {
        public BEIDOU_007_UINT_13(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_007_UINT_13(ushort _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_007_UINT_13(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "BEIDOU_008", dataType: "BIT", bitLength: 4, scaleFactor: 1, description: "BDS URAI")] //DF490
    public class BEIDOU_008_BIT_4 : DataFieldBase<byte>
    {
        public BEIDOU_008_BIT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_008_BIT_4(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_008_BIT_4(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_009", dataType: "INT", bitLength: 14, scaleFactor: RtcmConstants.P2_43, description: "BDS IDOT")] //DF491
    public class BEIDOU_009_INT_14_S : DataFieldBase<short>
    {
        public BEIDOU_009_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_009_INT_14_S(short _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_009_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "BEIDOU_010", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "BDS AODE")] //DF492
    public class BEIDOU_010_UINT_5 : DataFieldBase<byte>
    {
        public BEIDOU_010_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_010_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_010_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_011", dataType: "UINT", bitLength: 17, scaleFactor: 8, description: "BDS Toc")] //DF493
    public class BEIDOU_011_UINT_17_S : DataFieldBase<uint>
    {
        public BEIDOU_011_UINT_17_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_011_UINT_17_S(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_011_UINT_17_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_012", dataType: "INT", bitLength: 11, scaleFactor: RtcmConstants.P2_66, description: "BDS a2")] //DF494
    public class BEIDOU_012_INT_11_S : DataFieldBase<short>
    {
        public BEIDOU_012_INT_11_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_012_INT_11_S(short _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_012_INT_11_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "BEIDOU_013", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_50, description: "BDS a1")] //DF495
    public class BEIDOU_013_INT_22_S : DataFieldBase<int>
    {
        public BEIDOU_013_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_013_INT_22_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_013_INT_22_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_014", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_33, description: "BSD a0")] //DF496
    public class BEIDOU_014_INT_24_S : DataFieldBase<int>
    {
        public BEIDOU_014_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_014_INT_24_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_014_INT_24_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_015", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "BDS AODC")] //DF497
    public class BEIDOU_015_UINT_5 : DataFieldBase<byte>
    {
        public BEIDOU_015_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_015_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_015_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_016", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_6, description: "BDS Crs")] //DF498
    public class BEIDOU_016_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_016_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_016_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_016_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_017", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "BDS ∆n")] //DF499
    public class BEIDOU_017_INT_16_S : DataFieldBase<short>
    {
        public BEIDOU_017_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_017_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_017_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "BEIDOU_018", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "BDS M0")] //DF500
    public class BEIDOU_018_INT_32_S : DataFieldBase<int>
    {
        public BEIDOU_018_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_018_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_018_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_019", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_31, description: "BDS Cuc")] //DF501
    public class BEIDOU_019_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_019_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_019_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_019_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_020", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_33, description: "BDS e (Eccentricity)")] //DF502
    public class BEIDOU_020_UINT_32_S : DataFieldBase<uint>
    {
        public BEIDOU_020_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_020_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_020_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_021", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_31, description: "BDS Cus")] //DF503
    public class BEIDOU_021_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_021_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_021_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_021_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_022", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_19, description: "BDS A½")] //DF504
    public class BEIDOU_022_UINT_32_S : DataFieldBase<uint>
    {
        public BEIDOU_022_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_022_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_022_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_023", dataType: "UINT", bitLength: 17, scaleFactor: 8, description: "BDS Toe")] //DF505
    public class BEIDOU_023_UINT_17_S : DataFieldBase<uint>
    {
        public BEIDOU_023_UINT_17_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_023_UINT_17_S(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_023_UINT_17_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_024", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_31, description: "BDS Cic")] //DF506
    public class BEIDOU_024_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_024_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_024_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_024_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_025", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "BDS Ω0")] //DF507
    public class BEIDOU_025_INT_32_S : DataFieldBase<int>
    {
        public BEIDOU_025_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_025_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_025_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_026", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_31, description: "BDS Cis")] //DF508
    public class BEIDOU_026_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_026_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_026_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_026_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_027", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "BDS i0")] //DF509
    public class BEIDOU_027_INT_32_S : DataFieldBase<int>
    {
        public BEIDOU_027_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_027_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_027_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_028", dataType: "INT", bitLength: 18, scaleFactor: RtcmConstants.P2_6, description: "BDS Crc")] //DF510
    public class BEIDOU_028_INT_18_S : DataFieldBase<int>
    {
        public BEIDOU_028_INT_18_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_028_INT_18_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_028_INT_18_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_029", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "BDS ω (Argument of Perigee)")] //DF511
    public class BEIDOU_029_INT_32_S : DataFieldBase<int>
    {
        public BEIDOU_029_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_029_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_029_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_030", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_43, description: "BDS ΩDOT (Rate of Right Ascension)")] //DF512
    public class BEIDOU_030_INT_24_S : DataFieldBase<int>
    {
        public BEIDOU_030_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_030_INT_24_S(int _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_030_INT_24_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "BEIDOU_031", dataType: "INT", bitLength: 10, scaleFactor: 0.1, description: "BDS TGD1")] //DF513
    public class BEIDOU_031_INT_10_S : DataFieldBase<short>
    {
        public BEIDOU_031_INT_10_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_031_INT_10_S(short _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_031_INT_10_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "BEIDOU_032", dataType: "INT", bitLength: 10, scaleFactor: 0.1, description: "BDS TGD2")] //DF514
    public class BEIDOU_032_INT_10_S : DataFieldBase<short>
    {
        public BEIDOU_032_INT_10_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_032_INT_10_S(short _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_032_INT_10_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "BEIDOU_033", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "BSD SV Health")] //DF515
    public class BEIDOU_033_BIT_1 : DataFieldBase<byte>
    {
        public BEIDOU_033_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_033_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_033_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "BEIDOU_034", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "Beidou Residuals Epoch Time TOW")] //DF571
    public class BEIDOU_034_UINT_20 : DataFieldBase<uint>
    {
        public BEIDOU_034_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_034_UINT_20(uint _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_034_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "BEIDOU_035", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Beidou Number of Satellite Signals Processed")] //DF572
    public class BEIDOU_035_UINT_5 : DataFieldBase<byte>
    {
        public BEIDOU_035_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator BEIDOU_035_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator BEIDOU_035_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }
}
