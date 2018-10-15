using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;

         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();

         Task<PagedList<User>> GetUsers(UserParams userParams);

         Task<User> GetUser(int id);

         Task<Photo> GetPhoto(int id);

         Task<Photo> GetMainPhotoForUser(int userId);

         Task<Like> GetLike(int userId, int recipientId);  // check to see if like already exists for user

         Task<Message> GetMessage(int id);  // function to get method from database

         Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);

         Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId); // method for conversation between 2 users



         

    }
}