using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "GALILEO_001", dataType: "UINT", bitLength: 30, scaleFactor: 1, description: "Galileo Epoch Time (TOW)")] //DF248
    public class GALILEO_001_UINT_30 : DataFieldBase<uint>
    {
        public GALILEO_001_UINT_30(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_001_UINT_30(uint _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_001_UINT_30(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GALILEO_002", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "Galileo Satellite ID")] //DF252
    public class GALILEO_002_UINT_6 : DataFieldBase<byte>
    {
        public GALILEO_002_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_002_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_002_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_003", dataType: "BIT", bitLength: 8, scaleFactor: 0, description: "Galileo SISA (E1,E5b)")] //DF286
    public class GALILEO_003_BIT_8 : DataFieldBase<byte>
    {
        public GALILEO_003_BIT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_003_BIT_8(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_003_BIT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_004", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "Galileo E1-B Signal Health Status")] //DF287
    public class GALILEO_004_BIT_2 : DataFieldBase<byte>
    {
        public GALILEO_004_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_004_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_004_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_005", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Galileo E1-B Data Validity Status")] //DF288
    public class GALILEO_005_BIT_1 : DataFieldBase<byte>
    {
        public GALILEO_005_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_005_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_005_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_006", dataType: "UINT", bitLength: 12, scaleFactor: 1, description: "Galileo Week Number")] //DF289
    public class GALILEO_006_UINT_12 : DataFieldBase<ushort>
    {
        public GALILEO_006_UINT_12(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_006_UINT_12(ushort _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_006_UINT_12(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GALILEO_007", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "Galileo IODnav")] //DF290
    public class GALILEO_007_UINT_10 : DataFieldBase<ushort>
    {
        public GALILEO_007_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_007_UINT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_007_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GALILEO_008", dataType: "BIT", bitLength: 8, scaleFactor: 0, description: "Galileo SV SISA")] //DF291
    public class GALILEO_008_BIT_8 : DataFieldBase<byte>
    {
        public GALILEO_008_BIT_8(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_008_BIT_8(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_008_BIT_8(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_009", dataType: "INT", bitLength: 14, scaleFactor: RtcmConstants.P2_43, description: "Galileo Rate of Inclination (IDOT)")] //DF292
    public class GALILEO_009_INT_14_S : DataFieldBase<short>
    {
        public GALILEO_009_INT_14_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_009_INT_14_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_009_INT_14_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_010", dataType: "UINT", bitLength: 14, scaleFactor: 60, description: "Galileo toc")] //DF293
    public class GALILEO_010_UINT_14_S : DataFieldBase<ushort>
    {
        public GALILEO_010_UINT_14_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_010_UINT_14_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_010_UINT_14_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GALILEO_011", dataType: "INT", bitLength: 6, scaleFactor: RtcmConstants.P2_59, description: "Galileo af2")] //DF294
    public class GALILEO_011_INT_6_S : DataFieldBase<sbyte>
    {
        public GALILEO_011_INT_6_S(sbyte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_011_INT_6_S(sbyte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_011_INT_6_S(long _rawValue) => new((sbyte)_rawValue);
    }

    [DataField(name: "GALILEO_012", dataType: "INT", bitLength: 21, scaleFactor: RtcmConstants.P2_46, description: "Galileo af1")] //DF295
    public class GALILEO_012_INT_21_S : DataFieldBase<int>
    {
        public GALILEO_012_INT_21_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_012_INT_21_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_012_INT_21_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_013", dataType: "INT", bitLength: 31, scaleFactor: RtcmConstants.P2_34, description: "Galileo af0")] //DF296
    public class GALILEO_013_INT_31_S : DataFieldBase<int>
    {
        public GALILEO_013_INT_31_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_013_INT_31_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_013_INT_31_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_014", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "Galileo Crs")] //DF297
    public class GALILEO_014_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_014_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_014_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_014_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_015", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_43, description: "Galileo ∆n")] //DF298
    public class GALILEO_015_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_015_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_015_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_015_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_016", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "Galileo M0")] //DF299
    public class GALILEO_016_INT_32_S : DataFieldBase<int>
    {
        public GALILEO_016_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_016_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_016_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_017", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "Galileo Cuc")] //DF300
    public class GALILEO_017_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_017_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_017_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_017_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_018", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_33, description: "Galileo Eccentricity (e)")] //DF301
    public class GALILEO_018_UINT_32_S : DataFieldBase<uint>
    {
        public GALILEO_018_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_018_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_018_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GALILEO_019", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "Galileo Cus")] //DF302
    public class GALILEO_019_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_019_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_019_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_019_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_020", dataType: "UINT", bitLength: 32, scaleFactor: RtcmConstants.P2_19, description: "Galileo A½")] //DF303
    public class GALILEO_020_UINT_32_S : DataFieldBase<uint>
    {
        public GALILEO_020_UINT_32_S(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_020_UINT_32_S(uint _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_020_UINT_32_S(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GALILEO_021", dataType: "UINT", bitLength: 14, scaleFactor: 60, description: "Galileo toe")] //DF304
    public class GALILEO_021_UINT_14_S : DataFieldBase<ushort>
    {
        public GALILEO_021_UINT_14_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_021_UINT_14_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_021_UINT_14_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GALILEO_022", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "Galileo Cic")] //DF305
    public class GALILEO_022_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_022_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_022_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_022_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_023", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "Galileo Ω0")] //DF306
    public class GALILEO_023_INT_32_S : DataFieldBase<int>
    {
        public GALILEO_023_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_023_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_023_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_024", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_29, description: "Galileo Cis")] //DF307
    public class GALILEO_024_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_024_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_024_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_024_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_025", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "Galileo i0")] //DF308
    public class GALILEO_025_INT_32_S : DataFieldBase<int>
    {
        public GALILEO_025_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_025_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_025_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_026", dataType: "INT", bitLength: 16, scaleFactor: RtcmConstants.P2_5, description: "Galileo Crc")] //DF309
    public class GALILEO_026_INT_16_S : DataFieldBase<short>
    {
        public GALILEO_026_INT_16_S(short _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_026_INT_16_S(short _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_026_INT_16_S(long _rawValue) => new((short)_rawValue);
    }

    [DataField(name: "GALILEO_027", dataType: "INT", bitLength: 32, scaleFactor: RtcmConstants.P2_31, description: "Galileo ω (Argument of Perigee)")] //DF310
    public class GALILEO_027_INT_32_S : DataFieldBase<int>
    {
        public GALILEO_027_INT_32_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_027_INT_32_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_027_INT_32_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_028", dataType: "INT", bitLength: 24, scaleFactor: RtcmConstants.P2_43, description: "Galileo ΩDOT")] //DF311
    public class GALILEO_028_INT_24_S : DataFieldBase<int>
    {
        public GALILEO_028_INT_24_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_028_INT_24_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_028_INT_24_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_029", dataType: "INT", bitLength: 10, scaleFactor: RtcmConstants.P2_32, description: "Galileo BGD (E1/E5a)")] //DF312
    public class GALILEO_029_INT_10_S : DataFieldBase<int>
    {
        public GALILEO_029_INT_10_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_029_INT_10_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_029_INT_10_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_030", dataType: "INT", bitLength: 10, scaleFactor: RtcmConstants.P2_32, description: "Galileo BGD E5b/E1")] //DF313
    public class GALILEO_030_INT_10_S : DataFieldBase<int>
    {
        public GALILEO_030_INT_10_S(int _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_030_INT_10_S(int _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_030_INT_10_S(long _rawValue) => new((int)_rawValue);
    }

    [DataField(name: "GALILEO_031", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "Galileo E5a Signal Health Status")] //DF314
    public class GALILEO_031_BIT_2 : DataFieldBase<byte>
    {
        public GALILEO_031_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_031_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_031_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_032", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Galileo E5a Data Validity Status")] //DF315
    public class GALILEO_032_BIT_1 : DataFieldBase<byte>
    {
        public GALILEO_032_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_032_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_032_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_033", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "Galileo SOL NAV Signal Health Status (SOLHS)")] //DF316
    public class GALILEO_033_BIT_2 : DataFieldBase<byte>
    {
        public GALILEO_033_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_033_BIT_2(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_033_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_034", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Galileo SOL NAV Data Validity Status (SOLDVS)")] //DF317
    public class GALILEO_034_BIT_1 : DataFieldBase<byte>
    {
        public GALILEO_034_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_034_BIT_1(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_034_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_035", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "Galileo Signal and Tracking Mode Identifier")] //DF382
    public class GALILEO_035_UINT_5 : DataFieldBase<byte>
    {
        public GALILEO_035_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_035_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_035_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "GALILEO_036", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "Galileo Epoch Time 1s")] //DF458
    public class GALILEO_036_UINT_20 : DataFieldBase<uint>
    {
        public GALILEO_036_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_036_UINT_20(uint _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_036_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GALILEO_037", dataType: "UINT", bitLength: 10, scaleFactor: 1, description: "Galileo IODnav I/NAV")] //DF459
    public class GALILEO_037_UINT_10 : DataFieldBase<ushort>
    {
        public GALILEO_037_UINT_10(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_037_UINT_10(ushort _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_037_UINT_10(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "GALILEO_038", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "Galileo Residuals Epoch Time TOW")] //DF573
    public class GALILEO_038_UINT_20 : DataFieldBase<uint>
    {
        public GALILEO_038_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_038_UINT_20(uint _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_038_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "GALILEO_039", dataType: "UINT", bitLength: 5, scaleFactor: 0, description: "Galileo Number of Satellite Signals Processed")] //DF574
    public class GALILEO_039_UINT_5 : DataFieldBase<byte>
    {
        public GALILEO_039_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator GALILEO_039_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator GALILEO_039_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }
}
