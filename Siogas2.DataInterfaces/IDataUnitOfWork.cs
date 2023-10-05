using Siogas2.DataInterfaces.Parametrizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siogas2.DataInterfaces
{
    public interface IDataUnitOfWork : IDisposable
    {
        IGasoductoRepository GasoductoRepository { get; }
        //IClienteReventaRepository ClienteReventaRepository { get; }
        //IFavoritosRepository FavoritosRepository { get; }

        // interfaces del menú parametrización
        //IConfiguracionBaseRepository ConfiguracionBaseRepository { get; }
        //IMenuRepository MenuRepository { get; }
        //ITipoSociedadRepository TipoSociedadRepository { get; }
        //IPaisRepository PaisRepository { get; }
        //IDepartamentoRepository DepartamentoRepository { get; }
        //IMunicipioRepository MunicipioRepository { get; }
        //IEmpresaTransportadoraRepository EmpresaTransportadoraRepository { get; }
        //ITramoRepository TramoRepository { get; }
        //IFuenteSuministroRepository FuenteSuministroRepository { get; }
        //IProductorRepository ProductorRepository { get; }
        //ITipoPuntoRepository TipoPuntoRepository { get; }
        //ITipoUsoRepository TipoUsoRepository { get; }
        //IClienteRepository ClienteRepository { get; }
        //ITipoAgenteRepository TipoAgenteRepository { get; }
        //IOficinaRepository OficinaRepository { get; }
        //IContactoRepository ContactoRepository { get; }
        //IContratoRepository ContratoRepository { get; }
        //IComercializadorRepository ComercializadorRepository { get; }
        //IUsuarioporEstacionRepository UsuarioporEstacionRepository { get; }
        //IEstacionRepository EstacionRepository { get; }
        //IDestinoCorreoNotificacionRepository DestinoCorreoNotificacionRepository { get; }
        //IUsuarioGasoductoRepository UsuarioGasoductoRepository { get; }
        //IPuntoSalidaRepository PuntoSalidaRepository { get; }
        //INodoRepository NodoRepository { get; }
        //ICriteriosValidacionRepository CriteriosValidacionRepository { get; }
        //IMenuReportesRepository MenuReportesRepository { get; }
        //IRegistrarAnunciosRepository RegistrarAnunciosRepository { get; }
        //IUsuarioRepository UsuarioRepository { get; }
        //IAdmonCorreoNotificacionRepository AdmonCorreoNotificacionRepository { get; }
        //IListaFormatosRepository ListaFormatosRepository { get; }
        //IAsignaFormatosRepository AsignaFormatosRepository { get; }
        //IFechaDefaultRepository FechaDefaultRepository { get; }
        //IPropiedadGlobalRepository PropiedadGlobalRepository { get; }
        //IDiccionarioIdiomaRepository DiccionarioIdiomaRepository { get; }
        //IMercadoRepository MercadoRepository { get; }
        //IExpresionesValidacionRepository ExpresionesValidacionRepository { get; }
        //ICicloTransporteRepository CicloTransporteRepository { get; }
        //IPerfilCicloTransporteRepository PerfilCicloTransporteRepository { get; }
        //ISectorRepository SectorRepository { get; }
        //IPerfilOperacionRepository PerfilOperacionRepository { get; }
        //IPerfilHorarioNominacionRepository PerfilHorarioNominacionRepository { get; }
        //ILogCorreoNotificacionRepository LogCorreoNotificacionRepository { get; }
        //IAutorizacionRepository AutorizacionRepository { get; }
        //INominacionRepository NominacionRepository { get; }
        //IVolumenReferidoClienteRepository VolumenReferidoClienteRepository { get; }
        //IEquivalenciaReferidoRepository EquivalenciaReferidoRepository { get; }
        //IConfirmacionAutorizacionRepository ConfirmacionAutorizacionRepository { get; }
        //IPorcentajeNodosReguladosRepository PorcentajeNodosReguladosRepository { get; }
        //ICuentaBalanceRepository CuentaBalanceRepository { get; }
        //IProcesos008Repository Procesos008Repository { get; }
        //IClienteAdministradoRepository ClienteAdministradoRepository { get; }

        void Commit();
    }
}

