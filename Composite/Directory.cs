namespace Composite {
    public abstract class DirectoryType{
        
        public string Name = null!;
        public DirectoryType(string name){
            Name = name;
        }
        public abstract int GetSize();
    }

    public class DirectoryObj : DirectoryType
    {
        public List<DirectoryType> DirList = new List<DirectoryType>(); 

        public DirectoryObj(string name, int size): base(name){
            //Add file
            DirList.Add(new FileObj(name, size));
        }
        public void Add(DirectoryType dirType){
            DirList.Add(dirType);
        }

        public void Remove(DirectoryType dirType){
            DirList.Remove(dirType);
        }
        public override int GetSize()
        {
            int Size = 0;
            foreach(var obj in DirList){
                Size += obj.GetSize();
            }
            return Size;
        }

    }
    public class FileObj : DirectoryType
    {
        private int Size = 0;

        public FileObj(string name, int size):base(name){
            Size = size;
        }
        public override int GetSize()
        {
            return Size;
        }
    }
}