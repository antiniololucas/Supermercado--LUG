using DataAccess;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class BusinessMedioPago
    {
        public BusinessMedioPago()
        {
            tiposTarjeta = MPmedioPago.selectTipoTarjeta();
        }

        public List<EntityTipoTarjeta> tiposTarjeta;
        DataAccessMedioPago MPmedioPago = new DataAccessMedioPago();

        public BusinessRespuesta<bool> agregar(EntityMedioPago medioPago)
        {
            return MPmedioPago.insert(medioPago) ?
                 new BusinessRespuesta<bool>(true, true, "Se agregó exitosamente!") :
                 new BusinessRespuesta<bool>(false, false, "Error. No se pudo agregar");
        }

        public BusinessRespuesta<bool> eliminar(EntityMedioPago medioPago)
        {
            return MPmedioPago.delete(medioPago) ?
                new BusinessRespuesta<bool>(true, true, "Se eliminó correctamente!") :
                new BusinessRespuesta<bool>(false, false, "Error, no se pudo eliminar");
        }

        public BusinessRespuesta<List<EntityMedioPago>> listar()
        {
            try
            {
                return new BusinessRespuesta<List<EntityMedioPago>>(true, MPmedioPago.selectAll());
            }
            catch
            {
                return new BusinessRespuesta<List<EntityMedioPago>>(false, null, "Ha ocurrido un error");
            }
        }

        public BusinessRespuesta<bool> modificar(EntityMedioPago medioPago)
        {
            return
            MPmedioPago.Update(medioPago) ?
            new BusinessRespuesta<bool>(true, true, "Se modificó correctamente") :
            new BusinessRespuesta<bool>(false, false, "No se pudo modificar");
        }
    }
}
