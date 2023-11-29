namespace Tacotitos.vistas.ADMIN.CrudIngrediente
{
    partial class FormCrudIngrediente
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
            pnlLateral = new Panel();
            pnlForm = new Panel();
            cbbTipo = new ComboBox();
            lblTipo = new Label();
            lblErrorTxtNombre = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblId = new Label();
            nduPrecio = new NumericUpDown();
            txtNombre = new TextBox();
            txtId = new TextBox();
            pnlBtnForm = new Panel();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            pnlBoton = new Panel();
            btnNuevo = new Button();
            pnlContenido = new Panel();
            dgvIngredientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            pnlBotones = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            pcbBuscar = new PictureBox();
            txtBuscar = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlLateral.SuspendLayout();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nduPrecio).BeginInit();
            pnlBtnForm.SuspendLayout();
            pnlBoton.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.DarkGreen;
            pnlLateral.Controls.Add(pnlForm);
            pnlLateral.Controls.Add(pnlBoton);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(636, 769);
            pnlLateral.TabIndex = 4;
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.Controls.Add(cbbTipo);
            pnlForm.Controls.Add(lblTipo);
            pnlForm.Controls.Add(lblErrorTxtNombre);
            pnlForm.Controls.Add(lblPrecio);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(nduPrecio);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(pnlBtnForm);
            pnlForm.Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ButtonHighlight;
            pnlForm.Location = new Point(12, 12);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(613, 593);
            pnlForm.TabIndex = 1;
            // 
            // cbbTipo
            // 
            cbbTipo.FormattingEnabled = true;
            cbbTipo.Location = new Point(300, 243);
            cbbTipo.Name = "cbbTipo";
            cbbTipo.Size = new Size(300, 44);
            cbbTipo.TabIndex = 11;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(41, 243);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(253, 37);
            lblTipo.TabIndex = 10;
            lblTipo.Text = "Tipo de ingrediente:";
            // 
            // lblErrorTxtNombre
            // 
            lblErrorTxtNombre.AutoSize = true;
            lblErrorTxtNombre.Font = new Font("212 Orion Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTxtNombre.Location = new Point(211, 126);
            lblErrorTxtNombre.Name = "lblErrorTxtNombre";
            lblErrorTxtNombre.Size = new Size(0, 25);
            lblErrorTxtNombre.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 338);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(91, 37);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(119, 37);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(41, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 37);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // nduPrecio
            // 
            nduPrecio.DecimalPlaces = 2;
            nduPrecio.Location = new Point(166, 336);
            nduPrecio.Name = "nduPrecio";
            nduPrecio.Size = new Size(145, 43);
            nduPrecio.TabIndex = 4;
            nduPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 43);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(106, 43);
            txtId.TabIndex = 2;
            // 
            // pnlBtnForm
            // 
            pnlBtnForm.Controls.Add(btnActualizar);
            pnlBtnForm.Controls.Add(btnGuardar);
            pnlBtnForm.Controls.Add(btnCancelar);
            pnlBtnForm.Controls.Add(btnBorrar);
            pnlBtnForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBtnForm.ForeColor = SystemColors.ActiveCaptionText;
            pnlBtnForm.Location = new Point(9, 456);
            pnlBtnForm.Name = "pnlBtnForm";
            pnlBtnForm.Size = new Size(601, 95);
            pnlBtnForm.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(10, 23);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 55);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Visible = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 23);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(183, 55);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(411, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 55);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(211, 23);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(183, 55);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pnlBoton
            // 
            pnlBoton.Anchor = AnchorStyles.Top;
            pnlBoton.AutoSize = true;
            pnlBoton.Controls.Add(btnNuevo);
            pnlBoton.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBoton.Location = new Point(12, 625);
            pnlBoton.Name = "pnlBoton";
            pnlBoton.Size = new Size(608, 118);
            pnlBoton.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top;
            btnNuevo.Location = new Point(102, 30);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(367, 58);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(dgvIngredientes);
            pnlContenido.Controls.Add(pnlBotones);
            pnlContenido.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenido.Location = new Point(636, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(883, 769);
            pnlContenido.TabIndex = 5;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.AllowUserToAddRows = false;
            dgvIngredientes.AllowUserToDeleteRows = false;
            dgvIngredientes.AllowUserToOrderColumns = true;
            dgvIngredientes.AllowUserToResizeColumns = false;
            dgvIngredientes.AllowUserToResizeRows = false;
            dgvIngredientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, TIPO, PRECIO });
            dgvIngredientes.Location = new Point(24, 138);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.ReadOnly = true;
            dgvIngredientes.RowHeadersVisible = false;
            dgvIngredientes.RowHeadersWidth = 51;
            dgvIngredientes.RowTemplate.Height = 29;
            dgvIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredientes.Size = new Size(826, 619);
            dgvIngredientes.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE INGREDIENTE";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.ReadOnly = true;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(pcbBuscar);
            pnlBotones.Controls.Add(txtBuscar);
            pnlBotones.Location = new Point(24, 20);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(826, 85);
            pnlBotones.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(605, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(383, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(184, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.lupa1_removebg_preview;
            pcbBuscar.Location = new Point(294, 16);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(36, 50);
            pcbBuscar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbBuscar.TabIndex = 1;
            pcbBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(20, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(268, 37);
            txtBuscar.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormCrudIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1519, 769);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrudIngrediente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrudIngrediente";
            WindowState = FormWindowState.Maximized;
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nduPrecio).EndInit();
            pnlBtnForm.ResumeLayout(false);
            pnlBoton.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLateral;
        private Panel pnlForm;
        private Label lblErrorTxtNombre;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblId;
        private NumericUpDown nduPrecio;
        private TextBox txtNombre;
        private TextBox txtId;
        private Panel pnlBtnForm;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnBorrar;
        private Panel pnlBoton;
        private Button btnNuevo;
        private ComboBox cbbTipo;
        private Label lblTipo;
        private Panel pnlContenido;
        private DataGridView dgvIngredientes;
        private Panel pnlBotones;
        private Button btnEliminar;
        private Button btnEditar;
        private PictureBox pcbBuscar;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn PRECIO;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}