namespace ExifRemover
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
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonRemoveExif = new Button();
            richTextBoxImages = new RichTextBox();
            labelItems = new Label();
            textBoxDestination = new TextBox();
            label2 = new Label();
            buttonBrowse = new Button();
            progressBarComplete = new ProgressBar();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.GradientActiveCaption;
            buttonAdd.Location = new Point(38, 21);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(421, 37);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Select Images";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = SystemColors.GradientActiveCaption;
            buttonRemove.Location = new Point(465, 21);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(78, 37);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRemoveExif
            // 
            buttonRemoveExif.BackColor = SystemColors.GradientActiveCaption;
            buttonRemoveExif.Location = new Point(38, 582);
            buttonRemoveExif.Name = "buttonRemoveExif";
            buttonRemoveExif.Size = new Size(505, 45);
            buttonRemoveExif.TabIndex = 3;
            buttonRemoveExif.Text = "Remove Exif Info";
            buttonRemoveExif.UseVisualStyleBackColor = false;
            buttonRemoveExif.Click += buttonRemoveExif_Click;
            // 
            // richTextBoxImages
            // 
            richTextBoxImages.Location = new Point(38, 79);
            richTextBoxImages.Name = "richTextBoxImages";
            richTextBoxImages.Size = new Size(505, 371);
            richTextBoxImages.TabIndex = 4;
            richTextBoxImages.Text = "";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(477, 451);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(42, 15);
            labelItems.TabIndex = 5;
            labelItems.Text = "Items: ";
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(114, 497);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(345, 23);
            textBoxDestination.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 500);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 7;
            label2.Text = "Destination:";
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = SystemColors.GradientActiveCaption;
            buttonBrowse.Location = new Point(465, 497);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(78, 23);
            buttonBrowse.TabIndex = 8;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // progressBarComplete
            // 
            progressBarComplete.Location = new Point(38, 456);
            progressBarComplete.Name = "progressBarComplete";
            progressBarComplete.Size = new Size(421, 10);
            progressBarComplete.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(585, 663);
            Controls.Add(progressBarComplete);
            Controls.Add(buttonBrowse);
            Controls.Add(label2);
            Controls.Add(textBoxDestination);
            Controls.Add(labelItems);
            Controls.Add(richTextBoxImages);
            Controls.Add(buttonRemoveExif);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exif Remover";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonRemoveExif;
        private RichTextBox richTextBoxImages;
        private Label labelItems;
        private TextBox textBoxDestination;
        private Label label2;
        private Button buttonBrowse;
        private ProgressBar progressBarComplete;
    }
}