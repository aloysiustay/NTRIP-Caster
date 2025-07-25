using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Diagnostics;
using RtcmSharp.RtcmMessageTypes;
using RtcmSharp;
using Xunit;

namespace UnitTest
{
    internal class TestUtils
    {
        public static BaseMessage DecodeMessage(string path)
        {
            Assert.True(File.Exists(path), "Binary file not found in output directory.");
            byte[] data = File.ReadAllBytes(path);
            RtcmPacket packet = new();
            RtcmParser parser = new();
            foreach (byte b in data)
            {
                if (parser.ParseByte(b))
                {
                    packet = parser.GetRtcmPacket();
                }
            }
            return RtcmUtils.ProcessMessage(packet);
        }

        public static bool CompareDecodedData(List<string> _expected, List<string> _actual)
        {
            if(_expected.Count != _actual.Count)
            {
                Console.WriteLine($"Expected Number of Data: {_expected.Count}\n Actual Number of Data: {_actual.Count}");
                return false;
            }
            for(int i = 0; i < _actual.Count; ++i)
            {
                string expected = _expected[i].Trim() ?? "";
                string actual = _actual[i].Trim() ?? "";

                if (expected.ToUpperInvariant() != actual.ToUpperInvariant())
                {
                    if (expected == "0.0" && actual == "0")
                        continue;

                    Console.WriteLine($"At Index: {i}\nExpected: {expected}\nActual: {actual}");
                    return false;
                }
            }

            return true;
        }
        public static List<string> RunPythonDecoderScript(string inputPath)
        {
            string pythonExe = "python"; // or full path to python.exe
            string script = Path.Combine(AppContext.BaseDirectory, "decode_rtcm.py");
            string moduleName = "pyrtcm";
            var checkProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = pythonExe,
                    Arguments = $"-c \"import {moduleName}\"",
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            checkProcess.Start();
            checkProcess.WaitForExit();

            if (checkProcess.ExitCode != 0)
            {
                Console.WriteLine($"{moduleName} not found. Installing...");

                var installProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = pythonExe,
                        Arguments = $"-m pip install {moduleName}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                installProcess.Start();
                string output = installProcess.StandardOutput.ReadToEnd();
                string error = installProcess.StandardError.ReadToEnd();
                installProcess.WaitForExit();

                if (installProcess.ExitCode != 0)
                {
                    throw new Exception($"Failed to install Python module '{moduleName}':\n{error}");
                }
            }

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = pythonExe,
                    Arguments = $"{script} {inputPath}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            if (process == null)
                throw new Exception("Failed to start Python process");
            string jsonOutput = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var messages = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonOutput, options);

            List<string> allValues = new List<string>();

            if (messages != null)
            {
                foreach (var message in messages)
                {
                    foreach (var kvp in message)
                    {
                        allValues.Add(kvp.Value?.ToString() ?? "null");
                    }
                }
            }

            return allValues;
        }
    }
}
