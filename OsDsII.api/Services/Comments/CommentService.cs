using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OsDsII.api.Data;
using OsDsII.api.Models;
using OsDsII.api.Repository.CommentsRepository;

namespace OsDsII.api.Services.Comments
{
    public class CommentService
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CommentService(ICommentsRepository commentsRepository, IMapper mapper, DataContext context)
        {
            _commentsRepository = commentsRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task AddCommentAsync(int serviceOrderId, Comment comment)
        {
            Comment commentExists = HandleCommentObject(serviceOrderId, comment.Description);

            var os = await _context.ServiceOrders.Include(c => c.Customer).FirstOrDefaultAsync(s => serviceOrderId == s.Id);

            if (os == null)
            {
                throw new Exception("ServiceOrder not found.");
            }
        }

        private Comment HandleCommentObject(int id, string description)
        {
            Comment comment = new Comment
            {
                Description = description,
                ServiceOrderId = id
            };
            return comment;
        }
    }
}
