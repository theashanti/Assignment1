namespace Assignment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return Id + ", " + Name + ", Age: " + Age + ", Number: " + ShirtNumber + ".";
        }

        public void ValidateName()
        {
            if (Name.Length < 2) throw new ArgumentException("Name should at least have 2 characters");
            if (Name == null) throw new NullReferenceException("Name can't be null");
        }

        public void ValidateAge()
        {
            if (Age <= 1) throw new ArgumentOutOfRangeException("Age should be greater than 1");
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber > 99 || ShirtNumber < 1) throw new ArgumentOutOfRangeException("Shirt Number must be between 1 and 99");
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }

    }
}