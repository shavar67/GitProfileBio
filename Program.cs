
using GitProfileBio;

namespace GithubProfile
{
    class Profile
    {

        public static void Main(string[] args)
        {
            var _description = "Shavar.,Software Engineer.,Augmented reality | Artificial Intelligence." +
            ",C# | Ruby | Ruby | Go.";
            var _profile = new Profile();
            _profile.GreetNewVisitors();
            Console.WriteLine(_profile.CreateBio(_description));

        }
        public User CreateBio(string _userData)
        {
            var _user = new User();
            string[] userDetails = _userData.Split(",");
            for (var i = 0; i < userDetails.Length; i++)
            {
                _user.Name = userDetails[0];
                _user.Title = userDetails[1];
                _user.Interest = userDetails[2];
                _user.Courses = userDetails[3];
            }
            return _user;
        }

        public void GreetNewVisitors()
        {
            string msg = "";
            Console.WriteLine("Welcome to my github profile! have you been here before?");
            string returning = Console.ReadLine();
            if (returning.Equals("yes", StringComparison.OrdinalIgnoreCase)) msg = "\nWelcome back!\n";
            else msg = "Hello!, take a look around!\n";
            Console.WriteLine(msg);
        }
    }
}
        
            
     
   


