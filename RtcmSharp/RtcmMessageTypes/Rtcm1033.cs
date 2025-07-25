using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
namespace RtcmSharp.RtcmMessageTypes
{
    /*========= 1033: Receiver and Antenna Descriptors ===========================*/
    /*------------------------------------------------------------------------------
	Data Field | Data Type | Size in Bits | Resolution (Scale Factor) | Description
	--------------------------------------------------------------------------------
    DF003: UINT	| 12 | 0 | Reference Station ID
	DF029: UINT |  8 | 0 | Descriptor Counter
	DF030: CHAR |  8 | 0 | Antenna Descriptor
	DF031: UINT |  8 | 0 | Antenna Setup ID
	DF032: UINT |  8 | 0 | Serial Number Counter
	DF033: CHAR |  8 | 0 | Antenna Serial Number
	DF227: UINT |  8 | 0 | Receiver Type Descriptor Counter
	DF228: CHA  |  8 | 0 | Receiver Type Descriptor
	DF229: UINT |  8 | 0 | Receiver Firmware Version Counter
	DF230: CHA  |  8 | 0 | Receiver Firmware Version
	DF231: UINT |  8 | 0 | Receiver Serial Number Counter
	DF232: CHA  |  8 | 0 | Receiver Serial Number
	------------------------------------------------------------------------------*/
    public class Rtcm1033 : Rtcm1008
    {
        public DF_115_UINT_8 m_ReceiverTypeDescriptorLength { get; }
        public DF_116_STR m_ReceiverType { get; }
        public DF_117_UINT_8 m_ReceiverFirmwareLength { get; }
        public DF_118_STR m_ReceiverFirmware { get; }
        public DF_119_UINT_8 m_ReceiverSerialNumberLength { get; }
        public DF_120_STR m_ReceiverSerialNumber { get; }
        public Rtcm1033(Bitstream _bitStream) : base(_bitStream)
        {
            m_ReceiverTypeDescriptorLength = _bitStream.ReadBitsUnsigned(8);
            byte receiverTypeDescriptorLength = m_ReceiverTypeDescriptorLength.m_RawValue;
            var receiverType = new System.Text.StringBuilder(receiverTypeDescriptorLength);
            for (byte i = 0; i < receiverTypeDescriptorLength; ++i)
            {
                receiverType.Append((char)_bitStream.ReadBitsUnsigned(8));
            }
            m_ReceiverType = receiverType.ToString();

            m_ReceiverFirmwareLength = _bitStream.ReadBitsUnsigned(8);
            byte receiverFirmwareLength = m_ReceiverFirmwareLength.m_RawValue;
            var receiverFirmware = new System.Text.StringBuilder(receiverFirmwareLength);
            for (byte i = 0; i < receiverFirmwareLength; ++i)
            {
                receiverFirmware.Append((char)_bitStream.ReadBitsUnsigned(8));
            }
            m_ReceiverFirmware = receiverFirmware.ToString();

            m_ReceiverSerialNumberLength = _bitStream.ReadBitsUnsigned(8);
            byte receiverSerialNumberLength = m_ReceiverSerialNumberLength.m_RawValue;
            var receiverSerialNumber = new System.Text.StringBuilder(receiverSerialNumberLength);
            for (byte i = 0; i < receiverSerialNumberLength; ++i)
            {
                receiverSerialNumber.Append((char)_bitStream.ReadBitsUnsigned(8));
            }
            m_ReceiverSerialNumber = receiverSerialNumber.ToString();
        }
    }
}
