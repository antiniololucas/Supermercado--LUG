using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Business
{
    public class BusinessCategoria
    {

        DataAccessCategoria MPcat = new DataAccessCategoria();

        public BusinessRespuesta<bool> Agregar(EntityCategoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.Nombre) || string.IsNullOrEmpty(categoria.Descripcion))
                return new BusinessRespuesta<bool>(false, false, "Rellene campos");
            try
            {
                return new BusinessRespuesta<bool>(true, MPcat.Insert(categoria), "Agregado correctamente!");
            }
            catch
            {
                return new BusinessRespuesta<bool>(false, false, "Error al agregar");
            }
        }

        public BusinessRespuesta<bool> Eliminar(EntityCategoria cat)
        {
            cat.Id = Listar().Data.FirstOrDefault(item => item.Nombre == cat.Nombre).Id;
            try
            {
                return new BusinessRespuesta<bool>(true, MPcat.Delete(cat), $"Se elimino la categoria {cat.Nombre} satisfactoriamente");
            }
            catch
            {
                return new BusinessRespuesta<bool>(false, false, "Formato incorrecto para la categoria");
            }
        }

        public BusinessRespuesta<List<EntityCategoria>> Listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityCategoria>>(true, MPcat.SelectAll());
            }
            catch (Exception)
            {
                return new BusinessRespuesta<List<EntityCategoria>>(false, null, "Ha ocurrido un error en la busqueda");
            }
        }

        public BusinessRespuesta<bool> Modificar(EntityCategoria cat)
        {
            cat.Id = Listar().Data.FirstOrDefault(item => item.Nombre == cat.Nombre).Id;
            if (string.IsNullOrEmpty(cat.Nombre) || string.IsNullOrEmpty(cat.Descripcion))
            {
                return new BusinessRespuesta<bool>(false, false, "Error en los campos");
            }
            try
            {
                return new BusinessRespuesta<bool>(true, MPcat.Update(cat), "Se modificó correctamente!");
            }
            catch
            {
                return new BusinessRespuesta<bool>(false, false, "Error al Modificar");
            }
        }
    }
}
