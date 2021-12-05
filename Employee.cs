namespace CatWorx.BadgeMaker
{
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int ID;
        private string PhotoUrl;
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            PhotoUrl = photoUrl;
        }

        public string GetName() {
            return FirstName + " " + LastName;
        }

        public int GetId() {
            return ID;
        }

        public string GetPhotoUrl() {
            return PhotoUrl;
        }
    }
}