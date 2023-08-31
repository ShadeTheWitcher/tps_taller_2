namespace practico3
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
            TGuardar = new Button();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LNya = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TEliminar = new Button();
            SuspendLayout();
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(34, 236);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 0;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += button1_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(34, 67);
            LDni.Name = "LDni";
            LDni.Size = new Size(25, 15);
            LDni.TabIndex = 1;
            LDni.Text = "Dni";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(34, 104);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(34, 147);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            LNombre.Click += LNombre_Click;
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(34, 9);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 4;
            LNya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(153, 9);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 5;
            LModificar.Text = "modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(109, 59);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 6;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(109, 96);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(109, 139);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 8;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(134, 236);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 300);
            Controls.Add(TEliminar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(TGuardar);
            Name = "Form1";
            Text = "Pequeño forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TGuardar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Label LNya;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TEliminar;
    }
}