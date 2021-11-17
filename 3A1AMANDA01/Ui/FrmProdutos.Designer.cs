namespace _3A1AMANDA01.Ui
{
    partial class FrmProdutos
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(46, 15);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Código";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_id.Location = new System.Drawing.Point(15, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(43, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_nome.Location = new System.Drawing.Point(78, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(138, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(75, 23);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(41, 15);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_preco
            // 
            this.txt_preco.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_preco.Location = new System.Drawing.Point(234, 50);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(89, 20);
            this.txt_preco.TabIndex = 7;
            this.txt_preco.Text = "\r\n11,59";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(231, 25);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_preco.TabIndex = 6;
            this.lbl_preco.Text = "Preço";
            // 
            // txt_marca
            // 
            this.txt_marca.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_marca.Location = new System.Drawing.Point(342, 50);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(105, 20);
            this.txt_marca.TabIndex = 9;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(339, 23);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(42, 15);
            this.lbl_marca.TabIndex = 8;
            this.lbl_marca.Text = "Marca";
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_descricao.Location = new System.Drawing.Point(15, 116);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(432, 48);
            this.txt_descricao.TabIndex = 11;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(12, 88);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(62, 15);
            this.lbl_descricao.TabIndex = 10;
            this.lbl_descricao.Text = "Descrição";
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(15, 247);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(432, 180);
            this.dgv_produtos.TabIndex = 12;
            this.dgv_produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(15, 195);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(85, 31);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(193, 195);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(85, 31);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(362, 195);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(85, 31);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(463, 448);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
    }
}