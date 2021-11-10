namespace BotAPI.Responses
{
    public interface IResponse<T>
    {
        public bool Ok { get; set; }
        public T Result { get; set; }
    }
}
