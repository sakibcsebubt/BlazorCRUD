namespace BlazorCRUDApp.Model
{
    public class StandardApiResponseVM
    {
        public bool IsSuccess { get; set; }
        public long StatusCode { get; set; }
        public string? Massage { get; set; }
        public object? Data { get; set; }
    }
}
