using Siogas2.Models.Nominacion;
using Siogas2.Models.Parametrizacion;

using System.Collections.Generic;

namespace Siogas2.LogicInterfaces.Nominacion
{
    public interface IProcesos008Manager
    {
        ListadoRecorte008 Get(int Procesos008Id);
        IEnumerable<ListadoRecorte008> GetAll(string fecha, int gaso, int cta);
        IEnumerable<ListadoRecorte008> GetAll(int id);
        IEnumerable<Cuenta_res_008> GetCuenta_res_008(string dia, int cliente_id, int tramo_id);
        void Remove(int Procesos008Id);
        void Save(ListadoRecorte008 datos);
        void Cut(List<Parametros008> datos);
        void NoCut(List<Parametros008> datos);
        void Reverse(List<Parametros008> datos);
        void Reset(List<Cuenta_res_008> datos);
        void Reprocess(Parametros008 dato);
        Listado_control_activa_informe_res008 ActivaInforme(Parametros008 dato);
        void Bag(List<Parametros008> datos);
        void Cuts(List<Parametros008> datos);
        void Emails(List<Parametros008> datos);
        void Report(List<Parametros008> datos);
        string AgregarBolsa(Parametros008 dato);
        void RecAcu(List<Listado_recortes_editar> items, string Usuario, string sFecha);
        IEnumerable<Cliente> GetCustomers(int id);
        IEnumerable<ListaCtas008> GetListaCtas(int gaso, int cliente);
        IEnumerable<Nodos_res_008> GetListaNodos(int gaso, int cliente);
        IEnumerable<Listado_recortes_editar> GetListadoRecortesEditar(string fecha, int gaso, int cliente);
        IEnumerable<Pis_res_008> GetListaPis(int gaso);
        IEnumerable<Bolsa_editar_res_008> GetBolsaEditar(string fecha, int gaso, int cliente);
    }
}