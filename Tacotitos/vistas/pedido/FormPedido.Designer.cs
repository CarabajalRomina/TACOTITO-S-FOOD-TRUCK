namespace Tacotitos.vistas
{
    partial class FormPedido
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
            dgvPedidos = new DataGridView();
            TACO = new DataGridViewTextBoxColumn();
            PEDIDO = new DataGridViewTextBoxColumn();
            DETALLE = new DataGridViewImageColumn();
            ELIMINAR = new DataGridViewImageColumn();
            pnlSuperior = new Panel();
            pcbSalir = new PictureBox();
            pcbImgLogo = new PictureBox();
            lblTituloLogo = new Label();
            pnlInferior = new Panel();
            pnlLateral = new Panel();
            lbBuscar = new ListBox();
            pnlBotones = new Panel();
            lblDescripcion = new Label();
            pcbBuscar = new PictureBox();
            txtBuscar = new TextBox();
            pnlForm = new Panel();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDomicilio = new Label();
            txtDomicilio = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            lblNombre = new Label();
            lblId = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            panel1 = new Panel();
            btnConfirmarPedido = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).BeginInit();
            pnlLateral.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            pnlForm.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.AllowUserToResizeColumns = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { TACO, PEDIDO, DETALLE, ELIMINAR });
            dgvPedidos.Location = new Point(825, 182);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.RowTemplate.Height = 29;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(523, 462);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.CellClick += dgvPedidos_CellClick;
            // 
            // TACO
            // 
            TACO.HeaderText = "TACO";
            TACO.MinimumWidth = 6;
            TACO.Name = "TACO";
            TACO.ReadOnly = true;
            TACO.Visible = false;
            // 
            // PEDIDO
            // 
            PEDIDO.FillWeight = 132.204025F;
            PEDIDO.HeaderText = "";
            PEDIDO.MinimumWidth = 50;
            PEDIDO.Name = "PEDIDO";
            PEDIDO.ReadOnly = true;
            // 
            // DETALLE
            // 
            DETALLE.FillWeight = 87.58211F;
            DETALLE.HeaderText = "";
            DETALLE.Image = Properties.Resources.ver;
            DETALLE.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DETALLE.MinimumWidth = 6;
            DETALLE.Name = "DETALLE";
            DETALLE.ReadOnly = true;
            DETALLE.Resizable = DataGridViewTriState.True;
            DETALLE.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ELIMINAR
            // 
            ELIMINAR.FillWeight = 80.21391F;
            ELIMINAR.HeaderText = "";
            ELIMINAR.Image = Properties.Resources.borrar1;
            ELIMINAR.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ELIMINAR.MinimumWidth = 50;
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.ReadOnly = true;
            ELIMINAR.Resizable = DataGridViewTriState.True;
            ELIMINAR.SortMode = DataGridViewColumnSortMode.Automatic;
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
            pnlSuperior.Size = new Size(1491, 65);
            pnlSuperior.TabIndex = 5;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarblanco2;
            pcbSalir.Location = new Point(1432, 9);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(47, 53);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 4;
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
            pnlInferior.Location = new Point(0, 927);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1491, 49);
            pnlInferior.TabIndex = 6;
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.DarkGreen;
            pnlLateral.Controls.Add(lbBuscar);
            pnlLateral.Controls.Add(pnlBotones);
            pnlLateral.Controls.Add(pnlForm);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 65);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(636, 862);
            pnlLateral.TabIndex = 7;
            // 
            // lbBuscar
            // 
            lbBuscar.FormattingEnabled = true;
            lbBuscar.ItemHeight = 36;
            lbBuscar.Location = new Point(37, 117);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(429, 220);
            lbBuscar.TabIndex = 15;
            lbBuscar.Visible = false;
            lbBuscar.SelectedIndexChanged += lbBuscar_SelectedIndexChanged;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(lblDescripcion);
            pnlBotones.Controls.Add(pcbBuscar);
            pnlBotones.Controls.Add(txtBuscar);
            pnlBotones.Location = new Point(25, 16);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(580, 108);
            pnlBotones.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.Ivory;
            lblDescripcion.Location = new Point(12, 14);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(185, 37);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Buscar cliente";
            // 
            // pcbBuscar
            // 
            pcbBuscar.BackColor = Color.LightYellow;
            pcbBuscar.Image = Properties.Resources.lupa1_removebg_preview;
            pcbBuscar.Location = new Point(464, 54);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(36, 43);
            pcbBuscar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbBuscar.TabIndex = 1;
            pcbBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 54);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(429, 43);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.Controls.Add(lblTelefono);
            pnlForm.Controls.Add(txtTelefono);
            pnlForm.Controls.Add(lblDomicilio);
            pnlForm.Controls.Add(txtDomicilio);
            pnlForm.Controls.Add(lblApellido);
            pnlForm.Controls.Add(txtApellido);
            pnlForm.Controls.Add(label2);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Controls.Add(txtId);
            pnlForm.Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ButtonHighlight;
            pnlForm.Location = new Point(25, 186);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(580, 489);
            pnlForm.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(41, 361);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(122, 37);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(169, 358);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(359, 43);
            txtTelefono.TabIndex = 16;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(41, 282);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(125, 37);
            lblDomicilio.TabIndex = 15;
            lblDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(169, 279);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(359, 43);
            txtDomicilio.TabIndex = 14;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(41, 201);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(116, 37);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(166, 198);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(362, 43);
            txtApellido.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("212 Orion Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 126);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(119, 37);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(41, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 37);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(362, 43);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 43);
            txtId.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.AutoSize = true;
            panel1.Controls.Add(btnConfirmarPedido);
            panel1.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(679, 763);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 105);
            panel1.TabIndex = 8;
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.Anchor = AnchorStyles.Top;
            btnConfirmarPedido.Location = new Point(232, 24);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(367, 58);
            btnConfirmarPedido.TabIndex = 5;
            btnConfirmarPedido.Text = "CONFIRMAR PEDIDO";
            btnConfirmarPedido.UseVisualStyleBackColor = true;
            btnConfirmarPedido.Click += btnConfirmarPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("212 Orion Sans", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(980, 95);
            label1.Name = "label1";
            label1.Size = new Size(171, 65);
            label1.TabIndex = 9;
            label1.Text = "PEDIDO";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1491, 976);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pnlLateral);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            Controls.Add(dgvPedidos);
            Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPedido";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).EndInit();
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Panel pnlSuperior;
        private PictureBox pcbImgLogo;
        private Label lblTituloLogo;
        private PictureBox pcbSalir;
        private Panel pnlInferior;
        private Panel pnlLateral;
        private Panel pnlForm;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDomicilio;
        private TextBox txtDomicilio;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label label2;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtNombre;
        private TextBox txtId;
        private Panel pnlBotones;
        private PictureBox pcbBuscar;
        private TextBox txtBuscar;
        private Panel panel1;
        private Button btnConfirmarPedido;
        private Label lblDescripcion;
        private ListBox lbBuscar;
        private Label label1;
        private DataGridViewTextBoxColumn TACO;
        private DataGridViewTextBoxColumn PEDIDO;
        private DataGridViewImageColumn DETALLE;
        private DataGridViewImageColumn ELIMINAR;
    }
}