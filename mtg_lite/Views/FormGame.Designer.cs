﻿namespace mtg_lite
{
    partial class FormGame
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
            this.libraryDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.graveyardDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.handDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay();
            this.manaPoolDisplay = new mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay();
            this.battlefieldDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay();
            this.SuspendLayout();
            // 
            // libraryDisplay
            // 
            this.libraryDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryDisplay.Location = new System.Drawing.Point(9, 8);
            this.libraryDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.libraryDisplay.Name = "libraryDisplay";
            this.libraryDisplay.Size = new System.Drawing.Size(143, 181);
            this.libraryDisplay.TabIndex = 0;
            this.libraryDisplay.Zone = null;
            this.libraryDisplay.Load += new System.EventHandler(this.libraryDisplay_Load);
            // 
            // graveyardDisplay
            // 
            this.graveyardDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graveyardDisplay.Location = new System.Drawing.Point(9, 191);
            this.graveyardDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.graveyardDisplay.Name = "graveyardDisplay";
            this.graveyardDisplay.Size = new System.Drawing.Size(143, 181);
            this.graveyardDisplay.TabIndex = 1;
            this.graveyardDisplay.Zone = null;
            this.graveyardDisplay.Load += new System.EventHandler(this.graveyardDisplay_Load);
            // 
            // handDisplay
            // 
            this.handDisplay.Hand = null;
            this.handDisplay.Location = new System.Drawing.Point(161, 410);
            this.handDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.handDisplay.Name = "handDisplay";
            this.handDisplay.Size = new System.Drawing.Size(1138, 203);
            this.handDisplay.TabIndex = 3;
            this.handDisplay.Load += new System.EventHandler(this.handDisplay_Load);
            // 
            // manaPoolDisplay
            // 
            this.manaPoolDisplay.Location = new System.Drawing.Point(9, 411);
            this.manaPoolDisplay.ManaPool = null;
            this.manaPoolDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manaPoolDisplay.Name = "manaPoolDisplay";
            this.manaPoolDisplay.Size = new System.Drawing.Size(149, 202);
            this.manaPoolDisplay.TabIndex = 4;
            // 
            // battlefieldDisplay
            // 
            this.battlefieldDisplay.Battlefield = null;
            this.battlefieldDisplay.Location = new System.Drawing.Point(164, 8);
            this.battlefieldDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.battlefieldDisplay.Name = "battlefieldDisplay";
            this.battlefieldDisplay.Size = new System.Drawing.Size(1135, 398);
            this.battlefieldDisplay.TabIndex = 5;
            this.battlefieldDisplay.Load += new System.EventHandler(this.battlefieldDisplay_Load);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 626);
            this.Controls.Add(this.battlefieldDisplay);
            this.Controls.Add(this.manaPoolDisplay);
            this.Controls.Add(this.handDisplay);
            this.Controls.Add(this.graveyardDisplay);
            this.Controls.Add(this.libraryDisplay);
            this.Name = "FormGame";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay libraryDisplay;
        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay graveyardDisplay;
        private Views.UserControls.ZoneDisplays.HandDisplay handDisplay;
        private Views.UserControls.ManaDisplays.ManaPoolDisplay manaPoolDisplay;
        private Views.UserControls.ZoneDisplays.BattlefieldDisplay battlefieldDisplay;
    }
}