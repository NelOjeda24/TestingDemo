namespace MyLibrary
{
    public class Customer
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string FullName
        {
            get
            { return Name + " " + Lastname; }
            //return $"{Name} {LastName}";
        }
        //public string FullName => $"{Name} {Lastname}";
    }
}
