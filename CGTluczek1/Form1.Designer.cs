namespace CGTluczek1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonBright = new System.Windows.Forms.Button();
            this.buttonBrght2 = new System.Windows.Forms.Button();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.buttonGammaDn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCtUp = new System.Windows.Forms.Button();
            this.buttonCtDn = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonGBlur = new System.Windows.Forms.Button();
            this.buttonSharp = new System.Windows.Forms.Button();
            this.buttonEdge = new System.Windows.Forms.Button();
            this.buttonEmboss = new System.Windows.Forms.Button();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonResFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(891, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGray.Location = new System.Drawing.Point(0, 17);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(120, 23);
            this.buttonGray.TabIndex = 2;
            this.buttonGray.Text = "Gray";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.ButtonGray_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(891, 555);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(120, 23);
            this.buttonRevert.TabIndex = 4;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.ButtonRevert_Click);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInverse.Location = new System.Drawing.Point(136, 17);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(120, 23);
            this.buttonInverse.TabIndex = 5;
            this.buttonInverse.Text = "Inverse";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.ButtonInverse_Click);
            // 
            // buttonBright
            // 
            this.buttonBright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBright.Location = new System.Drawing.Point(0, 43);
            this.buttonBright.Name = "buttonBright";
            this.buttonBright.Size = new System.Drawing.Size(120, 23);
            this.buttonBright.TabIndex = 6;
            this.buttonBright.Text = "Brght Up";
            this.buttonBright.UseVisualStyleBackColor = true;
            this.buttonBright.Click += new System.EventHandler(this.ButtonBright_Click);
            // 
            // buttonBrght2
            // 
            this.buttonBrght2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrght2.Location = new System.Drawing.Point(136, 43);
            this.buttonBrght2.Name = "buttonBrght2";
            this.buttonBrght2.Size = new System.Drawing.Size(120, 23);
            this.buttonBrght2.TabIndex = 7;
            this.buttonBrght2.Text = "Brght Down";
            this.buttonBrght2.UseVisualStyleBackColor = true;
            this.buttonBrght2.Click += new System.EventHandler(this.ButtonBrght2_Click);
            // 
            // buttonGamma
            // 
            this.buttonGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGamma.Location = new System.Drawing.Point(0, 72);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(120, 23);
            this.buttonGamma.TabIndex = 8;
            this.buttonGamma.Text = "Gamma Up";
            this.buttonGamma.UseVisualStyleBackColor = true;
            this.buttonGamma.Click += new System.EventHandler(this.ButtonGamma_Click);
            // 
            // buttonGammaDn
            // 
            this.buttonGammaDn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGammaDn.Location = new System.Drawing.Point(136, 72);
            this.buttonGammaDn.Name = "buttonGammaDn";
            this.buttonGammaDn.Size = new System.Drawing.Size(120, 23);
            this.buttonGammaDn.TabIndex = 9;
            this.buttonGammaDn.Text = "Gamma Dn";
            this.buttonGammaDn.UseVisualStyleBackColor = true;
            this.buttonGammaDn.Click += new System.EventHandler(this.ButtonGammaDn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(891, 613);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCtUp
            // 
            this.buttonCtUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCtUp.Location = new System.Drawing.Point(0, 101);
            this.buttonCtUp.Name = "buttonCtUp";
            this.buttonCtUp.Size = new System.Drawing.Size(120, 23);
            this.buttonCtUp.TabIndex = 11;
            this.buttonCtUp.Text = "Contr Up";
            this.buttonCtUp.UseVisualStyleBackColor = true;
            this.buttonCtUp.Click += new System.EventHandler(this.ButtonCtUp_Click);
            // 
            // buttonCtDn
            // 
            this.buttonCtDn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCtDn.Location = new System.Drawing.Point(136, 101);
            this.buttonCtDn.Name = "buttonCtDn";
            this.buttonCtDn.Size = new System.Drawing.Size(120, 23);
            this.buttonCtDn.TabIndex = 12;
            this.buttonCtDn.Text = "Contr Dn";
            this.buttonCtDn.UseVisualStyleBackColor = true;
            this.buttonCtDn.Click += new System.EventHandler(this.ButtonCtDn_Click);
            // 
            // buttonBlur
            // 
            this.buttonBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlur.Location = new System.Drawing.Point(0, 130);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(120, 23);
            this.buttonBlur.TabIndex = 13;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.ButtonBlur_Click);
            // 
            // buttonGBlur
            // 
            this.buttonGBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGBlur.Location = new System.Drawing.Point(136, 130);
            this.buttonGBlur.Name = "buttonGBlur";
            this.buttonGBlur.Size = new System.Drawing.Size(120, 23);
            this.buttonGBlur.TabIndex = 14;
            this.buttonGBlur.Text = "G-Blur";
            this.buttonGBlur.UseVisualStyleBackColor = true;
            this.buttonGBlur.Click += new System.EventHandler(this.ButtonGBlur_Click);
            // 
            // buttonSharp
            // 
            this.buttonSharp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSharp.Location = new System.Drawing.Point(0, 159);
            this.buttonSharp.Name = "buttonSharp";
            this.buttonSharp.Size = new System.Drawing.Size(120, 23);
            this.buttonSharp.TabIndex = 15;
            this.buttonSharp.Text = "Sharp";
            this.buttonSharp.UseVisualStyleBackColor = true;
            this.buttonSharp.Click += new System.EventHandler(this.ButtonSharp_Click);
            // 
            // buttonEdge
            // 
            this.buttonEdge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdge.Location = new System.Drawing.Point(136, 159);
            this.buttonEdge.Name = "buttonEdge";
            this.buttonEdge.Size = new System.Drawing.Size(120, 23);
            this.buttonEdge.TabIndex = 16;
            this.buttonEdge.Text = "Edge";
            this.buttonEdge.UseVisualStyleBackColor = true;
            this.buttonEdge.Click += new System.EventHandler(this.ButtonEdge_Click);
            // 
            // buttonEmboss
            // 
            this.buttonEmboss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmboss.Location = new System.Drawing.Point(0, 188);
            this.buttonEmboss.Name = "buttonEmboss";
            this.buttonEmboss.Size = new System.Drawing.Size(120, 23);
            this.buttonEmboss.TabIndex = 17;
            this.buttonEmboss.Text = "Emboss";
            this.buttonEmboss.UseVisualStyleBackColor = true;
            this.buttonEmboss.Click += new System.EventHandler(this.ButtonEmboss_Click);
            // 
            // buttonFunc
            // 
            this.buttonFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFunc.Location = new System.Drawing.Point(136, 188);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(120, 23);
            this.buttonFunc.TabIndex = 18;
            this.buttonFunc.Text = "Func";
            this.buttonFunc.UseVisualStyleBackColor = true;
            this.buttonFunc.Click += new System.EventHandler(this.ButtonFunc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonBrght2);
            this.groupBox1.Controls.Add(this.buttonEmboss);
            this.groupBox1.Controls.Add(this.buttonEdge);
            this.groupBox1.Controls.Add(this.buttonGBlur);
            this.groupBox1.Controls.Add(this.buttonSharp);
            this.groupBox1.Controls.Add(this.buttonGammaDn);
            this.groupBox1.Controls.Add(this.buttonBlur);
            this.groupBox1.Controls.Add(this.buttonGamma);
            this.groupBox1.Controls.Add(this.buttonCtDn);
            this.groupBox1.Controls.Add(this.buttonCtUp);
            this.groupBox1.Controls.Add(this.buttonBright);
            this.groupBox1.Controls.Add(this.buttonInverse);
            this.groupBox1.Controls.Add(this.buttonGray);
            this.groupBox1.Controls.Add(this.buttonFunc);
            this.groupBox1.Location = new System.Drawing.Point(824, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 225);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(824, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseMove);
            // 
            // buttonResFunc
            // 
            this.buttonResFunc.Location = new System.Drawing.Point(891, 526);
            this.buttonResFunc.Name = "buttonResFunc";
            this.buttonResFunc.Size = new System.Drawing.Size(120, 23);
            this.buttonResFunc.TabIndex = 21;
            this.buttonResFunc.Text = "Reset Func";
            this.buttonResFunc.UseVisualStyleBackColor = true;
            this.buttonResFunc.Click += new System.EventHandler(this.ButtonResFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.buttonResFunc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "ImageFilterApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonBright;
        private System.Windows.Forms.Button buttonBrght2;
        private System.Windows.Forms.Button buttonGamma;
        private System.Windows.Forms.Button buttonGammaDn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCtUp;
        private System.Windows.Forms.Button buttonCtDn;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.Button buttonGBlur;
        private System.Windows.Forms.Button buttonSharp;
        private System.Windows.Forms.Button buttonEdge;
        private System.Windows.Forms.Button buttonEmboss;
        private System.Windows.Forms.Button buttonFunc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonResFunc;
    }
}

