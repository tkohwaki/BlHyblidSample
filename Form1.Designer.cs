using Microsoft.AspNetCore.Components.WebView.WindowsForms;
namespace BlHyblidSample;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    protected BlazorWebView blView;
    protected Button btnIncrement;
    protected Label lblMessage;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Blazor Hyblid Sample";
        TableLayoutPanel pnl = new TableLayoutPanel();
        pnl.Dock = DockStyle.Fill;
        pnl.RowStyles.Add(new RowStyle(SizeType.Absolute,50));
        pnl.RowStyles.Add(new RowStyle(SizeType.Absolute,50));
        pnl.RowStyles.Add(new RowStyle(SizeType.Percent,100));
        
        blView = new BlazorWebView();
        blView.Dock = DockStyle.Fill;
        pnl.SetRow(blView,2);

        btnIncrement = new Button();
        btnIncrement.Width = 120;
        btnIncrement.Height = 40;
        btnIncrement.Dock = DockStyle.Fill;
        btnIncrement.Text = "Increment";
        btnIncrement.Click += On_btnIncrement_Click;
        pnl.SetRow(btnIncrement,0);

        lblMessage = new Label();
        lblMessage.AutoSize = true;
        lblMessage.Dock = DockStyle.Fill;
        lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        lblMessage.Font = new Font(this.Font.FontFamily,14,FontStyle.Bold);
        pnl.SetRow(lblMessage,1);

        pnl.Controls.Add(btnIncrement);
        pnl.Controls.Add(lblMessage);
        pnl.Controls.Add(blView);

        this.Controls.Add(pnl);

    }

    #endregion
}
