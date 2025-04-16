namespace DragDrop
{
    public class FDList
    {
        public List<FileData> files = new List<FileData>();
        public List<string> filenames = new List<string>();
        public List<string> filelocations = new List<string>();
        public IDictionary<string, string> locfromkey = new Dictionary<string, string>();

        public int Count = 0;
        public void Add(string name, string location)
        {
            files.Add(new FileData() { Name = name, Location = location });
            filelocations.Add(location);
            filenames.Add(name);
            locfromkey.Add(name, location);
            Count++;
        }
        public void Remove(string name)
        {
            files.RemoveAt(filenames.IndexOf(name));
            filelocations.RemoveAt(filenames.IndexOf(name));
            filenames.Remove(name);
            locfromkey.Remove(name);
            Count--;
        }
    }
}
