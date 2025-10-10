using System.Reflection;
using System.Security.Cryptography;
using RtcmSharp.RtcmDatafields;
using RtcmSharp.RtcmDataFields;

namespace RtcmSharp.RtcmMessageTypes
{
    public abstract class BaseMessage
    {
        public DF_001_UINT_12 m_MessageType { get;set; }

        public string Describe(bool _verbose = false)
        {
            var sb = new System.Text.StringBuilder();
            var type = this.GetType();

            sb.AppendLine($"Description of {type.Name} (MessageType: {m_MessageType}):");

            // 1. Add base class properties first
            var baseProps = typeof(BaseMessage)
                .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)
                .OrderBy(p => p.MetadataToken);

            // 2. Add derived class properties
            // All other properties from 1005, 1006, etc.
            var otherProps = new List<System.Reflection.PropertyInfo>();
            var current = type;
            while (current != null && current != typeof(BaseMessage))
            {
                var props = current
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                otherProps.AddRange(props);
                current = current.BaseType;
            }

            var allProps = baseProps.Concat(otherProps.OrderBy(p => p.MetadataToken));

            foreach (var prop in allProps)
            {
                var propType = prop.PropertyType;
                object? value = prop.GetValue(this);

                if (value is System.Collections.IEnumerable enumerable && propType != typeof(string))
                {
                    sb.AppendLine($"- {prop.Name}:");

                    foreach (var item in enumerable)
                    {
                        if (item == null)
                        {
                            sb.AppendLine("    - null");
                            continue;
                        }

                        var itemType = item.GetType();
                        var itemProps = itemType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                        foreach (var itemProp in itemProps)
                        {
                            var attr = itemProp.GetCustomAttributes(typeof(DataFieldAttribute), false).FirstOrDefault() as DataFieldAttribute;
                            var itemValue = itemProp.GetValue(item);

                            if (attr != null && itemValue != null)
                            {
                                sb.AppendLine("    " + attr.GetMetadataString(_verbose) + itemValue.ToString());
                            }
                            else if (itemValue != null)
                            {
                                sb.AppendLine($"    - {itemProp.Name}: {itemValue}");
                            }
                        }
                    }
                }
                else
                {
                    var dataFieldAttr = propType
                        .GetCustomAttributes(typeof(DataFieldAttribute), false)
                        .FirstOrDefault() as DataFieldAttribute;

                    if (dataFieldAttr != null && value != null)
                    {
                        sb.AppendLine(dataFieldAttr.GetMetadataString(_verbose) + value.ToString());
                    }
                    else if(value != null)
                    {
                        sb.AppendLine($"- {prop.Name}: {propType.Name} " + value.ToString());
                    }
                    else
                    {
                        sb.AppendLine($"- {prop.Name}: {propType.Name} (no DataFieldAttribute)");
                    }
                }
            }
            return sb.ToString();
        }

        public List<string> GetInnerPropertyValues()
        {
            List<string> values = new List<string>();
            var type = this.GetType();

            var baseProps = typeof(BaseMessage)
                .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)
                .OrderBy(p => p.MetadataToken);

            var otherProps = new List<System.Reflection.PropertyInfo>();
            var current = type;
            while (current != null && current != typeof(BaseMessage))
            {
                var props = current
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                otherProps.AddRange(props);
                current = current.BaseType;
            }

            var allProps = baseProps.Concat(otherProps.OrderBy(p => p.MetadataToken));

            foreach (var prop in allProps)
            {
                var propType = prop.PropertyType;
                object? value = prop.GetValue(this);

                var dataFieldAttr = propType
                    .GetCustomAttributes(typeof(DataFieldAttribute), false)
                    .FirstOrDefault() as DataFieldAttribute;

                if (dataFieldAttr != null && value != null)
                {
                    if (dataFieldAttr.DataType == "CHA" || dataFieldAttr.DataType == "STR")
                    {
                        foreach (char c in value.ToString())
                        {
                            values.Add(c.ToString());
                        }
                    }
                    else
                    {
                        values.Add(value.ToString());
                    }
                }
            }
            return values;
        }

    }
}
