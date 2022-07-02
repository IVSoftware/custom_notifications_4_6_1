
namespace custom_notification
{
    partial class CustomNotificationContainer
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
            this.checkBoxDocked = new System.Windows.Forms.CheckBox();
            this.textBoxNewMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxDocked
            // 
            this.checkBoxDocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDocked.AutoSize = true;
            this.checkBoxDocked.Location = new System.Drawing.Point(11, 901);
            this.checkBoxDocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDocked.Name = "checkBoxDocked";
            this.checkBoxDocked.Size = new System.Drawing.Size(90, 24);
            this.checkBoxDocked.TabIndex = 0;
            this.checkBoxDocked.Text = "Docked";
            this.checkBoxDocked.UseVisualStyleBackColor = true;
            // 
            // textBoxNewMessage
            // 
            this.textBoxNewMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNewMessage.Location = new System.Drawing.Point(12, 868);
            this.textBoxNewMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewMessage.Name = "textBoxNewMessage";
            this.textBoxNewMessage.Size = new System.Drawing.Size(291, 26);
            this.textBoxNewMessage.TabIndex = 1;
            // 
            // CustomNotificationContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 935);
            this.Controls.Add(this.textBoxNewMessage);
            this.Controls.Add(this.checkBoxDocked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomNotificationContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDocked;
        private System.Windows.Forms.TextBox textBoxNewMessage;
    }
}