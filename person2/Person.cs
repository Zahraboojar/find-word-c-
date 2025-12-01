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
        public int  Id { get; set; }
        public OperationResult ValidateTextBox(TextBox textBox)
        {
            OperationResult valid = new OperationResult();
            if (textBox.Text == "")
            {
                valid.IsSuccess = false;
                valid.Message = textBox.Name + " is empty";
            }
            else
                valid.IsSuccess = true;
            return valid;
        }
        public OperationResult IsSelected(DataGridView dgv)
        {
            OperationResult valid = new OperationResult();
            if (dgv.CurrentCell == null)
            {
                valid.IsSuccess = false;
                valid.Message = "No cells selected. First select";
            }
            else
                valid.IsSuccess = true;
            return valid;
        }
    }
}
