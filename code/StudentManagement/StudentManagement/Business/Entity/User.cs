namespace StudentManagement.Business.Entity
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string PersonalNumericalCode { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

        protected bool Equals(User user)
        {
            return UserId == user.UserId && Name == user.Name && CardNumber == user.CardNumber
                && PersonalNumericalCode == user.PersonalNumericalCode && Address == user.Address;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = UserId;
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                hashCode = (hashCode * 397) ^ CardNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ PersonalNumericalCode.GetHashCode();
                hashCode = (hashCode * 397) ^ Address.GetHashCode();
                return hashCode;
            }
        }

    }
}