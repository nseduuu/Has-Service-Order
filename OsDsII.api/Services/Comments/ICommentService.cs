using OsDsII.api.Dtos.Comments;
using OsDsII.api.Models;

namespace OsDsII.api.Services.Comments
{
    public interface ICommentService
    {
        public Task<Comment> AddCommentAsync(int serviceOrderId, CommentDto comment);
    }
}
