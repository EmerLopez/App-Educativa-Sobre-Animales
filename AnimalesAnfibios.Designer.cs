
namespace App_Educativa_Sobre_Animales
{
    partial class AnimalesAnfibios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalesAnfibios));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtalimentacion = new System.Windows.Forms.TextBox();
            this.txthabitat = new System.Windows.Forms.TextBox();
            this.txtcomportamiento = new System.Windows.Forms.TextBox();
            this.prana = new System.Windows.Forms.PictureBox();
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
            this.Combobuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.pserpiente = new System.Windows.Forms.PictureBox();
            this.ptortuga = new System.Windows.Forms.PictureBox();
            this.piguana = new System.Windows.Forms.PictureBox();
            this.pcoco = new System.Windows.Forms.PictureBox();
            this.wonderZooDataSet = new App_Educativa_Sobre_Animales.WonderZooDataSet();
            this.anfibiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anfibiosTableAdapter = new App_Educativa_Sobre_Animales.WonderZooDataSetTableAdapters.anfibiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pserpiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piguana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcoco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderZooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anfibiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "nombre", true));
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(178, 61);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(257, 31);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpeso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "peso", true));
            this.txtpeso.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(178, 115);
            this.txtpeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtpeso.Multiline = true;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.ReadOnly = true;
            this.txtpeso.Size = new System.Drawing.Size(257, 46);
            this.txtpeso.TabIndex = 1;
            // 
            // txtalimentacion
            // 
            this.txtalimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtalimentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtalimentacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "alimentacion", true));
            this.txtalimentacion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalimentacion.Location = new System.Drawing.Point(178, 175);
            this.txtalimentacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtalimentacion.Multiline = true;
            this.txtalimentacion.Name = "txtalimentacion";
            this.txtalimentacion.ReadOnly = true;
            this.txtalimentacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtalimentacion.Size = new System.Drawing.Size(257, 56);
            this.txtalimentacion.TabIndex = 2;
            // 
            // txthabitat
            // 
            this.txthabitat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txthabitat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthabitat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "habitat", true));
            this.txthabitat.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthabitat.Location = new System.Drawing.Point(178, 252);
            this.txthabitat.Margin = new System.Windows.Forms.Padding(2);
            this.txthabitat.Multiline = true;
            this.txthabitat.Name = "txthabitat";
            this.txthabitat.ReadOnly = true;
            this.txthabitat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txthabitat.Size = new System.Drawing.Size(257, 75);
            this.txthabitat.TabIndex = 3;
            // 
            // txtcomportamiento
            // 
            this.txtcomportamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtcomportamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomportamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "comportamiento", true));
            this.txtcomportamiento.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomportamiento.Location = new System.Drawing.Point(178, 358);
            this.txtcomportamiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtcomportamiento.Multiline = true;
            this.txtcomportamiento.Name = "txtcomportamiento";
            this.txtcomportamiento.ReadOnly = true;
            this.txtcomportamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomportamiento.Size = new System.Drawing.Size(257, 95);
            this.txtcomportamiento.TabIndex = 4;
            // 
            // prana
            // 
            this.prana.Image = ((System.Drawing.Image)(resources.GetObject("prana.Image")));
            this.prana.Location = new System.Drawing.Point(509, 59);
            this.prana.Margin = new System.Windows.Forms.Padding(2);
            this.prana.Name = "prana";
            this.prana.Size = new System.Drawing.Size(346, 334);
            this.prana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prana.TabIndex = 6;
            this.prana.TabStop = false;
            this.prana.Visible = false;
            this.prana.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(684, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
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
            this.button2.Location = new System.Drawing.Point(508, 422);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 40);
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
            this.button3.Location = new System.Drawing.Point(684, 422);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 40);
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
            this.button4.Location = new System.Drawing.Point(508, 467);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ultimo";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alimentacion";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comportamiento";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(704, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 40);
            this.button5.TabIndex = 16;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Combobuscar
            // 
            this.Combobuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Combobuscar.FormattingEnabled = true;
            this.Combobuscar.Items.AddRange(new object[] {
            "iguana",
            "tortuga marina",
            "cocodrilo",
            "serpiente",
            "rana"});
            this.Combobuscar.Location = new System.Drawing.Point(508, 21);
            this.Combobuscar.Margin = new System.Windows.Forms.Padding(2);
            this.Combobuscar.Name = "Combobuscar";
            this.Combobuscar.Size = new System.Drawing.Size(172, 21);
            this.Combobuscar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "Anfibios";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(248)))), ((int)(((byte)(93)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(20, 476);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 40);
            this.button6.TabIndex = 19;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pserpiente
            // 
            this.pserpiente.Image = ((System.Drawing.Image)(resources.GetObject("pserpiente.Image")));
            this.pserpiente.Location = new System.Drawing.Point(509, 59);
            this.pserpiente.Margin = new System.Windows.Forms.Padding(2);
            this.pserpiente.Name = "pserpiente";
            this.pserpiente.Size = new System.Drawing.Size(346, 334);
            this.pserpiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pserpiente.TabIndex = 20;
            this.pserpiente.TabStop = false;
            this.pserpiente.Visible = false;
            // 
            // ptortuga
            // 
            this.ptortuga.Image = ((System.Drawing.Image)(resources.GetObject("ptortuga.Image")));
            this.ptortuga.Location = new System.Drawing.Point(508, 59);
            this.ptortuga.Margin = new System.Windows.Forms.Padding(2);
            this.ptortuga.Name = "ptortuga";
            this.ptortuga.Size = new System.Drawing.Size(346, 334);
            this.ptortuga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptortuga.TabIndex = 22;
            this.ptortuga.TabStop = false;
            this.ptortuga.Visible = false;
            // 
            // piguana
            // 
            this.piguana.Image = ((System.Drawing.Image)(resources.GetObject("piguana.Image")));
            this.piguana.Location = new System.Drawing.Point(508, 59);
            this.piguana.Margin = new System.Windows.Forms.Padding(2);
            this.piguana.Name = "piguana";
            this.piguana.Size = new System.Drawing.Size(346, 334);
            this.piguana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piguana.TabIndex = 23;
            this.piguana.TabStop = false;
            this.piguana.Visible = false;
            this.piguana.Click += new System.EventHandler(this.pcaballo_Click);
            // 
            // pcoco
            // 
            this.pcoco.Image = ((System.Drawing.Image)(resources.GetObject("pcoco.Image")));
            this.pcoco.Location = new System.Drawing.Point(508, 59);
            this.pcoco.Margin = new System.Windows.Forms.Padding(2);
            this.pcoco.Name = "pcoco";
            this.pcoco.Size = new System.Drawing.Size(346, 334);
            this.pcoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcoco.TabIndex = 24;
            this.pcoco.TabStop = false;
            this.pcoco.Visible = false;
            // 
            // wonderZooDataSet
            // 
            this.wonderZooDataSet.DataSetName = "WonderZooDataSet";
            this.wonderZooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anfibiosBindingSource
            // 
            this.anfibiosBindingSource.DataMember = "anfibios";
            this.anfibiosBindingSource.DataSource = this.wonderZooDataSet;
            // 
            // anfibiosTableAdapter
            // 
            this.anfibiosTableAdapter.ClearBeforeFill = true;
            // 
            // AnimalesAnfibios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(248)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(886, 541);
            this.Controls.Add(this.pcoco);
            this.Controls.Add(this.piguana);
            this.Controls.Add(this.ptortuga);
            this.Controls.Add(this.pserpiente);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Combobuscar);
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
            this.Controls.Add(this.prana);
            this.Controls.Add(this.txtcomportamiento);
            this.Controls.Add(this.txthabitat);
            this.Controls.Add(this.txtalimentacion);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnimalesAnfibios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WonderZoo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pserpiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piguana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcoco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderZooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anfibiosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtalimentacion;
        private System.Windows.Forms.TextBox txthabitat;
        private System.Windows.Forms.TextBox txtcomportamiento;
        private System.Windows.Forms.PictureBox prana;
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
        private System.Windows.Forms.ComboBox Combobuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pserpiente;
        private System.Windows.Forms.PictureBox ptortuga;
        private System.Windows.Forms.PictureBox piguana;
        private System.Windows.Forms.PictureBox pcoco;
        private WonderZooDataSet wonderZooDataSet;
        private System.Windows.Forms.BindingSource anfibiosBindingSource;
        private WonderZooDataSetTableAdapters.anfibiosTableAdapter anfibiosTableAdapter;
    }
}

