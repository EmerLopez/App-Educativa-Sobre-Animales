
namespace App_Educativa_Sobre_Animales
{
    partial class fusuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginAccessDataSet1 = new App_Educativa_Sobre_Animales.LoginAccessDataSet1();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.belimiar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.usuariosTableAdapter = new App_Educativa_Sobre_Animales.sistemaDataSetTableAdapters.UsuariosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuariosTableAdapter1 = new App_Educativa_Sobre_Animales.LoginAccessDataSet1TableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE USUARIOS AL SISTEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel";
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "nombre", true));
            this.txtusuario.Location = new System.Drawing.Point(397, 102);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(241, 25);
            this.txtusuario.TabIndex = 4;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.loginAccessDataSet1;
            // 
            // loginAccessDataSet1
            // 
            this.loginAccessDataSet1.DataSetName = "LoginAccessDataSet1";
            this.loginAccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "password", true));
            this.txtclave.Location = new System.Drawing.Point(397, 169);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Multiline = true;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(241, 25);
            this.txtclave.TabIndex = 5;
            // 
            // bprimero
            // 
            this.bprimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bprimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bprimero.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(43, 348);
            this.bprimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(109, 52);
            this.bprimero.TabIndex = 6;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = false;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // banterior
            // 
            this.banterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.banterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.banterior.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(180, 348);
            this.banterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(109, 52);
            this.banterior.TabIndex = 7;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = false;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsiguiente.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(313, 348);
            this.bsiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(109, 52);
            this.bsiguiente.TabIndex = 9;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = false;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bultimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bultimo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(457, 348);
            this.bultimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(109, 52);
            this.bultimo.TabIndex = 10;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = false;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnuevo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(43, 432);
            this.bnuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(109, 52);
            this.bnuevo.TabIndex = 11;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // belimiar
            // 
            this.belimiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.belimiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.belimiar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belimiar.Location = new System.Drawing.Point(180, 432);
            this.belimiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.belimiar.Name = "belimiar";
            this.belimiar.Size = new System.Drawing.Size(109, 52);
            this.belimiar.TabIndex = 12;
            this.belimiar.Text = "Eliminar";
            this.belimiar.UseVisualStyleBackColor = false;
            this.belimiar.Click += new System.EventHandler(this.belimiar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmodificar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(313, 432);
            this.bmodificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(109, 52);
            this.bmodificar.TabIndex = 13;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsalir.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(457, 432);
            this.bsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(109, 52);
            this.bsalir.TabIndex = 14;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.button8_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bguardar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(43, 523);
            this.bguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(109, 52);
            this.bguardar.TabIndex = 15;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.bactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bactualizar.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(313, 523);
            this.bactualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(109, 52);
            this.bactualizar.TabIndex = 16;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // lstnivel
            // 
            this.lstnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource1, "Nivel", true));
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstnivel.Location = new System.Drawing.Point(397, 242);
            this.lstnivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(241, 24);
            this.lstnivel.TabIndex = 17;
            this.lstnivel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 214);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(248)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(672, 598);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.belimiar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WonderZoo";
            this.Load += new System.EventHandler(this.fusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button belimiar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.ComboBox lstnivel;
        private sistemaDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private LoginAccessDataSet1 loginAccessDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private LoginAccessDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
    }
}