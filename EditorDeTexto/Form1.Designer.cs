﻿namespace EditorDeTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            btn_abrir = new ToolStripButton();
            btn_salvar = new ToolStripButton();
            btn_imprimir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_copiar = new ToolStripButton();
            btn_colar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_negrito = new ToolStripButton();
            btn_italico = new ToolStripButton();
            btn_sublinhado = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_esquerda = new ToolStripButton();
            btn_centro = new ToolStripButton();
            bnt_direita = new ToolStripButton();
            tb_tamanhoFonte = new ToolStripTextBox();
            toolStripButton1 = new ToolStripButton();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog2 = new PrintDialog();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            tb_nomeFonte = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(0, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(995, 518);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(995, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, imprimirToolStripMenuItem, salvarToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(149, 26);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(149, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(149, 26);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(149, 26);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(146, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(149, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, desfazerToolStripMenuItem, rToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(150, 26);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(150, 26);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(150, 26);
            desfazerToolStripMenuItem.Text = "Desfazer";
            desfazerToolStripMenuItem.Click += desfazerToolStripMenuItem_Click;
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(150, 26);
            rToolStripMenuItem.Text = "Refazer";
            rToolStripMenuItem.Click += rToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(83, 24);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(177, 26);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(177, 26);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += itálicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(177, 26);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(177, 26);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(163, 26);
            centralizarToolStripMenuItem.Text = "Centralizar";
            centralizarToolStripMenuItem.Click += centralizarToolStripMenuItem_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(163, 26);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(163, 26);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += direitaToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, btn_abrir, btn_salvar, btn_imprimir, toolStripSeparator1, btn_copiar, btn_colar, toolStripSeparator2, btn_negrito, btn_italico, btn_sublinhado, toolStripSeparator3, btn_esquerda, btn_centro, bnt_direita, tb_nomeFonte, tb_tamanhoFonte, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(995, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btn_novo
            // 
            btn_novo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_novo.Image = (Image)resources.GetObject("btn_novo.Image");
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(29, 24);
            btn_novo.Text = "Novo";
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_abrir
            // 
            btn_abrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_abrir.Image = (Image)resources.GetObject("btn_abrir.Image");
            btn_abrir.ImageTransparentColor = Color.Magenta;
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(29, 24);
            btn_abrir.Text = "Abrir";
            btn_abrir.Click += btn_abrir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(29, 24);
            btn_salvar.Text = "Salvar";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_imprimir
            // 
            btn_imprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_imprimir.Image = (Image)resources.GetObject("btn_imprimir.Image");
            btn_imprimir.ImageTransparentColor = Color.Magenta;
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(29, 24);
            btn_imprimir.Text = "toolStripButton1";
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btn_copiar
            // 
            btn_copiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_copiar.Image = (Image)resources.GetObject("btn_copiar.Image");
            btn_copiar.ImageTransparentColor = Color.Magenta;
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(29, 24);
            btn_copiar.Text = "Copiar";
            btn_copiar.Click += btn_copiar_Click;
            // 
            // btn_colar
            // 
            btn_colar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_colar.Image = (Image)resources.GetObject("btn_colar.Image");
            btn_colar.ImageTransparentColor = Color.Magenta;
            btn_colar.Name = "btn_colar";
            btn_colar.Size = new Size(29, 24);
            btn_colar.Text = "Colar";
            btn_colar.Click += btn_colar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btn_negrito
            // 
            btn_negrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_negrito.Image = (Image)resources.GetObject("btn_negrito.Image");
            btn_negrito.ImageTransparentColor = Color.Magenta;
            btn_negrito.Name = "btn_negrito";
            btn_negrito.Size = new Size(29, 24);
            btn_negrito.Text = "Negrito";
            btn_negrito.Click += btn_negrito_Click;
            // 
            // btn_italico
            // 
            btn_italico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_italico.Image = (Image)resources.GetObject("btn_italico.Image");
            btn_italico.ImageTransparentColor = Color.Magenta;
            btn_italico.Name = "btn_italico";
            btn_italico.Size = new Size(29, 24);
            btn_italico.Text = "Italico";
            btn_italico.Click += btn_italico_Click;
            // 
            // btn_sublinhado
            // 
            btn_sublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_sublinhado.Image = (Image)resources.GetObject("btn_sublinhado.Image");
            btn_sublinhado.ImageTransparentColor = Color.Magenta;
            btn_sublinhado.Name = "btn_sublinhado";
            btn_sublinhado.Size = new Size(29, 24);
            btn_sublinhado.Text = "Sublinhado";
            btn_sublinhado.Click += btn_sublinhado_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btn_esquerda
            // 
            btn_esquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_esquerda.Image = (Image)resources.GetObject("btn_esquerda.Image");
            btn_esquerda.ImageTransparentColor = Color.Magenta;
            btn_esquerda.Name = "btn_esquerda";
            btn_esquerda.Size = new Size(29, 24);
            btn_esquerda.Text = "Esquerda";
            btn_esquerda.Click += btn_esquerda_Click;
            // 
            // btn_centro
            // 
            btn_centro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_centro.Image = (Image)resources.GetObject("btn_centro.Image");
            btn_centro.ImageTransparentColor = Color.Magenta;
            btn_centro.Name = "btn_centro";
            btn_centro.Size = new Size(29, 24);
            btn_centro.Text = "Centro";
            btn_centro.Click += btn_centro_Click;
            // 
            // bnt_direita
            // 
            bnt_direita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bnt_direita.Image = (Image)resources.GetObject("bnt_direita.Image");
            bnt_direita.ImageTransparentColor = Color.Magenta;
            bnt_direita.Name = "bnt_direita";
            bnt_direita.Size = new Size(29, 24);
            bnt_direita.Text = "Direita";
            bnt_direita.Click += bnt_direita_Click;
            // 
            // tb_tamanhoFonte
            // 
            tb_tamanhoFonte.BorderStyle = BorderStyle.FixedSingle;
            tb_tamanhoFonte.Name = "tb_tamanhoFonte";
            tb_tamanhoFonte.Size = new Size(40, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "TXT";
            saveFileDialog1.Filter = "(*.TXT)|*.TXT";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // tb_nomeFonte
            // 
            tb_nomeFonte.BorderStyle = BorderStyle.FixedSingle;
            tb_nomeFonte.Name = "tb_nomeFonte";
            tb_nomeFonte.Size = new Size(100, 27);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 579);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de texto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripButton btn_novo;
        private ToolStripButton btn_abrir;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_colar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_negrito;
        private ToolStripButton btn_italico;
        private ToolStripButton btn_sublinhado;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_esquerda;
        private ToolStripButton btn_centro;
        private ToolStripButton bnt_direita;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private ToolStripButton btn_imprimir;
        private ToolStripTextBox tb_tamanhoFonte;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox tb_nomeFonte;
    }
}