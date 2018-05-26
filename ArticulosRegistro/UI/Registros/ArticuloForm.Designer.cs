namespace ArticulosRegistro.UI.Registros
{
    partial class ArticuloForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ArticuloIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaVenciDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.CantCotizTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ArticuloIdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DescripcionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PrecioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExistErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantCotErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantCotErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArticuloId";
            // 
            // ArticuloIdNumericUpDown
            // 
            this.ArticuloIdNumericUpDown.Location = new System.Drawing.Point(109, 34);
            this.ArticuloIdNumericUpDown.Name = "ArticuloIdNumericUpDown";
            this.ArticuloIdNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.ArticuloIdNumericUpDown.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(179, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Vencimiento";
            // 
            // FechaVenciDateTimePicker
            // 
            this.FechaVenciDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaVenciDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVenciDateTimePicker.Location = new System.Drawing.Point(169, 82);
            this.FechaVenciDateTimePicker.Name = "FechaVenciDateTimePicker";
            this.FechaVenciDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.FechaVenciDateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(101, 133);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(153, 20);
            this.DescripcionTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(101, 186);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(153, 20);
            this.PrecioTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad Cotizada";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(101, 241);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(153, 20);
            this.ExistenciaTextBox.TabIndex = 11;
            // 
            // CantCotizTextBox
            // 
            this.CantCotizTextBox.Location = new System.Drawing.Point(135, 290);
            this.CantCotizTextBox.Name = "CantCotizTextBox";
            this.CantCotizTextBox.Size = new System.Drawing.Size(119, 20);
            this.CantCotizTextBox.TabIndex = 12;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(13, 334);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(109, 334);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(206, 334);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ArticuloIdErrorProvider
            // 
            this.ArticuloIdErrorProvider.ContainerControl = this;
            // 
            // DescripcionErrorProvider
            // 
            this.DescripcionErrorProvider.ContainerControl = this;
            // 
            // PrecioErrorProvider
            // 
            this.PrecioErrorProvider.ContainerControl = this;
            // 
            // ExistErrorProvider
            // 
            this.ExistErrorProvider.ContainerControl = this;
            // 
            // CantCotErrorProvider
            // 
            this.CantCotErrorProvider.ContainerControl = this;
            // 
            // ArticuloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 375);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CantCotizTextBox);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaVenciDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ArticuloIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "ArticuloForm";
            this.Text = "ArticuloForm";
            this.Load += new System.EventHandler(this.ArticuloForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantCotErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ArticuloIdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaVenciDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.TextBox CantCotizTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider ArticuloIdErrorProvider;
        private System.Windows.Forms.ErrorProvider DescripcionErrorProvider;
        private System.Windows.Forms.ErrorProvider PrecioErrorProvider;
        private System.Windows.Forms.ErrorProvider ExistErrorProvider;
        private System.Windows.Forms.ErrorProvider CantCotErrorProvider;
    }
}