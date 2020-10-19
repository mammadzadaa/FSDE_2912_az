namespace Lesson_19_10_20_MVP.View
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.elementListView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // elementListView
            // 
            this.elementListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementListView.HideSelection = false;
            this.elementListView.LargeImageList = this.imageList1;
            this.elementListView.Location = new System.Drawing.Point(0, 0);
            this.elementListView.Name = "elementListView";
            this.elementListView.Size = new System.Drawing.Size(800, 450);
            this.elementListView.SmallImageList = this.imageList1;
            this.elementListView.TabIndex = 0;
            this.elementListView.UseCompatibleStateImageBehavior = false;
            this.elementListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.elementListView_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "element+fire+icon-1320166151963997842.png");
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementListView);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView elementListView;
        private System.Windows.Forms.ImageList imageList1;
    }
}