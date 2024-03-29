﻿
namespace Windows.UI.Concrete.UseControls.Navigators
{
    partial class LongNavigator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongNavigator));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator1.Appearance.Options.UseForeColor = true;
            this.controlNavigator1.Buttons.Append.Visible = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.First.ImageIndex = 2;
            this.controlNavigator1.Buttons.ImageList = this.imageCollection;
            this.controlNavigator1.Buttons.Last.ImageIndex = 3;
            this.controlNavigator1.Buttons.Next.ImageIndex = 4;
            this.controlNavigator1.Buttons.NextPage.ImageIndex = 0;
            this.controlNavigator1.Buttons.Prev.ImageIndex = 5;
            this.controlNavigator1.Buttons.PrevPage.ImageIndex = 1;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(711, 24);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator1.TextStringFormat = "Kayıt ( {0} / {1} )";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.doublenext_16x16, "doublenext_16x16", typeof(global::Windows.UI.Properties.Resources), 0);
            this.imageCollection.Images.SetKeyName(0, "doublenext_16x16");
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.doubleprev_16x16, "doubleprev_16x16", typeof(global::Windows.UI.Properties.Resources), 1);
            this.imageCollection.Images.SetKeyName(1, "doubleprev_16x16");
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.first_16x16, "first_16x16", typeof(global::Windows.UI.Properties.Resources), 2);
            this.imageCollection.Images.SetKeyName(2, "first_16x16");
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.last_16x16, "last_16x16", typeof(global::Windows.UI.Properties.Resources), 3);
            this.imageCollection.Images.SetKeyName(3, "last_16x16");
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.next_16x16, "next_16x16", typeof(global::Windows.UI.Properties.Resources), 4);
            this.imageCollection.Images.SetKeyName(4, "next_16x16");
            this.imageCollection.InsertImage(global::Windows.UI.Properties.Resources.prev_16x16, "prev_16x16", typeof(global::Windows.UI.Properties.Resources), 5);
            this.imageCollection.Images.SetKeyName(5, "prev_16x16");
            // 
            // LongNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator1);
            this.Name = "LongNavigator";
            this.Size = new System.Drawing.Size(711, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraEditors.ControlNavigator controlNavigator1;
    }
}
