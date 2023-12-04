using ChatBotPOO.Data.Enums;

namespace ChatBotPOO.Data;

public class MultimediaMessage : TextMessage
{
    public string Archive { get; set; }
    public ArchiveTypesEnum Format { get; set; }
}
