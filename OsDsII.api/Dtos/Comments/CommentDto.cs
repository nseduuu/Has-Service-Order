namespace OsDsII.api.Dtos.Comments
{
    public record CommentDto(long Id, string Description, DateTimeOffset SendDate, int ServiceOrderId)
    {
    }
}
