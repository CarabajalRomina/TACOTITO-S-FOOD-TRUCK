namespace Tacotitos.vistas.ADMIN.CrudCliente
{
    partial class FormCrudCliente
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
            pnlBoton = new Panel();
            btnNuevo = new Button();
            pnlLateral = new Panel();
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
            pnlBotonesForm = new Panel();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            pnlContenido = new Panel();
            dgvClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DOMICILIO = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            pnlBotones = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            pnlBoton.SuspendLayout();
            pnlLateral.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlBotonesForm.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBoton
            // 
            pnlBoton.Anchor = AnchorStyles.Top;
            pnlBoton.AutoSize = true;
            pnlBoton.Controls.Add(btnNuevo);
            pnlBoton.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBoton.Location = new Point(12, 636);
            pnlBoton.Name = "pnlBoton";
            pnlBoton.Size = new Size(613, 105);
            pnlBoton.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top;
            btnNuevo.Location = new Point(120, 30);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(367, 58);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.DarkGreen;
            pnlLateral.Controls.Add(pnlForm);
            pnlLateral.Controls.Add(pnlBoton);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(636, 770);
            pnlLateral.TabIndex = 5;
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
            pnlForm.Controls.Add(pnlBotonesForm);
            pnlForm.Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ButtonHighlight;
            pnlForm.Location = new Point(12, 12);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(616, 593);
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
            // pnlBotonesForm
            // 
            pnlBotonesForm.Controls.Add(btnActualizar);
            pnlBotonesForm.Controls.Add(btnGuardar);
            pnlBotonesForm.Controls.Add(btnCancelar);
            pnlBotonesForm.Controls.Add(btnBorrar);
            pnlBotonesForm.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBotonesForm.ForeColor = SystemColors.ActiveCaptionText;
            pnlBotonesForm.Location = new Point(9, 462);
            pnlBotonesForm.Name = "pnlBotonesForm";
            pnlBotonesForm.Size = new Size(604, 95);
            pnlBotonesForm.TabIndex = 1;
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
            btnCancelar.Location = new Point(412, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(183, 55);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(212, 23);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(183, 55);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(dgvClientes);
            pnlContenido.Controls.Add(pnlBotones);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenido.Location = new Point(636, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(886, 770);
            pnlContenido.TabIndex = 6;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, DOMICILIO, TELEFONO });
            dgvClientes.Location = new Point(24, 122);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(838, 619);
            dgvClientes.TabIndex = 1;
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
            // DOMICILIO
            // 
            DOMICILIO.HeaderText = "DOMICILIO";
            DOMICILIO.MinimumWidth = 6;
            DOMICILIO.Name = "DOMICILIO";
            DOMICILIO.ReadOnly = true;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.ReadOnly = true;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Location = new Point(24, 20);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(838, 85);
            pnlBotones.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(571, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(218, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(313, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(221, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormCrudCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1522, 770);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrudCliente";
            Text = "FormCrudCliente";
            WindowState = FormWindowState.Maximized;
            pnlBoton.ResumeLayout(false);
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlBotonesForm.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBoton;
        private Button btnNuevo;
        private Panel pnlLateral;
        private Panel pnlForm;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label label2;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtNombre;
        private TextBox txtId;
        private Panel pnlBotonesForm;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnBorrar;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDomicilio;
        private TextBox txtDomicilio;
        private Panel pnlContenido;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DOMICILIO;
        private DataGridViewTextBoxColumn TELEFONO;
        private Panel pnlBotones;
        private Button btnEliminar;
        private Button btnEditar;
    }
}