
namespace QREncoderAndDecoder
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
            this.Picturebox = new System.Windows.Forms.PictureBox();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.ButtonDecode = new System.Windows.Forms.Button();
            this.EncodeText = new System.Windows.Forms.TextBox();
            this.DecodeText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Picturebox
            // 
            this.Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picturebox.Location = new System.Drawing.Point(79, 67);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(313, 288);
            this.Picturebox.TabIndex = 0;
            this.Picturebox.TabStop = false;
            // 
            // BtnEncode
            // 
            this.BtnEncode.BackColor = System.Drawing.Color.Transparent;
            this.BtnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEncode.Location = new System.Drawing.Point(680, 140);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(75, 23);
            this.BtnEncode.TabIndex = 1;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = false;
            this.BtnEncode.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDecode
            // 
            this.ButtonDecode.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDecode.Location = new System.Drawing.Point(680, 204);
            this.ButtonDecode.Name = "ButtonDecode";
            this.ButtonDecode.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecode.TabIndex = 2;
            this.ButtonDecode.Text = "Decode";
            this.ButtonDecode.UseVisualStyleBackColor = false;
            this.ButtonDecode.Click += new System.EventHandler(this.button2_Click);
            // 
            // EncodeText
            // 
            this.EncodeText.Location = new System.Drawing.Point(476, 140);
            this.EncodeText.Name = "EncodeText";
            this.EncodeText.Size = new System.Drawing.Size(157, 22);
            this.EncodeText.TabIndex = 3;
            // 
            // DecodeText
            // 
            this.DecodeText.Location = new System.Drawing.Point(476, 205);
            this.DecodeText.Name = "DecodeText";
            this.DecodeText.Size = new System.Drawing.Size(157, 22);
            this.DecodeText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecodeText);
            this.Controls.Add(this.EncodeText);
            this.Controls.Add(this.ButtonDecode);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.Picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picturebox;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button ButtonDecode;
        private System.Windows.Forms.TextBox EncodeText;
        private System.Windows.Forms.TextBox DecodeText;
    }
}

