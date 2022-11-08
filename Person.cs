
namespace GitProfileBio { 
    public class User {
        private string name;
        private string title;
        private string interest;
        private string courses;

        public string Name { get => name; set => name = value; }
        public string Title { get => title; set => title = value; }
        public string Courses { get => courses; set => courses = value; }
        public string Interest { get => interest; set => interest = value; }
        public User() { Console.WriteLine("Please wait...generating profile bio.\n"); }
        public override string ToString() => "Name: " + Name + "\nTitle: " + Title + "\nInterest: " + Interest + "\ncurrently learning: " + Courses; } }

    


