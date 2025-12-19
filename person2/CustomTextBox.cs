using System.Windows.Forms;

namespace person2
{
    internal class CustomTextBox : TextBox
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                return true; // Tab غیرفعال شد
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                this.Parent?.SelectNextControl(
                    this,
                    true,
                    true,
                    true,
                    true
                );
            }

            base.OnKeyDown(e);
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = Color.LightYellow;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = Color.White;
        }
    }
}
