using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "QZSS_001", dataType: "UINT", bitLength: 30, scaleFactor: 1, description: "QZSS Epoch Time (TOW)")] //DF428
    public class QZSS_001_UINT_30 : DataFieldBase<uint>
    {
        public QZSS_001_UINT_30(uint _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_001_UINT_30(uint _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_002", dataType: "UINT", bitLength: 4, scaleFactor: 1, description: "QZSS Satellite ID")] //DF429
    public class QZSS_002_UINT_4 : DataFieldBase<byte>
    {
        public QZSS_002_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_002_UINT_4(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_003", dataType: "UINT", bitLength: 16, scaleFactor: RtcmConstants.P2_P4, description: "QZSS toc")] //DF430
    public class QZSS_003_UINT_16_S : DataFieldBase<ushort>
    {
        public QZSS_003_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_003_UINT_16_S(ushort _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_004", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_55, description: "QZSS af2")] //DF431
    public class QZSS_004_INT_8_S : DataFieldBase<sbyte>
    {
        public QZSS_004_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_004_INT_8_S(sbyte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_005", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "QZSS af1")] //DF432
    public class QZSS_005_INT_16_S : DataFieldBase<short>
    {
        public QZSS_005_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_005_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_006", dataType: "INT", bitLength: 22, scaleFactor: RtcmConstants.P2_31, description: "QZSS af0")] //DF433
    public class QZSS_006_INT_22_S : DataFieldBase<int>
    {
        public QZSS_006_INT_22_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_006_INT_22_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_007", dataType: "UINT", bitLength: 8, scaleFactor: 1, description: "QZSS IODE")] //DF434
    public class QZSS_007_UINT_8 : DataFieldBase<byte>
    {
        public QZSS_007_UINT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_007_UINT_8(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_008", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "QZSS Crs")] //DF435
    public class QZSS_008_INT_16_S : DataFieldBase<short>
    {
        public QZSS_008_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_008_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_009", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "QZSS ∆n")] //DF436
    public class QZSS_009_INT_16_S : DataFieldBase<short>
    {
        public QZSS_009_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_009_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_010", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "QZSS M0")] //DF437
    public class QZSS_010_INT_32_S : DataFieldBase<int>
    {
        public QZSS_010_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_010_INT_32_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_011", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "QZSS Cuc")] //DF438
    public class QZSS_011_INT_16_S : DataFieldBase<short>
    {
        public QZSS_011_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_011_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_012", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_33, description: "QZSS e")] //DF439
    public class QZSS_012_UINT_32_S : DataFieldBase<uint>
    {
        public QZSS_012_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_012_UINT_32_S(uint _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_013", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "QZSS Cus")] //DF440
    public class QZSS_013_INT_16_S : DataFieldBase<short>
    {
        public QZSS_013_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_013_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_014", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_19, description: "QZSS A½")] //DF441
    public class QZSS_014_UINT_32_S : DataFieldBase<uint>
    {
        public QZSS_014_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_014_UINT_32_S(uint _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_015", dataType: "UINT", bitLength: 16, scaleFactor: RtcmConstants.P2_P4, description: "QZSS toe")] //DF442
    public class QZSS_015_UINT_16_S : DataFieldBase<ushort>
    {
        public QZSS_015_UINT_16_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_015_UINT_16_S(ushort _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_016", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "QZSS Cic")] //DF443
    public class QZSS_016_INT_16_S : DataFieldBase<short>
    {
        public QZSS_016_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_016_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_017", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "QZSS Ω0")] //DF444
    public class QZSS_017_INT_32_S : DataFieldBase<int>
    {
        public QZSS_017_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_017_INT_32_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_018", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "QZSS Cis")] //DF445
    public class QZSS_018_INT_16_S : DataFieldBase<short>
    {
        public QZSS_018_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_018_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_019", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "QZSS i0")] //DF446
    public class QZSS_019_INT_32_S : DataFieldBase<int>
    {
        public QZSS_019_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_019_INT_32_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_020", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "QZSS Crc")] //DF447
    public class QZSS_020_INT_16_S : DataFieldBase<short>
    {
        public QZSS_020_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_020_INT_16_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_021", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "QZSS ω (Argument of Perigee)")] //DF448
    public class QZSS_021_INT_32_S : DataFieldBase<int>
    {
        public QZSS_021_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_021_INT_32_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_022", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_43, description: "QZSS ΩDOT (Rate of Right Ascension)")] //DF449
    public class QZSS_022_INT_24_S : DataFieldBase<int>
    {
        public QZSS_022_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_022_INT_24_S(int _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_023", dataType: "INT", bitLength: 14, scaleFactor: RtcmConstants.P2_43, description: "QZSS i0-DOT")] //DF450
    public class QZSS_023_INT_14_S : DataFieldBase<short>
    {
        public QZSS_023_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_023_INT_14_S(short _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_024", dataType: "BIT", bitLength: 2, scaleFactor: 1, description: "QZSS Codes on L2 Channel")] //DF451
    public class QZSS_024_BIT_2 : DataFieldBase<byte>
    {
        public QZSS_024_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_024_BIT_2(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_025", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "QZSS Week Number")] //DF452
    public class QZSS_025_UINT_10 : DataFieldBase<ushort>
    {
        public QZSS_025_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_025_UINT_10(ushort _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_026", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "QZSS URA")] //DF453
    public class QZSS_026_UINT_4 : DataFieldBase<byte>
    {
        public QZSS_026_UINT_4(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_026_UINT_4(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_027", dataType: "UINT", bitLength: 6, scaleFactor: 1, description: "QZSS SV health")] //DF454
    public class QZSS_027_UINT_6 : DataFieldBase<byte>
    {
        public QZSS_027_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_027_UINT_6(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_028", dataType: "INT", bitLength: 8, scaleFactor: RtcmConstants.P2_31, description: "QZSS TGD")] //DF455
    public class QZSS_028_INT_8_S : DataFieldBase<sbyte>
    {
        public QZSS_028_INT_8_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_028_INT_8_S(sbyte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_029", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "QZSS IODC")] //DF456
    public class QZSS_029_UINT_10 : DataFieldBase<ushort>
    {
        public QZSS_029_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_029_UINT_10(ushort _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_030", dataType: "BIT", bitLength: 1, scaleFactor: 1, description: "QZSS Fit Interval")] //DF457
    public class QZSS_030_BIT_1 : DataFieldBase<byte>
    {
        public QZSS_030_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_030_BIT_1(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_031", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "QZSS Epoch Time 1s")] //DF460
    public class QZSS_031_UINT_20 : DataFieldBase<uint>
    {
        public QZSS_031_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_031_UINT_20(uint _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_032", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "QZSS Signal and Tracking Mode Identifier")] //DF461
    public class QZSS_032_UINT_5 : DataFieldBase<byte>
    {
        public QZSS_032_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_032_UINT_5(byte _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_033", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "QZSS Residuals Epoch Time TOW")] //DF575
    public class QZSS_033_UINT_20 : DataFieldBase<uint>
    {
        public QZSS_033_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_033_UINT_20(uint _rawValue) => new (_rawValue);
    }

    [DataField(name: "QZSS_034", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "QZSS Number of Satellite Signals Processed")] //DF576
    public class QZSS_034_UINT_5 : DataFieldBase<byte>
    {
        public QZSS_034_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator QZSS_034_UINT_5(byte _rawValue) => new (_rawValue);
    }
}
