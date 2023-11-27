namespace Entity
{
    public class EntityDetalle : Entity
    {
        private int _nro_venta;

        public int Nro_Venta
        {
            get { return _nro_venta; }
            set { _nro_venta = value; }
        }

        private int _id_producto;

        public int Id_Producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        private int _cantProducto;

        public int CantProducto
        {
            get { return _cantProducto; }
            set { _cantProducto = value; }
        }
        private int _subtotal;

        public int SubTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

    }
}
