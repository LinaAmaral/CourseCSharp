

namespace Course.Entities
{
    class Client2
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public override bool Equals(object obj)
        {
            if(!(obj is Client2))
            {
                return false;
            }
            Client2 other = obj as Client2;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
