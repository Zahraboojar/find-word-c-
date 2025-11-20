using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string National_code { get; set; }
        public string Gender { get; set; }
        public Validate ValidateTextBox(TextBox textBox)
        {
            Validate valid = new Validate();
            if (textBox.Text == "")
            {
                valid.IsSuccess = false;
                valid.message = textBox.Name + " is empty";
            }
            else
                valid.IsSuccess = true;
            return valid;
        }
        public Validate IsSelected(DataGridView dgv)
        {
            Validate valid = new Validate();
            if (dgv.CurrentCell == null)
            {
                valid.IsSuccess = false;
                valid.message = "No cells selected. First select";
            }
            else
                valid.IsSuccess = true;
            return valid;
        }
    }
}
