using Entities;

namespace SEP6.Temporary
{
    public class DataSession
    {
        private static DataSession instance;
        public MovieDetails MovieDetails { get; set; }
        public User User { get; set; }
        public string LastLink { get; set; }
        public CastMember CastMember { get; set; }

        private DataSession()
        {
            
        }

        public static DataSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataSession();
                }
                return instance;
            }
        }
    }
}