using RtcmSharp.RtcmDatafields;
using RtcmSharp.Bit;
using System.Numerics;

namespace RtcmSharp.RtcmMessageTypes
{
    public class RtcmCell
    {
        public CELLPRN m_PseudorandomNoiseNumber { get; }
        public CELLSIG m_Signal { get; }
        public GNSS_035_INT_15_S m_SignalFinePseudorange { get; }
        public GNSS_036_INT_22_S m_SignalFinePseudorangeData { get; }
        public GNSS_037_UINT_4 m_PhaseRangeLockTimeIndicator { get; }
        public GNSS_052_BIT_1 m_HalfCycleAmbiguityIndicator { get; }
        public GNSS_038_UINT_6 m_SignalCNR { get; }
        public GNSS_039_INT_15_S m_SignalFinePhaseRangeRate { get; }

        public RtcmCell(Bitstream _bitStream, CELLPRN _prn, CELLSIG _sig, int _cellIndex, int _nCell)
        {
            m_PseudorandomNoiseNumber = _prn;
            m_Signal = _sig;
            
            int baseIndex = 0;
            m_SignalFinePseudorange = _bitStream.SeekBitsTwosComplement(baseIndex + 15 * _cellIndex, 15);
            baseIndex += 15 * _nCell;
            m_SignalFinePseudorangeData = _bitStream.SeekBitsTwosComplement(baseIndex + 22 * _cellIndex, 22);
            baseIndex += 22 * _nCell;
            m_PhaseRangeLockTimeIndicator = _bitStream.SeekBitsUnsigned(baseIndex + 4 * _cellIndex, 4);
            baseIndex += 4 * _nCell;
            m_HalfCycleAmbiguityIndicator = _bitStream.SeekBitsUnsigned(baseIndex + 1 * _cellIndex, 1);
            baseIndex += 1 * _nCell;
            m_SignalCNR = _bitStream.SeekBitsUnsigned(baseIndex + 6 * _cellIndex, 6);
            baseIndex += 6 * _nCell;
            m_SignalFinePhaseRangeRate = _bitStream.SeekBitsTwosComplement(baseIndex + 15 * _cellIndex, 15);
        }
    }
}
