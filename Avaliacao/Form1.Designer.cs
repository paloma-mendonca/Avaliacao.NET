namespace Avaliacao
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonAbreArq = new Button();
            buttonGravar = new Button();
            listNumbs = new ListBox();
            buttonAdd = new Button();
            txtInt1 = new Controle.txtInt();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            buttonCarregaGrid = new Button();
            buttonCriaJson = new Button();
            label3 = new Label();
            tabPage3 = new TabPage();
            cxCEP = new TextBox();
            button1 = new Button();
            txtIntCEP = new Controle.txtInt();
            label5 = new Label();
            label4 = new Label();
            tabPage4 = new TabPage();
            dataGridView2 = new DataGridView();
            buttonAPI = new Button();
            label6 = new Label();
            tabPage5 = new TabPage();
            txtInfo = new Label();
            txtErro = new Label();
            txtComeco = new Label();
            label7 = new Label();
            buttonBaixaImg = new Button();
            base64 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(16, 46);
            tabControl1.MaximumSize = new Size(950, 500);
            tabControl1.MinimumSize = new Size(950, 500);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonAbreArq);
            tabPage1.Controls.Add(buttonGravar);
            tabPage1.Controls.Add(listNumbs);
            tabPage1.Controls.Add(buttonAdd);
            tabPage1.Controls.Add(txtInt1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Q1 e Q2";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAbreArq
            // 
            buttonAbreArq.Location = new Point(141, 406);
            buttonAbreArq.Name = "buttonAbreArq";
            buttonAbreArq.Size = new Size(94, 29);
            buttonAbreArq.TabIndex = 5;
            buttonAbreArq.Text = "Abrir Arquivo";
            buttonAbreArq.UseVisualStyleBackColor = true;
            buttonAbreArq.Visible = false;
            buttonAbreArq.Click += buttonAbreArq_Click;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(33, 406);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(94, 29);
            buttonGravar.TabIndex = 5;
            buttonGravar.Text = "Gravar Lista";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Visible = false;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // listNumbs
            // 
            listNumbs.FormattingEnabled = true;
            listNumbs.ItemHeight = 15;
            listNumbs.Location = new Point(33, 120);
            listNumbs.Name = "listNumbs";
            listNumbs.Size = new Size(554, 259);
            listNumbs.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(271, 84);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Adicionar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtInt1
            // 
            txtInt1.Location = new Point(150, 84);
            txtInt1.Name = "txtInt1";
            txtInt1.Size = new Size(108, 23);
            txtInt1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Informe 1 número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(744, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(buttonCarregaGrid);
            tabPage2.Controls.Add(buttonCriaJson);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Q3, Q4 e Q5";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 272);
            dataGridView1.TabIndex = 2;
            // 
            // buttonCarregaGrid
            // 
            buttonCarregaGrid.Location = new Point(285, 148);
            buttonCarregaGrid.Name = "buttonCarregaGrid";
            buttonCarregaGrid.Size = new Size(234, 23);
            buttonCarregaGrid.TabIndex = 1;
            buttonCarregaGrid.Text = "Carrega Grid";
            buttonCarregaGrid.UseVisualStyleBackColor = true;
            buttonCarregaGrid.Click += buttonCarregaGrid_Click;
            // 
            // buttonCriaJson
            // 
            buttonCriaJson.Location = new Point(37, 148);
            buttonCriaJson.Name = "buttonCriaJson";
            buttonCriaJson.Size = new Size(234, 23);
            buttonCriaJson.TabIndex = 1;
            buttonCriaJson.Text = "Criar arquivo data.json";
            buttonCriaJson.UseVisualStyleBackColor = true;
            buttonCriaJson.Click += buttonCriaJson_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 25);
            label3.Name = "label3";
            label3.Size = new Size(740, 105);
            label3.TabIndex = 0;
            label3.Text = resources.GetString("label3.Text");
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cxCEP);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(txtIntCEP);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(942, 472);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Q6";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cxCEP
            // 
            cxCEP.Location = new Point(43, 174);
            cxCEP.Multiline = true;
            cxCEP.Name = "cxCEP";
            cxCEP.Size = new Size(530, 232);
            cxCEP.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(264, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIntCEP
            // 
            txtIntCEP.Location = new Point(138, 127);
            txtIntCEP.Name = "txtIntCEP";
            txtIntCEP.Size = new Size(112, 23);
            txtIntCEP.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 130);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 1;
            label5.Text = "Informe o CEP: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 29);
            label4.Name = "label4";
            label4.Size = new Size(633, 75);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Controls.Add(buttonAPI);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(942, 472);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Q7";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 185);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(735, 270);
            dataGridView2.TabIndex = 2;
            // 
            // buttonAPI
            // 
            buttonAPI.Location = new Point(39, 148);
            buttonAPI.Name = "buttonAPI";
            buttonAPI.Size = new Size(253, 23);
            buttonAPI.TabIndex = 1;
            buttonAPI.Text = "Consultar e Mostrar";
            buttonAPI.UseVisualStyleBackColor = true;
            buttonAPI.Click += buttonAPI_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 26);
            label6.Name = "label6";
            label6.Size = new Size(447, 105);
            label6.TabIndex = 0;
            label6.Text = resources.GetString("label6.Text");
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(base64);
            tabPage5.Controls.Add(buttonBaixaImg);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(942, 472);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Q8";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.AutoSize = true;
            txtInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtInfo.ForeColor = Color.Red;
            txtInfo.Location = new Point(17, 18);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(0, 19);
            txtInfo.TabIndex = 1;
            // 
            // txtErro
            // 
            txtErro.AutoSize = true;
            txtErro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtErro.ForeColor = Color.Red;
            txtErro.Location = new Point(16, 18);
            txtErro.Name = "txtErro";
            txtErro.Size = new Size(0, 19);
            txtErro.TabIndex = 1;
            txtErro.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtComeco
            // 
            txtComeco.AutoSize = true;
            txtComeco.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtComeco.ForeColor = Color.Green;
            txtComeco.Location = new Point(21, 22);
            txtComeco.Name = "txtComeco";
            txtComeco.Size = new Size(164, 19);
            txtComeco.TabIndex = 2;
            txtComeco.Text = "Pronto para Começar!!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 27);
            label7.Name = "label7";
            label7.Size = new Size(708, 30);
            label7.TabIndex = 0;
            label7.Text = resources.GetString("label7.Text");
            // 
            // buttonBaixaImg
            // 
            buttonBaixaImg.Location = new Point(34, 116);
            buttonBaixaImg.Name = "buttonBaixaImg";
            buttonBaixaImg.Size = new Size(239, 25);
            buttonBaixaImg.TabIndex = 1;
            buttonBaixaImg.Text = "Baixar Imagem e Gravar";
            buttonBaixaImg.UseVisualStyleBackColor = true;
            buttonBaixaImg.Click += buttonBaixaImg_Click;
            // 
            // base64
            // 
            base64.Location = new Point(34, 178);
            base64.Multiline = true;
            base64.Name = "base64";
            base64.Size = new Size(575, 245);
            base64.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(txtComeco);
            Controls.Add(txtErro);
            Controls.Add(txtInfo);
            Controls.Add(tabControl1);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label2;
        private Label label1;
        private Button buttonAbreArq;
        private Button buttonGravar;
        private ListBox listNumbs;
        private Button buttonAdd;
        private Controle.txtInt txtInt1;
        private Label txtInfo;
        private Label txtErro;
        private Label txtComeco;
        private Button buttonCarregaGrid;
        private Button buttonCriaJson;
        private Label label3;
        private DataGridView dataGridView1;
        private Controle.txtInt txtIntCEP;
        private Label label5;
        private Label label4;
        private TextBox cxCEP;
        private Button button1;
        private DataGridView dataGridView2;
        private Button buttonAPI;
        private Label label6;
        private TextBox base64;
        private Button buttonBaixaImg;
        private Label label7;
    }
}