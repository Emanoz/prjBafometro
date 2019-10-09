using System.Windows.Forms;

namespace prjEstoque
{
    class Util
    {
        public Util()
        {

        }

        public void Slider(System.Windows.Forms.Control pn, int height, int width)
        {
            pn.Height = height;
            pn.Width = width;
        }

        public void Slider(System.Windows.Forms.Control pn, System.Windows.Forms.GroupBox gb, System.Windows.Forms.Button btn, int height, int width)
        {
            if (gb.Height == 28)
            {
                Slider(gb, height, width);
                Slider(pn, height, width);
                btn.Image = prjEstoque.Properties.Resources.icons8_triangle_arrow_14;
            }
            else
            {
                Slider(gb, 28, width);
                Slider(pn, 65, width);
                btn.Image = prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            }
        }

        public void LimparCampos(Control.ControlCollection control)
        {
            foreach(Control item in control)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is ComboBox)
                {
                    ((ComboBox)item).DataSource = null;
                    ((ComboBox)item).Items.Clear();
                }
                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                else if (item is MaskedTextBox)
                    ((MaskedTextBox)item).Clear();
                else if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = System.DateTime.Now;
                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 0;
            }
        }
    }
}
