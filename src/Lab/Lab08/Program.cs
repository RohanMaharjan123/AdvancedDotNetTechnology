using System;
using System.Drawing;
using System.Windows.Forms;

namespace DialogBoxDemo
{
    class MainForm : Form
    {
        private Button btnFont = new()
        {
            Location = new Point(20, 100),
            Size = new Size(80, 30),
            Text = "The cool font"
        };

        private Button btnColor = new()
        {
            Location = new Point(120, 100),
            Size = new Size(80, 30),
            Text = "The cool color"
        };

        private TextBox txtBox = new()
        {
            Size = new Size(200, 75),
            Location = new Point(20, 20)
        };

        private ColorDialog colorDlg = new();
        private FontDialog fontDlg = new();

        public MainForm()
        {
            Text = "Dialoggg";
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;

            btnFont.Click += (s, e) =>
            {
                if (fontDlg.ShowDialog() == DialogResult.OK)
                    txtBox.Font = fontDlg.Font;
            };

            btnColor.Click += (s, e) =>
            {
                if (colorDlg.ShowDialog() == DialogResult.OK)
                    BackColor = colorDlg.Color;
            };

            Controls.AddRange(new Control[] { txtBox, btnFont, btnColor });
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}