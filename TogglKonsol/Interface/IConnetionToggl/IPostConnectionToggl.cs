namespace TogglKonsol
{
    public interface IPostConnectionToggl
    {
        void Post(string apiToken, string url, string json);
    }
}