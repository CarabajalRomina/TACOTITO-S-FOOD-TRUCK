namespace Tacotitos.vistas.ADMIN.CrudTipoIngrediente
{
    partial class FormCrudTipoIngrediente
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
            lblErrorTxtNombre = new Label();
            lblCantMax = new Label();
            lblNombre = new Label();
            lblId = new Label();
            nduCantMax = new NumericUpDown();
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
            dgvTiposIngrediente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            CANTMAX = new DataGridViewTextBoxColumn();
            pnlBotones = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            pcbBuscar = new PictureBox();
            txtBuscar = new TextBox();
            pnlLateral.SuspendLayout();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nduCantMax).BeginInit();
            pnlBtnForm.SuspendLayout();
            pnlBoton.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiposIngrediente).BeginInit();
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
            pnlLateral.Size = new Size(646, 833);
            pnlLateral.TabIndex = 3;
            // 
            // pnlForm
            // 
            pnlForm.AutoSize = true;
            pnlForm.Controls.Add(lblErrorTxtNombre);
            pnlForm.Controls.Add(lblCantMax);
            pnlForm.Controls.Add(lblNombre);
            pnlForm.Controls.Add(lblId);
            pnlForm.Controls.Add(nduCantMax);
            pnlForm.Controls.Add(txtNombre);
            pnlForm.Controls.Add(txtId);
            pnlForm.Controls.Add(pnlBtnForm);
            pnlForm.Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            pnlForm.ForeColor = SystemColors.ButtonHighlight;
            pnlForm.Location = new Point(12, 36);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(617, 477);
            pnlForm.TabIndex = 1;
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
            // lblCantMax
            // 
            lblCantMax.AutoSize = true;
            lblCantMax.Location = new Point(86, 244);
            lblCantMax.Name = "lblCantMax";
            lblCantMax.Size = new Size(240, 37);
            lblCantMax.TabIndex = 7;
            lblCantMax.Text = "Cantidad maxima:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(86, 157);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(119, 37);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(86, 69);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 37);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // nduCantMax
            // 
            nduCantMax.Location = new Point(332, 242);
            nduCantMax.Name = "nduCantMax";
            nduCantMax.Size = new Size(94, 43);
            nduCantMax.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 43);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(144, 66);
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
            pnlBtnForm.Location = new Point(3, 356);
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
            pnlBoton.Location = new Point(12, 519);
            pnlBoton.Name = "pnlBoton";
            pnlBoton.Size = new Size(617, 118);
            pnlBoton.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top;
            btnNuevo.Location = new Point(131, 29);
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
            pnlContenido.Controls.Add(dgvTiposIngrediente);
            pnlContenido.Controls.Add(pnlBotones);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pnlContenido.Location = new Point(646, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(862, 833);
            pnlContenido.TabIndex = 4;
            // 
            // dgvTiposIngrediente
            // 
            dgvTiposIngrediente.AllowUserToAddRows = false;
            dgvTiposIngrediente.AllowUserToDeleteRows = false;
            dgvTiposIngrediente.AllowUserToOrderColumns = true;
            dgvTiposIngrediente.AllowUserToResizeColumns = false;
            dgvTiposIngrediente.AllowUserToResizeRows = false;
            dgvTiposIngrediente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTiposIngrediente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiposIngrediente.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTiposIngrediente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposIngrediente.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, CANTMAX });
            dgvTiposIngrediente.Location = new Point(24, 142);
            dgvTiposIngrediente.Name = "dgvTiposIngrediente";
            dgvTiposIngrediente.ReadOnly = true;
            dgvTiposIngrediente.RowHeadersVisible = false;
            dgvTiposIngrediente.RowHeadersWidth = 51;
            dgvTiposIngrediente.RowTemplate.Height = 29;
            dgvTiposIngrediente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTiposIngrediente.Size = new Size(823, 669);
            dgvTiposIngrediente.TabIndex = 1;
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
            // CANTMAX
            // 
            CANTMAX.HeaderText = "CANTIDAD MAXIMA";
            CANTMAX.MinimumWidth = 6;
            CANTMAX.Name = "CANTMAX";
            CANTMAX.ReadOnly = true;
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
            // FormCrudTipoIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1508, 833);
            Controls.Add(pnlContenido);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrudTipoIngrediente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrudTipoIngrediente";
            WindowState = FormWindowState.Maximized;
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nduCantMax).EndInit();
            pnlBtnForm.ResumeLayout(false);
            pnlBoton.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTiposIngrediente).EndInit();
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLateral;
        private Panel pnlContenido;
        private Panel pnlBotones;
        private DataGridView dgvTiposIngrediente;
        private Button btnEliminar;
        private Button btnEditar;
        private PictureBox pcbBuscar;
        private TextBox txtBuscar;
        private Panel pnlBoton;
        private Button btnNuevo;
        private Button btnCancelar;
        private Panel pnlForm;
        private Label lblId;
        private NumericUpDown nduCantMax;
        private TextBox txtNombre;
        private TextBox txtId;
        private Panel pnlBtnForm;
        private Button btnGuardar;
        private Button btnBorrar;
        private Label lblNombre;
        private Label lblCantMax;
        private Label lblErrorTxtNombre;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn CANTMAX;
        private Button btnActualizar;
    }
}