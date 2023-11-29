namespace Tacotitos.vistas
{
    partial class FormMenuPrincipal
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
            panel1 = new Panel();
            onlBotones = new Panel();
            btnEstadisticas = new Button();
            btnPedido = new Button();
            btnAdmin = new Button();
            panel2 = new Panel();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            pcbSalir = new PictureBox();
            panel1.SuspendLayout();
            onlBotones.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(onlBotones);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 1055);
            panel1.TabIndex = 0;
            // 
            // onlBotones
            // 
            onlBotones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            onlBotones.Controls.Add(btnEstadisticas);
            onlBotones.Controls.Add(btnPedido);
            onlBotones.Controls.Add(btnAdmin);
            onlBotones.Location = new Point(46, 168);
            onlBotones.Name = "onlBotones";
            onlBotones.Size = new Size(615, 846);
            onlBotones.TabIndex = 1;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.BackColor = Color.White;
            btnEstadisticas.Font = new Font("212 Orion Sans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstadisticas.ForeColor = Color.FromArgb(0, 192, 0);
            btnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.Location = new Point(57, 560);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(509, 86);
            btnEstadisticas.TabIndex = 2;
            btnEstadisticas.TabStop = false;
            btnEstadisticas.Text = "ESTADISTICAS";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.MouseLeave += btnAdmin_MouseLeave;
            btnEstadisticas.MouseHover += btnAdmin_MouseHover;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.White;
            btnPedido.Font = new Font("212 Orion Sans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedido.ForeColor = Color.FromArgb(0, 192, 0);
            btnPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedido.Location = new Point(57, 340);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(509, 86);
            btnPedido.TabIndex = 1;
            btnPedido.TabStop = false;
            btnPedido.Text = "PEDIDO";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            btnPedido.MouseLeave += btnAdmin_MouseLeave;
            btnPedido.MouseHover += btnAdmin_MouseHover;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.White;
            btnAdmin.Font = new Font("212 Orion Sans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.FromArgb(0, 192, 0);
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(57, 125);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(509, 86);
            btnAdmin.TabIndex = 0;
            btnAdmin.TabStop = false;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            btnAdmin.MouseLeave += btnAdmin_MouseLeave;
            btnAdmin.MouseHover += btnAdmin_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 127);
            panel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("LillyBelle", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Location = new Point(83, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(595, 96);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tacotito's FoodTruck";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.tmex;
            pictureBox1.Location = new Point(790, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 891);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pcbSalir
            // 
            pcbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbSalir.Image = Properties.Resources.cerrarX32;
            pcbSalir.Location = new Point(1446, 23);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(44, 42);
            pcbSalir.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbSalir.TabIndex = 0;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1513, 1055);
            Controls.Add(pcbSalir);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Potatoes And Peas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            onlBotones.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pcbSalir;
        private Panel panel2;
        private Label lblTitulo;
        private Panel onlBotones;
        private Button btnAdmin;
        private Button btnEstadisticas;
        private Button btnPedido;
    }
}