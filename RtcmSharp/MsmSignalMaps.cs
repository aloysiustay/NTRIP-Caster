namespace RtcmSharp
{
    public static class MsmSignalMaps
    {
        // GPS signals: index 1-based (0 is unused)
        public static readonly string[] GPS = new string[32]
        {
        "", "1C","1P","1W","1Y","1M","", "2C","2P","2W","2Y","2M",
        "", "","2S","2L","2X","", "", "", "", "5I","5Q","5X",
        "", "","", "","", "1S","1L","1X"
        };

        // GLONASS signals
        public static readonly string[] GLO = new string[32]
        {
        "", "1C","1P","", "", "", "", "2C","2P","", "3I","3Q",
        "3X","", "","", "", "", "", "", "", "", "", "",
        "", "","", "","", "","", ""
        };

        // Galileo signals
        public static readonly string[] GAL = new string[32]
        {
        "", "1C","1A","1B","1X","1Z","", "6C","6A","6B","6X","6Z",
        "", "7I","7Q","7X","", "8I","8Q","8X","", "5I","5Q","5X",
        "", "","", "","", "","", ""
        };

        // QZSS signals
        public static readonly string[] QZS = new string[32]
        {
        "", "1C","", "", "", "", "", "", "6S","6L","6X","",
        "", "","2S","2L","2X","", "", "", "", "5I","5Q","5X",
        "", "","", "","", "1S","1L","1X"
        };

        // SBAS signals
        public static readonly string[] SBS = new string[32]
        {
        "", "1C","", "", "", "", "", "", "", "", "", "",
        "", "","", "","", "", "", "", "", "5I","5Q","5X",
        "", "","", "","", "","", ""
        };

        // BeiDou (BDS/COMPASS) signals
        public static readonly string[] BDS = new string[32]
        {
        "", "1I","1Q","1X","", "", "", "6I","6Q","6X","", "",
        "", "7I","7Q","7X","", "", "", "", "", "", "", "",
        "", "","", "","", "","", ""
        };
    }

}
