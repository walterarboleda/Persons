namespace Persons
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
            txtPersonID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Insertar = new Button();
            dgvClientes = new DataGridView();
            btnActualizar = new Button();
            Eliminar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnVertodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtPersonID
            // 
            txtPersonID.Location = new Point(427, 84);
            txtPersonID.Name = "txtPersonID";
            txtPersonID.Size = new Size(100, 23);
            txtPersonID.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(427, 187);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(427, 131);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 88);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "PersonID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 195);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 139);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "LastName";
            // 
            // Insertar
            // 
            Insertar.Location = new Point(26, 405);
            Insertar.Name = "Insertar";
            Insertar.Size = new Size(75, 23);
            Insertar.TabIndex = 6;
            Insertar.Text = "Insertar";
            Insertar.UseVisualStyleBackColor = true;
            Insertar.Click += Insertar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(239, 236);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(371, 150);
            dgvClientes.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(136, 405);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(239, 405);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(75, 23);
            Eliminar.TabIndex = 9;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(356, 405);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(484, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVertodos
            // 
            btnVertodos.Location = new Point(627, 407);
            btnVertodos.Name = "btnVertodos";
            btnVertodos.Size = new Size(75, 23);
            btnVertodos.TabIndex = 12;
            btnVertodos.Text = "Ver Todos";
            btnVertodos.UseVisualStyleBackColor = true;
            btnVertodos.Click += btnVertodos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVertodos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(Eliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvClientes);
            Controls.Add(Insertar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPersonID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Insertar;
        private DataGridView dgvClientes;
        private Button btnActualizar;
        private Button Eliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnVertodos;
    }
}
