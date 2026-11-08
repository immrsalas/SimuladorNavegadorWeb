namespace SimuladorNavegadorWeb
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
            txtUrl = new TextBox();
            btnVisitar = new Button();
            btnAtras = new Button();
            btnAdelante = new Button();
            lblPaginaActual = new Label();
            lstHistorialAtras = new ListBox();
            lstHistorialAdelante = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(40, 46);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(437, 35);
            txtUrl.TabIndex = 0;
            // 
            // btnVisitar
            // 
            btnVisitar.Location = new Point(40, 112);
            btnVisitar.Name = "btnVisitar";
            btnVisitar.Size = new Size(125, 64);
            btnVisitar.TabIndex = 1;
            btnVisitar.Text = "Visitar";
            btnVisitar.UseVisualStyleBackColor = true;
            btnVisitar.Click += btnVisitar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(187, 112);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(128, 64);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "← Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAdelante
            // 
            btnAdelante.Location = new Point(341, 112);
            btnAdelante.Name = "btnAdelante";
            btnAdelante.Size = new Size(136, 64);
            btnAdelante.TabIndex = 3;
            btnAdelante.Text = "Adelante →";
            btnAdelante.UseVisualStyleBackColor = true;
            btnAdelante.Click += btnAdelante_Click;
            // 
            // lblPaginaActual
            // 
            lblPaginaActual.AutoSize = true;
            lblPaginaActual.Location = new Point(50, 214);
            lblPaginaActual.Name = "lblPaginaActual";
            lblPaginaActual.Size = new Size(228, 30);
            lblPaginaActual.TabIndex = 4;
            lblPaginaActual.Text = "Página actual: Ninguna";
            // 
            // lstHistorialAtras
            // 
            lstHistorialAtras.FormattingEnabled = true;
            lstHistorialAtras.Location = new Point(611, 46);
            lstHistorialAtras.Name = "lstHistorialAtras";
            lstHistorialAtras.Size = new Size(245, 484);
            lstHistorialAtras.TabIndex = 5;
            // 
            // lstHistorialAdelante
            // 
            lstHistorialAdelante.FormattingEnabled = true;
            lstHistorialAdelante.Location = new Point(926, 46);
            lstHistorialAdelante.Name = "lstHistorialAdelante";
            lstHistorialAdelante.Size = new Size(245, 484);
            lstHistorialAdelante.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(611, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 7;
            label1.Text = "Pila atras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(926, 9);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 8;
            label2.Text = "Pila Adelante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 607);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstHistorialAdelante);
            Controls.Add(lstHistorialAtras);
            Controls.Add(lblPaginaActual);
            Controls.Add(btnAdelante);
            Controls.Add(btnAtras);
            Controls.Add(btnVisitar);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnVisitar;
        private Button btnAtras;
        private Button btnAdelante;
        private Label lblPaginaActual;
        private ListBox lstHistorialAtras;
        private ListBox lstHistorialAdelante;
        private Label label1;
        private Label label2;
    }
}
