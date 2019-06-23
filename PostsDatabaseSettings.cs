using System.ComponentModel.DataAnnotations;

namespace Blogs
{
    public class PostsDatabaseSettings : IPostsDatabaseSettings
    {
        public string PostsCollectionName { get; set; } = "Posts";
        public string ConnectionString { get; set; } ="mongodb://localhost:27017";
        public string DatabaseName { get; set; } ="adyarcafe";
    }

    public interface IPostsDatabaseSettings
    {
        string PostsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
