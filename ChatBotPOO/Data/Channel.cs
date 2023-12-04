using ChatBotPOO.Data.Interfaces;

namespace ChatBotPOO.Data;

public class Channel : IChannel
{
    public string channel { get; set; }

    public Response SendMessage(string receiver, TextMessage textMessage)
    {
        Console.WriteLine($"Message has been sent from the channel: {channel}");
        Console.WriteLine($"Receiver: {receiver}");
        Console.WriteLine($"Message: {textMessage.Text}");
        Console.WriteLine($"Send Date: {textMessage}");

        return new Response { Problem = "", Success = true };
    }

    public Response SendMessage(string receiver, MultimediaMessage MultimediaMessage)
    {
        Console.WriteLine($"Multimedia Message has been sent from the channel: {channel}");
        Console.WriteLine($"Receiver: {receiver}");
        Console.WriteLine($"Message: {MultimediaMessage.Text}");
        Console.WriteLine($"Date Sent: {MultimediaMessage.SendDate}");
        Console.WriteLine($"Archive: {MultimediaMessage.Archive}");
        Console.WriteLine($"Archive Type: {MultimediaMessage.Format}");

        return new Response { Problem = "", Success= true };
    }

    public Response SendMessage(string receiver, VideoMessage videoMessage)
    {
        Console.WriteLine($"Multimedia Message has been sent from the channel: {channel}");
        Console.WriteLine($"Receiver: {receiver}");
        Console.WriteLine($"Message: {videoMessage.Text}");
        Console.WriteLine($"Date Sent: {videoMessage.SendDate}");
        Console.WriteLine($"Archive: {videoMessage.Archive}");
        Console.WriteLine($"Archive Type: {videoMessage.Format}");
        Console.WriteLine($"Duration: {videoMessage.Duration}");

        return new Response { Problem = "", Success = true };
    }
}
