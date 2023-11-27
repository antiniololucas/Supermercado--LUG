using Entity;
using System;
using System.Data;

namespace DataAccess
{
    //clase de mapeo accesible desde todas los DataAccess
    internal static class SqlMapper
    {
        public static EntityDetalle MapDetalle(DataRow registro) => new EntityDetalle()
        {

            Id = int.Parse(registro["id"].ToString()),
            Nro_Venta = int.Parse(registro["nro_venta"].ToString()),
            Id_Producto = int.Parse(registro["id_producto"].ToString()),
            CantProducto = int.Parse(registro["cant_producto"].ToString()),
            SubTotal = int.Parse(registro["subtotal"].ToString()),
        };

        public static EntityCliente MapCliente(DataRow registro) => new EntityCliente()
        {
            Dni = int.Parse(registro["dni"].ToString()),
            Nombre = registro["nombre"].ToString(),
            Apellido = registro["apellido"].ToString(),
            Telefono = int.Parse(registro["telefono"].ToString()),
        };

        public static EntityVenta MapVenta(DataRow registro) => new EntityVenta()
        {
            Id = int.Parse(registro["nro_venta"].ToString()),
            ID_Cliente = int.Parse(registro["id_cliente"].ToString()),
            Total = double.Parse(registro["total"].ToString()),
            Fecha = DateTime.Parse(registro["fecha"].ToString()),
            Nro_Tarjeta = int.Parse(registro["nro_tarjeta"].ToString())
        };

        public static EntityCategoria MapCategoria(DataRow registro) => new EntityCategoria()
        {
            Id = int.Parse(registro["id"].ToString()),
            Nombre = registro["nombre"].ToString(),
            Descripcion = registro["descripcion"].ToString(),
        };

        public static EntityMedioPago MapMedioPago(DataRow registro) => new EntityMedioPago()
        {
            Id_cliente = int.Parse(registro["id_cliente"].ToString()),
            Id_Tipo_Tarjeta = int.Parse(registro["id_tipo_tarjeta"].ToString()),
            NroTarjeta = int.Parse(registro["nro_tarjeta"].ToString()),
            FechaCaducidad = (DateTime)registro["fecha_caducidad"],
            Cvv = int.Parse(registro["cvv"].ToString()),
        };

        public static EntityTipoTarjeta MapTipoTarjeta(DataRow registro) => new EntityTipoTarjeta()
        {
            Id = int.Parse(registro["id"].ToString()),
            Nombre = registro["nombre"].ToString()
        };

        public static EntityProducto MapProducto(DataRow registro) => new EntityProducto()
        {
            Id = int.Parse(registro["id"].ToString()),
            Nombre = registro["nombre"].ToString(),
            Descripcion = registro["descripcion"].ToString(),
            Id_Categoria = int.Parse(registro["id_categoria"].ToString()),
            Precio = double.Parse(registro["precio"].ToString()),
            Stock = int.Parse(registro["stock"].ToString()),
        };
    }
}
