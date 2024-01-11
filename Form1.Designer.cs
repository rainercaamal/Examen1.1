namespace Examen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            TxtUsuario = new TextBox();
            TxtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(111, 111);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(155, 43);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(406, 111);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(134, 43);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(189, 12);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(295, 23);
            TxtUsuario.TabIndex = 2;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(189, 60);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(295, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 184);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsuario);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private Button BtnCancelar;
        private TextBox TxtUsuario;
        private TextBox TxtPassword;
        private Label label1;
        private Label label2;
    }
}