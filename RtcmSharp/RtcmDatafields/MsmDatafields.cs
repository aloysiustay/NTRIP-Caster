using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    [DataField(name: "PRN", dataType: "PRN", bitLength: 0, scaleFactor: 0, description: "Derived satellite PRN")]
    public class PRN : DataFieldBase<byte>
    {
        public PRN(byte _rawValue) : base(_rawValue) { }
        public static implicit operator PRN(byte _rawValue) => new(_rawValue);
        public static implicit operator PRN(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "ExtSatInfo", dataType: "UINT", bitLength: 4, scaleFactor: 0, description: "Derived satellite PRN")]
    public class ExtSatInfo : DataFieldBase<byte>
    {
        public ExtSatInfo(byte _rawValue) : base(_rawValue) { }
        public static implicit operator ExtSatInfo(byte _rawValue) => new(_rawValue);
        public static implicit operator ExtSatInfo(ulong _rawValue) => new((byte)_rawValue);
    }

    [DataField(name: "CELLPRN", dataType: "CELLPRN", bitLength: 0, scaleFactor: 0, description: "Derived satellite PRN")]
    public class CELLPRN : DataFieldBase<byte>
    {
        public CELLPRN(byte _rawValue) : base(_rawValue) { }
        public static implicit operator CELLPRN(byte _rawValue) => new(_rawValue);
        public static implicit operator CELLPRN(ulong _rawValue) => new((byte)_rawValue);
    }
    [DataField(name: "CELLSIG", dataType: "CELLSIG", bitLength: 0, scaleFactor: 0, description: "Derived satellite Signal ID")]
    public class CELLSIG : DataFieldBase<string>
    {
        public CELLSIG(string _rawValue) : base(_rawValue) { }
        public static implicit operator CELLSIG(string _rawValue) => new(_rawValue);
    }
}
