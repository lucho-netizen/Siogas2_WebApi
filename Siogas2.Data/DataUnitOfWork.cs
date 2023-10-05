using Microsoft.Extensions.Configuration;
using Siogas2.Data.Parametrizacion;
//using Siogas2.Data.Cdsa;
//using Siogas2.Data.Nominacion;
using Siogas2.DataInterfaces;
//using Siogas2.DataInterfaces.Cdsa;
//using Siogas2.DataInterfaces.Nominacion;
using Siogas2.DataInterfaces.Parametrizacion;
using Siogas3.Data.Parametrizacion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Siogas2.Data
{
    public class DataUnitOfWork : IDataUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        // declarar variables repositorios
        private IGasoductoRepository gasoductoRepository;
        private IClienteReventaRepository clienteReventaRepository;
        //private IFavoritosRepository favoritosRepository;

        //private IConfiguracionBaseRepository configuracionBaseRepository;
        //private IMenuRepository menuRepository;
        //private ITipoSociedadRepository tipoSociedadRepository;
        //private IPaisRepository paisRepository;
        //private IDepartamentoRepository departamentoRepository;
        //private IMunicipioRepository municipioRepository;
        //private IEmpresaTransportadoraRepository empresaTransportadoraRepository;
        //private ITramoRepository tramoRepository;
        //private IFuenteSuministroRepository fuenteSuministroRepository;
        //private IProductorRepository productorRepository;
        //private ITipoPuntoRepository tipoPuntoRepository;
        //private ITipoUsoRepository tipoUsoRepository;
        //private IClienteRepository clienteRepository;
        //private ITipoAgenteRepository tipoAgenteRepository;
        //private IOficinaRepository oficinaRepository;
        //private IContactoRepository contactoRepository;
        //private IContratoRepository contratoRepository;
        //private IComercializadorRepository comercializadorRepository;
        //private IUsuarioporEstacionRepository usuarioporEstacionRepository;
        //private IEstacionRepository estacionRepository;
        //private IDestinoCorreoNotificacionRepository destinoCorreoNotificacionRepository;
        //private IUsuarioGasoductoRepository usuarioGasoductoRepository;
        //private IPuntoSalidaRepository puntoSalidaRepository;
        //private INodoRepository nodoRepository;
        //private ICriteriosValidacionRepository criteriosValidacionRepository;
        //private IMenuReportesRepository menuReportesRepository;
        //private IRegistrarAnunciosRepository registrarAnunciosRepository;
        //private IUsuarioRepository usuarioRepository;
        //private IAdmonCorreoNotificacionRepository admonCorreoNotificacionRepository;
        //private IListaFormatosRepository listaFormatosRepository;
        //private IAsignaFormatosRepository asignaFormatosRepository;
        //private IFechaDefaultRepository fechaDefaultRepository;
        //private IPropiedadGlobalRepository propiedadGlobalRepository;
        //private IDiccionarioIdiomaRepository diccionarioIdiomaRepository;
        //private IMercadoRepository mercadoRepository;
        //private IExpresionesValidacionRepository expresionesValidacionRepository;
        //private ICicloTransporteRepository cicloTransporteRepository;
        //private IPerfilCicloTransporteRepository perfilCicloTransporteRepository;
        //private ISectorRepository sectorRepository;
        //private IPerfilOperacionRepository perfilOperacionRepository;
        //private IPerfilHorarioNominacionRepository perfilHorarioNominacionRepository;
        //private ILogCorreoNotificacionRepository logCorreoNotificacionRepository;
        //private IAutorizacionRepository autorizacionRepository;
        //private INominacionRepository nominacionRepository;
        //private IVolumenReferidoClienteRepository volumenReferidoClienteRepository;
        //private IEquivalenciaReferidoRepository equivalenciaReferidoRepository;
        //private IConfirmacionAutorizacionRepository confirmacionAutorizacionRepository;
        //private IPorcentajeNodosReguladosRepository porcentajeNodosReguladosRepository;
        //private ICuentaBalanceRepository cuentaBalanceRepository;
        //private IProcesos008Repository procesos008Repository;
        //private IClienteAdministradoRepository clienteAdministradoRepository;

        public DataUnitOfWork(IConfiguration configuration)
        {
            if (Convert.ToBoolean(configuration.GetSection("Dev-VPN").Value))
            {
                _connection = new SqlConnection(configuration.GetConnectionString("Conexion"));
            }
            else
            {
                _connection = new SqlConnection(configuration.GetConnectionString("Conexion"));
            }
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        private void ResetRepositories()
        {

        }

        // declarar propiedades de repositorios
        public IGasoductoRepository GasoductoRepository
        {
            get { return gasoductoRepository ?? (gasoductoRepository = new GasoductoRepository(_transaction)); }
        }

        public IClienteReventaRepository ClienteReventaRepository
        {
            get { return clienteReventaRepository ?? (clienteReventaRepository = new ClienteReventaRepository(_transaction)); }
        }

        //public IFavoritosRepository FavoritosRepository
        //{
        //    get { return favoritosRepository ?? (favoritosRepository = new FavoritosRepository(_transaction)); }
        //}

        //public IConfiguracionBaseRepository ConfiguracionBaseRepository
        //{
        //    get { return configuracionBaseRepository ?? (configuracionBaseRepository = new ConfiguracionBaseRepository(_transaction)); }
        //}

        //public IMenuRepository MenuRepository
        //{
        //    get { return menuRepository ?? (menuRepository = new MenuRepository(_transaction)); }
        //}

        //public ITipoSociedadRepository TipoSociedadRepository
        //{
        //    get { return tipoSociedadRepository ?? (tipoSociedadRepository = new TipoSociedadRepository(_transaction)); }
        //}

        //public IPaisRepository PaisRepository
        //{
        //    get { return paisRepository ?? (paisRepository = new PaisRepository(_transaction)); }
        //}

        //public IDepartamentoRepository DepartamentoRepository
        //{
        //    get { return departamentoRepository ?? (departamentoRepository = new DepartamentoRepository(_transaction)); }
        //}

        //public IMunicipioRepository MunicipioRepository
        //{
        //    get { return municipioRepository ?? (municipioRepository = new MunicipioRepository(_transaction)); }
        //}

        //public IEmpresaTransportadoraRepository EmpresaTransportadoraRepository
        //{
        //    get { return empresaTransportadoraRepository ?? (empresaTransportadoraRepository = new EmpresaTransportadoraRepository(_transaction)); }
        //}

        //public ITramoRepository TramoRepository
        //{
        //    get { return tramoRepository ?? (tramoRepository = new TramoRepository(_transaction)); }
        //}

        //public IFuenteSuministroRepository FuenteSuministroRepository
        //{
        //    get { return fuenteSuministroRepository ?? (fuenteSuministroRepository = new FuenteSuministroRepository(_transaction)); }
        //}

        //public IProductorRepository ProductorRepository
        //{
        //    get { return productorRepository ?? (productorRepository = new ProductorRepository(_transaction)); }
        //}

        //public ITipoPuntoRepository TipoPuntoRepository
        //{
        //    get { return tipoPuntoRepository ?? (tipoPuntoRepository = new TipoPuntoRepository(_transaction)); }
        //}

        //public ITipoUsoRepository TipoUsoRepository
        //{
        //    get { return tipoUsoRepository ?? (tipoUsoRepository = new TipoUsoRepository(_transaction)); }
        //}

        //public IClienteRepository ClienteRepository
        //{
        //    get { return clienteRepository ?? (clienteRepository = new ClienteRepository(_transaction)); }
        //}

        //public ITipoAgenteRepository TipoAgenteRepository
        //{
        //    get { return tipoAgenteRepository ?? (tipoAgenteRepository = new TipoAgenteRepository(_transaction)); }
        //}

        //public IOficinaRepository OficinaRepository
        //{
        //    get { return oficinaRepository ?? (oficinaRepository = new OficinaRepository(_transaction)); }
        //}

        //public IContactoRepository ContactoRepository
        //{
        //    get { return contactoRepository ?? (contactoRepository = new ContactoRepository(_transaction)); }
        //}

        //public IContratoRepository ContratoRepository
        //{
        //    get { return contratoRepository ?? (contratoRepository = new ContratoRepository(_transaction)); }
        //}

        //public IComercializadorRepository ComercializadorRepository
        //{
        //    get { return comercializadorRepository ?? (comercializadorRepository = new ComercializadorRepository(_transaction)); }
        //}

        //public IUsuarioporEstacionRepository UsuarioporEstacionRepository
        //{
        //    get { return usuarioporEstacionRepository ?? (usuarioporEstacionRepository = new UsuarioporEstacionRepository(_transaction)); }
        //}

        //public IEstacionRepository EstacionRepository
        //{
        //    get { return estacionRepository ?? (estacionRepository = new EstacionRepository(_transaction)); }
        //}

        //public IDestinoCorreoNotificacionRepository DestinoCorreoNotificacionRepository
        //{
        //    get { return destinoCorreoNotificacionRepository ?? (destinoCorreoNotificacionRepository = new DestinoCorreoNotificacionRepository(_transaction)); }
        //}

        //public IUsuarioGasoductoRepository UsuarioGasoductoRepository
        //{
        //    get { return usuarioGasoductoRepository ?? (usuarioGasoductoRepository = new UsuarioGasoductoRepository(_transaction)); }
        //}

        //public IPuntoSalidaRepository PuntoSalidaRepository
        //{
        //    get { return puntoSalidaRepository ?? (puntoSalidaRepository = new PuntoSalidaRepository(_transaction)); }
        //}

        //public INodoRepository NodoRepository
        //{
        //    get { return nodoRepository ?? (nodoRepository = new NodoRepository(_transaction)); }
        //}

        //public ICriteriosValidacionRepository CriteriosValidacionRepository
        //{
        //    get { return criteriosValidacionRepository ?? (criteriosValidacionRepository = new CriteriosValidacionRepository(_transaction)); }
        //}

        //public IMenuReportesRepository MenuReportesRepository
        //{
        //    get { return menuReportesRepository ?? (menuReportesRepository = new MenuReportesRepository(_transaction)); }
        //}

        //public IRegistrarAnunciosRepository RegistrarAnunciosRepository
        //{
        //    get { return registrarAnunciosRepository ?? (registrarAnunciosRepository = new RegistrarAnunciosRepository(_transaction)); }
        //}

        //public IUsuarioRepository UsuarioRepository
        //{
        //    get { return usuarioRepository ?? (usuarioRepository = new UsuarioRepository(_transaction)); }
        //}

        //public IAdmonCorreoNotificacionRepository AdmonCorreoNotificacionRepository
        //{
        //    get { return admonCorreoNotificacionRepository ?? (admonCorreoNotificacionRepository = new AdmonCorreoNotificacionRepository(_transaction)); }
        //}

        //public IListaFormatosRepository ListaFormatosRepository
        //{
        //    get { return listaFormatosRepository ?? (listaFormatosRepository = new ListaFormatosRepository(_transaction)); }
        //}

        //public IAsignaFormatosRepository AsignaFormatosRepository
        //{
        //    get { return asignaFormatosRepository ?? (asignaFormatosRepository = new AsignaFormatosRepository(_transaction)); }
        //}

        //public IFechaDefaultRepository FechaDefaultRepository
        //{
        //    get { return fechaDefaultRepository ?? (fechaDefaultRepository = new FechaDefaultRepository(_transaction)); }
        //}

        //public IPropiedadGlobalRepository PropiedadGlobalRepository
        //{
        //    get { return propiedadGlobalRepository ?? (propiedadGlobalRepository = new PropiedadGlobalRepository(_transaction)); }
        //}

        //public IDiccionarioIdiomaRepository DiccionarioIdiomaRepository
        //{
        //    get { return diccionarioIdiomaRepository ?? (diccionarioIdiomaRepository = new DiccionarioIdiomaRepository(_transaction)); }
        //}

        //public IMercadoRepository MercadoRepository
        //{
        //    get { return mercadoRepository ?? (mercadoRepository = new MercadoRepository(_transaction)); }
        //}

        //public IExpresionesValidacionRepository ExpresionesValidacionRepository
        //{
        //    get { return expresionesValidacionRepository ?? (expresionesValidacionRepository = new ExpresionesValidacionRepository(_transaction)); }
        //}

        //public ICicloTransporteRepository CicloTransporteRepository
        //{
        //    get { return cicloTransporteRepository ?? (cicloTransporteRepository = new CicloTransporteRepository(_transaction)); }
        //}

        //public IPerfilCicloTransporteRepository PerfilCicloTransporteRepository
        //{
        //    get { return perfilCicloTransporteRepository ?? (perfilCicloTransporteRepository = new PerfilCicloTransporteRepository(_transaction)); }
        //}

        //public ISectorRepository SectorRepository
        //{
        //    get { return sectorRepository ?? (sectorRepository = new SectorRepository(_transaction)); }
        //}

        //public IPerfilOperacionRepository PerfilOperacionRepository
        //{
        //    get { return perfilOperacionRepository ?? (perfilOperacionRepository = new PerfilOperacionRepository(_transaction)); }
        //}

        //public IPerfilHorarioNominacionRepository PerfilHorarioNominacionRepository
        //{
        //    get { return perfilHorarioNominacionRepository ?? (perfilHorarioNominacionRepository = new PerfilHorarioNominacionRepository(_transaction)); }
        //}

        //public ILogCorreoNotificacionRepository LogCorreoNotificacionRepository
        //{
        //    get { return logCorreoNotificacionRepository ?? (logCorreoNotificacionRepository = new LogCorreoNotificacionRepository(_transaction)); }
        //}
        //public IAutorizacionRepository AutorizacionRepository
        //{
        //    get { return autorizacionRepository ?? (autorizacionRepository = new AutorizacionRepository(_transaction)); }
        //}

        //public INominacionRepository NominacionRepository
        //{
        //    get { return nominacionRepository ?? (nominacionRepository = new NominacionRepository(_transaction)); }
        //}

        //public IVolumenReferidoClienteRepository VolumenReferidoClienteRepository
        //{
        //    get { return volumenReferidoClienteRepository ?? (volumenReferidoClienteRepository = new VolumenReferidoClienteRepository(_transaction)); }
        //}
        //public IEquivalenciaReferidoRepository EquivalenciaReferidoRepository
        //{
        //    get { return equivalenciaReferidoRepository ?? (equivalenciaReferidoRepository = new EquivalenciasReferidoRepository(_transaction)); }
        //}
        //public IConfirmacionAutorizacionRepository ConfirmacionAutorizacionRepository
        //{
        //    get { return confirmacionAutorizacionRepository ?? (confirmacionAutorizacionRepository = new ConfirmacionAutorizacionRepository(_transaction)); }
        //}
        //public IPorcentajeNodosReguladosRepository PorcentajeNodosReguladosRepository
        //{
        //    get { return porcentajeNodosReguladosRepository ?? (porcentajeNodosReguladosRepository = new PorcentajeNodosReguladosRepository(_transaction)); }
        //}
        //public ICuentaBalanceRepository CuentaBalanceRepository
        //{
        //    get { return cuentaBalanceRepository ?? (cuentaBalanceRepository = new CuentaBalanceRepository(_transaction)); }
        //}
        //public IProcesos008Repository Procesos008Repository
        //{
        //    get { return procesos008Repository ?? (procesos008Repository = new Procesos008Repository(_transaction)); }
        //}

        //public IClienteAdministradoRepository ClienteAdministradoRepository
        //{
        //    get { return clienteAdministradoRepository ?? (clienteAdministradoRepository = new ClienteAdministradoRepository(_transaction)); }
        //}

        DataInterfaces.Parametrizacion.IGasoductoRepository IDataUnitOfWork.GasoductoRepository => throw new NotImplementedException();

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();

                ResetRepositories();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private interface IAutorizacionRepository
        {
        }
    }
}
