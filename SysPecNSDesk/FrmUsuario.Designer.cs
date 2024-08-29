﻿namespace SysPecNSDesk
{
    partial class FrmUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            btn_Inserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_ID = new TextBox();
            txt_Nome = new TextBox();
            txt_Email = new TextBox();
            cmbNivel = new ComboBox();
            label6 = new Label();
            txt_Senha = new TextBox();
            txt_confirma_senha = new TextBox();
            chkAtivo = new CheckBox();
            btn_editar = new Button();
            btn_Deletar = new Button();
            txt_Busca = new TextBox();
            btn_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.GridColor = SystemColors.InactiveCaption;
            dgvUsuarios.Location = new Point(34, 274);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(501, 124);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.White;
            btn_Inserir.FlatAppearance.BorderColor = Color.White;
            btn_Inserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.Image = Properties.Resources.Add;
            btn_Inserir.Location = new Point(106, 177);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(64, 59);
            btn_Inserir.TabIndex = 5;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 70);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 70);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Nivel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 123);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Senha";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(131, 41);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(60, 23);
            txt_ID.TabIndex = 7;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(197, 41);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(245, 23);
            txt_Nome.TabIndex = 0;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(131, 85);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(198, 23);
            txt_Email.TabIndex = 1;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(342, 85);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(109, 23);
            cmbNivel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 123);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 11;
            label6.Text = "Confirmar Senha";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(131, 141);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(104, 23);
            txt_Senha.TabIndex = 3;
            txt_Senha.UseSystemPasswordChar = true;
            // 
            // txt_confirma_senha
            // 
            txt_confirma_senha.Location = new Point(241, 141);
            txt_confirma_senha.Name = "txt_confirma_senha";
            txt_confirma_senha.Size = new Size(100, 23);
            txt_confirma_senha.TabIndex = 4;
            txt_confirma_senha.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(359, 141);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(196, 189);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(64, 34);
            btn_editar.TabIndex = 6;
            btn_editar.Text = "&Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            btn_Deletar.Location = new Point(274, 189);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(64, 34);
            btn_Deletar.TabIndex = 7;
            btn_Deletar.Text = "De&letar";
            btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // txt_Busca
            // 
            txt_Busca.Location = new Point(34, 248);
            txt_Busca.Name = "txt_Busca";
            txt_Busca.Size = new Size(501, 23);
            txt_Busca.TabIndex = 8;
            txt_Busca.TextChanged += txt_Busca_TextChanged;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(352, 189);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(64, 34);
            btn_Cancelar.TabIndex = 12;
            btn_Cancelar.Text = "&Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancelar;
            ClientSize = new Size(569, 450);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_Busca);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_editar);
            Controls.Add(chkAtivo);
            Controls.Add(txt_confirma_senha);
            Controls.Add(txt_Senha);
            Controls.Add(label6);
            Controls.Add(cmbNivel);
            Controls.Add(txt_Email);
            Controls.Add(txt_Nome);
            Controls.Add(txt_ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Inserir);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Button btn_Inserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_ID;
        private TextBox txt_Nome;
        private TextBox txt_Email;
        private ComboBox cmbNivel;
        private Label label6;
        private TextBox txt_Senha;
        private TextBox txt_confirma_senha;
        private CheckBox chkAtivo;
        private Button btn_editar;
        private Button btn_Deletar;
        private TextBox txt_Busca;
        private Button btn_Cancelar;
    }
}