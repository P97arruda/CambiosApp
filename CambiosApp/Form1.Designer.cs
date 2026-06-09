namespace CambiosApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            buttonConverter = new Button();
            labelResultado = new Label();
            labelStatus = new Label();
            progressBar1 = new ProgressBar();
            buttonTroca = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(68, 93);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(114, 92);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(321, 23);
            textBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(68, 156);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 2;
            label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(68, 219);
            label3.Name = "label3";
            label3.Size = new Size(134, 19);
            label3.TabIndex = 3;
            label3.Text = "Moeda de destino:";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(196, 152);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(239, 23);
            comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(196, 215);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(239, 23);
            comboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            buttonConverter.Enabled = false;
            buttonConverter.Location = new Point(493, 92);
            buttonConverter.Name = "buttonConverter";
            buttonConverter.Size = new Size(127, 44);
            buttonConverter.TabIndex = 6;
            buttonConverter.Text = "Converter ";
            buttonConverter.UseVisualStyleBackColor = true;
            buttonConverter.Click += buttonConverter_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelResultado.Location = new Point(93, 309);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(315, 19);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 388);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(477, 380);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(192, 23);
            progressBar1.TabIndex = 9;
            // 
            // buttonTroca
            // 
            buttonTroca.Enabled = false;
            buttonTroca.ImageKey = "5735261.png";
            buttonTroca.ImageList = imageList1;
            buttonTroca.Location = new Point(493, 146);
            buttonTroca.Name = "buttonTroca";
            buttonTroca.Size = new Size(127, 40);
            buttonTroca.TabIndex = 10;
            buttonTroca.UseVisualStyleBackColor = true;
            buttonTroca.Click += buttonTroca_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "5735261.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 449);
            Controls.Add(buttonTroca);
            Controls.Add(progressBar1);
            Controls.Add(labelStatus);
            Controls.Add(labelResultado);
            Controls.Add(buttonConverter);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxValor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Câmbios ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxValor;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private Button buttonConverter;
        private Label labelResultado;
        private Label labelStatus;
        private ProgressBar progressBar1;
        private Button buttonTroca;
        private ImageList imageList1;
    }
}
