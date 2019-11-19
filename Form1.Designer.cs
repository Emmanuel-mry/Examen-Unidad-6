namespace ListaTareasForma
{
    partial class Form1
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
            this.Fechatxt = new System.Windows.Forms.DateTimePicker();
            this.Estadotxt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Horatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tareatxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreUsuariotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editarbtn = new System.Windows.Forms.Button();
            this.DtvTareas = new System.Windows.Forms.DataGridView();
            this.CREADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // Fechatxt
            // 
            this.Fechatxt.Location = new System.Drawing.Point(120, 106);
            this.Fechatxt.Name = "Fechatxt";
            this.Fechatxt.Size = new System.Drawing.Size(200, 20);
            this.Fechatxt.TabIndex = 55;
            // 
            // Estadotxt
            // 
            this.Estadotxt.FormattingEnabled = true;
            this.Estadotxt.Items.AddRange(new object[] {
            "Pendiente",
            "En Proceso",
            "Realizada"});
            this.Estadotxt.Location = new System.Drawing.Point(120, 135);
            this.Estadotxt.Name = "Estadotxt";
            this.Estadotxt.Size = new System.Drawing.Size(100, 21);
            this.Estadotxt.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "FECHA:";
            // 
            // Horatxt
            // 
            this.Horatxt.Location = new System.Drawing.Point(120, 80);
            this.Horatxt.Name = "Horatxt";
            this.Horatxt.Size = new System.Drawing.Size(64, 20);
            this.Horatxt.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "HORA:";
            // 
            // Tareatxt
            // 
            this.Tareatxt.Location = new System.Drawing.Point(120, 54);
            this.Tareatxt.Name = "Tareatxt";
            this.Tareatxt.Size = new System.Drawing.Size(147, 20);
            this.Tareatxt.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "TAREA:";
            // 
            // NombreUsuariotxt
            // 
            this.NombreUsuariotxt.Location = new System.Drawing.Point(120, 28);
            this.NombreUsuariotxt.Name = "NombreUsuariotxt";
            this.NombreUsuariotxt.Size = new System.Drawing.Size(147, 20);
            this.NombreUsuariotxt.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "CREADA POR:";
            // 
            // Editarbtn
            // 
            this.Editarbtn.Location = new System.Drawing.Point(408, 99);
            this.Editarbtn.Name = "Editarbtn";
            this.Editarbtn.Size = new System.Drawing.Size(88, 32);
            this.Editarbtn.TabIndex = 45;
            this.Editarbtn.Text = "EDITAR";
            this.Editarbtn.UseVisualStyleBackColor = true;
            this.Editarbtn.Click += new System.EventHandler(this.Editarbtn_Click);
            // 
            // DtvTareas
            // 
            this.DtvTareas.AllowUserToAddRows = false;
            this.DtvTareas.AllowUserToDeleteRows = false;
            this.DtvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREADOR,
            this.TAREA,
            this.HORA,
            this.FECHA,
            this.ESTADO});
            this.DtvTareas.Location = new System.Drawing.Point(12, 194);
            this.DtvTareas.Name = "DtvTareas";
            this.DtvTareas.ReadOnly = true;
            this.DtvTareas.Size = new System.Drawing.Size(536, 180);
            this.DtvTareas.TabIndex = 44;
            this.DtvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvTareas_CellContentClick);
            // 
            // CREADOR
            // 
            this.CREADOR.HeaderText = "CREADOR";
            this.CREADOR.Name = "CREADOR";
            this.CREADOR.ReadOnly = true;
            // 
            // TAREA
            // 
            this.TAREA.HeaderText = "TAREA";
            this.TAREA.Name = "TAREA";
            this.TAREA.ReadOnly = true;
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            this.HORA.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(408, 41);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(88, 33);
            this.Agregarbtn.TabIndex = 43;
            this.Agregarbtn.Text = "AGREGAR";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(572, 386);
            this.Controls.Add(this.Fechatxt);
            this.Controls.Add(this.Estadotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Horatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tareatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreUsuariotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Editarbtn);
            this.Controls.Add(this.DtvTareas);
            this.Controls.Add(this.Agregarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fechatxt;
        private System.Windows.Forms.ComboBox Estadotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Horatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tareatxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreUsuariotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editarbtn;
        private System.Windows.Forms.DataGridView DtvTareas;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}

