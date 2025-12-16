using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmDatafields
{
    public abstract class DataFieldBase
    {
        public abstract double GetScaledValue();
    }

    public abstract class DataFieldBase<T> : DataFieldBase
    {
        public readonly T m_RawValue;
        public readonly bool m_HasScale;
        public readonly double m_ScaledValue;
        protected DataFieldBase(T _rawValue)
        {
            m_RawValue = _rawValue;
            var attr = Attribute.GetCustomAttribute(this.GetType(), typeof(DataFieldAttribute)) as DataFieldAttribute;
            m_HasScale = attr.ScaleFactor != 0 && attr.ScaleFactor != 1;
            m_ScaledValue = m_HasScale ? Convert.ToDouble(m_RawValue) * attr.ScaleFactor : Convert.ToDouble(m_RawValue);
        }
        public T GetRawValue()
        {
            return m_RawValue;
        }
        public override double GetScaledValue()
        {
            return m_ScaledValue;
        }

        public override string ToString()
        {
            return m_HasScale ? $"{GetScaledValue()}" : $"{GetRawValue()}";
        }
    }
}
