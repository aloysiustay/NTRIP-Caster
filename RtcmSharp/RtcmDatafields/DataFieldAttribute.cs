namespace RtcmSharp.RtcmDataFields
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class DataFieldAttribute : Attribute
    {
        public string Name { get; }
        public string DataType { get; }
        public int BitLength { get; }
        public double ScaleFactor { get; }
        public string Description { get; }

        public DataFieldAttribute(string name, string dataType, int bitLength, double scaleFactor, string description)
        {
            Name = name;
            DataType = dataType;
            BitLength = bitLength;
            ScaleFactor = scaleFactor;
            Description = description;
        }

        public string GetMetadataString(bool _verbose = true)
        {
            return _verbose ? $"Name: {Name}, DataType: {DataType}, BitLength: {BitLength}, ScaleFactor: {ScaleFactor}, Description: {Description}" : $"{Name}: ";
        }
    }
}
