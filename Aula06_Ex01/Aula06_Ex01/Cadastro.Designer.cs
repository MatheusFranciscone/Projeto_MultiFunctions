namespace Aula06_Ex01
{
    partial class frmCadastro
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tdbTabela = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimparCad = new System.Windows.Forms.Button();
            this.btnSairCad = new System.Windows.Forms.Button();
            this.tbcCadastro.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.tdbTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tbpRegistro);
            this.tbcCadastro.Controls.Add(this.tdbTabela);
            this.tbcCadastro.Location = new System.Drawing.Point(12, 12);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(561, 255);
            this.tbcCadastro.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.btnAdicionar);
            this.tbpRegistro.Controls.Add(this.txtCodigo);
            this.tbpRegistro.Controls.Add(this.txtNome);
            this.tbpRegistro.Controls.Add(this.lblNome);
            this.tbpRegistro.Controls.Add(this.lblCodigo);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(553, 229);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Entrada de Dados";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(230, 153);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(119, 47);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(157, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(261, 32);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(157, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 32);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(75, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(75, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // tdbTabela
            // 
            this.tdbTabela.Controls.Add(this.btnLimpar);
            this.tdbTabela.Controls.Add(this.btnEliminar);
            this.tdbTabela.Controls.Add(this.dgvTabela);
            this.tdbTabela.Location = new System.Drawing.Point(4, 22);
            this.tdbTabela.Name = "tdbTabela";
            this.tdbTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tdbTabela.Size = new System.Drawing.Size(553, 229);
            this.tdbTabela.TabIndex = 1;
            this.tdbTabela.Text = "Consultar Dados";
            this.tdbTabela.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(458, 195);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(377, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome});
            this.dgvTabela.Location = new System.Drawing.Point(0, 3);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(550, 186);
            this.dgvTabela.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // btnLimparCad
            // 
            this.btnLimparCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCad.Location = new System.Drawing.Point(366, 273);
            this.btnLimparCad.Name = "btnLimparCad";
            this.btnLimparCad.Size = new System.Drawing.Size(97, 37);
            this.btnLimparCad.TabIndex = 3;
            this.btnLimparCad.Text = "Limpar";
            this.btnLimparCad.UseVisualStyleBackColor = true;
            this.btnLimparCad.Click += new System.EventHandler(this.btnLimparCad_Click);
            // 
            // btnSairCad
            // 
            this.btnSairCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCad.Location = new System.Drawing.Point(465, 273);
            this.btnSairCad.Name = "btnSairCad";
            this.btnSairCad.Size = new System.Drawing.Size(104, 37);
            this.btnSairCad.TabIndex = 4;
            this.btnSairCad.Text = "Sair";
            this.btnSairCad.UseVisualStyleBackColor = true;
            this.btnSairCad.Click += new System.EventHandler(this.btnSairCad_Click);
            // 
            // frmCadastro
            // 
            this.AcceptButton = this.btnAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 330);
            this.Controls.Add(this.btnSairCad);
            this.Controls.Add(this.btnLimparCad);
            this.Controls.Add(this.tbcCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro";
            this.tbcCadastro.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.tbpRegistro.PerformLayout();
            this.tdbTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tdbTabela;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button btnLimparCad;
        private System.Windows.Forms.Button btnSairCad;
    }
}