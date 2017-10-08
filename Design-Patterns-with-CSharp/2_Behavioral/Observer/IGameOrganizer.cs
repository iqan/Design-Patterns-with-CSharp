using System.Collections.Generic;

namespace _2_Behavioral.Observer
{
    public interface IGameOrganizer
    {
        void RegisterAudience(IAudience audience);
        void UnregisterAudience(IAudience audience);
        void NotifyAudience(GameResult result);
    }

    public class BadmintonOrganizer : IGameOrganizer
    {
        private List<IAudience> _audiences = new List<IAudience>();

        public void RegisterAudience(IAudience audience)
        {
            _audiences.Add(audience);
        }

        public void UnregisterAudience(IAudience audience)
        {
            _audiences.Remove(audience);
        }

        public void NotifyAudience(GameResult result)
        {
            _audiences.ForEach( a => a.Update(result));
        }

        public void AfterGameIsDone(GameResult result)
        {
            NotifyAudience(result);
        }
    }
}
