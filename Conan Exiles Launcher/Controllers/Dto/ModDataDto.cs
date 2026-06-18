namespace Conan_Exiles_Launcher.Controllers.Dto
{
    public class ModDataDto
    {
        public string FileName { get; set; }
        public string ID { get; set; }

        public override bool Equals(object? other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other is ModDataDto that)
            {
                return string.Equals(this.FileName, that.FileName)
                    && string.Equals(this.ID, that.ID);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(FileName);
            hash.Add(ID);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"{{ FileName: \"{FileName}\","
                + $" Id: \"{ID}\" }}";
        }
    }
}
