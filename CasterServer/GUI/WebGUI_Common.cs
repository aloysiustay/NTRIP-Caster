namespace CasterServer.GUI
{
    public class MountpointStatusDTO
    {
        public int m_MessageType { get; set; }
        public string m_UtcTimeStamp { get; set; }
        public string m_LocalTimeStamp { get; set; }
        public double m_TimeInterval { get; set; }
    }

    public class MountpointInfoDTO
    {
        public string m_Name { get; set; }
        public string m_Identifier { get; set; }
        public string m_Format { get; set; }
        public string m_FormatDetails { get; set; }
        public string m_Carrier { get; set; }
        public string m_NavSystem { get; set; }
        public string m_Network { get; set; }
        public string m_Country { get; set; }
        public double m_Lat { get; set; }
        public double m_Lon { get; set; }
    }
}
