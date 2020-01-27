namespace TestWebServices
{
    public class Constants
    {
        public static class Permission
        {
            public static class ORDERS
            {
                /// <summary>
                /// Ordenes - Visualización del dashboard
                /// </summary>
                public const string DASHBOARD_V = "ORDERS_DASHBOARD_V";
                /// <summary>
                /// Ordenes - Visualización de las órdenes & detalles
                /// </summary>
                public const string ORDER_V = "ORDERS_ORDER_V";
                /// <summary>
                /// Ordenes - Excepción crediticia y detalle
                /// </summary>
                public const string EXCEPTION_CREDIT_V = "ORDERS_EXCEPTION_CREDIT_V";
                /// <summary>
                /// Ordenes - Excepción de dirección y detalle
                /// </summary>
                public const string EXCEPTION_ADDRESS_V = "ORDERS_EXCEPTION_ADDRESS_V";
                /// <summary>
                /// Ordenes - Agregar comentario a solicitud
                /// </summary>
                public const string ORDER_ADD_COMMENT = "ORDERS_ORDER_ADD_COMMENT";
                /// <summary>
                /// Ordenes - Cambiar estado de solicitud
                /// </summary>
                public const string ORDER_CHANGE_STATUS = "ORDERS_ORDER_CHANGE_STATUS";
                /// <summary>
                /// Ordenes - Cambiar promotor
                /// </summary>
                public const string ORDER_MASS_ASSIGN = "ORDERS_ORDER_MASS_ASSIGN";
                /// <summary>
                /// Ordenes - Asignar solicitud
                /// </summary>
                public const string ORDER_CHANGE_AGENT = "ORDERS_ORDER_CHANGE_AGENT";
                /// <summary>
                /// Ordenes - Actualizar datos OMS de la solicitud
                /// </summary>
                public const string ORDER_OMS_UPDATE = "ORDERS_ORDER_OMS_UPDATE";
                /// <summary>
                /// Ordenes - Reportes
                /// </summary>
                public const string REPORTS_V = "ORDERS_REPORTS_V";
                /// <summary>
                /// Asignacion fuera de cadena de mando
                /// </summary>
                public const string ORDERS_ASSIGN_COMMAND_CHAIN = "ORDERS_ASSIGN_COMMAND_CHAIN";
                /// <summary>
                /// Ordenes - Autoasignarse solicitudes
                /// </summary>
                public const string ORDER_SELF_ASSIGN = "ORDERS_SELF_ASSIGN";
            }
            public static class ADMIN
            {

                #region Equipments
                /// <summary>
                /// Admin - Visualizar disponibilidad de equipos
                /// </summary>
                public const string EQUIPMENTS_V = "ADMIN_EQUIPMENTS_V";
                /// <summary>
                ///  Admin - Crear disponibilidad de equipos
                /// </summary>
                public const string EQUIPMENTS_C = "ADMIN_EQUIPMENTS_C";
                /// <summary>
                ///  Admin - Actualizar disponibilidad de equipos
                /// </summary>
                public const string EQUIPMENTS_U = "ADMIN_EQUIPMENTS_U";
                #endregion

                #region Plan Services
                /// <summary>
                ///  Admin - Visualizar planes y servicio
                /// </summary>
                public const string PLANS_SERVICES_V = "ADMIN_PLANS_SERVICES_V";

                /// <summary>
                ///  Admin - Agregar y eliminar planes y servicios a un canal
                /// </summary>
                public const string PLANS_SERVICES_U = "ADMIN_PLANS_SERVICES_U";
                #endregion

                #region WorkQueue
                /// <summary>
                /// Admin - Visualizar colas de trabajo
                /// </summary>
                public const string WORK_QUEUES_V = "ADMIN_WORK_QUEUES_V";
                /// <summary>
                /// Admin - Crear colas de trabajo
                /// </summary>
                public const string WORK_QUEUES_C = "ADMIN_WORK_QUEUES_C";
                /// <summary>
                ///  Admin - Actualizar colas de trabajo
                /// </summary>
                public const string WORK_QUEUES_U = "ADMIN_WORK_QUEUES_U";
                #endregion

                #region Payment Methods
                /// <summary>
                /// Admin - Visualizar métodos de pago
                /// </summary>
                public const string PAYMENT_METHOD_V = "ADMIN_PAYMENT_METHOD_V";
                /// <summary>
                /// Admin - Crear métodos de pago
                /// </summary>
                public const string PAYMENT_METHOD_C = "ADMIN_PAYMENT_METHOD_C";
                /// <summary>
                /// Admin - Actualizar métodos de pago
                /// </summary>
                public const string PAYMENT_METHOD_U = "ADMIN_PAYMENT_METHOD_U";
                #endregion

                #region Channels
                /// <summary>
                /// Admin - Visualizar canales
                /// </summary>
                public const string CHANNELS_V = "ADMIN_CHANNELS_V";
                /// <summary>
                /// Admin - Crear canales
                /// </summary>
                public const string CHANNELS_C = "ADMIN_CHANNELS_C";
                /// <summary>
                /// Admin - Actualizar canales
                /// </summary>
                public const string CHANNELS_U = "ADMIN_CHANNELS_U";
                #endregion

                #region Products
                /// <summary>
                /// Admin - Visualizar disponibilidad de productos
                /// </summary>
                public const string PRODUCTS_V = "ADMIN_PRODUCTS_V";
                /// <summary>
                /// Admin - Crear disponibilidad de productos
                /// </summary>
                public const string PRODUCTS_C = "ADMIN_PRODUCTS_C";
                /// <summary>
                /// Admin - Actualizar disponibilidad de productos
                /// </summary>
                public const string PRODUCTS_U = "ADMIN_PRODUCTS_U";
                #endregion

                #region Users
                /// <summary>
                /// Admin - Visualizar usuarios
                /// </summary>
                public const string USERS_V = "ADMIN_USERS_V";
                /// <summary>
                ///  Admin - Crear usuarios
                /// </summary>
                public const string USERS_C = "ADMIN_USERS_C";
                /// <summary>
                ///   Admin - Actualizar usuarios
                /// </summary>
                public const string USERS_U = "ADMIN_USERS_U";
                #endregion

                #region Colors
                /// <summary>
                ///   Admin - Actualizar colores de usuarios
                /// </summary>
                public const string COLORS_U = "ADMIN_COLORS_U";
                #endregion

                #region Information
                /// <summary>
                ///    Admin - Ver mensajes informativos
                /// </summary>
                public const string INFORMATION_V = "ADMIN_INFORMATION_V";
                /// <summary>
                ///  Admin - Crear mensajes informativos
                /// </summary>
                public const string INFORMATION_C = "ADMIN_INFORMATION_C";
                #endregion

                #region Providers
                /// <summary>
                /// Admin - Visualizar Proveedores
                /// </summary>
                public const string PROVIDER_V = "ADMIN_PROVIDER_V";
                /// <summary>
                /// Admin - Crear Proveedores
                /// </summary>
                public const string PROVIDER_C = "ADMIN_PROVIDER_C";
                /// <summary>
                /// Admin - Actualizar Proveedores
                /// </summary>
                public const string PROVIDER_U = "ADMIN_PROVIDER_U";
                #endregion

                #region TV Caegory
                /// <summary>
                /// Admin - Visualizar Categoria de tv
                /// </summary>
                public const string TV_CATEGORY_V = "ADMIN_TV_CATEGORY_V";
                /// <summary>
                /// Admin - Crear Categoria de tv
                /// </summary>
                public const string TV_CATEGORY_C = "ADMIN_TV_CATEGORY_C";
                /// <summary>
                /// Admin - Actualizar Categoria de tv
                /// </summary>
                public const string TV_CATEGORY_U = "ADMIN_TV_CATEGORY_U";
                #endregion

                #region Plan Portfolio
                /// <summary>
                /// Admin - Visualizar Portafolio
                /// </summary>
                public const string PLAN_PORTFOLIOS_V = "ADMIN_PLAN_PORTFOLIOS_V";
                /// <summary>
                /// Admin - Crear Portafolio
                /// </summary>
                public const string PLAN_PORTFOLIOS_C = "ADMIN_PLAN_PORTFOLIOS_C";
                /// <summary>
                /// Admin - Actualizar Portafolio
                /// </summary>
                public const string PLAN_PORTFOLIOS_U = "ADMIN_PLAN_PORTFOLIOS_U";
                #endregion

                #region Portability Reason
                /// <summary>
                /// Admin - Visualizar razones de portabilidad
                /// </summary>
                public const string PORTABILITY_REASON_V = "ADMIN_PORTABILITY_V";

                /// <summary>
                /// Admin - Crear razones de portabilidad
                /// </summary>
                public const string PORTABILITY_REASON_C = "ADMIN_PORTABILITY_C";

                /// <summary>
                /// Admin - Actualizar razones de portabilidad
                /// </summary>
                public const string PORTABILITY_REASON_U = "ADMIN_PORTABILITY_U";
                #endregion

                #region Plan Types
                /// <summary>
                ///  Admin - Visualizar Tipos de planes
                /// </summary>
                public const string PLANS_TYPES_V = "ADMIN_PLAN_TYPES_V";
                /// <summary>
                ///  Admin - Crear Tipos de planes
                /// </summary>
                public const string PLANS_TYPES_C = "ADMIN_PLAN_TYPES_C";
                /// <summary>
                ///  Admin - Actualizar Tipos de planes
                /// </summary>
                public const string PLANS_TYPES_U = "ADMIN_PLAN_TYPES_U";
                #endregion

                #region Not Selling Reason
                /// <summary>
                /// Admin - Visualizar razones de no venta
                /// </summary>
                public const string NOT_SELLING_REASONS_V = "ADMIN_NOT_SELLING_REASONS_V";
                /// <summary>
                /// Admin - Crear razones de no venta
                /// </summary>
                public const string NOT_SELLING_REASONS_C = "ADMIN_NOT_SELLING_REASONS_C";
                /// <summary>
                /// Admin - Editar razones de no venta
                /// </summary>
                public const string NOT_SELLING_REASONS_U = "ADMIN_NOT_SELLING_REASONS_U";
                #endregion

                #region Plan capacity
                public const string PLANS_CONFIGURATION_V = "ADMIN_PLANS_CONFIGURATION_V";
                public const string PLANS_CONFIGURATION_U = "ADMIN_PLANS_CONFIGURATION_U";
                #endregion

                #region Plan Labels
                public const string PLAN_LABELS_V = "ADMIN_PLAN_LABELS_V";
                public const string PLAN_LABELS_C = "ADMIN_PLAN_LABELS_C";
                public const string PLAN_LABELS_U = "ADMIN_PLAN_LABELS_U";
                #endregion

                #region Plan optional service configuration
                public const string OPTIONAL_SERVICES_CONFIGURATION_V = "ADMIN_OPTIONAL_SERVICES_CONFIGURATION_V";
                public const string OPTIONAL_SERVICES_CONFIGURATION_U = "ADMIN_OPTIONAL_SERVICES_CONFIGURATION_U";
                #endregion

                #region Plan optional service type
                public const string OPTIONAL_SERVICES_TYPES_V = "ADMIN_OPTIONAL_SERVICE_TYPES_V";
                public const string OPTIONAL_SERVICES_TYPES_C = "ADMIN_OPTIONAL_SERVICE_TYPES_C";
                public const string OPTIONAL_SERVICES_TYPES_U = "ADMIN_OPTIONAL_SERVICE_TYPES_U";
                #endregion

                #region Logs
                public const string LOG_V = "ADMIN_LOG_V";
                public const string LOG_C = "ADMIN_LOG_C";
                public const string LOG_U = "ADMIN_LOG_U";
                #endregion

                #region Sell Objective
                /// <summary>
                /// Admin - Visualizar un objetivo de venta
                /// </summary>
                public const string SALES_OBJECTIVES_V = "ADMIN_SALES_OBJECTIVES_V";
                /// <summary>
                /// Admin - Crear un objetivo de venta
                /// </summary>
                public const string SALES_OBJECTIVES_C = "ADMIN_SALES_OBJECTIVES_C";
                /// <summary>
                /// Admin - Actualizar un objetivo de venta
                /// </summary>
                public const string SALES_OBJECTIVES_U = "ADMIN_SALES_OBJECTIVES_U";
                #endregion

                #region Chain of Command
                /// <summary>
                /// Admin - Obviar la cadena de mando para poder ver todo.
                /// </summary>
                public const string CHAIN_OF_COMMAND_V = "ADMIN_CHAIN_OF_COMMAND_V";
                #endregion

            }
            public static class SALES
            {
                /// <summary>
                /// Ventas - Visualizar dashboard
                /// </summary>
                public const string DASHBOARD_V = "SALES_DASHBOARD_V";
                /// <summary>
                /// Ventas - Visualizar mapa
                /// </summary>
                public const string MAP_V = "SALES_MAP_V";

                /// <summary>
                /// Ventas - Visualizar visitas
                /// </summary>
                public const string VISITS_V = "SALES_VISITS_V";

                /// <summary>
                /// Ventas - Visualizar catálogo de planes
                /// </summary>
                public const string CATALOG_PLANS_V = "SALES_CATALOG_PLANS_V";
                /// <summary>
                /// Ventas - Visualizar catálogo de equipos
                /// </summary>
                public const string CATALOG_EQUIPMENT_V = "SALES_CATALOG_EQUIPMENT_V";
                /// <summary>
                ///  Ventas - Visualizar órdenes
                /// </summary>
                public const string ORDERS_V = "SALES_ORDERS_V";

                /// <summary>
                /// Ventas - Comentar una orden
                /// </summary>
                public const string ORDER_ADD_COMMENT = "SALES_ORDER_ADD_COMMENT";
                /// <summary>
                ///  Ventas - Visualizar excepciones crédito
                /// </summary>
                public const string EXCEPTION_CREDIT_V = "SALES_EXCEPTION_CREDIT_V";

                /// <summary>
                /// Ventas - Visualizar excepciones de dirección
                /// </summary>
                public const string EXCEPTION_ADDRESS_V = "SALES_EXCEPTION_ADDRESS_V";

                /// <summary>
                /// Ventas - Visualizar Delegaciones
                /// </summary>
                public const string DELEGATIONS_V = "SALES_DELEGATIONS_V";
                /// <summary>
                /// Ventas - Crear Delegaciones
                /// </summary>
                public const string DELEGATIONS_C = "SALES_DELEGATIONS_C";
                /// <summary>
                /// Ventas - Visualizar Aprobaciones
                /// </summary>
                public const string APPROBATIONS_V = "SALES_APPROBATIONS_V";
                /// <summary>
                /// Ventas - Actualizar Aprobaciones
                /// </summary>
                public const string APPROBATIONS_U = "SALES_APPROBATIONS_U";
                /// <summary>
                /// Ventas - Visualizar prospectos
                /// </summary>
                public const string PROSPECTS_V = "SALES_PROSPECTS_V";
                /// <summary>
                /// Ventas - Visualizar clientes
                /// </summary>
                public const string CLIENTS_V = "SALES_CLIENTS_V";
                /// <summary>
                /// Ventas - Visualizar citas
                /// </summary>
                public const string APPOINTMENTS_V = "SALES_APPOINTMENTS_V";
                /// <summary>
                /// Ventas - Reportes de ventas
                /// </summary>
                public const string REPORTS = "SALES_REPORTS";

                /// <summary>
                /// Ventas - Reporte de movimientos de un usuario por el canal
                /// </summary>
                public const string REPORT_CHANNEL_HISTORY = "SALES_REPORT_CHANNEL_HISTORY";

                /// <summary>
                /// Ventas - Reportes de ventas
                /// </summary>
                public const string REPORT_COMMAND_CHAIN = "SALES_REPORT_COMMAND_CHAIN";



            }
        }
    }
}
