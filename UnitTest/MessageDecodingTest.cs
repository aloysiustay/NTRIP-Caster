using RtcmSharp.RtcmMessageTypes;
using Xunit;
namespace UnitTest
{
    public class RtcmSharpTest
    {
        [Fact]
        public void Message1075Test()
        {
            //List<string> pyRtcm = TestUtils.RunPythonDecoderScript(Path.Combine(AppContext.BaseDirectory, "RtcmBinary", "1075"));
            string directoryPath = Path.Combine(AppContext.BaseDirectory, "RtcmBinary", "1125");
            BaseMessage myRtcm = TestUtils.DecodeMessage(directoryPath);

            //Console.WriteLine("pyRTCM:\n");
            //foreach (string str in pyRtcm)
            //{
            //    Console.WriteLine(str + "\n");
            //}
            //Console.WriteLine("RtcmSharp:\n");
            Console.WriteLine(myRtcm.Describe());
        }


        [Fact]
        public void MessageDecodingTest()
        {
            string directoryPath = Path.Combine(AppContext.BaseDirectory, "RtcmBinary");
            string[] binFiles = Directory.GetFiles(directoryPath, "*.bin");
            int passed = 0, failed = 0;
            foreach (var file in binFiles)
            {
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(file);
                try
                {

                    List<string> pyRtcm = TestUtils.RunPythonDecoderScript(file);
                    //TestUtils.DecodeMessage(file).Describe(false);
                    List<string> myRtcm = TestUtils.DecodeMessage(file).GetInnerPropertyValues();
                    bool correct = TestUtils.CompareDecodedData(pyRtcm, myRtcm);
                    Assert.True(correct, "The decoded data did not match.");
                    Console.WriteLine($"✅ Passed: {fileNameWithoutExt}");
                    ++passed;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Failed: {fileNameWithoutExt} - {ex.Message}");
                    ++failed;
                }
            }
            Console.WriteLine($"Finished. Passed: {passed}, Failed: {failed}");
            Assert.Equal(0, failed);
        }

    }
}