using System;

namespace CompositePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory videoTutorial = new Directory("Video Tutorial");
            File courseScript = new File("course Script", "TestUser");
            Directory videos = new Directory("Videos");
            videoTutorial.Add(courseScript);
            videoTutorial.Add(videos);

            File videoOne = new File("Video One", "TestUser");
            File videoTwo = new File("Video Two", "TestUser");
            File videoThree = new File("Video Three", "TestUser");
            File videoFour = new File("Video Four", "TestUser");
            File videoFive = new File("Video Five", "TestUser");
            videos.Add(videoOne);
            videos.Add(videoTwo);
            videos.Add(videoThree);
            videos.Add(videoFour);
            videos.Add(videoFive);

            videoTutorial.Print();
            Console.ReadLine();
        }
    }
}
