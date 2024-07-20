using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox inputTextBox;
    private Label outputLabel;

    public MainForm()
    {
        InitializeComponents();
        InitializeFields();
    }

    private void InitializeComponents()
    {
        this.inputTextBox = new TextBox() { Location = new System.Drawing.Point(15, 15) };
        this.outputLabel = new Label() { Location = new System.Drawing.Point(15, 45), Width = 200 };

        this.Controls.Add(this.inputTextBox);
        this.Controls.Add(this.outputLabel);
    }

    private void InitializeFields()
    {
        // Initialize input field
        this.inputTextBox.Text = "";

        // Initialize output field
        this.outputLabel.Text = "";
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}
