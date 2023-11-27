using DataAccess;
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class BusinessVenta
    {
        DataAccessVenta MPventa = new DataAccessVenta();
        public List<EntityDetalle> detallesActuales = new List<EntityDetalle>();

        public int getId()
        {
            return MPventa.getId();
        }

        public BusinessRespuesta<List<EntityVenta>> listarVentas()
        {
            try
            {
                return new BusinessRespuesta<List<EntityVenta>>(true, MPventa.getAllVentas());
            }
            catch
            {
                return new BusinessRespuesta<List<EntityVenta>>(false, null, "Ha ocurrido un error");
            }
        }

        public BusinessRespuesta<bool> agregar(EntityVenta venta)
        {
            if (MPventa.Insert(venta) && MPventa.InsertDetails(detallesActuales) && venta.Total > 0)
            {
                return new BusinessRespuesta<bool>(true, true, "Se registro la venta. Factura impresa en xml!");
            }
            return new BusinessRespuesta<bool>(false, false, "No se pudo completar la venta");
        }

        public BusinessRespuesta<List<EntityDetalle>> listarDetalles(string nroVenta)
        {
            try
            {
                int nro = int.Parse(nroVenta);
                return new BusinessRespuesta<List<EntityDetalle>>(true, MPventa.getAllDetails(nro));
            }
            catch
            {
                return new BusinessRespuesta<List<EntityDetalle>>(false, null, "Ocurrió un eror");
            }
        }

        public bool GenerateXML(int numeroVenta)
        {
            return MPventa.GenerateVentaXML(numeroVenta);
        }

        public MetricaUltimaSemana ObtenerMetricas()
        {
            return MPventa.GetMetricas();
        }

        public bool GenerarMetricasXML()
        {
            return MPventa.GenerarMetricasXML();
        }

        public void crearXml(int ventaActual)
        {
           MPventa.generateFactura(ventaActual);
        }
    }
}
