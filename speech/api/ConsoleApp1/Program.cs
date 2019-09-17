using System;
using Google.Cloud.Speech.V1;

using ProcessCommand;

namespace ConsoleApp1
{
    class Program
    {
        //static string DEMO_FILE = "audio.raw";
        static string DEMO_FILE = "ttt.wav";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var speech = SpeechClient.Create();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            var response = speech.Recognize(new RecognitionConfig()
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 44100,
                LanguageCode = "zh-TW",
            }, RecognitionAudio.FromFile(DEMO_FILE));

            string lastString = "";
            //StringToCommand stc = new StringToCommand();
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    Console.WriteLine(alternative.Transcript);
                    //if (lastString.Length <= alternative.Transcript.Length)
                    //{
                    //    lastString = alternative.Transcript;
                    //}
                    //else
                    //{
                    //    string[] arrCallFunction = stc.TransToCallFunction(lastString);

                    //    Console.WriteLine("Function Call: " + string.Join(" -=- ", arrCallFunction));
                    //    lastString = alternative.Transcript;
                    //}
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                }
            }

        }
    }
}
