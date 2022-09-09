namespace AA.Application.Models
{
    public record User(string FullName, DateTime Birthday)
    {
        public override string ToString()
        {
            return $"{FullName};{Birthday.ToString("yyyy_MM_dd")}";
        }
    }
}