using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "RESERVED_FIELD", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Reserved Field")] //DF001
    public class RESERVED_FIELD_BIT_1 : DataFieldBase<byte>
    {
        public RESERVED_FIELD_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator RESERVED_FIELD_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator RESERVED_FIELD_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "RESERVED_001", dataType: "BIT", bitLength: 1, scaleFactor: 0, description: "Reserved 1 BIT, ")] //DF001_1
    public class RESERVED_BIT_1 : DataFieldBase<byte>
    {
        public RESERVED_BIT_1(byte _rawValue) : base(_rawValue) { }
        public static implicit operator RESERVED_BIT_1(byte _rawValue) => new (_rawValue);
        public static implicit operator RESERVED_BIT_1(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "RESERVED_002", dataType: "BIT", bitLength: 2, scaleFactor: 0, description: "Reserved 2 BIT, s")] //DF001_2
    public class RESERVED_BIT_2 : DataFieldBase<byte>
    {
        public RESERVED_BIT_2(byte _rawValue) : base(_rawValue) { }
        public static implicit operator RESERVED_BIT_2(byte _rawValue) => new (_rawValue);
        public static implicit operator RESERVED_BIT_2(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "RESERVED_003", dataType: "BIT", bitLength: 3, scaleFactor: 0, description: "Reserved 3 BIT, s")] //DF001_3
    public class RESERVED_BIT_3 : DataFieldBase<byte>
    {
        public RESERVED_BIT_3(byte _rawValue) : base(_rawValue) { }
        public static implicit operator RESERVED_BIT_3(byte _rawValue) => new (_rawValue);
        public static implicit operator RESERVED_BIT_3(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "RESERVED_007", dataType: "BIT", bitLength: 7, scaleFactor: 0, description: "Reserved 7 BIT, s")] //DF001_7
    public class RESERVED_BIT_7 : DataFieldBase<byte>
    {
        public RESERVED_BIT_7(byte _rawValue) : base(_rawValue) { }
        public static implicit operator RESERVED_BIT_7(byte _rawValue) => new (_rawValue);
        public static implicit operator RESERVED_BIT_7(ulong _rawValue) => new((byte)_rawValue);
    }
}
