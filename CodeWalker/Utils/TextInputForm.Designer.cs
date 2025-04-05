namespace CodeWalker.Utils
{
    partial class TextInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInputForm));
            this.MainTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelThisButton = new System.Windows.Forms.Button();
            this.PromptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.MainTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 15);
            this.MainTextBox.BackBrush = null;
            this.MainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(130)))), ((int)(((byte)(133)))));
            this.MainTextBox.CharHeight = 15;
            this.MainTextBox.CharWidth = 8;
            this.MainTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MainTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.MainTextBox.Font = new System.Drawing.Font("Cascadia Code", 9.75F);
            this.MainTextBox.IndentBackColor = System.Drawing.Color.Black;
            this.MainTextBox.IsReplaceMode = false;
            this.MainTextBox.Location = new System.Drawing.Point(1, 47);
            this.MainTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.MainTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.MainTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("MainTextBox.ServiceColors")));
            this.MainTextBox.Size = new System.Drawing.Size(756, 415);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Zoom = 100;
            this.MainTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.MainTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(668, 473);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 30);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelThisButton
            // 
            this.CancelThisButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelThisButton.Location = new System.Drawing.Point(574, 473);
            this.CancelThisButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelThisButton.Name = "CancelThisButton";
            this.CancelThisButton.Size = new System.Drawing.Size(88, 30);
            this.CancelThisButton.TabIndex = 2;
            this.CancelThisButton.Text = "Cancel";
            this.CancelThisButton.UseVisualStyleBackColor = true;
            this.CancelThisButton.Click += new System.EventHandler(this.CancelThisButton_Click);
            // 
            // PromptLabel
            // 
            this.PromptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PromptLabel.AutoEllipsis = true;
            this.PromptLabel.Location = new System.Drawing.Point(14, 7);
            this.PromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(742, 37);
            this.PromptLabel.TabIndex = 3;
            this.PromptLabel.Text = "Please input text:";
            // 
            // TextInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 519);
            this.Controls.Add(this.PromptLabel);
            this.Controls.Add(this.CancelThisButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MainTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TextInputForm";
            this.Text = "Text Input - CodeWalker by dexyfex";
            ((System.ComponentModel.ISupportInitialize)(this.MainTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox MainTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelThisButton;
        private System.Windows.Forms.Label PromptLabel;
    }
}