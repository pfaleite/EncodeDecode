namespace EDTool
{
    partial class MnForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MnForm));
            this.TbSource = new System.Windows.Forms.TextBox();
            this.TbEncoded = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FadeIn = new System.Windows.Forms.Timer(this.components);
            this.LbHeader = new System.Windows.Forms.Label();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.FadeOut = new System.Windows.Forms.Timer(this.components);
            this.LbVersion = new System.Windows.Forms.Label();
            this.SvFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EncodeIco = new System.Windows.Forms.PictureBox();
            this.ClipboardIco = new System.Windows.Forms.PictureBox();
            this.SettingsIco = new System.Windows.Forms.PictureBox();
            this.SaveToFileIco = new System.Windows.Forms.PictureBox();
            this.MinimizeIco = new System.Windows.Forms.PictureBox();
            this.CloseBt = new System.Windows.Forms.PictureBox();
            this.AppIco = new System.Windows.Forms.PictureBox();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncodeIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClipboardIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveToFileIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIco)).BeginInit();
            this.SuspendLayout();
            // 
            // TbSource
            // 
            this.TbSource.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSource.Location = new System.Drawing.Point(40, 106);
            this.TbSource.Multiline = true;
            this.TbSource.Name = "TbSource";
            this.TbSource.Size = new System.Drawing.Size(579, 103);
            this.TbSource.TabIndex = 0;
            // 
            // TbEncoded
            // 
            this.TbEncoded.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEncoded.Location = new System.Drawing.Point(40, 250);
            this.TbEncoded.Multiline = true;
            this.TbEncoded.Name = "TbEncoded";
            this.TbEncoded.ReadOnly = true;
            this.TbEncoded.Size = new System.Drawing.Size(579, 103);
            this.TbEncoded.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please insert text to encode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encoded text";
            // 
            // FadeIn
            // 
            this.FadeIn.Interval = 1;
            this.FadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeader.ForeColor = System.Drawing.Color.Black;
            this.LbHeader.Location = new System.Drawing.Point(94, 21);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(265, 32);
            this.LbHeader.TabIndex = 6;
            this.LbHeader.Text = "Encode/Decode Tool";
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Transparent;
            this.ControlBox.Controls.Add(this.MinimizeIco);
            this.ControlBox.Controls.Add(this.CloseBt);
            this.ControlBox.Location = new System.Drawing.Point(502, 12);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(141, 27);
            this.ControlBox.TabIndex = 8;
            // 
            // FadeOut
            // 
            this.FadeOut.Interval = 1;
            this.FadeOut.Tick += new System.EventHandler(this.FadeOut_Tick);
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.Location = new System.Drawing.Point(99, 51);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(35, 13);
            this.LbVersion.TabIndex = 9;
            this.LbVersion.Text = "label3";
            // 
            // EncodeIco
            // 
            this.EncodeIco.Image = global::EDTool.Properties.Resources.ico32c_encode2;
            this.EncodeIco.Location = new System.Drawing.Point(587, 368);
            this.EncodeIco.Name = "EncodeIco";
            this.EncodeIco.Size = new System.Drawing.Size(24, 24);
            this.EncodeIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EncodeIco.TabIndex = 13;
            this.EncodeIco.TabStop = false;
            this.EncodeIco.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.EncodeIco.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.EncodeIco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // ClipboardIco
            // 
            this.ClipboardIco.Image = global::EDTool.Properties.Resources.ico32c_clipboard2;
            this.ClipboardIco.Location = new System.Drawing.Point(540, 367);
            this.ClipboardIco.Name = "ClipboardIco";
            this.ClipboardIco.Size = new System.Drawing.Size(24, 24);
            this.ClipboardIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClipboardIco.TabIndex = 12;
            this.ClipboardIco.TabStop = false;
            this.ClipboardIco.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.ClipboardIco.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.ClipboardIco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // SettingsIco
            // 
            this.SettingsIco.Image = global::EDTool.Properties.Resources.ico32c_settings2;
            this.SettingsIco.Location = new System.Drawing.Point(489, 368);
            this.SettingsIco.Name = "SettingsIco";
            this.SettingsIco.Size = new System.Drawing.Size(24, 24);
            this.SettingsIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsIco.TabIndex = 11;
            this.SettingsIco.TabStop = false;
            this.SettingsIco.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.SettingsIco.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.SettingsIco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // SaveToFileIco
            // 
            this.SaveToFileIco.Image = global::EDTool.Properties.Resources.ico32c_save2;
            this.SaveToFileIco.Location = new System.Drawing.Point(517, 368);
            this.SaveToFileIco.Name = "SaveToFileIco";
            this.SaveToFileIco.Size = new System.Drawing.Size(24, 24);
            this.SaveToFileIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SaveToFileIco.TabIndex = 10;
            this.SaveToFileIco.TabStop = false;
            this.SaveToFileIco.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.SaveToFileIco.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.SaveToFileIco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // MinimizeIco
            // 
            this.MinimizeIco.Image = global::EDTool.Properties.Resources.ico24c_minimize2;
            this.MinimizeIco.Location = new System.Drawing.Point(88, 4);
            this.MinimizeIco.Name = "MinimizeIco";
            this.MinimizeIco.Size = new System.Drawing.Size(18, 18);
            this.MinimizeIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeIco.TabIndex = 1;
            this.MinimizeIco.TabStop = false;
            this.MinimizeIco.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.MinimizeIco.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.MinimizeIco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // CloseBt
            // 
            this.CloseBt.Image = global::EDTool.Properties.Resources.ico24c_close1;
            this.CloseBt.Location = new System.Drawing.Point(108, 1);
            this.CloseBt.Name = "CloseBt";
            this.CloseBt.Size = new System.Drawing.Size(24, 24);
            this.CloseBt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBt.TabIndex = 0;
            this.CloseBt.TabStop = false;
            this.CloseBt.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.CloseBt.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            this.CloseBt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            // 
            // AppIco
            // 
            this.AppIco.Image = global::EDTool.Properties.Resources.ico64c_encode;
            this.AppIco.Location = new System.Drawing.Point(43, 25);
            this.AppIco.Name = "AppIco";
            this.AppIco.Size = new System.Drawing.Size(44, 44);
            this.AppIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppIco.TabIndex = 5;
            this.AppIco.TabStop = false;
            // 
            // MnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.Controls.Add(this.EncodeIco);
            this.Controls.Add(this.ClipboardIco);
            this.Controls.Add(this.SettingsIco);
            this.Controls.Add(this.SaveToFileIco);
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.LbHeader);
            this.Controls.Add(this.AppIco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEncoded);
            this.Controls.Add(this.TbSource);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MnForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encode";
            this.Load += new System.EventHandler(this.MnForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MnForm_MouseDown);
            this.ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EncodeIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClipboardIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveToFileIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbSource;
        private System.Windows.Forms.TextBox TbEncoded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer FadeIn;
        private System.Windows.Forms.PictureBox AppIco;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.PictureBox CloseBt;
        private System.Windows.Forms.Timer FadeOut;
        private System.Windows.Forms.Label LbVersion;
        private System.Windows.Forms.PictureBox MinimizeIco;
        private System.Windows.Forms.PictureBox SaveToFileIco;
        private System.Windows.Forms.SaveFileDialog SvFileDialog;
        private System.Windows.Forms.PictureBox SettingsIco;
        private System.Windows.Forms.PictureBox ClipboardIco;
        private System.Windows.Forms.PictureBox EncodeIco;
    }
}

