
namespace Adaline
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxEntradas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonPesos = new System.Windows.Forms.Button();
            this.numericUpDownError = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownEpocas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLR = new System.Windows.Forms.NumericUpDown();
            this.labelW0 = new System.Windows.Forms.Label();
            this.labelW1 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(500, 200);
            this.pictureBoxError.TabIndex = 1;
            this.pictureBoxError.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxError);
            this.groupBox1.Location = new System.Drawing.Point(527, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error";
            // 
            // listBoxEntradas
            // 
            this.listBoxEntradas.FormattingEnabled = true;
            this.listBoxEntradas.Location = new System.Drawing.Point(533, 12);
            this.listBoxEntradas.Name = "listBoxEntradas";
            this.listBoxEntradas.Size = new System.Drawing.Size(198, 264);
            this.listBoxEntradas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "L.R.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonIniciar);
            this.groupBox2.Controls.Add(this.buttonPesos);
            this.groupBox2.Controls.Add(this.numericUpDownError);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownEpocas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownLR);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(754, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 178);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(161, 118);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 11;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonPesos
            // 
            this.buttonPesos.Location = new System.Drawing.Point(37, 118);
            this.buttonPesos.Name = "buttonPesos";
            this.buttonPesos.Size = new System.Drawing.Size(75, 23);
            this.buttonPesos.TabIndex = 10;
            this.buttonPesos.Text = "Pesos";
            this.buttonPesos.UseVisualStyleBackColor = true;
            this.buttonPesos.Click += new System.EventHandler(this.buttonPesos_Click);
            // 
            // numericUpDownError
            // 
            this.numericUpDownError.DecimalPlaces = 2;
            this.numericUpDownError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownError.Location = new System.Drawing.Point(65, 71);
            this.numericUpDownError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownError.Name = "numericUpDownError";
            this.numericUpDownError.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownError.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "E.M.";
            // 
            // numericUpDownEpocas
            // 
            this.numericUpDownEpocas.Location = new System.Drawing.Point(195, 30);
            this.numericUpDownEpocas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEpocas.Name = "numericUpDownEpocas";
            this.numericUpDownEpocas.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownEpocas.TabIndex = 7;
            this.numericUpDownEpocas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Epocas";
            // 
            // numericUpDownLR
            // 
            this.numericUpDownLR.DecimalPlaces = 2;
            this.numericUpDownLR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownLR.Location = new System.Drawing.Point(65, 31);
            this.numericUpDownLR.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLR.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownLR.Name = "numericUpDownLR";
            this.numericUpDownLR.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownLR.TabIndex = 5;
            this.numericUpDownLR.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownLR.ValueChanged += new System.EventHandler(this.numericUpDownLR_ValueChanged);
            // 
            // labelW0
            // 
            this.labelW0.AutoSize = true;
            this.labelW0.Location = new System.Drawing.Point(774, 231);
            this.labelW0.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW0.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW0.Name = "labelW0";
            this.labelW0.Size = new System.Drawing.Size(50, 13);
            this.labelW0.TabIndex = 6;
            this.labelW0.Text = "W0";
            // 
            // labelW1
            // 
            this.labelW1.AutoSize = true;
            this.labelW1.Location = new System.Drawing.Point(862, 231);
            this.labelW1.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW1.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW1.Name = "labelW1";
            this.labelW1.Size = new System.Drawing.Size(50, 13);
            this.labelW1.TabIndex = 7;
            this.labelW1.Text = "W1";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(958, 231);
            this.labelW2.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW2.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(50, 13);
            this.labelW2.TabIndex = 8;
            this.labelW2.Text = "W2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 525);
            this.Controls.Add(this.labelW2);
            this.Controls.Add(this.labelW1);
            this.Controls.Add(this.labelW0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxEntradas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Actividad 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxEntradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonPesos;
        private System.Windows.Forms.NumericUpDown numericUpDownError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownEpocas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLR;
        private System.Windows.Forms.Label labelW0;
        private System.Windows.Forms.Label labelW1;
        private System.Windows.Forms.Label labelW2;
    }
}

