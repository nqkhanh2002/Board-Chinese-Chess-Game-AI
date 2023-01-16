namespace ChineseChess
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.boardPanel = new System.Windows.Forms.Panel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.controlGroup.SuspendLayout();
            this.statusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackgroundImage = global::ChineseChess.Properties.Resources.Board;
            this.boardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardPanel.Location = new System.Drawing.Point(14, 15);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(624, 678);
            this.boardPanel.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(21, 39);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(101, 38);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Enabled = false;
            this.undoButton.Location = new System.Drawing.Point(129, 39);
            this.undoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(101, 38);
            this.undoButton.TabIndex = 1;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.undoButton);
            this.controlGroup.Controls.Add(this.newGameButton);
            this.controlGroup.Location = new System.Drawing.Point(645, 15);
            this.controlGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlGroup.Size = new System.Drawing.Size(262, 100);
            this.controlGroup.TabIndex = 1;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Control";
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.statusLabel);
            this.statusGroup.Controls.Add(this.startButton);
            this.statusGroup.Controls.Add(this.turnLabel);
            this.statusGroup.Controls.Add(this.currentPlayerLabel);
            this.statusGroup.Location = new System.Drawing.Point(645, 122);
            this.statusGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusGroup.Size = new System.Drawing.Size(262, 188);
            this.statusGroup.TabIndex = 2;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(7, 81);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(249, 50);
            this.statusLabel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(65, 135);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 38);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(7, 36);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(45, 20);
            this.turnLabel.TabIndex = 0;
            this.turnLabel.Text = "Turn:";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.ForeColor = System.Drawing.Color.Red;
            this.currentPlayerLabel.Location = new System.Drawing.Point(61, 36);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 20);
            this.currentPlayerLabel.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 714);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.boardPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiness Chess";
            this.controlGroup.ResumeLayout(false);
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.GroupBox controlGroup;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label turnLabel;
    }
}

