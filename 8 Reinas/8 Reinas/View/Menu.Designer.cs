namespace _8_Reinas
{
    partial class formMenu
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
            System.Windows.Forms.Label iteracionesLbl;
            System.Windows.Forms.Label poblacionLbl;
            System.Windows.Forms.Label probCruceLbl;
            System.Windows.Forms.Label probMutacionLbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxDatos = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.iteracionesNumUD = new System.Windows.Forms.NumericUpDown();
            this.poblacionNumUD = new System.Windows.Forms.NumericUpDown();
            this.probCruceNumUD = new System.Windows.Forms.NumericUpDown();
            this.probMutacionNumUD = new System.Windows.Forms.NumericUpDown();
            this.picBxAbout = new System.Windows.Forms.PictureBox();
            this.datoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iteracionesLbl = new System.Windows.Forms.Label();
            poblacionLbl = new System.Windows.Forms.Label();
            probCruceLbl = new System.Windows.Forms.Label();
            probMutacionLbl = new System.Windows.Forms.Label();
            this.grpBxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionesNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poblacionNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCruceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probMutacionNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Bodoni MT Black", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(447, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "8 REINAS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxDatos
            // 
            this.grpBxDatos.Controls.Add(iteracionesLbl);
            this.grpBxDatos.Controls.Add(this.iteracionesNumUD);
            this.grpBxDatos.Controls.Add(poblacionLbl);
            this.grpBxDatos.Controls.Add(this.poblacionNumUD);
            this.grpBxDatos.Controls.Add(probCruceLbl);
            this.grpBxDatos.Controls.Add(this.probCruceNumUD);
            this.grpBxDatos.Controls.Add(probMutacionLbl);
            this.grpBxDatos.Controls.Add(this.probMutacionNumUD);
            this.grpBxDatos.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxDatos.Location = new System.Drawing.Point(64, 83);
            this.grpBxDatos.Name = "grpBxDatos";
            this.grpBxDatos.Size = new System.Drawing.Size(320, 185);
            this.grpBxDatos.TabIndex = 1;
            this.grpBxDatos.TabStop = false;
            this.grpBxDatos.Text = "DATOS";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(149, 278);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 55);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ACEPTAR";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // iteracionesLbl
            // 
            iteracionesLbl.AutoSize = true;
            iteracionesLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iteracionesLbl.Location = new System.Drawing.Point(25, 40);
            iteracionesLbl.Name = "iteracionesLbl";
            iteracionesLbl.Size = new System.Drawing.Size(94, 21);
            iteracionesLbl.TabIndex = 0;
            iteracionesLbl.Text = "Iteraciones:";
            // 
            // iteracionesNumUD
            // 
            this.iteracionesNumUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datoBindingSource, "Iteraciones", true));
            this.iteracionesNumUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteracionesNumUD.Location = new System.Drawing.Point(162, 40);
            this.iteracionesNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iteracionesNumUD.Name = "iteracionesNumUD";
            this.iteracionesNumUD.ReadOnly = true;
            this.iteracionesNumUD.Size = new System.Drawing.Size(120, 24);
            this.iteracionesNumUD.TabIndex = 1;
            this.iteracionesNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // poblacionLbl
            // 
            poblacionLbl.AutoSize = true;
            poblacionLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            poblacionLbl.Location = new System.Drawing.Point(25, 71);
            poblacionLbl.Name = "poblacionLbl";
            poblacionLbl.Size = new System.Drawing.Size(85, 21);
            poblacionLbl.TabIndex = 2;
            poblacionLbl.Text = "Poblacion:";
            // 
            // poblacionNumUD
            // 
            this.poblacionNumUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datoBindingSource, "Poblacion", true));
            this.poblacionNumUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionNumUD.Location = new System.Drawing.Point(162, 71);
            this.poblacionNumUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.poblacionNumUD.Name = "poblacionNumUD";
            this.poblacionNumUD.ReadOnly = true;
            this.poblacionNumUD.Size = new System.Drawing.Size(120, 24);
            this.poblacionNumUD.TabIndex = 3;
            this.poblacionNumUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // probCruceLbl
            // 
            probCruceLbl.AutoSize = true;
            probCruceLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            probCruceLbl.Location = new System.Drawing.Point(25, 102);
            probCruceLbl.Name = "probCruceLbl";
            probCruceLbl.Size = new System.Drawing.Size(98, 21);
            probCruceLbl.TabIndex = 4;
            probCruceLbl.Text = "Prob. Cruce:";
            // 
            // probCruceNumUD
            // 
            this.probCruceNumUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datoBindingSource, "ProbCruce", true));
            this.probCruceNumUD.DecimalPlaces = 2;
            this.probCruceNumUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probCruceNumUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probCruceNumUD.Location = new System.Drawing.Point(162, 102);
            this.probCruceNumUD.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.probCruceNumUD.Minimum = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            this.probCruceNumUD.Name = "probCruceNumUD";
            this.probCruceNumUD.ReadOnly = true;
            this.probCruceNumUD.Size = new System.Drawing.Size(120, 24);
            this.probCruceNumUD.TabIndex = 5;
            this.probCruceNumUD.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            // 
            // probMutacionLbl
            // 
            probMutacionLbl.AutoSize = true;
            probMutacionLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            probMutacionLbl.Location = new System.Drawing.Point(25, 133);
            probMutacionLbl.Name = "probMutacionLbl";
            probMutacionLbl.Size = new System.Drawing.Size(123, 21);
            probMutacionLbl.TabIndex = 6;
            probMutacionLbl.Text = "Prob. Mutacion:";
            // 
            // probMutacionNumUD
            // 
            this.probMutacionNumUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datoBindingSource, "ProbMutacion", true));
            this.probMutacionNumUD.DecimalPlaces = 2;
            this.probMutacionNumUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probMutacionNumUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probMutacionNumUD.Location = new System.Drawing.Point(162, 133);
            this.probMutacionNumUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.probMutacionNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.probMutacionNumUD.Name = "probMutacionNumUD";
            this.probMutacionNumUD.ReadOnly = true;
            this.probMutacionNumUD.Size = new System.Drawing.Size(120, 24);
            this.probMutacionNumUD.TabIndex = 7;
            this.probMutacionNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // picBxAbout
            // 
            this.picBxAbout.Image = global::_8_Reinas.Properties.Resources.Autor;
            this.picBxAbout.Location = new System.Drawing.Point(9, 278);
            this.picBxAbout.Name = "picBxAbout";
            this.picBxAbout.Size = new System.Drawing.Size(40, 55);
            this.picBxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxAbout.TabIndex = 3;
            this.picBxAbout.TabStop = false;
            // 
            // datoBindingSource
            // 
            this.datoBindingSource.DataSource = typeof(_8_Reinas.Model.Dato);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.picBxAbout);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.grpBxDatos);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.grpBxDatos.ResumeLayout(false);
            this.grpBxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracionesNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poblacionNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCruceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probMutacionNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxDatos;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox picBxAbout;
        private System.Windows.Forms.NumericUpDown iteracionesNumUD;
        private System.Windows.Forms.BindingSource datoBindingSource;
        private System.Windows.Forms.NumericUpDown poblacionNumUD;
        private System.Windows.Forms.NumericUpDown probCruceNumUD;
        private System.Windows.Forms.NumericUpDown probMutacionNumUD;
    }
}

