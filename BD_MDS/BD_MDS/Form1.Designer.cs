namespace BD_MDS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_casos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total_registro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_servicio_negocio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sintoma_o_detalle = new System.Windows.Forms.TextBox();
            this.cbo_sintoma_detalle = new System.Windows.Forms.ComboBox();
            this.cbo_componente_servicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_especialistas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_casos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_casos
            // 
            this.dgv_casos.AllowDrop = true;
            this.dgv_casos.AllowUserToAddRows = false;
            this.dgv_casos.AllowUserToDeleteRows = false;
            this.dgv_casos.AllowUserToOrderColumns = true;
            this.dgv_casos.AllowUserToResizeColumns = false;
            this.dgv_casos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgv_casos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_casos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_casos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_casos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_casos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_casos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_casos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_casos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_casos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_casos.GridColor = System.Drawing.Color.Black;
            this.dgv_casos.Location = new System.Drawing.Point(0, 262);
            this.dgv_casos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_casos.Name = "dgv_casos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_casos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_casos.RowHeadersVisible = false;
            this.dgv_casos.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_casos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_casos.Size = new System.Drawing.Size(929, 377);
            this.dgv_casos.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "TOTAL CONSULTA:";
            // 
            // lbl_total_registro
            // 
            this.lbl_total_registro.AutoSize = true;
            this.lbl_total_registro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_total_registro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_total_registro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_total_registro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_total_registro.Location = new System.Drawing.Point(158, 230);
            this.lbl_total_registro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_registro.Name = "lbl_total_registro";
            this.lbl_total_registro.Size = new System.Drawing.Size(50, 24);
            this.lbl_total_registro.TabIndex = 112;
            this.lbl_total_registro.Text = "9999";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbo_servicio_negocio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_sintoma_o_detalle);
            this.groupBox2.Controls.Add(this.cbo_sintoma_detalle);
            this.groupBox2.Controls.Add(this.cbo_componente_servicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(17, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(912, 144);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTRO DE CATEGORIZACIONES";
            // 
            // cbo_servicio_negocio
            // 
            this.cbo_servicio_negocio.BackColor = System.Drawing.Color.Silver;
            this.cbo_servicio_negocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_servicio_negocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_servicio_negocio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbo_servicio_negocio.ForeColor = System.Drawing.Color.Black;
            this.cbo_servicio_negocio.FormattingEnabled = true;
            this.cbo_servicio_negocio.Items.AddRange(new object[] {
            "",
            "Backup de información",
            "Bases de datos",
            "Gestión de accesos",
            "Gestión de activos",
            "Gestión de aplicaciones",
            "Gestión de servidores",
            "Impresión",
            "Monitoreo",
            "Networking",
            "Seguridad informática",
            "Soporte de hardware",
            "Soporte de software",
            "Telefonía",
            "Transmisiones en línea",
            "Virtualización"});
            this.cbo_servicio_negocio.Location = new System.Drawing.Point(264, 99);
            this.cbo_servicio_negocio.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_servicio_negocio.Name = "cbo_servicio_negocio";
            this.cbo_servicio_negocio.Size = new System.Drawing.Size(303, 27);
            this.cbo_servicio_negocio.Sorted = true;
            this.cbo_servicio_negocio.TabIndex = 125;
            this.cbo_servicio_negocio.SelectedIndexChanged += new System.EventHandler(this.cbo_servicio_negocio_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "SERVICIO DE NEGOCIO:";
            // 
            // txt_sintoma_o_detalle
            // 
            this.txt_sintoma_o_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sintoma_o_detalle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_sintoma_o_detalle.ForeColor = System.Drawing.Color.Black;
            this.txt_sintoma_o_detalle.Location = new System.Drawing.Point(578, 28);
            this.txt_sintoma_o_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sintoma_o_detalle.MaxLength = 1000;
            this.txt_sintoma_o_detalle.Name = "txt_sintoma_o_detalle";
            this.txt_sintoma_o_detalle.Size = new System.Drawing.Size(325, 27);
            this.txt_sintoma_o_detalle.TabIndex = 123;
            this.txt_sintoma_o_detalle.TextChanged += new System.EventHandler(this.txt_sintoma_o_detalle_TextChanged);
            // 
            // cbo_sintoma_detalle
            // 
            this.cbo_sintoma_detalle.BackColor = System.Drawing.Color.Silver;
            this.cbo_sintoma_detalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sintoma_detalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_sintoma_detalle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbo_sintoma_detalle.ForeColor = System.Drawing.Color.Black;
            this.cbo_sintoma_detalle.FormattingEnabled = true;
            this.cbo_sintoma_detalle.Items.AddRange(new object[] {
            "Acceso",
            "Acompañamiento",
            "Acompañamiento Eventos",
            "Acompañamientos Revisión Salas",
            "Activar Usuarios",
            "Activar/Bloquear Cuenta",
            "Activar/Boquear Cuenta",
            "Actualización",
            "Actualización Fireware Dispositivos de Red",
            "Actualización Firmware",
            "Actualización Licenciamiento",
            "Actualización Paquete Office",
            "Actualización SQL Server",
            "Actualizar",
            "Adjuntar RUT",
            "Aire Acondicionado",
            "Ajustar Perfil",
            "Ajustes Foto /Firma",
            "Alto Consumo de Memoria",
            "Ampliación Capacidad",
            "Análisis bajo Demanda",
            "Analisis Eventos",
            "Analisis por Demanda de Boletines de Terceros",
            "Analisis Proactivo Boletines de seguridad",
            "Aplicación de Monitoreo No Funciona",
            "Apoyo Pruebas",
            "Aprovisionamiento del Servidor",
            "Aprovisionamiento Servidor",
            "Asesorías / Información",
            "Asigancion de Casos",
            "Asignación / Retiro Clave",
            "Asignación / Retiro Extensión",
            "Asignación de Accesorios",
            "Asignacion de Casos",
            "Asignación de Clave",
            "Asignación de Equipo",
            "Asignación de Extensión",
            "Asignación de IP",
            "Asignación de Mouse / Teclado",
            "Asignación de periféricos",
            "Asignación de Roles",
            "Asignación Direccionamiento Ip",
            "Asignación IP",
            "Asignación Pin",
            "Asignación Teléfono",
            "Asignar Licencia",
            "Asignar Perfil",
            "Asignar Permisos",
            "Asignar Permisos Carpeta de Red",
            "Asignar Roles",
            "Atasco de Papel",
            "Aumento Capacidad Disco",
            "Autorización Gasto Promoción",
            "Backup",
            "Bloqueo o Caída de Aplicación",
            "Bloqueo o Caida de la Aplicación",
            "Bloqueo o Caída de la Aplicación",
            "Bloqueo Pagina Web",
            "Bloqueo/ Lentitud Sistema Operativo",
            "Caida Canal Internacional",
            "Caida Canal Nacional",
            "Caida Canal Principal",
            "Caída de Aplicación o Servicio",
            "Caída Masiva  Servicio Telefonía",
            "Cambio de Contraseña",
            "Cambio de Idioma",
            "Cambio Fechas de eventos",
            "Cambio Impresora",
            "Cambio Kit Mantenimiento",
            "Cambio Mouse/Teclado",
            "Cambio Recibo de Pago",
            "Cambio Teléfono",
            "Cambio Tóner/Cartuchos",
            "Cambio Valor Pago Eventos",
            "Cambios Recibos de Pagos",
            "Cancelar/Anular Casos",
            "Capacitación Manejo",
            "Compartir Calendario",
            "Configuación Dispositivo",
            "Configuración",
            "Configuración DHCP",
            "Configuración Dispositivo",
            "Configuración o Modificación SSID Red Wifi",
            "Configuración Puertos",
            "Configuracion Telefono",
            "Configuración Utm Firewall",
            "Configuración V-LAN",
            "Configuración/Sincronización OneDrive",
            "Configurar",
            "Configurar SharePoint",
            "Configurar Sitios de Confianza",
            "Configurar SSID",
            "Configurar Vista de Compatibilidad",
            "Consumo de Memoria",
            "Control Acceso",
            "Creación Base de Datos",
            "Creación de Buzón Compartido",
            "Creación de Directiva",
            "Creación de Exclusión",
            "Creación de Unidades Compartidas",
            "Creación de Usuario",
            "Creación Grupos De Correo",
            "Creación Grupos de Seguridad",
            "Creación Maquina Virtual",
            "Creación Politica de Backup",
            "Creación Políticas de Backup",
            "Creación Puntos de Montaje",
            "Creación Usuario",
            "Crear",
            "Crear Aplicación en Azure",
            "Crear Capeta de Red",
            "Crear Exclusiones en Rutas",
            "Crear Host",
            "Crear Snapshot",
            "Crear Usuario",
            "Crear Vlans",
            "Cuentas Personales",
            "Daño Base de Datos",
            "Daño Componente",
            "Daño en Disco Físico",
            "Daño en Disco Virtual",
            "Daño Físico",
            "Daño Físico de Periféricos",
            "Daño Físico Teléfono",
            "Daño Memoria",
            "Daño Pantalla",
            "Depuración Información Obsoleta",
            "Desbloqueo de cuenta",
            "Desinstalación",
            "Desinstalar",
            "Desistalación",
            "Despliegue Antivirus",
            "Diagnóstico de Hardware",
            "Diagnóstico Teléfono",
            "Direccionamiento de Llamadas",
            "Direccionamiento Llamadas",
            "Ejecución de Script T-SQL",
            "Eliminación  Grupos de Correo",
            "Eliminación  Grupos de Seguridad",
            "Eliminación Base de Datos",
            "Eliminación de Directiva",
            "Eliminación de Exclusión",
            "Eliminación Grupos de Seguridad",
            "Eliminación Maquina Virtual",
            "Eliminación Masiva Correos",
            "Eliminación Politica de Backup",
            "Eliminación Virus",
            "Eliminar",
            "Eliminar Aplicación en Azure",
            "Eliminar Capeta de Red",
            "Eliminar Host",
            "Eliminar Permisos Carpeta de Red",
            "Eliminar Usuario",
            "Emisión Firma Digital",
            "Encolamiento de Llamadas",
            "Enrutamiento",
            "Envio de Documentos",
            "Equipo No Enciende",
            "Equipo Virtual No Permite Conexión",
            "Error de Almacenamiento",
            "Error de Backups",
            "Error de Licenciamiento",
            "Error en Calidad de Impresión",
            "Error En Certificado SSL",
            "Error en Exportar Archivo",
            "Error en Transmisión",
            "Error Imprimir en Dúplex",
            "Escaneo Preventivo de Equipos",
            "Exploit Vulnerabilidad",
            "Exportar Base de Datos",
            "Falla  Equipo de Sala",
            "Falla Acceso ",
            "Falla Acceso  Carpeta compartida",
            "Falla Acceso a Carpeta Compartida",
            "Falla Acceso Carpeta compartida",
            "Falla Actualización Firmware",
            "Falla Aplicación",
            "Falla Aplicaciones Adobe",
            "Falla Bases de Datos",
            "Falla Batería",
            "Falla de Acceso",
            "Falla de Acceso por Portal",
            "Falla de Disco",
            "Falla de Funcionalidad",
            "Falla de Memoria",
            "Falla de Reportes",
            "Falla de SO",
            "Falla Despliegue de Listas",
            "Falla en Aplicación",
            "Falla en Base de Datos",
            "Falla en BIOS",
            "Falla en Componente",
            "Falla en Drive",
            "Falla en Funcionalidad",
            "Falla en Portales Web",
            "Falla en Sofphone",
            "Falla Masiva ",
            "Falla OneDrive",
            "Falla Otro Dispositivo",
            "Falla Outlook",
            "Falla Paquete de office",
            "Falla Programación de Reunión",
            "Falla Punto de Red",
            "Falla Tarjeta de Red",
            "Falla Teams",
            "Fallas de Dispositivo",
            "Fallas de Servicios",
            "Fallas en Funcionalidad",
            "Felicitación",
            "Filtrado Web",
            "Generación De Reportes",
            "Generación Informe Anual de Ciberseguridad",
            "Generar Reporte",
            "Gestión Contractual",
            "Gestión Correspondencia",
            "Gestión de Jobs",
            "Gestión Facturas",
            "Habilitar Páginas Web",
            "Habilitar permisos SharePoint",
            "Habilitar Puertos",
            "Habilitar Punto de Red",
            "Habilitar Usuarios",
            "Implementación ESXI",
            "Implementación VCENTER",
            "Importar Base de Datos",
            "Impresora No Enciende",
            "Indisponibilidad",
            "Informes",
            "Instalación",
            "Instalación  Certificados SSL",
            "Instalación Acrobat",
            "Instalación Adobe Creative Suite",
            "Instalación Certificados SSL",
            "Instalación de Parte",
            "Instalación de Sofphone",
            "Instalación Paquete de Office",
            "Instalación S.O. SQL Server",
            "Instalación Servidor en Datacenter",
            "Instalar",
            "Instalar/ Predeterminar Impresora",
            "Instrumento - Servicio",
            "Inyección Código",
            "Lentitud /Error",
            "Lentitud Aplicación",
            "Lentitud en Aplicación",
            "Lentitud en Aplicación o Servicio",
            "Lentitud en Aplicación Servicio",
            "Lentitud en la Aplicación",
            "Lentitud Paquete Office",
            "Liberacion Casos Retenidos",
            "Limpieza de Drive",
            "Limpieza Rack",
            "Llamada Entrecortada",
            "Llamadas Informativas",
            "Logros",
            "Mantenimiento",
            "Mantenimiento Bases de Datos",
            "Mantenimiento Preventivo",
            "Mantenimiento Programado",
            "Mapeo Unidades de Red",
            "Modificación Buzón de Correo",
            "Modificación de Directiva",
            "Modificación de Eventos",
            "Modificación de Exclusión",
            "Modificación Grupos de Correo",
            "Modificación Grupos de Seguridad",
            "Modificación Maquina Virtual",
            "Modificación Política de Backup",
            "Modificar ",
            "Modificar Aplicación en Azure",
            "Modificar Capacidad  Almacenamiento",
            "Modificar Capacidad Almacenamiento",
            "Modificar Carpeta de Red",
            "Modificar Host",
            "Modificar Listas Blancas y Negras",
            "Modificar Permisos Carpeta de Red",
            "Modificar Politicas DLP",
            "Modificar Registros en Calendario",
            "Modificar Usuario",
            "Montaje",
            "Movimiento de Información",
            "Movimiento o Replica de Información",
            "Neo te Escucha",
            "No Ingresan / Salen Llamadas",
            "No Llega Archivo a Impresora",
            "Novedad Hurto",
            "Novedad Perdida",
            "Oportunidades",
            "Parametrización Balanceador",
            "Parametrización DNS",
            "Parametrización en Portales",
            "Parametrización WAF",
            "Perdida de Cables",
            "Perdida de Conexión",
            "Perdida de Conexión del Agente",
            "Perdida de Información ",
            "Perfilamiento de Equipo",
            "Perfilamiento Equipo",
            "Phishing / Spam",
            "Políticas",
            "Préstamo",
            "Préstamo de Accesorios",
            "Préstamo de Equipo",
            "Problema de Ingreso",
            "Problemas de Acceso",
            "Problemas de Arranque",
            "Problemas de Envió y Recepción",
            "Problemas para Digitalizar",
            "Problemas para Sacar Copias",
            "Proyectos ",
            "Queja",
            "Ransomware",
            "Re direccionamiento de Correo",
            "Realizar Backup",
            "Realizar Snapshot",
            "Red corporativa",
            "Red invitados",
            "Registro Autenticación Multifactor",
            "Reinicio Programado",
            "Reporte Falla Equipos Rentados",
            "Reseteo Contraseña",
            "Restauración  Backup",
            "Restauración Backup Servidor",
            "Restaurar Autenticación Multifactor",
            "Restaurar Backup",
            "Restaurar Contraseña",
            "Restaurar Información Carpeta de Red",
            "Restaurar Snapshot",
            "Retirar Correo de Cuarentena",
            "Retiro",
            "Retiro de clave",
            "Retiro de Equipos",
            "Retiro de Extensión",
            "Retiro Deshabilitar MFA",
            "Retiro Pin",
            "Retiros de Accesorios",
            "Retiros de Perifericos",
            "Revisión Alertas",
            "Revisión Informes",
            "Revisión Mouse/Teclado",
            "Rotación de Cintas",
            "Ruido en Llamada",
            "Seguimiento Casos",
            "Seguridad de Hardware",
            "Seguridad de Red",
            "Seguridad de Software",
            "Servicio Linux se Reporta Caído",
            "Servicio Windows Se Reporta Caído",
            "Sistema Contra Incendio",
            "Sistema Eléctrico",
            "Solicitud  Información - Asesoría",
            "Solicitud  Reporte de Llamadas",
            "Solicitud de Información",
            "Solicitud de Viaje",
            "Solicitud Información",
            "Solicitud Información - Asesoría",
            "Solicitud Reporte de LIamadas",
            "Solicitudes de información de inventario",
            "Spyware",
            "Sugerencia",
            "Suspender Usuario",
            "Toma de Backup Servidor",
            "Tramite de Garantía",
            "Tramite Garantía",
            "Traslado Impresora",
            "Traslado o Movimiento",
            "Troyanos",
            "UPS",
            "Validar Usuarios",
            "Verificación de Empresa para Generar Recibo de Pago",
            "Verificación Maquina Virtual",
            "Verificación URL Pago de Eventos",
            "Virus",
            "Virus Informáticos",
            "Volcado de Memoria",
            "Vpn"});
            this.cbo_sintoma_detalle.Location = new System.Drawing.Point(264, 63);
            this.cbo_sintoma_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_sintoma_detalle.Name = "cbo_sintoma_detalle";
            this.cbo_sintoma_detalle.Size = new System.Drawing.Size(303, 27);
            this.cbo_sintoma_detalle.Sorted = true;
            this.cbo_sintoma_detalle.TabIndex = 121;
            this.cbo_sintoma_detalle.SelectedIndexChanged += new System.EventHandler(this.cbo_sintoma_detalle_SelectedIndexChanged);
            // 
            // cbo_componente_servicio
            // 
            this.cbo_componente_servicio.BackColor = System.Drawing.Color.Silver;
            this.cbo_componente_servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_componente_servicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_componente_servicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbo_componente_servicio.ForeColor = System.Drawing.Color.Black;
            this.cbo_componente_servicio.FormattingEnabled = true;
            this.cbo_componente_servicio.Items.AddRange(new object[] {
            "3 Ejes",
            "Acceso a Red",
            "Administración de Activos",
            "Administración de Servidores Windows",
            "Administración Servidores Linux",
            "Alarmas",
            "Antivirus",
            "Aplicaciones Adobe",
            "Apoyo Tecnologico",
            "Baja de Activos",
            "Banco Proyectos",
            "CBD Pago Eventos",
            "Compromisos de Presidencia",
            "Consulta",
            "Correo Electrónico  ",
            "Cuartos Técnicos",
            "Datacenter",
            "Dispositivos Adicionales",
            "Equipo Portátil",
            "Equipos Escritorio",
            "Equipos Mac",
            "ESXi",
            "Export Access",
            "File Server",
            "Firewall",
            "Gestión de Alertas",
            "Gestión de Cuentas",
            "Gestión de Eventos",
            "Gestor Pro",
            "Google Chrome",
            "Host",
            "Impresión",
            "Internet",
            "Internet Explorer",
            "Intranet",
            "Librería HPMLS2024",
            "Maquina Virtual",
            "MYSQL Server",
            "Neo - Salesforce",
            "Office 365",
            "Operación",
            "Oportunidades en Tiempo Real",
            "Pagos en Línea",
            "Portales WEB",
            "PQRS",
            "Red WiFi",
            "Sifai",
            "Simulador de Costos",
            "SISA",
            "Sofphone Avaya",
            "Solicitud de Giros – Autorización de Gastos",
            "Solicitud de Mercadeo",
            "Solicitud Vacaciones",
            "SQL Server",
            "Switches",
            "Tableau",
            "Talento Pro",
            "Telefonía",
            "Universidad ProColombia",
            "Veritas BackupExec",
            "Videoconferencias",
            "VMWare",
            "VPN Forticlient"});
            this.cbo_componente_servicio.Location = new System.Drawing.Point(264, 28);
            this.cbo_componente_servicio.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_componente_servicio.Name = "cbo_componente_servicio";
            this.cbo_componente_servicio.Size = new System.Drawing.Size(303, 27);
            this.cbo_componente_servicio.Sorted = true;
            this.cbo_componente_servicio.TabIndex = 120;
            this.cbo_componente_servicio.SelectedIndexChanged += new System.EventHandler(this.cbo_componente_servicio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 119;
            this.label3.Text = "SINTOMA O DETALLE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 118;
            this.label1.Text = "COMPONENTE DEL SERVICIO:";
            // 
            // btn_especialistas
            // 
            this.btn_especialistas.Location = new System.Drawing.Point(17, 168);
            this.btn_especialistas.Name = "btn_especialistas";
            this.btn_especialistas.Size = new System.Drawing.Size(148, 36);
            this.btn_especialistas.TabIndex = 126;
            this.btn_especialistas.Text = "ESPECIALISTAS";
            this.btn_especialistas.UseVisualStyleBackColor = true;
            this.btn_especialistas.Click += new System.EventHandler(this.btn_especialistas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 127;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(965, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_especialistas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_total_registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_casos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIZACIONES MDS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_casos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_casos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_registro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_servicio_negocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sintoma_o_detalle;
        private System.Windows.Forms.ComboBox cbo_sintoma_detalle;
        private System.Windows.Forms.ComboBox cbo_componente_servicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_especialistas;
        private System.Windows.Forms.Button button1;
    }
}

