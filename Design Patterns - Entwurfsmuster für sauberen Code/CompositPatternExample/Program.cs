using System;

namespace CompositPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory videoTutorial = new Directory("Video Tutorial");
            File courseScript = new File("Course Script", "TestUser");
            Directory videos = new Directory("Videos");

            videoTutorial.Add(courseScript);
            videoTutorial.Add(videos);

            File videoOne = new File("Video One", "TestUser");
            File videoTwo = new File("Video Two", "TestUser");

            videos.Add(videoOne);
            videos.Add(videoTwo);

            videoTutorial.Print("");
            
            Console.ReadLine();
        }
    }
}
