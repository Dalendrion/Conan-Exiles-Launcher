namespace Conan_Exiles_Launcher.Controllers.Dto
{
    public class ModDataDto
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
