﻿
namespace Oviparos
{
    partial class Anfibios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anfibios));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.anfibiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fenaheDataSet = new Oviparos.fenaheDataSet();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtalimentacion = new System.Windows.Forms.TextBox();
            this.txthabitat = new System.Windows.Forms.TextBox();
            this.txtcomportamiento = new System.Windows.Forms.TextBox();
            this.piguana = new System.Windows.Forms.PictureBox();
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
            this.button6 = new System.Windows.Forms.Button();
            this.ptortuga = new System.Windows.Forms.PictureBox();
            this.pcocodrilo = new System.Windows.Forms.PictureBox();
            this.pserpiente = new System.Windows.Forms.PictureBox();
            this.prana = new System.Windows.Forms.PictureBox();
            this.anfibiosTableAdapter = new Oviparos.fenaheDataSetTableAdapters.anfibiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.anfibiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenaheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piguana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcocodrilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pserpiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prana)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anfibiosBindingSource, "nombre", true));
            this.txtnombre.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(178, 59);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(257, 31);
            this.txtnombre.TabIndex = 0;
            // 
            // anfibiosBindingSource
            // 
            this.anfibiosBindingSource.DataMember = "anfibios";
            this.anfibiosBindingSource.DataSource = this.fenaheDataSet;
            // 
            // fenaheDataSet
            // 
            this.fenaheDataSet.DataSetName = "fenaheDataSet";
            this.fenaheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // piguana
            // 
            this.piguana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piguana.BackgroundImage")));
            this.piguana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piguana.Location = new System.Drawing.Point(502, 59);
            this.piguana.Margin = new System.Windows.Forms.Padding(2);
            this.piguana.Name = "piguana";
            this.piguana.Size = new System.Drawing.Size(346, 331);
            this.piguana.TabIndex = 6;
            this.piguana.TabStop = false;
            this.piguana.Visible = false;
            this.piguana.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.button5.Location = new System.Drawing.Point(733, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 20);
            this.button5.TabIndex = 16;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.FormattingEnabled = true;
            this.txtbuscar.Items.AddRange(new object[] {
            "iguana",
            "tortuga marina",
            "cocodrilo",
            "serpientes",
            "ranas"});
            this.txtbuscar.Location = new System.Drawing.Point(557, 23);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(172, 21);
            this.txtbuscar.TabIndex = 17;
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            // ptortuga
            // 
            this.ptortuga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptortuga.BackgroundImage")));
            this.ptortuga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptortuga.Location = new System.Drawing.Point(502, 59);
            this.ptortuga.Margin = new System.Windows.Forms.Padding(2);
            this.ptortuga.Name = "ptortuga";
            this.ptortuga.Size = new System.Drawing.Size(346, 331);
            this.ptortuga.TabIndex = 20;
            this.ptortuga.TabStop = false;
            this.ptortuga.Visible = false;
            // 
            // pcocodrilo
            // 
            this.pcocodrilo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcocodrilo.BackgroundImage")));
            this.pcocodrilo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcocodrilo.Location = new System.Drawing.Point(493, 59);
            this.pcocodrilo.Margin = new System.Windows.Forms.Padding(2);
            this.pcocodrilo.Name = "pcocodrilo";
            this.pcocodrilo.Size = new System.Drawing.Size(346, 331);
            this.pcocodrilo.TabIndex = 21;
            this.pcocodrilo.TabStop = false;
            this.pcocodrilo.Visible = false;
            // 
            // pserpiente
            // 
            this.pserpiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pserpiente.BackgroundImage")));
            this.pserpiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pserpiente.Location = new System.Drawing.Point(493, 58);
            this.pserpiente.Margin = new System.Windows.Forms.Padding(2);
            this.pserpiente.Name = "pserpiente";
            this.pserpiente.Size = new System.Drawing.Size(346, 331);
            this.pserpiente.TabIndex = 22;
            this.pserpiente.TabStop = false;
            this.pserpiente.Visible = false;
            // 
            // prana
            // 
            this.prana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prana.BackgroundImage")));
            this.prana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prana.Location = new System.Drawing.Point(493, 59);
            this.prana.Margin = new System.Windows.Forms.Padding(2);
            this.prana.Name = "prana";
            this.prana.Size = new System.Drawing.Size(346, 331);
            this.prana.TabIndex = 23;
            this.prana.TabStop = false;
            this.prana.Visible = false;
            // 
            // anfibiosTableAdapter
            // 
            this.anfibiosTableAdapter.ClearBeforeFill = true;
            // 
            // Anfibios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(248)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(886, 541);
            this.Controls.Add(this.prana);
            this.Controls.Add(this.pserpiente);
            this.Controls.Add(this.pcocodrilo);
            this.Controls.Add(this.ptortuga);
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
            this.Controls.Add(this.piguana);
            this.Controls.Add(this.txtcomportamiento);
            this.Controls.Add(this.txthabitat);
            this.Controls.Add(this.txtalimentacion);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Anfibios";
            this.Text = "WonderZoo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anfibiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fenaheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piguana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptortuga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcocodrilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pserpiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtalimentacion;
        private System.Windows.Forms.TextBox txthabitat;
        private System.Windows.Forms.TextBox txtcomportamiento;
        private System.Windows.Forms.PictureBox piguana;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox ptortuga;
        private System.Windows.Forms.PictureBox pcocodrilo;
        private System.Windows.Forms.PictureBox pserpiente;
        private System.Windows.Forms.PictureBox prana;
        private fenaheDataSet fenaheDataSet;
        private System.Windows.Forms.BindingSource anfibiosBindingSource;
        private fenaheDataSetTableAdapters.anfibiosTableAdapter anfibiosTableAdapter;
    }
}
