
namespace Oviparos
{
    partial class Oviparosanimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oviparosanimales));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtalimentacion = new System.Windows.Forms.TextBox();
            this.txthabitat = new System.Windows.Forms.TextBox();
            this.txtcomportamiento = new System.Windows.Forms.TextBox();
            this.ptortuga = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fenaheDataSet4 = new global::Oviparos.fenaheDataSet4();
            this.oviparosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oviparosTableAdapter = new global::Oviparos.fenaheDataSet4TableAdapters.oviparosTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.ppinguinos = new System.Windows.Forms.PictureBox();
            this.ppollos = new System.Windows.Forms.PictureBox();
            this.ptorogoz = new System.Windows.Forms.PictureBox();
            this.pavestruz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenaheDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviparosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppinguinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppollos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptorogoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavestruz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oviparosBindingSource, "nombre", true));
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(238, 73);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(342, 38);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpeso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oviparosBindingSource, "peso", true));
            this.txtpeso.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(238, 142);
            this.txtpeso.Multiline = true;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.ReadOnly = true;
            this.txtpeso.Size = new System.Drawing.Size(342, 56);
            this.txtpeso.TabIndex = 1;
            // 
            // txtalimentacion
            // 
            this.txtalimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtalimentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtalimentacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oviparosBindingSource, "alimentacion", true));
            this.txtalimentacion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalimentacion.Location = new System.Drawing.Point(238, 215);
            this.txtalimentacion.Multiline = true;
            this.txtalimentacion.Name = "txtalimentacion";
            this.txtalimentacion.ReadOnly = true;
            this.txtalimentacion.Size = new System.Drawing.Size(342, 68);
            this.txtalimentacion.TabIndex = 2;
            // 
            // txthabitat
            // 
            this.txthabitat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txthabitat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthabitat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oviparosBindingSource, "habitat", true));
            this.txthabitat.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthabitat.Location = new System.Drawing.Point(238, 310);
            this.txthabitat.Multiline = true;
            this.txthabitat.Name = "txthabitat";
            this.txthabitat.ReadOnly = true;
            this.txthabitat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txthabitat.Size = new System.Drawing.Size(342, 92);
            this.txthabitat.TabIndex = 3;
            // 
            // txtcomportamiento
            // 
            this.txtcomportamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcomportamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomportamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oviparosBindingSource, "comportamiento", true));
            this.txtcomportamiento.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomportamiento.Location = new System.Drawing.Point(238, 440);
            this.txtcomportamiento.Multiline = true;
            this.txtcomportamiento.Name = "txtcomportamiento";
            this.txtcomportamiento.ReadOnly = true;
            this.txtcomportamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomportamiento.Size = new System.Drawing.Size(342, 117);
            this.txtcomportamiento.TabIndex = 4;
            // 
            // ptortuga
            // 
            this.ptortuga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptortuga.BackgroundImage")));
            this.ptortuga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptortuga.Location = new System.Drawing.Point(679, 73);
            this.ptortuga.Name = "ptortuga";
            this.ptortuga.Size = new System.Drawing.Size(461, 407);
            this.ptortuga.TabIndex = 6;
            this.ptortuga.TabStop = false;
            this.ptortuga.Visible = false;
            this.ptortuga.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(679, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Primero";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(678, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Anterior";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(912, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(912, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ultimo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alimentacion";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comportamiento";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(977, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 24);
            this.button5.TabIndex = 16;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtbuscar.FormattingEnabled = true;
            this.txtbuscar.Items.AddRange(new object[] {
            "Tortuga Marina",
            "Pinguino",
            "Gallina",
            "Torogoz",
            "Avestruz"});
            this.txtbuscar.Location = new System.Drawing.Point(743, 28);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(228, 24);
            this.txtbuscar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 51);
            this.label6.TabIndex = 18;
            this.label6.Text = "Oviparos";
            // 
            // fenaheDataSet4
            // 
            this.fenaheDataSet4.DataSetName = "fenaheDataSet4";
            this.fenaheDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oviparosBindingSource
            // 
            this.oviparosBindingSource.DataMember = "oviparos";
            this.oviparosBindingSource.DataSource = this.fenaheDataSet4;
            // 
            // oviparosTableAdapter
            // 
            this.oviparosTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(26, 586);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 49);
            this.button6.TabIndex = 19;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ppinguinos
            // 
            this.ppinguinos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ppinguinos.BackgroundImage")));
            this.ppinguinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ppinguinos.Location = new System.Drawing.Point(678, 73);
            this.ppinguinos.Name = "ppinguinos";
            this.ppinguinos.Size = new System.Drawing.Size(461, 407);
            this.ppinguinos.TabIndex = 20;
            this.ppinguinos.TabStop = false;
            this.ppinguinos.Visible = false;
            // 
            // ppollos
            // 
            this.ppollos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ppollos.BackgroundImage")));
            this.ppollos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ppollos.Location = new System.Drawing.Point(678, 71);
            this.ppollos.Name = "ppollos";
            this.ppollos.Size = new System.Drawing.Size(461, 407);
            this.ppollos.TabIndex = 21;
            this.ppollos.TabStop = false;
            this.ppollos.Visible = false;
            // 
            // ptorogoz
            // 
            this.ptorogoz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptorogoz.BackgroundImage")));
            this.ptorogoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptorogoz.Location = new System.Drawing.Point(679, 71);
            this.ptorogoz.Name = "ptorogoz";
            this.ptorogoz.Size = new System.Drawing.Size(461, 407);
            this.ptorogoz.TabIndex = 22;
            this.ptorogoz.TabStop = false;
            this.ptorogoz.Visible = false;
            // 
            // pavestruz
            // 
            this.pavestruz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pavestruz.BackgroundImage")));
            this.pavestruz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pavestruz.Location = new System.Drawing.Point(678, 73);
            this.pavestruz.Name = "pavestruz";
            this.pavestruz.Size = new System.Drawing.Size(461, 407);
            this.pavestruz.TabIndex = 23;
            this.pavestruz.TabStop = false;
            this.pavestruz.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(248)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1181, 666);
            this.Controls.Add(this.pavestruz);
            this.Controls.Add(this.ptorogoz);
            this.Controls.Add(this.ppollos);
            this.Controls.Add(this.ppinguinos);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptortuga);
            this.Controls.Add(this.txtcomportamiento);
            this.Controls.Add(this.txthabitat);
            this.Controls.Add(this.txtalimentacion);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales Oviparos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenaheDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviparosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppinguinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppollos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptorogoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavestruz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtalimentacion;
        private System.Windows.Forms.TextBox txthabitat;
        private System.Windows.Forms.TextBox txtcomportamiento;
        private System.Windows.Forms.PictureBox ptortuga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox txtbuscar;
        private System.Windows.Forms.Label label6;
        private fenaheDataSet4 fenaheDataSet4;
        private System.Windows.Forms.BindingSource oviparosBindingSource;
        private fenaheDataSet4TableAdapters.oviparosTableAdapter oviparosTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox ppinguinos;
        private System.Windows.Forms.PictureBox ppollos;
        private System.Windows.Forms.PictureBox ptorogoz;
        private System.Windows.Forms.PictureBox pavestruz;
    }
}

