using Domain.Abstractions;

namespace Domain.Users
{
    public class User : Entity
    {
        private User(Guid id, Name name) : base(id)
        {
            name = name;
        }
        public Name Name { get; private set; }
    }
}
