using ChatBotPOO.Data;
using ChatBotPOO.Data.Enums;
using Microsoft.AspNetCore.Mvc;

namespace ChatBotPOO.Controllers;

[ApiController]
[Route("/SendMessage")]
public class MessageSenderController : ControllerBase
{
    [HttpPost]
    public Response Send([FromForm] string message, string media, ArchiveTypesEnum format, int duration, string receiver, string channel)
    {
        Channel channels = new Channel();

        var response = new Response { Problem = "Invalid archive", Success = false };

        switch (channel.ToLower().Trim())
        {
            case "whatsapp":
                channels.channel = "whatsapp";
                break;

            case "facebook":
                channels.channel = "facebook";
                break;

            case "instagram":
                channels.channel = "instagram";
                break;

            case "telegram":
                channels.channel = "telegram";
                break;

            default:
                return new Response { Success = false, Problem = "Invalid Channel" };
                break;
        }

        if (format == ArchiveTypesEnum.TXT)
            response = channels.SendMessage(receiver, new TextMessage
            {
                Text = message,
                SendDate = DateTime.Now
            });

        if (format == ArchiveTypesEnum.PDF || format == ArchiveTypesEnum.MP3)
            response = channels.SendMessage(receiver, new MultimediaMessage
            {
                Text = message,
                SendDate = DateTime.Now,
                Archive = media,
                Format = format
            });

        if (format == ArchiveTypesEnum.MP4)
            response = channels.SendMessage(receiver, new VideoMessage
            {
                Text = message,
                SendDate = DateTime.Now,
                Archive = media,
                Format = format,
                Duration = duration
            });

        return response;
    }
}
