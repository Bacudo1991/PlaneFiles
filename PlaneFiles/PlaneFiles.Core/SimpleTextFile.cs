namespace PlaneFiles.Core
{
    public class SimpleTextFile
    {
        private readonly string _path;

        public SimpleTextFile(string path)
        {
            _path = path;
        }

        public void writeAllLines(string[] lines)
        {
            File.WriteAllLines(_path, lines);            
        }

        public string[] ReadAllLines()
        {
            return File.ReadAllLines(_path);
        }
    }
}
