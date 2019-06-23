using System.ComponentModel.DataAnnotations;

namespace Blogs
{
    public class PostsDatabaseSettings : IPostsDatabaseSettings
    {
        public string PostsCollectionName { get; set; } = "Posts";
        public string ConnectionString { get; set; } = "mongodb+srv://adyarcafe:jFXmEAZ7X8OWMRa8@knowyourhobby-stjiv.gcp.mongodb.net/test?retryWrites=true&w=majority";
        public string DatabaseName { get; set; } ="adyarcafe";
    }

    public interface IPostsDatabaseSettings
    {
        string PostsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
