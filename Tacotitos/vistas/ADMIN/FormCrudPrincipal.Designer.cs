namespace Tacotitos.vistas.ADMIN
{
    partial class FormCrudPrincipal
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
            pnlSuperior2 = new Panel();
            btnIngrediente = new Button();
            btnTipoIngrediente = new Button();
            pnlContenedor = new Panel();
            pnlInferior = new Panel();
            btnClientr = new Button();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).BeginInit();
            pnlSuperior2.SuspendLayout();
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
            pnlSuperior.Size = new Size(1293, 65);
            pnlSuperior.TabIndex = 3;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarblanco2;
            pcbSalir.Location = new Point(1234, 9);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(47, 53);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 2;
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
            // pnlSuperior2
            // 
            pnlSuperior2.AutoSize = true;
            pnlSuperior2.BackColor = Color.White;
            pnlSuperior2.Controls.Add(btnClientr);
            pnlSuperior2.Controls.Add(btnIngrediente);
            pnlSuperior2.Controls.Add(btnTipoIngrediente);
            pnlSuperior2.Dock = DockStyle.Top;
            pnlSuperior2.Font = new Font("212 Orion Sans", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSuperior2.ForeColor = Color.Green;
            pnlSuperior2.Location = new Point(0, 65);
            pnlSuperior2.Name = "pnlSuperior2";
            pnlSuperior2.Size = new Size(1293, 74);
            pnlSuperior2.TabIndex = 4;
            // 
            // btnIngrediente
            // 
            btnIngrediente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIngrediente.BackColor = Color.White;
            btnIngrediente.Location = new Point(837, 31);
            btnIngrediente.Name = "btnIngrediente";
            btnIngrediente.Size = new Size(213, 40);
            btnIngrediente.TabIndex = 1;
            btnIngrediente.Text = "Ingrediente";
            btnIngrediente.UseVisualStyleBackColor = false;
            btnIngrediente.Click += btnIngrediente_Click;
            // 
            // btnTipoIngrediente
            // 
            btnTipoIngrediente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTipoIngrediente.BackColor = Color.White;
            btnTipoIngrediente.ForeColor = Color.Green;
            btnTipoIngrediente.Location = new Point(551, 31);
            btnTipoIngrediente.Name = "btnTipoIngrediente";
            btnTipoIngrediente.Size = new Size(280, 40);
            btnTipoIngrediente.TabIndex = 0;
            btnTipoIngrediente.Text = "Tipo de ingrediente";
            btnTipoIngrediente.UseVisualStyleBackColor = false;
            btnTipoIngrediente.Click += btnTipoIngrediente_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.Location = new Point(0, 138);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1293, 604);
            pnlContenedor.TabIndex = 5;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(0, 52, 0);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 748);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(1293, 49);
            pnlInferior.TabIndex = 2;
            // 
            // btnClientr
            // 
            btnClientr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClientr.BackColor = Color.White;
            btnClientr.Location = new Point(1056, 31);
            btnClientr.Name = "btnClientr";
            btnClientr.Size = new Size(213, 40);
            btnClientr.TabIndex = 2;
            btnClientr.Text = "Cliente";
            btnClientr.UseVisualStyleBackColor = false;
            btnClientr.Click += btnClientr_Click;
            // 
            // FormCrudPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1293, 797);
            Controls.Add(pnlInferior);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlSuperior2);
            Controls.Add(pnlSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrudPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrudPrincipal";
            WindowState = FormWindowState.Maximized;
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbImgLogo).EndInit();
            pnlSuperior2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSuperior;
        private PictureBox pcbImgLogo;
        private Label lblTituloLogo;
        private PictureBox pcbSalir;
        private Panel pnlSuperior2;
        private Button btnTipoIngrediente;
        private Button btnIngrediente;
        private Panel pnlContenedor;
        private Panel pnlInferior;
        private Button btnClientr;
    }
}