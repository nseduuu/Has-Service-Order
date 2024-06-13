using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OsDsII.api.Data;
using OsDsII.api.Dtos.Comments;
using OsDsII.api.Exceptions;
using OsDsII.api.Models;
using OsDsII.api.Repository.CommentsRepository;
using OsDsII.api.Repository.ServiceOrderRepository;

namespace OsDsII.api.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CommentService(ICommentsRepository commentsRepository, IMapper mapper, DataContext context, IServiceOrderRepository serviceOrderRepository)
        {
            _commentsRepository = commentsRepository;
            _mapper = mapper;
            _context = context;
            _serviceOrderRepository = serviceOrderRepository;
        }

        public async Task<Comment>AddCommentAsync(int serviceOrderId, CommentDto comment)
        {
            var commentMapped = _mapper.Map<Comment>(comment);
            var os = await _serviceOrderRepository.GetByIdAsync(serviceOrderId);

            if (os == null)
            {
                throw new NotFoundException("ServiceOrder not found.");
            }

            Comment commentExists = HandleCommentObject(os.Id, commentMapped.Description);

            return commentExists;
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
