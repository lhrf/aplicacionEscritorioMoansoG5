namespace CEIBIO.Presentacion
{
    internal sealed class Mantenedor
    {
        private readonly Control datos;
        private readonly Button nuevo;
        private readonly Button editar;
        private readonly Button guardar;
        private readonly Button cancelar;
        private readonly Button inhabilitar;

        public int Id { get; private set; }
        public bool Editando { get; private set; }

        public Mantenedor(Control datos, Button nuevo, Button editar, Button guardar, Button cancelar, Button inhabilitar)
        {
            this.datos = datos;
            this.nuevo = nuevo;
            this.editar = editar;
            this.guardar = guardar;
            this.cancelar = cancelar;
            this.inhabilitar = inhabilitar;
            Modo(false);
        }

        public void Nuevo()
        {
            Ui.Limpiar(datos);
            Id = 0;
            Modo(true);
        }

        public void Editar(int id)
        {
            Id = id;
            Modo(true);
        }

        public void Cancelar()
        {
            Ui.Limpiar(datos);
            Id = 0;
            Modo(false);
        }

        private void Modo(bool editando)
        {
            Editando = editando;
            datos.Enabled = editando;
            guardar.Enabled = editando;
            cancelar.Enabled = editando;
            nuevo.Enabled = !editando;
            editar.Enabled = !editando;
            inhabilitar.Enabled = !editando;
        }
    }
}
