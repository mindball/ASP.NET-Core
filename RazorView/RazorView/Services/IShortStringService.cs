namespace RazorView.Services
{
    public interface IShortStringService
    {
        string GetShort(string str, int maxLength);
    }
}
