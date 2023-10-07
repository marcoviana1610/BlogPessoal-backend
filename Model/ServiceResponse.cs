namespace BlogPessoal.Model
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; } = true;
    }
}
