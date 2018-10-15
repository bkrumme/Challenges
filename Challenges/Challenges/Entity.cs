namespace Challenges
{
    public abstract class Entity : IEntity
    {
        public bool Equals(IEntity x, IEntity y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(IEntity obj)
        {
            return obj.Id;
        }

        public int Id { get; set; }
    }
}
