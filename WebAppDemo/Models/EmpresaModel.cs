namespace WebAppDemo.Models
{
    public class EmpresaModel
    {
        public int Codigo { get; set; }

        public string RazonSocial { get; set; }

        private string descripcion;
        public string Descripcion
        {
            get
            {
                return RazonSocial + " -- EMPRESA --" + descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
    }
}
