namespace OsDsII.api.Services.Comments
{
    public interface ICommentService
    {
        public Task GetCommentAsync(int Id);
        public Task AddCommentAsync(int Id);
    }
}
