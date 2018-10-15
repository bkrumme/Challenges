using System.Collections.Generic;

namespace Challenges
{
    public interface IEntity : IEqualityComparer<IEntity>
    {
        int Id { get; set; }
    }
}
