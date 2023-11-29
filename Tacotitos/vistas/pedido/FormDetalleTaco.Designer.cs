namespace Tacotitos.vistas.pedido
{
    partial class FormDetalleTaco
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
            dgvDetallesIngre = new DataGridView();
            IDINGRE = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            PRECIOINGRE = new DataGridViewTextBoxColumn();
            lblNroTaco = new Label();
            lblTotalTaco = new Label();
            btnEditar = new Button();
            pnlSuperior = new Panel();
            pictureBox1 = new PictureBox();
            pcbSalir = new PictureBox();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesIngre).BeginInit();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            SuspendLayout();
            // 
            // dgvDetallesIngre
            // 
            dgvDetallesIngre.AllowUserToAddRows = false;
            dgvDetallesIngre.AllowUserToDeleteRows = false;
            dgvDetallesIngre.AllowUserToResizeRows = false;
            dgvDetallesIngre.Anchor = AnchorStyles.Top;
            dgvDetallesIngre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesIngre.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDetallesIngre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetallesIngre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesIngre.Columns.AddRange(new DataGridViewColumn[] { IDINGRE, NOMBRE, TIPO, PRECIOINGRE });
            dgvDetallesIngre.Location = new Point(43, 125);
            dgvDetallesIngre.Margin = new Padding(4);
            dgvDetallesIngre.Name = "dgvDetallesIngre";
            dgvDetallesIngre.RowHeadersVisible = false;
            dgvDetallesIngre.RowHeadersWidth = 51;
            dgvDetallesIngre.RowTemplate.Height = 29;
            dgvDetallesIngre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallesIngre.Size = new Size(761, 516);
            dgvDetallesIngre.TabIndex = 16;
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
            // lblNroTaco
            // 
            lblNroTaco.AutoSize = true;
            lblNroTaco.Location = new Point(407, 78);
            lblNroTaco.Name = "lblNroTaco";
            lblNroTaco.Size = new Size(0, 31);
            lblNroTaco.TabIndex = 17;
            // 
            // lblTotalTaco
            // 
            lblTotalTaco.Anchor = AnchorStyles.Top;
            lblTotalTaco.AutoSize = true;
            lblTotalTaco.Location = new Point(407, 645);
            lblTotalTaco.Name = "lblTotalTaco";
            lblTotalTaco.Size = new Size(156, 31);
            lblTotalTaco.TabIndex = 18;
            lblTotalTaco.Text = "Total del taco: ";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(287, 703);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(276, 64);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(0, 52, 0);
            pnlSuperior.Controls.Add(pictureBox1);
            pnlSuperior.Controls.Add(pcbSalir);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(850, 65);
            pnlSuperior.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.cerrarblanco2;
            pictureBox1.Location = new Point(791, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarblanco2;
            pcbSalir.Location = new Point(2001, 12);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(47, 53);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 3;
            pcbSalir.TabStop = false;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(569, 649);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 31);
            lblPrecio.TabIndex = 21;
            // 
            // FormDetalleTaco
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 803);
            Controls.Add(lblPrecio);
            Controls.Add(pnlSuperior);
            Controls.Add(btnEditar);
            Controls.Add(lblTotalTaco);
            Controls.Add(lblNroTaco);
            Controls.Add(dgvDetallesIngre);
            Font = new Font("212 Orion Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormDetalleTaco";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDetalleTaco";
            Load += FormDetalleTaco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesIngre).EndInit();
            pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDetallesIngre;
        private DataGridViewTextBoxColumn IDINGRE;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn PRECIOINGRE;
        private Label lblNroTaco;
        private Label lblTotalTaco;
        private Button btnEditar;
        private Panel pnlSuperior;
        private PictureBox pcbSalir;
        private PictureBox pictureBox1;
        private Label lblPrecio;
    }
}