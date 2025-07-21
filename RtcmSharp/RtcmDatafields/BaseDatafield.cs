using RtcmSharp.RtcmDataFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtcmSharp.RtcmDatafields
{
    public abstract class DataFieldBase
    {
        public abstract double? GetScaledValue();
    }

    public abstract class DataFieldBase<T> : DataFieldBase
    {
        public readonly T m_RawValue;
        public readonly double? m_ScaledValue;
        protected DataFieldBase(T _rawValue)
        {
            m_RawValue = _rawValue;
            var attr = Attribute.GetCustomAttribute(this.GetType(), typeof(DataFieldAttribute)) as DataFieldAttribute;
            bool hasScale = attr.ScaleFactor != 0 && attr.ScaleFactor != 1;
            m_ScaledValue = hasScale ? Convert.ToDouble(m_RawValue) * attr.ScaleFactor : null;
        }
        public T GetRawValue()
        {
            return m_RawValue;
        }
        public override double? GetScaledValue()
        {
            return m_ScaledValue;
        }
    }
}
