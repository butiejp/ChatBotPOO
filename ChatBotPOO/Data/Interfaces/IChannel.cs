namespace ChatBotPOO.Data.Interfaces;

public interface IChannel
{

    Response SendMessage(string receiver, TextMessage textMessage);

    Response SendMessage(string receiver, MultimediaMessage MultimediaMessage);

    Response SendMessage(string receiver, VideoMessage videoMessage);
}
