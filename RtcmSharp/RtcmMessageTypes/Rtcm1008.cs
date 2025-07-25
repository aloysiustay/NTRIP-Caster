using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1008: Antenna Descriptor and Serial Number =======================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
    DF003: UINT	| 12 | 0 | Reference Station ID
	DF029: UINT |  8 | 0 | Descriptor Counter
	DF030: CHAR |  8 | 0 | Antenna Descriptor
	DF031: UINT |  8 | 0 | Antenna Setup ID
	DF032: UINT |  8 | 0 | Serial Number Counter
	DF033: CHAR |  8 | 0 | Antenna Serial Number
	------------------------------------------------------------------------------*/
    public class Rtcm1008 : BaseMessage
    {
        public DF_002_UINT_12 m_StationID { get; }
        public DF_007_UINT_8 m_AntennaDescriptorLength { get; }
        public DF_008_STR m_AntennaDescriptor { get; }
        public DF_009_UINT_8 m_SetupID { get; }
        public DF_010_UINT_8 m_AntennaSerialNumberLength { get; }
        public DF_011_STR m_AntennaSerialNumber { get; }
        public Rtcm1008(Bitstream _bitStream)
        {
            m_MessageType = _bitStream.ReadBitsUnsigned(12);
            m_StationID = _bitStream.ReadBitsUnsigned(12);
            m_AntennaDescriptorLength = _bitStream.ReadBitsUnsigned(8);
            byte antennaDescriptorLength = m_AntennaDescriptorLength.m_RawValue;
            var antennaDescriptor = new System.Text.StringBuilder(antennaDescriptorLength);
            for (byte i = 0; i < antennaDescriptorLength; ++i)
            {
                antennaDescriptor.Append((char)_bitStream.ReadBitsUnsigned(8));
            }
            m_AntennaDescriptor = antennaDescriptor.ToString();

            m_SetupID = _bitStream.ReadBitsUnsigned(8);

            m_AntennaSerialNumberLength = _bitStream.ReadBitsUnsigned(8);
            byte antennaSerialNumberLength = m_AntennaSerialNumberLength.m_RawValue;
            var antennaSerialNumber = new System.Text.StringBuilder(antennaSerialNumberLength);
            for (byte i = 0; i < antennaSerialNumberLength; ++i)
            {
                antennaSerialNumber.Append((char)_bitStream.ReadBitsUnsigned(8));
            }
            m_AntennaSerialNumber = antennaSerialNumber.ToString();
        }
    }
}
