using RestfulWebAPI.Models;
using RestfulWebAPI.Repository;

namespace RestfulWebAPI.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;

        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;   
        }

        public Posts Create(Posts post)
        {
            return _repository.Add(post);
        }

        public Posts DeleteProduct(int id)
        {
            var deletePost = _repository.GetById(id);
            return _repository.Delete(deletePost);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Posts Update(int id, Posts post)
        {
           return _repository.UpdateById(post, id);
        }
    }
}
