using DataAccess;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Business
{
    public class BusinessProducto
    {
        DataAccessProducto MPproducto = new DataAccessProducto();
        public List<EntityCategoria> categorias;

        public BusinessProducto()
        {
            categorias = MPproducto.LoadCategorias();
        }

        public BusinessRespuesta<bool> agregar(EntityProducto producto, string precio, string stock)
        {
            if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Descripcion) || int.TryParse(precio, out int _precio) || !int.TryParse(stock, out int _stock))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");

            producto.Precio = _precio;
            producto.Stock = _stock;

            return MPproducto.Insert(producto) ?
                new BusinessRespuesta<bool>(true, true, "Agregado Correctamente!") :
                new BusinessRespuesta<bool>(false, false, "Error al agregar");
        }

        public BusinessRespuesta<bool> eliminar(string id)
        {
            try
            {
                return MPproducto.Delete(int.Parse(id)) ?
                      new BusinessRespuesta<bool>(true, true, "Se eliminó correctamente!") :
                      new BusinessRespuesta<bool>(false, false, "No se pudó eliminar, revise el id solicitado");
            }
            catch
            {
                return new BusinessRespuesta<bool>(false, false, " Formato incorrecto en el ID");
            }
        }

        public BusinessRespuesta<List<EntityProducto>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityProducto>>(true, MPproducto.SelectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityProducto>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public BusinessRespuesta<bool> modificar(EntityProducto producto, string precio, string stock)
        {
            if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Descripcion)|| !int.TryParse(precio, out int _precio) || !int.TryParse(stock, out int _stock))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");

            producto.Precio = _precio;
            producto.Stock = _stock;

            if (MPproducto.Update(producto))
                return new BusinessRespuesta<bool>(true, true, "Modificado Correctamente!");
            else
            {
                return new BusinessRespuesta<bool>(false, false, "Error al modificar");
            }
        }
        public BusinessRespuesta<bool> modificar(EntityProducto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");


            if (MPproducto.Update(producto))
                return new BusinessRespuesta<bool>(true, true, "Modificado Correctamente!");
            else
            {
                return new BusinessRespuesta<bool>(false, false, "Error al modificar");
            }
        }

        public bool xml()
        {
            return MPproducto.xml();
        }
    }
}
