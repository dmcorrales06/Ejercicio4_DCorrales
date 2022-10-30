namespace Vista
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioSfButton = new Syncfusion.WinForms.Controls.SfButton();
            this.CerrarSfButton = new Syncfusion.WinForms.Controls.SfButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.Location = new System.Drawing.Point(89, 58);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(218, 22);
            this.ClaveTextBox.TabIndex = 13;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(89, 30);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(218, 22);
            this.UsuarioTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // UsuarioSfButton
            // 
            this.UsuarioSfButton.AccessibleName = "Button";
            this.UsuarioSfButton.BackColor = System.Drawing.Color.LightCoral;
            this.UsuarioSfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.UsuarioSfButton.Location = new System.Drawing.Point(48, 101);
            this.UsuarioSfButton.Name = "UsuarioSfButton";
            this.UsuarioSfButton.Size = new System.Drawing.Size(127, 39);
            this.UsuarioSfButton.Style.BackColor = System.Drawing.Color.LightCoral;
            this.UsuarioSfButton.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.UsuarioSfButton.TabIndex = 15;
            this.UsuarioSfButton.Text = "Iniciar Sesión";
            this.UsuarioSfButton.UseVisualStyleBackColor = false;
            this.UsuarioSfButton.Click += new System.EventHandler(this.UsuarioSfButton_Click);
            // 
            // CerrarSfButton
            // 
            this.CerrarSfButton.AccessibleName = "Button";
            this.CerrarSfButton.BackColor = System.Drawing.Color.LightCoral;
            this.CerrarSfButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.CerrarSfButton.Location = new System.Drawing.Point(196, 101);
            this.CerrarSfButton.Name = "CerrarSfButton";
            this.CerrarSfButton.Size = new System.Drawing.Size(111, 39);
            this.CerrarSfButton.Style.BackColor = System.Drawing.Color.LightCoral;
            this.CerrarSfButton.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.CerrarSfButton.TabIndex = 16;
            this.CerrarSfButton.Text = "Cerrar";
            this.CerrarSfButton.UseVisualStyleBackColor = false;
            this.CerrarSfButton.Click += new System.EventHandler(this.CerrarSfButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.UsuarioSfButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.CancelButton = this.CerrarSfButton;
            this.ClientSize = new System.Drawing.Size(462, 153);
            this.Controls.Add(this.CerrarSfButton);
            this.Controls.Add(this.UsuarioSfButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton UsuarioSfButton;
        private Syncfusion.WinForms.Controls.SfButton CerrarSfButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

