using System;

namespace Entity
{
    public class EntityVenta : Entity
    {
        private int _id_cliente;

        public int ID_Cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }


        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }


        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _nro_tarjeta;

        public int Nro_Tarjeta
        {
            get { return _nro_tarjeta; }
            set { _nro_tarjeta = value; }
        }


    }
}
