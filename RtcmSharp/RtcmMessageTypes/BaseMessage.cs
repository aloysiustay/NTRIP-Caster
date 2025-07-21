using RtcmSharp.RtcmDatafields;
using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmMessageTypes
{
    public abstract class BaseMessage
    {
        public DF_001_UINT_12 m_MessageType { get;set; }
        public string Describe()
        {
            var sb = new System.Text.StringBuilder();
            var type = this.GetType();

            sb.AppendLine($"Description of {type.Name} (MessageType: {m_MessageType}):");

            // 1. Add base class properties first
            var baseProps = typeof(BaseMessage)
                .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)
                .OrderBy(p => p.MetadataToken);

            // 2. Add derived class properties
            var derivedProps = type
                .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly)
                .OrderBy(p => p.MetadataToken);

            var allProps = baseProps.Concat(derivedProps);

            foreach (var prop in allProps)
            {
                var propType = prop.PropertyType;

                // Try to get the attribute from the *type* of the property (like DF_002_UINT_12)
                var dataFieldAttr = propType
                    .GetCustomAttributes(typeof(DataFieldAttribute), false)
                    .FirstOrDefault() as DataFieldAttribute;

                if (dataFieldAttr != null)
                {
                    sb.AppendLine(dataFieldAttr.GetMetadataString());
                }
                else
                {
                    sb.AppendLine($"- {prop.Name}: {propType.Name} (no DataFieldAttribute)");
                }
            }
            return sb.ToString();
        }

    }
}
