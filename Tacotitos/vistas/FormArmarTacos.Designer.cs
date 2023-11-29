namespace Tacotitos.vistas
{
    partial class FormArmarTacos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSuperior = new Panel();
            pcbSalir = new PictureBox();
            pcbImgLogo = new PictureBox();
            lblTituloLogo = new Label();
            pnlInferior = new Panel();
            dgvIngredientesTaco = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            INGREDIENTES = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            cbbTiposIngredientes = new ComboBox();
            pcbQuitar = new PictureBox();
            pcbAgregar = new PictureBox();
            pnlContenedor = new Panel();
            lblAviso = new Label();
            pnlTablas = new Panel();
            dgvTaco = new DataGridView();
            IDINGRE = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            PRECIOINGRE = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            btnAgregarAPedido = new Button();
            lblInfo = new Label();
            pcbPedido = new PictureBox();
            lblDescripcion = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesTaco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuitar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAgregar).BeginInit();
            pnlContenedor.SuspendLayout();
            pnlTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPedido).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(0, 52, 0);
            pnlSuperior.Controls.Add(pcbSalir);
            pnlSuperior.Controls.Add(pcbImgLogo);
            pnlSuperior.Controls.Add(lblTituloLogo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1410, 65);
            pnlSuperior.TabIndex = 4;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarblanco2;
            pcbSalir.Location = new Point(1351, 12);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(47, 53);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 3;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            // 
            // pcbImgLogo
            // 
            pcbImgLogo.BackgroundImageLayout = ImageLayout.None;
            pcbImgLogo.Image = Properties.Resources.iconoTaco;
            pcbImgLogo.Location = new Point(37, 3);
            pcbImgLogo.Name = "pcbImgLogo";
            pcbImgLogo.Size = new Size(68, 56);
            pcbImgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbImgLogo.TabIndex = 1;
            pcbImgLogo.TabStop = false;
            // 
            // lblTituloLogo
            // 
            lblTituloLogo.AutoSize = true;
            lblTituloLogo.Font = new Font("LillyBelle", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloLogo.ForeColor = SystemColors.ButtonHighlight;
            lblTituloLogo.Location = new Point(98, 9);
            lblTituloLogo.Name = "lblTituloLogo";
            lblTituloLogo.Size = new Size(229, 38);
            lblTituloLogo.TabIndex = 0;
            lblTituloLogo.Text = "Tacotito's FoodTruck";
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(0, 52, 0);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 980);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1410, 49);
            pnlInferior.TabIndex = 5;
            // 
            // dgvIngredientesTaco
            // 
            dgvIngredientesTaco.AllowUserToAddRows = false;
            dgvIngredientesTaco.AllowUserToDeleteRows = false;
            dgvIngredientesTaco.AllowUserToResizeRows = false;
            dgvIngredientesTaco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredientesTaco.BackgroundColor = SystemColors.ButtonHighlight;
            dgvIngredientesTaco.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvIngredientesTaco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientesTaco.Columns.AddRange(new DataGridViewColumn[] { ID, INGREDIENTES, PRECIO });
            dgvIngredientesTaco.Location = new Point(16, 25);
            dgvIngredientesTaco.Name = "dgvIngredientesTaco";
            dgvIngredientesTaco.RowHeadersVisible = false;
            dgvIngredientesTaco.RowHeadersWidth = 51;
            dgvIngredientesTaco.RowTemplate.Height = 29;
            dgvIngredientesTaco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredientesTaco.Size = new Size(569, 551);
            dgvIngredientesTaco.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // INGREDIENTES
            // 
            INGREDIENTES.HeaderText = "INGREDIENTES";
            INGREDIENTES.MinimumWidth = 6;
            INGREDIENTES.Name = "INGREDIENTES";
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            // 
            // cbbTiposIngredientes
            // 
            cbbTiposIngredientes.FormattingEnabled = true;
            cbbTiposIngredientes.Location = new Point(827, 50);
            cbbTiposIngredientes.Name = "cbbTiposIngredientes";
            cbbTiposIngredientes.Size = new Size(461, 44);
            cbbTiposIngredientes.TabIndex = 8;
            cbbTiposIngredientes.SelectedIndexChanged += cbbTiposIngredientes_SelectedIndexChanged_1;
            // 
            // pcbQuitar
            // 
            pcbQuitar.Anchor = AnchorStyles.Top;
            pcbQuitar.Image = Properties.Resources.flechaRoja;
            pcbQuitar.Location = new Point(610, 333);
            pcbQuitar.Name = "pcbQuitar";
            pcbQuitar.Size = new Size(69, 69);
            pcbQuitar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbQuitar.TabIndex = 11;
            pcbQuitar.TabStop = false;
            pcbQuitar.Click += pcbQuitar_Click;
            // 
            // pcbAgregar
            // 
            pcbAgregar.Anchor = AnchorStyles.Top;
            pcbAgregar.Image = Properties.Resources.flechaVerde1;
            pcbAgregar.Location = new Point(610, 190);
            pcbAgregar.Name = "pcbAgregar";
            pcbAgregar.Size = new Size(69, 69);
            pcbAgregar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbAgregar.TabIndex = 12;
            pcbAgregar.TabStop = false;
            pcbAgregar.Click += pcbAgregar_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Controls.Add(lblAviso);
            pnlContenedor.Controls.Add(pnlTablas);
            pnlContenedor.Controls.Add(btnAgregarAPedido);
            pnlContenedor.Controls.Add(lblInfo);
            pnlContenedor.Controls.Add(pcbPedido);
            pnlContenedor.Controls.Add(lblDescripcion);
            pnlContenedor.Controls.Add(cbbTiposIngredientes);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenedor.ForeColor = Color.Green;
            pnlContenedor.Location = new Point(0, 65);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1410, 915);
            pnlContenedor.TabIndex = 14;
            // 
            // lblAviso
            // 
            lblAviso.Anchor = AnchorStyles.Top;
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(12, 794);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(0, 37);
            lblAviso.TabIndex = 19;
            // 
            // pnlTablas
            // 
            pnlTablas.Anchor = AnchorStyles.Top;
            pnlTablas.Controls.Add(dgvIngredientesTaco);
            pnlTablas.Controls.Add(pcbQuitar);
            pnlTablas.Controls.Add(pcbAgregar);
            pnlTablas.Controls.Add(dgvTaco);
            pnlTablas.Location = new Point(46, 155);
            pnlTablas.Name = "pnlTablas";
            pnlTablas.Size = new Size(1307, 608);
            pnlTablas.TabIndex = 18;
            // 
            // dgvTaco
            // 
            dgvTaco.AllowUserToAddRows = false;
            dgvTaco.AllowUserToDeleteRows = false;
            dgvTaco.AllowUserToResizeRows = false;
            dgvTaco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvTaco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaco.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTaco.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTaco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaco.Columns.AddRange(new DataGridViewColumn[] { IDINGRE, NOMBRE, PRECIOINGRE, TIPO });
            dgvTaco.Location = new Point(705, 25);
            dgvTaco.Name = "dgvTaco";
            dgvTaco.RowHeadersVisible = false;
            dgvTaco.RowHeadersWidth = 51;
            dgvTaco.RowTemplate.Height = 29;
            dgvTaco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaco.Size = new Size(588, 551);
            dgvTaco.TabIndex = 15;
            // 
            // IDINGRE
            // 
            IDINGRE.HeaderText = "ID";
            IDINGRE.MinimumWidth = 6;
            IDINGRE.Name = "IDINGRE";
            IDINGRE.ReadOnly = true;
            IDINGRE.Visible = false;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "INGREDIENTES";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            // 
            // PRECIOINGRE
            // 
            PRECIOINGRE.HeaderText = "PRECIO";
            PRECIOINGRE.MinimumWidth = 6;
            PRECIOINGRE.Name = "PRECIOINGRE";
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE INGREDIENTE";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.ReadOnly = true;
            // 
            // btnAgregarAPedido
            // 
            btnAgregarAPedido.Anchor = AnchorStyles.Top;
            btnAgregarAPedido.BackColor = Color.White;
            btnAgregarAPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarAPedido.Location = new Point(1024, 806);
            btnAgregarAPedido.Name = "btnAgregarAPedido";
            btnAgregarAPedido.Size = new Size(264, 52);
            btnAgregarAPedido.TabIndex = 17;
            btnAgregarAPedido.Text = "AGREGAR A PEDIDO";
            btnAgregarAPedido.UseVisualStyleBackColor = false;
            btnAgregarAPedido.Click += btnAgregarAPedido_Click;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top;
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.FromArgb(192, 0, 0);
            lblInfo.Location = new Point(532, 115);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 37);
            lblInfo.TabIndex = 14;
            // 
            // pcbPedido
            // 
            pcbPedido.Anchor = AnchorStyles.Top;
            pcbPedido.Image = Properties.Resources.carrito_de_compras;
            pcbPedido.Location = new Point(1312, 806);
            pcbPedido.Name = "pcbPedido";
            pcbPedido.Size = new Size(52, 49);
            pcbPedido.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPedido.TabIndex = 16;
            pcbPedido.TabStop = false;
            pcbPedido.Click += pcbPedido_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.Green;
            lblDescripcion.Location = new Point(98, 53);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(699, 37);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Seleccione los tipos de ingrediente para agregar al taco:";
            // 
            // FormArmarTacos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1410, 1029);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormArmarTacos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArmarTacos";
            WindowState = FormWindowState.Maximized;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesTaco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuitar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAgregar).EndInit();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            pnlTablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pcbImgLogo;
        private Label lblTituloLogo;
        private PictureBox pcbSalir;
        private Panel pnlInferior;
        private DataGridView dgvIngredientesTaco;
        private System.CodeDom.CodeTypeReference Column1;
        private ComboBox cbbTiposIngredientes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn INGREDIENTES;
        private DataGridViewTextBoxColumn PRECIO;
        private PictureBox pcbQuitar;
        private PictureBox pcbAgregar;
        private Panel pnlContenedor;
        private Label lblDescripcion;
        private Label lblInfo;
        private DataGridView dgvTaco;
        private DataGridViewTextBoxColumn IDINGRE;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRECIOINGRE;
        private DataGridViewTextBoxColumn TIPO;
        private PictureBox pcbPedido;
        private Button btnAgregarAPedido;
        private Panel pnlTablas;
        private Label lblAviso;
    }
}