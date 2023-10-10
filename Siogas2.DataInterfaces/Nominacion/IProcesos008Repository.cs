
using Siogas2.DataInterfaces;
using Siogas2.Models.Nominacion;
using Siogas2.Models.Parametrizacion;

using System.Collections.Generic;

namespace Siogas2.DataInterfaces.Nominacion
{
    public interface IProcesos008Repository : IRepository<ListadoRecorte008, int>
    {
        IEnumerable<ListadoRecorte008> RetrieveAll(string fecha, int gaso, int cta);
        IEnumerable<Cuenta_res_008> RetrieveCuenta_res_008(string dia, int gaso, int cta);
        void Cut(List<Parametros008> datos);
        void NoCut(List<Parametros008> datos);
        void Reverse(List<Parametros008> datos);
        Listado_control_activa_informe_res008 ActivReport(Parametros008 dato);
        void Reset(List<Cuenta_res_008> datos);
        void Reprocess(Parametros008 dato);
        void Bag(List<Parametros008> datos);
        void Cuts(List<Parametros008> datos);
        void Emails(List<Parametros008> datos);
        void Report(List<Parametros008> datos);
        string AgregarBolsa(Parametros008 dato);
        public void RecAcu(List<Listado_recortes_editar> items, string Usuario, string sFecha);
        IEnumerable<Cliente> ClienteRetrieveComplete(int id);
        IEnumerable<ListaCtas008> ListaCuentas(int gasoId, int cliente);
        IEnumerable<Nodos_res_008> GetListaNodos(int gasoId, int cliente);
        IEnumerable<Pis_res_008> GetListaPis(int gasoId);
        IEnumerable<Bolsa_editar_res_008> GetBolsaEditAll(string fecha, int gaso, int cliente);
        IEnumerable<Listado_recortes_editar> GetListadoRecortesEdit(string fecha, int gaso, int cliente);
    }
}
