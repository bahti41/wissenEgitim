using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class MessageManager : IMessagaService
    {
        private readonly IMapper _mapper;
        private readonly IMessageRepository _repository;

        public MessageManager(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _repository = messageRepository;
        }

        public async Task<Response<MessageDetailsViewModel>> CreateAsync(MessageDetailsViewModel messageDetailsViewModel)
        {
            var message = _mapper.Map<Message>(messageDetailsViewModel);
            var createdMessage = await _repository.CreateAsync(message);
            if (createdMessage == null)
            {
                return Response<MessageDetailsViewModel>.Fail("Kategori oluşturulamadı");
            }
            var createdMessageViewModel = _mapper.Map<MessageDetailsViewModel>(createdMessage);
            return Response<MessageDetailsViewModel>.Success(createdMessageViewModel);
        }

        public Task<Response<List<MessageDetailsViewModel>>> GetAllAsync(string userId, bool isRead = true)
        {
            throw new NotImplementedException();
        }

        public Task<Response<MessageDetailsViewModel>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> GetMessageCount(string userId, bool isRead = false)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
