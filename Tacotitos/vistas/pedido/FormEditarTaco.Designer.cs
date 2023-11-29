namespace Tacotitos.vistas.pedido
{
    partial class FormEditarTaco
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            dgvIngredientesTaco = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            INGREDIENTES = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            pcbQuitar = new PictureBox();
            pcbAgregar = new PictureBox();
            dgvDetalleTaco = new DataGridView();
            IDINGRE = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            PRECIOINGRE = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            pnlInferior = new Panel();
            lblDescripcion = new Label();
            cbbTiposIngredientes = new ComboBox();
            lblAviso = new Label();
            lblInfo = new Label();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesTaco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuitar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleTaco).BeginInit();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(0, 52, 0);
            pnlSuperior.Controls.Add(pcbSalir);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Margin = new Padding(4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1561, 76);
            pnlSuperior.TabIndex = 21;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarblanco2;
            pcbSalir.Location = new Point(1482, 13);
            pcbSalir.Margin = new Padding(4);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(66, 59);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 5;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.cerrarblanco2;
            pictureBox1.Location = new Point(2388, 17);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvIngredientesTaco);
            panel1.Controls.Add(pcbQuitar);
            panel1.Controls.Add(pcbAgregar);
            panel1.Controls.Add(dgvDetalleTaco);
            panel1.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(13, 224);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 669);
            panel1.TabIndex = 22;
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
            dgvIngredientesTaco.Location = new Point(15, 37);
            dgvIngredientesTaco.Margin = new Padding(4);
            dgvIngredientesTaco.Name = "dgvIngredientesTaco";
            dgvIngredientesTaco.RowHeadersVisible = false;
            dgvIngredientesTaco.RowHeadersWidth = 51;
            dgvIngredientesTaco.RowTemplate.Height = 29;
            dgvIngredientesTaco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredientesTaco.Size = new Size(662, 603);
            dgvIngredientesTaco.TabIndex = 16;
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
            // pcbQuitar
            // 
            pcbQuitar.Anchor = AnchorStyles.Top;
            pcbQuitar.Image = Properties.Resources.flechaRoja;
            pcbQuitar.Location = new Point(706, 356);
            pcbQuitar.Margin = new Padding(4);
            pcbQuitar.Name = "pcbQuitar";
            pcbQuitar.Size = new Size(97, 99);
            pcbQuitar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbQuitar.TabIndex = 17;
            pcbQuitar.TabStop = false;
            pcbQuitar.Click += pcbQuitar_Click;
            // 
            // pcbAgregar
            // 
            pcbAgregar.Anchor = AnchorStyles.Top;
            pcbAgregar.Image = Properties.Resources.flechaVerde1;
            pcbAgregar.Location = new Point(706, 183);
            pcbAgregar.Margin = new Padding(4);
            pcbAgregar.Name = "pcbAgregar";
            pcbAgregar.Size = new Size(97, 99);
            pcbAgregar.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbAgregar.TabIndex = 18;
            pcbAgregar.TabStop = false;
            pcbAgregar.Click += pcbAgregar_Click;
            // 
            // dgvDetalleTaco
            // 
            dgvDetalleTaco.AllowUserToAddRows = false;
            dgvDetalleTaco.AllowUserToDeleteRows = false;
            dgvDetalleTaco.AllowUserToResizeRows = false;
            dgvDetalleTaco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvDetalleTaco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleTaco.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDetalleTaco.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetalleTaco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleTaco.Columns.AddRange(new DataGridViewColumn[] { IDINGRE, NOMBRE, TIPO, PRECIOINGRE });
            dgvDetalleTaco.Location = new Point(831, 32);
            dgvDetalleTaco.Margin = new Padding(4);
            dgvDetalleTaco.Name = "dgvDetalleTaco";
            dgvDetalleTaco.RowHeadersVisible = false;
            dgvDetalleTaco.RowHeadersWidth = 51;
            dgvDetalleTaco.RowTemplate.Height = 29;
            dgvDetalleTaco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleTaco.Size = new Size(677, 608);
            dgvDetalleTaco.TabIndex = 19;
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
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE INGREDIENTE";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.ReadOnly = true;
            // 
            // PRECIOINGRE
            // 
            PRECIOINGRE.HeaderText = "PRECIO";
            PRECIOINGRE.MinimumWidth = 6;
            PRECIOINGRE.Name = "PRECIOINGRE";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.Location = new Point(626, 980);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(259, 66);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(0, 52, 0);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 1052);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1561, 50);
            pnlInferior.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.Green;
            lblDescripcion.Location = new Point(117, 121);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(699, 37);
            lblDescripcion.TabIndex = 26;
            lblDescripcion.Text = "Seleccione los tipos de ingrediente para agregar al taco:";
            // 
            // cbbTiposIngredientes
            // 
            cbbTiposIngredientes.FormattingEnabled = true;
            cbbTiposIngredientes.Location = new Point(846, 118);
            cbbTiposIngredientes.Name = "cbbTiposIngredientes";
            cbbTiposIngredientes.Size = new Size(461, 44);
            cbbTiposIngredientes.TabIndex = 25;
            cbbTiposIngredientes.SelectedIndexChanged += cbbTiposIngredientes_SelectedIndexChanged;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.Red;
            lblAviso.Location = new Point(343, 922);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(0, 37);
            lblAviso.TabIndex = 27;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Top;
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.FromArgb(192, 0, 0);
            lblInfo.Location = new Point(352, 183);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 37);
            lblInfo.TabIndex = 28;
            // 
            // FormEditarTaco
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1561, 1102);
            Controls.Add(lblInfo);
            Controls.Add(lblAviso);
            Controls.Add(lblDescripcion);
            Controls.Add(cbbTiposIngredientes);
            Controls.Add(pnlInferior);
            Controls.Add(btnActualizar);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Font = new Font("212 Orion Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormEditarTaco";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormEditarTaco";
            Load += FormEditarTaco_Load;
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngredientesTaco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbQuitar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleTaco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pictureBox1;
        private PictureBox pcbSalir;
        private Panel panel1;
        private DataGridView dgvIngredientesTaco;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn INGREDIENTES;
        private DataGridViewTextBoxColumn PRECIO;
        private PictureBox pcbQuitar;
        private PictureBox pcbAgregar;
        private DataGridView dgvDetalleTaco;
        private Button btnActualizar;
        private Panel pnlInferior;
        private DataGridViewTextBoxColumn IDINGRE;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn PRECIOINGRE;
        private Label lblDescripcion;
        private ComboBox cbbTiposIngredientes;
        private Label lblAviso;
        private Label lblInfo;
    }
}