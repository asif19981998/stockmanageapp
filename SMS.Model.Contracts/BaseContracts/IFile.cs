namespace SMS.Model.Contracts.BaseContracts
{
    public interface IFile
    {
        long Id { get; set; }
        int FileTypeId { get; set; }
        string FileSource { get; set; }
        string FileName { get; set; }
        byte[] File { get; set; }
        IFileType FileType { get; set; }
    }
}