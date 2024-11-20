namespace CRUD
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
            groupBox1 = new GroupBox();
            btnCrear = new Button();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtCarrera = new TextBox();
            txtCarnet = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            dvgEstudiantes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCarrera);
            groupBox1.Controls.Add(txtCarnet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 480);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Personal";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.MistyRose;
            btnCrear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(340, 429);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(110, 32);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Agregar";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ScrollBar;
            txtTelefono.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(23, 377);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(427, 30);
            txtTelefono.TabIndex = 8;
            txtTelefono.Enter += txtTelefono_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 350);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 7;
            label5.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 274);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 6;
            label4.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.BackColor = SystemColors.ScrollBar;
            txtCarrera.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarrera.Location = new Point(23, 301);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(427, 30);
            txtCarrera.TabIndex = 4;
            txtCarrera.Enter += txtCarrera_Enter;
            // 
            // txtCarnet
            // 
            txtCarnet.BackColor = SystemColors.ScrollBar;
            txtCarnet.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarnet.Location = new Point(23, 222);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(427, 30);
            txtCarnet.TabIndex = 5;
            txtCarnet.Enter += txtCarnet_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 195);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 4;
            label3.Text = "No. Carnet";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ScrollBar;
            txtID.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(23, 148);
            txtID.Name = "txtID";
            txtID.Size = new Size(427, 30);
            txtID.TabIndex = 3;
            txtID.Enter += txtID_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 121);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "No. Identificación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(23, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(427, 30);
            txtNombre.TabIndex = 0;
            txtNombre.Enter += txtNombre_Enter;
            // 
            // dvgEstudiantes
            // 
            dvgEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgEstudiantes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dvgEstudiantes.Location = new Point(523, 22);
            dvgEstudiantes.Name = "dvgEstudiantes";
            dvgEstudiantes.RowHeadersWidth = 51;
            dvgEstudiantes.Size = new Size(1054, 429);
            dvgEstudiantes.TabIndex = 1;
            dvgEstudiantes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "No. Identificación";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "No. Carnet";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Carrera";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Teléfono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.MistyRose;
            txtEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEliminar.Location = new Point(1420, 470);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(157, 32);
            txtEliminar.TabIndex = 10;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = false;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.MistyRose;
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(1226, 470);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 32);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MistyRose;
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1023, 470);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 32);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1589, 530);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(txtEliminar);
            Controls.Add(dvgEstudiantes);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Estudiante";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private TextBox txtCarrera;
        private TextBox txtCarnet;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private DataGridView dvgEstudiantes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnCrear;
        private Button txtEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}
