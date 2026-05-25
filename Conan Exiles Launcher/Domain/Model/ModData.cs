namespace Conan_Exiles_Launcher.Domain.Model
{
    public class ModData
    {
        public string FileName { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return $"{{ FileName: \"{FileName}\","
                + $" Id: \"{ID}\" }}";
        }
    }
}
