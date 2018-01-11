using System.Collections.Generic;

namespace _2_Behavioral.Observer
{
    public interface IAudience
    {
        void Update(GameResult result);
        List<GameResult> GameResults { get; set; }
    }

    public class NewsPaper : IAudience
    {
        public NewsPaper()
        {
            GameResults = new List<GameResult>();    
        }

        public void Update(GameResult result)
        {
            GameResults.Add(result);
        }

        public List<GameResult> GameResults { get; set; }
    }

    public class Radio : IAudience
    {
        public Radio()
        {
            GameResults = new List<GameResult>();
        }

        public void Update(GameResult result)
        {
            GameResults.Add(result);
        }

        public List<GameResult> GameResults { get; set; }
    }

    public class Television : IAudience
    {
        public Television()
        {
            GameResults = new List<GameResult>();
        }

        public void Update(GameResult result)
        {
            GameResults.Add(result);
        }

        public List<GameResult> GameResults { get; set; }
    }
}