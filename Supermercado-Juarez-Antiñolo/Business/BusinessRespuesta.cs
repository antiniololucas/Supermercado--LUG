namespace Business
{
    public class BusinessRespuesta<T>
    {
        public BusinessRespuesta(bool ok, T data, string mensaje = "")
        {
            this.Ok = ok;
            this.Data = data;
            this.Mensaje = mensaje;
        }
        public bool Ok { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }
    }
}
