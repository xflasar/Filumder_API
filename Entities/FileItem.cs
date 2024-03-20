namespace Filumder_API.Entities
{
    public class FileItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public FileItem(string name, string description, string url)
        {
            Name = name;
            Description = description;
            Url = url;
        }
    }
}
