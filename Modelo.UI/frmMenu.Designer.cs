namespace Modelo.UI
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.chkAtivoCateg = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.salvarCliente = new System.Windows.Forms.Button();
            this.chkAtivoCliente = new System.Windows.Forms.CheckBox();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEMax = new System.Windows.Forms.TextBox();
            this.txtEMin = new System.Windows.Forms.TextBox();
            this.txtEAtual = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtDescricaoRedu = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.salvarProduto = new System.Windows.Forms.Button();
            this.chkAtivoProduto = new System.Windows.Forms.CheckBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(57, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(3, 94);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(194, 20);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "Descrição";
            // 
            // chkAtivoCateg
            // 
            this.chkAtivoCateg.AutoSize = true;
            this.chkAtivoCateg.Location = new System.Drawing.Point(73, 120);
            this.chkAtivoCateg.Name = "chkAtivoCateg";
            this.chkAtivoCateg.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoCateg.TabIndex = 2;
            this.chkAtivoCateg.Text = "Ativo";
            this.chkAtivoCateg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.chkAtivoCateg);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtCelular);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.txtCidade);
            this.panel2.Controls.Add(this.txtCEP);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.txtComplemento);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.txtCPFCNPJ);
            this.panel2.Controls.Add(this.txtTipo);
            this.panel2.Controls.Add(this.salvarCliente);
            this.panel2.Controls.Add(this.chkAtivoCliente);
            this.panel2.Controls.Add(this.txtClienteNome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(296, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 423);
            this.panel2.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(104, 231);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 16;
            this.txtEstado.Text = "Estado";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "Email";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(4, 305);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 20);
            this.txtCelular.TabIndex = 14;
            this.txtCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(4, 267);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Text = "Telefone";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(4, 231);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(97, 20);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.Text = "Cidade";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(4, 192);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(200, 20);
            this.txtCEP.TabIndex = 11;
            this.txtCEP.Text = "CEP";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(104, 155);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(3, 155);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(98, 20);
            this.txtComplemento.TabIndex = 9;
            this.txtComplemento.Text = "Complemento";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(4, 117);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 8;
            this.txtEndereco.Text = "Endereço";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(104, 80);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCPFCNPJ.TabIndex = 7;
            this.txtCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(4, 80);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(97, 20);
            this.txtTipo.TabIndex = 6;
            this.txtTipo.Text = "Tipo";
            // 
            // salvarCliente
            // 
            this.salvarCliente.Location = new System.Drawing.Point(70, 397);
            this.salvarCliente.Name = "salvarCliente";
            this.salvarCliente.Size = new System.Drawing.Size(75, 23);
            this.salvarCliente.TabIndex = 4;
            this.salvarCliente.Text = "Salvar";
            this.salvarCliente.UseVisualStyleBackColor = true;
            this.salvarCliente.Click += new System.EventHandler(this.salvarCliente_Click);
            // 
            // chkAtivoCliente
            // 
            this.chkAtivoCliente.AutoSize = true;
            this.chkAtivoCliente.Location = new System.Drawing.Point(4, 354);
            this.chkAtivoCliente.Name = "chkAtivoCliente";
            this.chkAtivoCliente.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoCliente.TabIndex = 4;
            this.chkAtivoCliente.Text = "Ativo";
            this.chkAtivoCliente.UseVisualStyleBackColor = true;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(4, 36);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(200, 20);
            this.txtClienteNome.TabIndex = 5;
            this.txtClienteNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEMax);
            this.panel3.Controls.Add(this.txtEMin);
            this.panel3.Controls.Add(this.txtEAtual);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.txtValorVenda);
            this.panel3.Controls.Add(this.txtPorcentagem);
            this.panel3.Controls.Add(this.txtValorCusto);
            this.panel3.Controls.Add(this.txtUnidade);
            this.panel3.Controls.Add(this.txtDescricaoRedu);
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.salvarProduto);
            this.panel3.Controls.Add(this.chkAtivoProduto);
            this.panel3.Controls.Add(this.txtCategoria);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(588, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 423);
            this.panel3.TabIndex = 5;
            // 
            // txtEMax
            // 
            this.txtEMax.Location = new System.Drawing.Point(143, 270);
            this.txtEMax.Name = "txtEMax";
            this.txtEMax.Size = new System.Drawing.Size(54, 20);
            this.txtEMax.TabIndex = 17;
            this.txtEMax.Text = "E Max";
            // 
            // txtEMin
            // 
            this.txtEMin.Location = new System.Drawing.Point(76, 270);
            this.txtEMin.Name = "txtEMin";
            this.txtEMin.Size = new System.Drawing.Size(54, 20);
            this.txtEMin.TabIndex = 16;
            this.txtEMin.Text = "E Min";
            // 
            // txtEAtual
            // 
            this.txtEAtual.Location = new System.Drawing.Point(3, 270);
            this.txtEAtual.Name = "txtEAtual";
            this.txtEAtual.Size = new System.Drawing.Size(54, 20);
            this.txtEAtual.TabIndex = 15;
            this.txtEAtual.Text = "E Atual";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 218);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 20);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.Text = "Codigo de Barras";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(3, 192);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(194, 20);
            this.txtValorVenda.TabIndex = 12;
            this.txtValorVenda.Text = "Valor da Venda";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(3, 166);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(194, 20);
            this.txtPorcentagem.TabIndex = 11;
            this.txtPorcentagem.Text = "Porcentagem";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Location = new System.Drawing.Point(3, 140);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(194, 20);
            this.txtValorCusto.TabIndex = 10;
            this.txtValorCusto.Text = "Valor Custo";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(3, 114);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(194, 20);
            this.txtUnidade.TabIndex = 9;
            this.txtUnidade.Text = "Unidade";
            // 
            // txtDescricaoRedu
            // 
            this.txtDescricaoRedu.Location = new System.Drawing.Point(3, 88);
            this.txtDescricaoRedu.Name = "txtDescricaoRedu";
            this.txtDescricaoRedu.Size = new System.Drawing.Size(194, 20);
            this.txtDescricaoRedu.TabIndex = 8;
            this.txtDescricaoRedu.Text = "Descrição Reduzida";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(3, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(194, 20);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.Text = "Descrição";
            // 
            // salvarProduto
            // 
            this.salvarProduto.Location = new System.Drawing.Point(70, 397);
            this.salvarProduto.Name = "salvarProduto";
            this.salvarProduto.Size = new System.Drawing.Size(75, 23);
            this.salvarProduto.TabIndex = 5;
            this.salvarProduto.Text = "Salvar";
            this.salvarProduto.UseVisualStyleBackColor = true;
            this.salvarProduto.Click += new System.EventHandler(this.salvarProduto_Click);
            // 
            // chkAtivoProduto
            // 
            this.chkAtivoProduto.AutoSize = true;
            this.chkAtivoProduto.Location = new System.Drawing.Point(3, 354);
            this.chkAtivoProduto.Name = "chkAtivoProduto";
            this.chkAtivoProduto.Size = new System.Drawing.Size(50, 17);
            this.chkAtivoProduto.TabIndex = 6;
            this.chkAtivoProduto.Text = "Ativo";
            this.chkAtivoProduto.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(3, 36);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(194, 20);
            this.txtCategoria.TabIndex = 6;
            this.txtCategoria.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Produto";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.CheckBox chkAtivoCateg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkAtivoCliente;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salvarCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button salvarProduto;
        private System.Windows.Forms.CheckBox chkAtivoProduto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtEMax;
        private System.Windows.Forms.TextBox txtEMin;
        private System.Windows.Forms.TextBox txtEAtual;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtDescricaoRedu;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}

