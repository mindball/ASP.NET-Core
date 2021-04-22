namespace LearningSystem.Services
{
    public interface IPdfGeneratorService
    {
        byte[] GeneratePdfFromHtml(string html);
    }
}
