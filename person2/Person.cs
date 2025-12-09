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
        public Gender Gender { get; set; }
        public int  Id { get; set; }
        public OperationResult ValidateTextBox(TextBox textBox)
        {
            if (textBox.Text == "")
                return OperationResult.Failed(textBox.Name + " is empty");
            else
                return OperationResult.Success();
        }
        public OperationResult IsSelected(DataGridView dgv)
        {
            if (dgv.CurrentCell == null)
                return OperationResult.Failed("No cells selected. First select");
            else
                return OperationResult.Success();
        }
    }
}
