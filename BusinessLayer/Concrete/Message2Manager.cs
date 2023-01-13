using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messageDal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetInboxWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            _messageDal.Insert(t);        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }
        public async Task <List<AppUser>> GetUsersAsync()
        {
            using(var context=new Context())
            {
                return await context.Users.ToListAsync();
            }
        }
        public Message2 TGetById(int id)
        {
           return _messageDal.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _messageDal.GetSendBoxWithMessageByWriter(id);
        }
    }
}
