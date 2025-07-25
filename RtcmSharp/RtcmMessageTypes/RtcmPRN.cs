using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;

namespace RtcmSharp.RtcmMessageTypes
{
    public class RtcmPRN
    {
        public PRN m_PseudorandomNoiseNumber { get; }
        public GNSS_032_UINT_8 m_SatelliteRoughRangeMilliseconds { get; }
        public ExtSatInfo m_ExtInfo { get; }
        public GNSS_033_UINT_10_S m_SatelliteRoughRangeModuloMs { get; }
        public GNSS_034_INT_14 m_SatelliteRoughPhaseRangeRate { get; }

        public RtcmPRN(Bitstream _bitStream, PRN _prn, int _satIndex, int _nSat)
        {
            m_PseudorandomNoiseNumber = _prn;
            int first = 8 * _satIndex;
            int second = (8 * _nSat) + (4 * _satIndex);
            int third = ((8 + 4) * _nSat) + (10 * _satIndex);
            int fouth = ((8 + 4 + 10) * _nSat) + (14 * _satIndex);
            m_SatelliteRoughRangeMilliseconds = _bitStream.SeekBitsUnsigned(first, 8);
            m_ExtInfo = _bitStream.SeekBitsUnsigned(second, 4);
            m_SatelliteRoughRangeModuloMs = _bitStream.SeekBitsUnsigned(third, 10);
            m_SatelliteRoughPhaseRangeRate = _bitStream.SeekBitsTwosComplement(fouth, 14);
        }
    }
}
