namespace MusicStoreCodeFirst.Models
{
    using System.Data.Entity;

    public class MusicStoreModel : DbContext
    {
        // Your context has been configured to use a 'MusicStoreModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicStoreCodeFirst.Models.MusicStoreModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusicStoreModel' 
        // connection string in the application configuration file.
        public MusicStoreModel()
            : base("name=MusicStoreEntity")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}