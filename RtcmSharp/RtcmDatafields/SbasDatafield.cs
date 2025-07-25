using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "SBAS_001", dataType: "UINT", bitLength: 20, scaleFactor: 1, description: "SBAS Epoch Time 1s")] //DF462
    public class SBAS_001_UINT_20 : DataFieldBase<uint>
    {
        public SBAS_001_UINT_20(uint _rawValue) : base(_rawValue) { }
        public static implicit operator SBAS_001_UINT_20(uint _rawValue) => new(_rawValue);
        public static implicit operator SBAS_001_UINT_20(ulong _rawValue) => new((uint)_rawValue);
    }

    [DataField(name: "SBAS_002", dataType: "UINT", bitLength: 6, scaleFactor: 0, description: "SBAS Satellite ID")] //DF463
    public class SBAS_002_UINT_6 : DataFieldBase<byte>
    {
        public SBAS_002_UINT_6(byte _rawValue) : base(_rawValue) { }
        public static implicit operator SBAS_002_UINT_6(byte _rawValue) => new(_rawValue);
        public static implicit operator SBAS_002_UINT_6(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "SBAS_003", dataType: "UINT", bitLength: 5, scaleFactor: 1, description: "SBAS Signal and Tracking Mode Identifier")] //DF464
    public class SBAS_003_UINT_5 : DataFieldBase<byte>
    {
        public SBAS_003_UINT_5(byte _rawValue) : base(_rawValue) { }
        public static implicit operator SBAS_003_UINT_5(byte _rawValue) => new(_rawValue);
        public static implicit operator SBAS_003_UINT_5(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "SBAS_004", dataType: "BIT", bitLength: 9, scaleFactor: 16, description: "SBAS t0 Modulo")] //DF468
    public class SBAS_004_BIT_9_S : DataFieldBase<ushort>
    {
        public SBAS_004_BIT_9_S(ushort _rawValue) : base(_rawValue) { }
        public static implicit operator SBAS_004_BIT_9_S(ushort _rawValue) => new(_rawValue);
        public static implicit operator SBAS_004_BIT_9_S(ulong _rawValue) => new((ushort)_rawValue);
    }

    [DataField(name: "SBAS_005", dataType: "BIT", bitLength: 24, scaleFactor: 0, description: "SBAS IOD CRC")] //DF469
    public class SBAS_005_BIT_24 : DataFieldBase<uint>
    {
        public SBAS_005_BIT_24(uint _rawValue) : base(_rawValue) { }
        public static implicit operator SBAS_005_BIT_24(uint _rawValue) => new(_rawValue);
        public static implicit operator SBAS_005_BIT_24(ulong _rawValue) => new((uint)_rawValue);
    }
}
