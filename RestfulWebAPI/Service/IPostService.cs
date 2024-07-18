using RestfulWebAPI.Models;

namespace RestfulWebAPI.Service
{
    public interface IPostService
    {
        Posts Create(Posts posts);
        Posts GetPost(int id);
        Posts DeleteProduct(int id);
        Posts Update(int id, Posts post);
        List<Posts> GetAll();
    }
}
