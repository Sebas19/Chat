namespace ChatJOYA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChatContext : DbContext
    {
        public ChatContext()
            : base("name=ChatContext")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.idRoom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nick)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.idUser)
                .WillCascadeOnDelete(false);
        }
    }
}
