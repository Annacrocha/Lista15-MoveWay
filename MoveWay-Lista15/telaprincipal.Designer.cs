namespace MoveWay_Lista15
{
    partial class MoveWay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveWay));
            lblsetor = new Label();
            txtSetor = new TextBox();
            btListar = new Button();
            btListarTodos = new Button();
            dataGridView1 = new DataGridView();
            lblID = new Label();
            lblNome = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            btGravar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblsetor
            // 
            lblsetor.AutoSize = true;
            lblsetor.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsetor.Location = new Point(74, 59);
            lblsetor.Name = "lblsetor";
            lblsetor.Size = new Size(159, 17);
            lblsetor.TabIndex = 0;
            lblsetor.Text = "Digite o nome do setor:";
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(239, 59);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(363, 23);
            txtSetor.TabIndex = 1;
            // 
            // btListar
            // 
            btListar.BackColor = Color.Gold;
            btListar.Location = new Point(626, 59);
            btListar.Name = "btListar";
            btListar.Size = new Size(75, 23);
            btListar.TabIndex = 2;
            btListar.Text = "Listar";
            btListar.UseVisualStyleBackColor = false;
            btListar.Click += btListar_Click;
            // 
            // btListarTodos
            // 
            btListarTodos.BackColor = Color.Gold;
            btListarTodos.Location = new Point(734, 59);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(92, 23);
            btListarTodos.TabIndex = 3;
            btListarTodos.Text = "Listar Todos";
            btListarTodos.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(88, 305);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 17);
            lblID.TabIndex = 5;
            lblID.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(239, 305);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(117, 304);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(292, 305);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 23);
            txtNome.TabIndex = 8;
            // 
            // btGravar
            // 
            btGravar.BackColor = Color.Gold;
            btGravar.Location = new Point(74, 397);
            btGravar.Name = "btGravar";
            btGravar.Size = new Size(75, 23);
            btGravar.TabIndex = 9;
            btGravar.Text = "Gravar";
            btGravar.UseVisualStyleBackColor = false;
            btGravar.Click += btGravar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Gold;
            btEditar.Location = new Point(292, 397);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(75, 23);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Gold;
            btExcluir.Location = new Point(527, 397);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(644, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MoveWay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 469);
            Controls.Add(pictureBox1);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btGravar);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lblNome);
            Controls.Add(lblID);
            Controls.Add(dataGridView1);
            Controls.Add(btListarTodos);
            Controls.Add(btListar);
            Controls.Add(txtSetor);
            Controls.Add(lblsetor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoveWay";
            Text = "MoveWay";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsetor;
        private TextBox txtSetor;
        private Button btListar;
        private Button btListarTodos;
        private DataGridView dataGridView1;
        private Label lblID;
        private Label lblNome;
        private TextBox txtID;
        private TextBox txtNome;
        private Button btGravar;
        private Button btEditar;
        private Button btExcluir;
        private PictureBox pictureBox1;
    }
}
