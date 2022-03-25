namespace DocumentMgr
{
    public class Document
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime LastAccessedDate { get; set; }
        public string UploadedBy { get; set; }
        public int FileSize { get; set; }
        public string FileExtension { get; set; }
    }
}
